using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ILifecycle
{
	/// <summary>
	/// Get current lifecycle stage for record
	/// </summary>
	/// <remarks>
	/// Gets the current lifecycle stage of a business object record
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <param name="recordId"></param>
	/// <returns>Task of GetRecordStatusResponse</returns>
	[Get("/api/V1/{businessObjectDefinitionId}/records/{recordId}/stage")]
	Task<GetRecordStatusResponse> GetRecordStageAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		[AliasAs("recordId")] string recordId,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get current lifecycle status for record
	/// </summary>
	/// <remarks>
	/// Gets the current lifecycle status of a business object record
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <param name="recordId"></param>
	/// <returns>Task of GetRecordStatusResponse</returns>
	[Get("/api/V1/{businessObjectDefinitionId}/records/{recordId}/status")]
	Task<GetRecordStatusResponse> GetRecordStatusAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		[AliasAs("recordId")] string recordId,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get lifecycle stages
	/// </summary>
	/// <remarks>
	/// Gets all of the stages on the lifecycle for a Business Object
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <returns>Task of GetStagesResponse</returns>
	[Get("/api/V1/{businessObjectDefinitionId}/lifecycle/stages")]
	Task<GetStagesResponse> GetStagesAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get lifecycle statuses
	/// </summary>
	/// <remarks>
	/// Gets all of the statuses on the lifecycle for a Business Object
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <returns>Task of GetStatusesResponse</returns>
	[Get("/api/V1/{businessObjectDefinitionId}/lifecycle/statuses")]
	Task<GetStatusesResponse> GetStatusesAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get lifecycle transition options for record
	/// </summary>
	/// <remarks>
	/// Gets the lifecycle transition options currently available to a business object record
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <param name="recordId"></param>
	/// <returns>Task of GetTransitionOptionsResponse</returns>
	[Get("/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitionOptions")]
	Task<GetTransitionOptionsResponse> GetTransitionOptionsAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		[AliasAs("recordId")] string recordId,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get lifecycle transitions
	/// </summary>
	/// <remarks>
	/// Gets all of the transitions on the lifecycle for a Business Object
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <returns>Task of GetTransitionsResponse</returns>
	[Get("/api/V1/{businessObjectDefinitionId}/lifecycle/transitions")]
	Task<GetTransitionsResponse> GetTransitionsAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		CancellationToken cancellationToken);

	/// <summary>
	/// Transition a business object record
	/// </summary>
	/// <remarks>
	/// Transitions a business object record in to the specified lifecycle status
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="businessObjectDefinitionId"></param>
	/// <param name="recordId"></param>
	/// <param name="transitionRecordRequest"></param>
	/// <returns>Task of ResponseBase</returns>
	[Post("/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitions")]
	Task<ResponseBase> TransitionRecordAsync(
		[AliasAs("businessObjectDefinitionId")] string businessObjectDefinitionId,
		[AliasAs("recordId")] string recordId,
		[Body] TransitionRecordRequest transitionRecordRequest,
		CancellationToken cancellationToken);
}
