using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class ApprovalIntegrationTests : CherwellClientTest
{
	public ApprovalIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	// ActionApprovalAsync - requires an approval rec id, which we do not currently have

	// GetApprovalByRecIdAsync - requires an approval rec id, which we do not currently have

	// GetMyApprovalsAsync - returns "You do not have rights to query for this business object."

	// GetMyPendingApprovalsAsync - returns "You do not have rights to query for this business object."
	
}