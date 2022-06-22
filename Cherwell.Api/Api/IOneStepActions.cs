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
    public interface IOneStepActionsApi
    {
        #region Asynchronous Operations

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}")]
        Task<CoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1([Header("UserAgent")] string userAgent, [AliasAs("association")]string association, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("folder")]string folder, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}")]
        Task<CoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1([Header("UserAgent")] string userAgent, [AliasAs("association")]string association, [AliasAs("scope")]string scope, [AliasAs("scopeowner")]string scopeowner, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getonestepactions/association/{association}/scope/{scope}")]
        Task<CoreManagerData> OneStepActionsGetOneStepActionsByAssociationScopeV1([Header("UserAgent")] string userAgent, [AliasAs("association")]string association, [AliasAs("scope")]string scope, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getonestepactions/association/{association}")]
        Task<CoreManagerData> OneStepActionsGetOneStepActionsByAssociationV1([Header("UserAgent")] string userAgent, [AliasAs("association")]string association, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get One-Step Actions by default Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by default Association
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of CoreManagerData</returns>
        [Get("/api/V1/getonestepactions")]
        Task<CoreManagerData> OneStepActionsGetOneStepActionsV1([Header("UserAgent")] string userAgent, [AliasAs("links")]bool? links = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

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
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of OneStepActionsOneStepActionResponse</returns>
        [Get("/api/V1/runonestepaction/standinkey/{standinkey}/busobid/{busobid}/busobrecid/{busobrecid}")]
        Task<OneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1([Header("UserAgent")] string userAgent, [AliasAs("standinkey")]string standinkey, [AliasAs("busobid")]string busobid, [AliasAs("busobrecid")]string busobrecid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of OneStepActionsOneStepActionResponse</returns>
        [Get("/api/V1/runonestepaction/standinkey/{standinkey}")]
        Task<OneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionByStandInKeyV1([Header("UserAgent")] string userAgent, [AliasAs("standinkey")]string standinkey, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of OneStepActionsOneStepActionResponse</returns>
        [Post("/api/V1/runonestepaction")]
        Task<OneStepActionsOneStepActionResponse> OneStepActionsRunOneStepActionV1([Header("UserAgent")] string userAgent, [Body]OneStepActionsOneStepActionRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);
        #endregion Asynchronous Operations
    }
}
