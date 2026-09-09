using Microsoft.Extensions.Logging.Abstractions;

namespace Cherwell.Api.Test;

/// <summary>
/// Tests for the shape of the OAuth2 token request.
///
/// <para>
/// Reported as issue #1: the client could not authenticate against a Cherwell 10.5 instance and
/// retried instead. The token request omitted both the "auth_mode" query parameter and the
/// "client_id" form field that Cherwell documents, sending the client id only as an HTTP Basic
/// credential. <c>AuthenticationMode</c> was validated on the options but never actually sent, so
/// setting it to Windows or LDAP had no effect at all.
/// </para>
///
/// <para>
/// These are pure unit tests. They build the request and inspect it, requiring no credentials, no
/// configuration and no live instance.
/// </para>
/// </summary>
public class TokenRequestTests
{
	private const string ClientId = "test-client-id";
	private const string UserName = "test-user";
	private const string Password = "test-password";

	private static AuthenticatedHttpClientHandler CreateHandler(string authenticationMode = "Internal")
		=> new(
			new CherwellClientOptions
			{
				BaseAddress = "https://cherwell.example.com/CherwellAPI",
				ClientId = ClientId,
				UserName = UserName,
				Password = Password,
				AuthenticationMode = authenticationMode
			},
			NullLogger.Instance);

	private static async Task<string> GetFormBodyAsync(HttpRequestMessage request)
		=> await request.Content!.ReadAsStringAsync(TestContext.Current.CancellationToken);

	/// <summary>
	/// The headline defect: the client id must reach Cherwell as a form field.
	/// </summary>
	[Fact]
	public async Task CreateTokenRequest_SendsClientIdAsAFormField()
	{
		using var handler = CreateHandler();

		using var request = handler.CreateTokenRequest("password");

		var body = await GetFormBodyAsync(request);
		body.Should().Contain($"client_id={ClientId}");
	}

	/// <summary>
	/// The other half of the defect: auth_mode must be sent, so the option stops being inert.
	/// </summary>
	/// <param name="authenticationMode">The configured authentication mode.</param>
	[Theory]
	[InlineData("Internal")]
	[InlineData("Windows")]
	[InlineData("LDAP")]
	[InlineData("SAML")]
	public void CreateTokenRequest_SendsTheConfiguredAuthenticationMode(string authenticationMode)
	{
		using var handler = CreateHandler(authenticationMode);

		using var request = handler.CreateTokenRequest("password");

		request.RequestUri!.OriginalString.Should().Be($"token?auth_mode={authenticationMode}");
	}

	/// <summary>
	/// An authentication mode is not required to be URL-safe, so it must be escaped rather than
	/// concatenated into the query string.
	/// </summary>
	[Fact]
	public void CreateTokenRequest_EscapesTheAuthenticationMode()
	{
		using var handler = CreateHandler("Active Directory&x=1");

		using var request = handler.CreateTokenRequest("password");

		request.RequestUri!.OriginalString.Should().Be("token?auth_mode=Active%20Directory%26x%3D1");
	}

	/// <summary>
	/// The credentials and grant type must still be sent as they were before the fix.
	/// </summary>
	[Fact]
	public async Task CreateTokenRequest_StillSendsTheGrantTypeAndCredentials()
	{
		using var handler = CreateHandler();

		using var request = handler.CreateTokenRequest("password");

		var body = await GetFormBodyAsync(request);
		body.Should().Contain("grant_type=password");
		body.Should().Contain($"username={UserName}");
		body.Should().Contain($"password={Password}");
	}

	/// <summary>
	/// A refresh has no refresh token until one has been stored, so the field is omitted rather than
	/// sent empty.
	/// </summary>
	[Fact]
	public async Task CreateTokenRequest_WithoutAStoredRefreshToken_OmitsIt()
	{
		using var handler = CreateHandler();

		using var request = handler.CreateTokenRequest("refresh_token");

		var body = await GetFormBodyAsync(request);
		body.Should().Contain("grant_type=refresh_token");
		body.Should().NotContain("refresh_token=");
	}

	/// <summary>
	/// The request must be posted as a form, which is what Cherwell's token endpoint accepts.
	/// </summary>
	[Fact]
	public void CreateTokenRequest_IsAPostOfUrlEncodedForm()
	{
		using var handler = CreateHandler();

		using var request = handler.CreateTokenRequest("password");

		request.Method.Should().Be(HttpMethod.Post);
		request.Content!.Headers.ContentType!.MediaType
			.Should().Be("application/x-www-form-urlencoded");
		request.Content.Headers.ContentType.CharSet.Should().Be("UTF-8");
	}
}
