using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IApproval
{
	/// <summary>
	/// Action an Approval
	/// </summary>
	/// <remarks>
	/// Operation that actions an Approval Business Object. Use this method, passing either approve, abstain or deny to update the Business Object&#39;s state
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="approvalRecId"></param>
	/// <param name="approvalAction"></param>
	/// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <returns>Task of BusinessObjectSaveResponse</returns>
	[Post("/api/V1/approval/{approvalRecId}/{approvalAction}")]
	Task<SaveResponse> ActionApprovalAsync(
		[AliasAs("approvalRecId")] string approvalRecId,
		[AliasAs("approvalAction")] string approvalAction,
		[AliasAs("lang")] string? lang = null,
		[AliasAs("locale")] string? locale = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Approval
	/// </summary>
	/// <remarks>
	/// Operation that returns an Approval Business Object.  Use the provided links to action the Approval
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="approvalRecId"></param>
	/// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <returns>Task of ApprovalReadResponse</returns>
	[Get("/api/V1/approval/{approvalRecId}")]
	Task<ApprovalReadResponse> GetApprovalByRecIdAsync(
		[AliasAs("approvalRecId")] string approvalRecId,
		[AliasAs("lang")] string? lang = null,
		[AliasAs("locale")] string? locale = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all waitings for the current user
	/// </summary>
	/// <remarks>
	/// Operation that returns a list of Approval Business Objects that are in a state of &#39;Waiting&#39; for the current user.  Use the provided links to action the Approval
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <returns>Task ofGetApprovalsResponse</returns>
	[Get("/api/V1/getmyapprovals")]
	Task<GetApprovalsResponse> GetMyApprovalsAsync(
		[AliasAs("lang")] string? lang = null,
		[AliasAs("locale")] string? locale = null,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all waiting approvals that were created by the current user
	/// </summary>
	/// <remarks>
	/// Operation that returns a list of Approval Business Objects that are in a state of &#39;Waiting&#39; that were created by the current user.  Use the provided links to action the Approval
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <returns>Task ofGetApprovalsResponse</returns>
	[Get("/api/V1/getmypendingapprovals")]
	Task<GetApprovalsResponse> GetMyPendingApprovalsAsync(
		[AliasAs("lang")] string? lang = null,
		[AliasAs("locale")] string? locale = null,
		CancellationToken cancellationToken = default);
}
