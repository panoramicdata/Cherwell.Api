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
    public interface ILifecycleApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Get current lifecycle stage for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle stage of a business object record
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of GetRecordStatusResponse</returns>
        [Get("/api/V1/{businessObjectDefinitionId}/records/{recordId}/stage")]
        Task<GetRecordStatusResponse> GetRecordStage([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("recordId")]string recordId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get current lifecycle status for record
        /// </summary>
        /// <remarks>
        /// Gets the current lifecycle status of a business object record
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of GetRecordStatusResponse</returns>
        [Get("/api/V1/{businessObjectDefinitionId}/records/{recordId}/status")]
        Task<GetRecordStatusResponse> GetRecordStatus([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("recordId")]string recordId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get lifecycle stages
        /// </summary>
        /// <remarks>
        /// Gets all of the stages on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of GetStagesResponse</returns>
        [Get("/api/V1/{businessObjectDefinitionId}/lifecycle/stages")]
        Task<GetStagesResponse> GetStages([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get lifecycle statuses
        /// </summary>
        /// <remarks>
        /// Gets all of the statuses on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of GetStatusesResponse</returns>
        [Get("/api/V1/{businessObjectDefinitionId}/lifecycle/statuses")]
        Task<GetStatusesResponse> GetStatuses([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get lifecycle transition options for record
        /// </summary>
        /// <remarks>
        /// Gets the lifecycle transition options currently available to a business object record
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="recordId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of GetTransitionOptionsResponse</returns>
        [Get("/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitionOptions")]
        Task<GetTransitionOptionsResponse> GetTransitionOptions([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("recordId")]string recordId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get lifecycle transitions
        /// </summary>
        /// <remarks>
        /// Gets all of the transitions on the lifecycle for a Business Object
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="businessObjectDefinitionId"></param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of GetTransitionsResponse</returns>
        [Get("/api/V1/{businessObjectDefinitionId}/lifecycle/transitions")]
        Task<GetTransitionsResponse> GetTransitions([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of ResponseBase</returns>
        [Post("/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitions")]
        Task<ResponseBase> TransitionRecord([Header("UserAgent")] string userAgent, [AliasAs("businessObjectDefinitionId")]string businessObjectDefinitionId, [AliasAs("recordId")]string recordId, [Body]TransitionRecordRequest transitionRecordRequest, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);
        #endregion Asynchronous Operations
    }
}