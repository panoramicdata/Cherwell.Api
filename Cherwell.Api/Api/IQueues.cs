using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;

namespace Cherwell.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueuesApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Add a Business Object to a queue
        /// </summary>
        /// <remarks>
        /// Operation to add a Business Object to a queue
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all properties necessary to add an item to a queue. All properties are required. The standin key defines the queue to which we want to add the Business Object.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of QueuesAddItemToQueueResponse</returns>
        [Post("/api/V1/additemtoqueue")]
        Task<AddItemToQueueResponse> QueuesAddItemToQueue([Header("UserAgent")] string userAgent, [Body]AddItemToQueueRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Check a Business Object in to a queue
        /// </summary>
        /// <remarks>
        /// Operation to check in a queue item
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking in an item to a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of QueuesCheckInQueueItemResponse</returns>
        [Post("/api/V1/checkinqueueitem")]
        Task<CheckInQueueItemResponse> QueuesCheckInQueueItem([Header("UserAgent")] string userAgent, [Body]CheckInQueueItemRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Check a Business Object out of a queue
        /// </summary>
        /// <remarks>
        /// Operation to check out a queue item
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object for checking out an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of QueuesCheckOutQueueItemResponse</returns>
        [Post("/api/V1/checkoutqueueitem")]
        Task<CheckOutQueueItemResponse> QueuesCheckOutQueueItem([Header("UserAgent")] string userAgent, [Body]CheckOutQueueItemRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getqueues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
        Task<ManagerData> QueuesGetQueuesFolder([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("folder")]string folder, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getqueues/scope/{scope}/scopeowner/{scopeowner}")]
        Task<ManagerData> QueuesGetQueuesScopeOwner([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object type based on scope.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">The scope to get available queues for.</param>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getqueues/scope/{scope}")]
        Task<ManagerData> QueuesGetQueuesScope([Header("UserAgent")] string userAgent, [AliasAs("scope")]string scope, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get available queues.
        /// </summary>
        /// <remarks>
        /// Get available queues for a specific Business Object.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Whether or not to include links. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getqueues")]
        Task<ManagerData> QueuesGetQueues([Header("UserAgent")] string userAgent, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Remove an item from a queue
        /// </summary>
        /// <remarks>
        /// Operation to remove an item from a queue
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to remove an item from a queue. All properties are required except for historyNotes</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of QueuesRemoveItemFromQueueResponse</returns>
        [Post("/api/V1/removeitemfromqueue")]
        Task<RemoveItemFromQueueResponse> QueuesRemoveItemFromQueue([Header("UserAgent")] string userAgent, [Body]RemoveItemFromQueueRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);
        #endregion Asynchronous Operations
    }
}
