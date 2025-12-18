namespace Cherwell.Api.Test;

public class QueuesIntegrationTests : TestBase
{
	// AddItemToQueueAsync - unable to test, no queueStandInKey to test with
	// CheckInQueueItemAsync - unable to test, no queueStandInKey to test with
	// CheckOutQueueItemAsync - unable to test, no queueStandInKey to test with
	// GetQueuesFolderAsync - unable to test, no scope to test with
	// GetQueuesScopeOwnerAsync - unable to test, no scope to test with
	// GetQueuesScopeAsync - unable to test, no scope to test with

	[Fact]
	public async Task GetQueues_Succeeds()
	{
		var response = await Client
			.Queues
			.GetQueuesAsync(null, CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// RemoveItemFromQueueAsync - unable to test, no queueStandInKey to test with
}