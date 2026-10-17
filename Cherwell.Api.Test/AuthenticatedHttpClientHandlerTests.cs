using System.Security.Authentication;
using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Cherwell.Api.Test;

public class AuthenticatedHttpClientHandlerTests
{
	/// <summary>
	/// The token request the handler builds targets the auth_mode query parameter and includes
	/// the client id, grant type, username and password in the body.
	/// </summary>
	[Fact]
	public async Task CreateTokenRequest_IncludesClientCredentialsAndAuthMode()
	{
		var options = ValidOptions();
		var handler = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);

		var request = handler.CreateTokenRequest("password");

		request.Method.Should().Be(System.Net.Http.HttpMethod.Post);
		request.RequestUri!.ToString().Should().Contain("auth_mode=LDAP");
		var body = await request.Content!.ReadAsStringAsync(CancellationToken.None);
		body.Should().Contain("client_id=client-1");
		body.Should().Contain("grant_type=password");
		body.Should().Contain("username=alice");
		body.Should().Contain("password=secret");
		request.Content!.Headers.ContentType!.MediaType.Should().Be("application/x-www-form-urlencoded");
	}

	/// <summary>
	/// A mis-formatted user agent is rejected before the handler is even usable.
	/// </summary>
	[Fact]
	public void Constructor_BadUserAgent_ThrowsFormatException()
	{
		var options = ValidOptions();
		options.UserAgent = "no-slash-here";

		FormatException? exception = null;
		try
		{
			_ = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		}
		catch (FormatException ex)
		{
			exception = ex;
		}

		exception.Should().NotBeNull();
		exception!.Message.Should().Contain("UserAgent");
	}

	/// <summary>
	/// A null user agent is accepted (no header is added).
	/// </summary>
	[Fact]
	public void Constructor_NullUserAgent_AcceptsAndSucceeds()
	{
		var options = ValidOptions();
		options.UserAgent = null;

		var handler = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		handler.Should().NotBeNull();
	}

	/// <summary>
	/// A null BaseAddress is required by the constructor; it surfaces as an ArgumentNullException.
	/// </summary>
	[Fact]
	public void Constructor_NullBaseAddress_Throws()
	{
		var options = ValidOptions();
		options.BaseAddress = "";

		Exception? exception = null;
		try
		{
			_ = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		}
		catch (Exception ex)
		{
			exception = ex;
		}

		exception.Should().NotBeNull();
	}

	/// <summary>
	/// A fully configured handler is constructed without throwing.
	/// </summary>
	[Fact]
	public void Constructor_ValidOptions_Succeeds()
	{
		var options = ValidOptions();

		var handler = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		handler.Should().NotBeNull();
	}

	private static CherwellClientOptions ValidOptions() => new()
	{
		UserName = "alice",
		Password = "secret",
		ClientId = "client-1",
		BaseAddress = "https://api.example.com",
		AuthenticationMode = "LDAP",
		UserAgent = "SystemName/1.0",
		MaxAttempts = 1
	};
}
