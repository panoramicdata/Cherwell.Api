using Microsoft.Extensions.Logging.Abstractions;

namespace Cherwell.Api.Test;

/// <summary>
/// Pure unit tests: a refused write throws before any request is sent, so no credentials or server are needed.
/// </summary>
public class ReadOnlyOptionTests
{
	private static CherwellClientOptions NewOptions(bool isReadOnly) => new()
	{
		UserName = "fake-user",
		Password = "fake-password",
		ClientId = "fake-client",
		BaseAddress = "https://cherwell.invalid/",
		IsReadOnly = isReadOnly
	};

	/// <summary>
	/// The option defaults to false so existing callers are unaffected.
	/// </summary>
	[Fact]
	public void IsReadOnly_DefaultsToFalse()
		=> new CherwellClientOptions().IsReadOnly.Should().BeFalse();

	/// <summary>
	/// Writes are refused by the real handler before the request is sent.
	/// </summary>
	[Theory]
	[InlineData("DELETE", "/api/V1/deleteuser/userrecordid/1")]
	[InlineData("PUT", "/api/V1/setculture/culturecode/en-GB")]
	[InlineData("POST", "/api/V1/savebusinessobject")]
	public async Task WriteIsRefused_WhenIsReadOnly(string method, string path)
	{
		using var handler = new AuthenticatedHttpClientHandler(NewOptions(true), NullLogger.Instance);
		using var client = new HttpClient(handler) { BaseAddress = new Uri("https://cherwell.invalid/") };

		var act = () => client.SendAsync(new HttpRequestMessage(new HttpMethod(method), path), TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<InvalidOperationException>();
	}

	/// <summary>
	/// Reads, including the POST operations that only read, are allowed by name; other writes are not.
	/// </summary>
	[Theory]
	[InlineData("GET", "/api/V1/getbusinessobject/busobid/1", true)]
	[InlineData("POST", "/api/V1/getsearchresults", true)]
	[InlineData("POST", "/api/V1/getbusinessobjectbatch", true)]
	[InlineData("POST", "/api/V2/storedsearches", true)]
	[InlineData("POST", "/api/V1/savebusinessobject", false)]
	[InlineData("POST", "/api/V1/runonestepaction", false)]
	[InlineData("POST", "/api/V1/uploadbusinessobjectattachment/filename/a/busobid/1/busobrecid/2/offset/0/totalsize/1", false)]
	[InlineData("PUT", "/api/V1/setculture/culturecode/en-GB", false)]
	[InlineData("DELETE", "/api/V1/deleteteam/1", false)]
	public void IsReadRequest_ClassifiesRequests(string method, string path, bool expected)
	{
		using var request = new HttpRequestMessage(new HttpMethod(method), $"https://cherwell.invalid{path}");

		AuthenticatedHttpClientHandler.IsReadRequest(request).Should().Be(expected);
	}
}
