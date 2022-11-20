using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class QueuesIntegrationTests : CherwellClientTest
{
	public QueuesIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	// AddItemToQueueAsync - unable to test, no queueStandInKey to test with
	// CheckInQueueItemAsync - unable to test, no queueStandInKey to test with
	// CheckOutQueueItemAsync - unable to test, no queueStandInKey to test with
	// GetQueuesFolderAsync - unable to test, no scope to test with
	// GetQueuesScopeOwnerAsync - unable to test, no scope to test with
	// GetQueuesScopeAsync - unable to test, no scope to test with

	[Fact]
	public async Task GetQueues_Succeeds()
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

	// RemoveItemFromQueueAsync - unable to test, no queueStandInKey to test with
}