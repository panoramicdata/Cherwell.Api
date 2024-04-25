namespace Cherwell.Api.Test;

public class ApprovalIntegrationTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _cherwellClient = cherwellClient;

	// ActionApprovalAsync - requires an approval rec id, which we do not currently have

	// GetApprovalByRecIdAsync - requires an approval rec id, which we do not currently have

	// GetMyApprovalsAsync - returns "You do not have rights to query for this business object."

	// GetMyPendingApprovalsAsync - returns "You do not have rights to query for this business object."
}