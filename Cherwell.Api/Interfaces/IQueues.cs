using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IQueues
{
	/// <summary>
	/// Add a Business Object to a queue
	/// </summary>
	/// <remarks>
	/// Operation to add a Business Object to a queue
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object containing all properties necessary to add an item to a queue. All properties are required. The standin key defines the queue to which we want to add the Business Object.</param>
	/// <returns>Task of AddItemToQueueResponse</returns>
	[Post("/api/V1/additemtoqueue")]
	Task<AddItemToQueueResponse> AddItemToQueueAsync(
		[Body] AddItemToQueueRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Check a Business Object in to a queue
	/// </summary>
	/// <remarks>
	/// Operation to check in a queue item
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">The request object for checking in an item to a queue. All properties are required except for historyNotes</param>
	/// <returns>Task of CheckInQueueItemResponse</returns>
	[Post("/api/V1/checkinqueueitem")]
	Task<CheckInQueueItemResponse> CheckInQueueItemAsync(
		[Body] CheckInQueueItemRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Check a Business Object out of a queue
	/// </summary>
	/// <remarks>
	/// Operation to check out a queue item
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">The request object for checking out an item from a queue. All properties are required except for historyNotes</param>
	/// <returns>Task of CheckOutQueueItemResponse</returns>
	[Post("/api/V1/checkoutqueueitem")]
	Task<CheckOutQueueItemResponse> CheckOutQueueItemAsync(
		[Body] CheckOutQueueItemRequest request,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get available queues.
	/// </summary>
	/// <remarks>
	/// Get available queues for a specific Business Object type based on scope, scope owner, and folder.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scope">The scope to get available queues for.</param>
	/// <param name="scopeowner">The scope owner to get available queues for.</param>
	/// <param name="folder">The folder to get available queues for.  This has to be the folder ID which can be retrieved by doing a getqueues operation without the folder including links option then the links will have the folder IDs.</param>
	/// <param name="links">Whether or not to include links. (optional)</param>
	/// <returns>Task of ManagerData</returns>
	[Get("/api/V1/getqueues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
	Task<ManagerData> GetQueuesFolderAsync(
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("folder")] string folder,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get available queues.
	/// </summary>
	/// <remarks>
	/// Get available queues for a specific Business Object type based on scope, and scope owner.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scope">The scope to get available queues for.</param>
	/// <param name="scopeowner">The scope owner to get available queues for.</param>
	/// <param name="links">Whether or not to include links. (optional)</param>
	/// <returns>Task of ManagerData</returns>
	[Get("/api/V1/getqueues/scope/{scope}/scopeowner/{scopeowner}")]
	Task<ManagerData> GetQueuesScopeOwnerAsync(
		[AliasAs("scope")] string scope,
		[AliasAs("scopeowner")] string scopeowner,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get available queues.
	/// </summary>
	/// <remarks>
	/// Get available queues for a specific Business Object type based on scope.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="scope">The scope to get available queues for.</param>
	/// <param name="links">Whether or not to include links. (optional)</param>
	/// <returns>Task of ManagerData</returns>
	[Get("/api/V1/getqueues/scope/{scope}")]
	Task<ManagerData> GetQueuesScopeAsync(
		[AliasAs("scope")] string scope,
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Get available queues.
	/// </summary>
	/// <remarks>
	/// Get available queues for a specific Business Object.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="links">Whether or not to include links. (optional)</param>
	/// <returns>Task of ManagerData</returns>
	[Get("/api/V1/getqueues")]
	Task<ManagerData> GetQueuesAsync(
		[AliasAs("links")] bool? links,
		CancellationToken cancellationToken);

	/// <summary>
	/// Remove an item from a queue
	/// </summary>
	/// <remarks>
	/// Operation to remove an item from a queue
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">The request object to remove an item from a queue. All properties are required except for historyNotes</param>
	/// <returns>Task of RemoveItemFromQueueResponse</returns>
	[Post("/api/V1/removeitemfromqueue")]
	Task<RemoveItemFromQueueResponse> RemoveItemFromQueueAsync(
		[Body] RemoveItemFromQueueRequest request,
		CancellationToken cancellationToken);
}
