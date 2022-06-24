using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOneStepActions
{
	/// <summary>
	/// Get One-Step Actions by Folder
	/// </summary>
	/// <remarks>
	/// Operation to get One-Step Actions by Association, Scope, Scope Owner in a specific folder.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Business Object association to get One-Step Actions for</param>
	/// <param name="scope">Scope to get One-Step Actions for</param>
	/// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
	/// <param name="folder">Folder to get One-Step Actions from</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V1/getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
	Task<ManagerData> GetOneStepActionsByAssociationScopeScopeOwnerFolderAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("folder")] string folder,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get One-Step Actions by Scope Owner
	/// </summary>
	/// <remarks>
	/// Operation to get One-Step Actions by Association, Scope, Scope Owner
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Business Object association to get One-Step Actions for</param>
	/// <param name="scope">Scope to get One-Step Actions for</param>
	/// <param name="scopeowner">Scope owner to get One-Step Actions for</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V1/getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}")]
	Task<ManagerData> GetOneStepActionsByAssociationScopeScopeOwnerAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get One-Step Actions by Scope
	/// </summary>
	/// <remarks>
	/// Operation to get One-Step Actions by Association, Scope
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Business Object association to get One-Step Actions for</param>
	/// <param name="scope">Scope to get One-Step Actions for</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V1/getonestepactions/association/{association}/scope/{scope}")]
	Task<ManagerData> GetOneStepActionsByAssociationScopeAsync(
		[AliasAs("association")] string association,
		[AliasAs("scope")] string scope,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get One-Step Actions by Association
	/// </summary>
	/// <remarks>
	/// Operation to get One-Step Actions by Association
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="association">Business Object association to get One-Step Actions for</param>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V1/getonestepactions/association/{association}")]
	Task<ManagerData> GetOneStepActionsByAssociationAsync(
		[AliasAs("association")] string association,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get One-Step Actions by default Association
	/// </summary>
	/// <remarks>
	/// Operation to get One-Step Actions by default Association
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
	/// <returns>Task of CoreManagerData</returns>
	[Get("/api/V1/getonestepactions")]
	Task<ManagerData> GetOneStepActionsAsync(
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Run a One-Step Action for a Business Object record
	/// </summary>
	/// <remarks>
	/// Operation to run a One-Step Action for a Business Object record by Business Object ID and Business Object Record ID.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="standinkey">The key to find the One-Step Action to run</param>
	/// <param name="busobid">Specify the Business Object ID.</param>
	/// <param name="busobrecid">Specify the Business Object record ID.</param>
	/// <returns>Task of OneStepActionResponse</returns>
	[Get("/api/V1/runonestepaction/standinkey/{standinkey}/busobid/{busobid}/busobrecid/{busobrecid}")]
	Task<OneStepActionResponse> RunOneStepActionByKeyForRecordByRecIdAsync(
		[AliasAs("standinkey")] string standinkey,
		[AliasAs("busobid")] string busobid,
		[AliasAs("busobrecid")] string busobrecid,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Run a stand alone One-Step Action
	/// </summary>
	/// <remarks>
	/// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="standinkey">The key to find the One-Step Action to run</param>
	/// <returns>Task of OneStepActionResponse</returns>
	[Get("/api/V1/runonestepaction/standinkey/{standinkey}")]
	Task<OneStepActionResponse> RunOneStepActionByStandInKeyAsync(
		[AliasAs("standinkey")] string standinkey,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Run a One-Step Action using a OneStepActionRequest
	/// </summary>
	/// <remarks>
	/// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
	/// <returns>Task of OneStepActionResponse</returns>
	[Post("/api/V1/runonestepaction")]
	Task<OneStepActionResponse> RunOneStepActionAsync(
		[Body] OneStepActionRequest request,
		CancellationToken cancellationToken = default);
}
