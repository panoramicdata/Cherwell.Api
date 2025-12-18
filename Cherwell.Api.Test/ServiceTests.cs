namespace Cherwell.Api.Test;

public class ServiceTests : TestBase
{
	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsNotNullResponse()
	{
		var response = await Client
			.Service
			.GetServiceInfoAsync(CancellationToken);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsValidApiVersion()
	{
		var response = await Client
			.Service
			.GetServiceInfoAsync(CancellationToken);

		response
			.ApiVersion
			.Should()
			.NotBeNullOrWhiteSpace();
	}

	[Fact]
	public async Task GetServiceInfoAsync_RequestServiceInfo_GetsSystemDateThatIsToday()
	{
		var response = await Client
			.Service
			.GetServiceInfoAsync(CancellationToken);

		response
			.SystemDateTime
			.Date
			.Should()
			.Be(DateTime.Today);
	}
}