using System.Globalization;
using System.Net;
using System.Security.Authentication;
using Cherwell.Api.Models;
using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class LoopbackClientTests
{
	private const string TokenJson = "{\"access_token\":\"tok\",\"refresh_token\":\"ref\",\"expires_in\":3600,\"token_type\":\"bearer\"}";
	private static CancellationToken Ct => TestContext.Current.CancellationToken;

	private static CherwellClientOptions Options(string baseAddress) => new()
	{
		BaseAddress = baseAddress,
		ClientId = "client",
		UserName = "alice",
		Password = "secret",
		MaxAttempts = 1,
		UserAgent = "Tests/1.0"
	};

	private static async Task<CherwellApiException> ApiExceptionAsync(Func<Task> action)
	{
		var thrown = await Record.ExceptionAsync(action);
		for (var current = thrown; current is not null; current = current.InnerException)
		{
			if (current is CherwellApiException api)
			{
				return api;
			}
		}

		throw new InvalidOperationException($"No CherwellApiException was thrown: {thrown}");
	}

	private static (int, string) Route(HttpListenerRequest request, int status, string body) =>
		request.Url!.AbsolutePath switch
		{
			"/token" => (200, TokenJson),
			"/api/V1/logout" => (200, "{}"),
			_ => (status, body)
		};

	/// <summary>
	/// A successful call authenticates, deserialises the body and logs out on dispose.
	/// </summary>
	[Fact]
	public async Task GetServiceInfo_Succeeds_AndLogsOutOnDispose()
	{
		using var server = new LoopbackServer(r => Route(r, 200, "{\"apiVersion\":\"9.9\",\"csmVersion\":\"10\"}"));
		var client = new CherwellClient(Options(server.BaseAddress));

		var info = await client.Service.GetServiceInfoAsync(Ct);
		client.Dispose();

		info.ApiVersion.Should().Be("9.9");
		info.CsmVersion.Should().Be("10");
		server.Requests.Should().Contain(r => r.StartsWith("POST /token?auth_mode=Internal", StringComparison.Ordinal));
		server.Requests.Should().Contain("GET /api/V1/serviceinfo");
	}

	/// <summary>
	/// A structured error body becomes a CherwellApiException carrying the response.
	/// </summary>
	[Fact]
	public async Task GetServiceInfo_StructuredError_ThrowsWithResponse()
	{
		using var server = new LoopbackServer(r => Route(r, 403, "{\"errorCode\":\"FORBIDDEN\",\"errorMessage\":\"nope\",\"hasError\":true}"));
		using var client = new CherwellClient(Options(server.BaseAddress));

		var assertion = await ApiExceptionAsync(() => client.Service.GetServiceInfoAsync(Ct));

		assertion.Response!.ErrorCode.Should().Be("FORBIDDEN");
		assertion.Response.HttpStatusCode.Should().Be(EnumHttpStatusCode.Forbidden);
		assertion.Message.Should().Contain("with message: nope");
	}

	/// <summary>
	/// A body that is not JSON becomes a CherwellApiException quoting the body.
	/// </summary>
	[Fact]
	public async Task GetServiceInfo_UnstructuredError_ThrowsWithBody()
	{
		using var server = new LoopbackServer(r => Route(r, 500, "plain failure"));
		using var client = new CherwellClient(Options(server.BaseAddress));

		var assertion = await ApiExceptionAsync(() => client.Service.GetServiceInfoAsync(Ct));

		assertion.Message.Should().Contain("plain failure");
	}

	/// <summary>
	/// A rejected token request fails authentication and is wrapped in a CherwellApiException.
	/// </summary>
	[Fact]
	public async Task GetServiceInfo_TokenRejected_ThrowsApiExceptionWrappingAuthentication()
	{
		using var server = new LoopbackServer(_ => (400, "bad credentials"));
		using var client = new CherwellClient(Options(server.BaseAddress));

		var assertion = await ApiExceptionAsync(() => client.Service.GetServiceInfoAsync(Ct));

		assertion.InnerException.Should().BeOfType<AuthenticationException>();
	}

	/// <summary>
	/// A read-only client refuses a write before anything is sent, and the culture is added to read requests.
	/// </summary>
	[Fact]
	public async Task ReadOnly_WriteRefused_AndCultureAppended()
	{
		using var server = new LoopbackServer(r => Route(r, 200, "{}"));
		var options = Options(server.BaseAddress);
		options.IsReadOnly = true;
		options.Culture = new CultureInfo("fr-FR");
		using var client = new CherwellClient(options);

		await client.Service.GetServiceInfoAsync(Ct);
		var write = await Record.ExceptionAsync(() => client.BusinessObject.SaveBusinessObjectAsync(new SaveRequest(), Ct));

		write.Should().NotBeNull();
		(write is InvalidOperationException ? write : write!.InnerException).Should().BeOfType<InvalidOperationException>();
		server.Requests.Should().Contain("GET /api/V1/serviceinfo?locale=fr-FR");
		server.Requests.Should().NotContain(r => r.StartsWith("POST /api/V1/savebusinessobject", StringComparison.Ordinal));
	}

	/// <summary>
	/// POST operations that only read are classified as read requests, writes are not.
	/// </summary>
	[Theory]
	[InlineData("GET", "/api/V1/x", true)]
	[InlineData("HEAD", "/api/V1/x", true)]
	[InlineData("POST", "/api/V1/getsearchresults", true)]
	[InlineData("POST", "/api/V1/GetSearchResults/", true)]
	[InlineData("POST", "/api/V1/savebusinessobject", false)]
	[InlineData("DELETE", "/api/V1/x", false)]
	[InlineData("PUT", "/api/V1/x", false)]
	public void IsReadRequest_ClassifiesByMethodAndOperation(string method, string path, bool expected)
	{
		using var request = new HttpRequestMessage(new HttpMethod(method), path);

		AuthenticatedHttpClientHandler.IsReadRequest(request).Should().Be(expected);
	}
}
