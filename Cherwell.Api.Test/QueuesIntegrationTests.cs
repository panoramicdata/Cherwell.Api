using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class QueuesIntegrationTests : CherwellClientTest
{
	public QueuesIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void GetQueues_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Queues
			.GetQueuesAsync(null, cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}
}