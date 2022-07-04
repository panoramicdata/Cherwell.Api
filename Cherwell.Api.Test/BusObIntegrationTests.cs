using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class BusObIntegrationTests : CherwellClientTest
{
	public BusObIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void GetBusObSummaries_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSummariesAsync("Major", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetBusObSchema_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", true, cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetBusObByName_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Attachment", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}
}