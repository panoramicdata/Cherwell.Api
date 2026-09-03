using System.Net.Http;
using System.Net.Http.Headers;

namespace Cherwell.Api.Test;

/// <summary>
/// Tests for header redaction in diagnostic output.
///
/// <para>
/// <c>AuthenticatedHttpClientHandler</c> assigns the Authorization header a bearer token and then,
/// nine lines later, joined every request header key and value into its Debug level log message.
/// The response side did the same, exposing Set-Cookie. Without redaction a usable access token is
/// written wherever those messages end up.
/// </para>
///
/// <para>
/// These are pure unit tests. They construct headers directly and require no credentials, no
/// configuration and no live instance.
/// </para>
/// </summary>
public class HttpExtensionsTests
{
	private const string FakeToken = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOP";

	/// <summary>
	/// The headline case: the bearer token this client sets must not survive into the message.
	/// </summary>
	[Fact]
	public void ToDebugString_BearerToken_DoesNotLeakTheCredential()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", FakeToken);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakeToken);
		debugString.Should().Be($"Authorization: Bearer <redacted, length {FakeToken.Length}>");
	}

	/// <summary>
	/// Proves the defect being fixed: the previous rendering leaked, the replacement does not.
	/// </summary>
	[Fact]
	public void ToDebugString_UnlikeTheOldJoin_DoesNotContainTheToken()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", FakeToken);

		// This is exactly what the handler did before the fix.
		var previousRendering = string.Join(
			"\n",
			request.Headers.Select(h => $"{h.Key}: {string.Join(", ", h.Value.Select(v => v))}"));

		previousRendering.Should().Contain(FakeToken, "the previous rendering is what leaked");
		request.Headers.ToDebugString().Should().NotContain(FakeToken);
	}

	/// <summary>
	/// The token client authenticates with Basic rather than Bearer.
	/// </summary>
	[Fact]
	public void ToDebugString_BasicScheme_KeepsTheSchemeAndRedactsTheCredential()
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("Authorization", "Basic dXNlcjpwYXNzd29yZA==");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be("Authorization: Basic <redacted, length 20>");
		debugString.Should().NotContain("dXNlcjpwYXNzd29yZA==");
	}

	/// <summary>
	/// A header added without validation keeps whatever casing the caller used.
	/// </summary>
	/// <param name="headerName">The header name casing under test.</param>
	[Theory]
	[InlineData("authorization")]
	[InlineData("AUTHORIZATION")]
	[InlineData("AuThOrIzAtIoN")]
	public void ToDebugString_AuthorizationHeader_IsRedactedWhateverTheCasing(string headerName)
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation(headerName, $"Bearer {FakeToken}");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakeToken);
		debugString.Should().Contain("<redacted");
	}

	/// <summary>
	/// The other standard credential-bearing header names are redacted too.
	/// </summary>
	/// <param name="headerName">The credential-bearing header name under test.</param>
	[Theory]
	[InlineData("Proxy-Authorization")]
	[InlineData("Cookie")]
	[InlineData("X-API-Key")]
	[InlineData("Api-Key")]
	[InlineData("X-Api-Token")]
	[InlineData("X-Auth-Token")]
	public void ToDebugString_OtherCredentialHeaders_AreRedacted(string headerName)
	{
		const string secret = "s3cr3t-value-that-must-not-be-logged";
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation(headerName, secret);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(secret);
		debugString.Should().Contain("<redacted");
	}

	/// <summary>
	/// A vendor may prefix the standard header name rather than using it directly.
	/// </summary>
	[Fact]
	public void ToDebugString_VendorPrefixedAuthorizationHeader_IsRedacted()
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("X-Vendor-Authorization", $"Bearer {FakeToken}");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakeToken);
		debugString.Should().Be($"X-Vendor-Authorization: Bearer <redacted, length {FakeToken.Length}>");
	}

	/// <summary>
	/// A cookie value also contains a space, so treating the text before the first space as a scheme
	/// would preserve the very value being redacted. Only Authorization style headers keep a scheme.
	/// </summary>
	[Fact]
	public void ToDebugString_CookieValueContainingASpace_IsRedactedWhole()
	{
		const string cookie = "session=abc123def456; HttpOnly";
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("Cookie", cookie);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be($"Cookie: <redacted, length {cookie.Length}>");
		debugString.Should().NotContain("session=");
	}

	/// <summary>
	/// A credential with no scheme prefix has nothing safe to preserve, so all of it goes.
	/// </summary>
	[Fact]
	public void ToDebugString_CredentialWithoutAScheme_IsRedactedEntirely()
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("X-API-Key", "abcdef123456");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be("X-API-Key: <redacted, length 12>");
	}

	/// <summary>
	/// Redaction must be surgical: the useful headers alongside the credential must survive intact.
	/// </summary>
	[Fact]
	public void ToDebugString_RedactsOnlyTheSensitiveHeader()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", FakeToken);
		request.Headers.TryAddWithoutValidation("User-Agent", "SystemName/1.0");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakeToken);
		debugString.Should().Contain("User-Agent: SystemName/1.0");
	}

	/// <summary>
	/// Response headers go through the same helper, so Set-Cookie is covered.
	/// </summary>
	[Fact]
	public void ToDebugString_ResponseSetCookie_IsRedacted()
	{
		using var response = new HttpResponseMessage();
		response.Headers.TryAddWithoutValidation("Set-Cookie", "session=abc123def456; HttpOnly");

		var debugString = response.Headers.ToDebugString();

		debugString.Should().NotContain("abc123def456");
		debugString.Should().Contain("<redacted");
	}

	/// <summary>
	/// A request carrying no credential is rendered with nothing removed.
	/// </summary>
	[Fact]
	public void ToDebugString_NonSensitiveHeader_IsUnchanged()
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("User-Agent", "SystemName/1.0");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be("User-Agent: SystemName/1.0");
	}

	/// <summary>
	/// An empty header collection produces no output at all.
	/// </summary>
	[Fact]
	public void ToDebugString_NoHeaders_IsEmpty()
	{
		using var request = new HttpRequestMessage();

		request.Headers.ToDebugString().Should().BeEmpty();
	}
}
