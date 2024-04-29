using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class ServiceTests(ITestOutputHelper iTestOutputHelper) : CherwellClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsNotNullResponse()
	{
		var response = await TestCherwellClient
			.Service
			.GetServiceInfoAsync(CancellationToken.None);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsValidApiVersion()
	{
		var response = await TestCherwellClient
			.Service
			.GetServiceInfoAsync(CancellationToken.None);

		response
			.ApiVersion
			.Should()
			.NotBeNullOrWhiteSpace();
	}

	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsSystemDateThatIsToday()
	{
		var response = await TestCherwellClient
			.Service
			.GetServiceInfoAsync(CancellationToken.None);

		response
			.SystemDateTime
			.Date
			.Should()
			.Be(DateTime.Today);
	}
}