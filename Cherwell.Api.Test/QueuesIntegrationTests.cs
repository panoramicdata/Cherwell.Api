using FluentAssertions;
using Xunit;

namespace Cherwell.Api.Test;

public class QueuesIntegrationTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _testCherwellClient = cherwellClient;

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

		var response = await _testCherwellClient
			.Queues
			.GetQueuesAsync(null, cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// RemoveItemFromQueueAsync - unable to test, no queueStandInKey to test with
}