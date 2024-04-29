using FluentAssertions;
using Xunit;

namespace Cherwell.Api.Test;

public class ServiceTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _cherwellClient = cherwellClient;

	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsNotNullResponse()
	{
		var response = await _cherwellClient
			.Service
			.GetServiceInfoAsync(CancellationToken.None);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsValidApiVersion()
	{
		var response = await _cherwellClient
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
		var response = await _cherwellClient
			.Service
			.GetServiceInfoAsync(CancellationToken.None);

		response
			.SystemDateTime
			.Date
			.Should()
			.Be(DateTime.Today);
	}
}