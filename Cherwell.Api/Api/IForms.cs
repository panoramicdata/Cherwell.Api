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
    public interface IFormsApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Get mobile form by BusObId and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and Public ID.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="publicid">Specify the Business Object Public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of MobileFormResponse</returns>
        [Get("/api/V1/getmobileformforbusob/busobid/{busobid}/publicid/{publicid}")]
        Task<MobileFormResponse> GetMobileFormForBusObByIdAndPublicId([Header("UserAgent")] string userAgent, [AliasAs("busobid")]string busobid, [AliasAs("publicid")]string publicid, [AliasAs("foredit")]bool? foredit, [AliasAs("formid")]string formid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get mobile form by Business Object ID and Business Object Record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object ID and record ID.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object Record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of MobileFormResponse</returns>
        [Get("/api/V1/getmobileformforbusob/busobid/{busobid}/busobrecid/{busobrecid}")]
        Task<MobileFormResponse> GetMobileFormForBusObByIdAndRecId([Header("UserAgent")] string userAgent, [AliasAs("busobid")]string busobid, [AliasAs("busobrecid")]string busobrecid, [AliasAs("foredit")]bool? foredit, [AliasAs("formid")]string formid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get mobile form by Business Object name and Public ID
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and public ID.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="publicid">Specify the Business Object public ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of MobileFormResponse</returns>
        [Get("/api/V1/getmobileformforbusob/busobname/{busobname}/publicid/{publicid}")]
        Task<MobileFormResponse> GetMobileFormForBusObByNameAndPublicId([Header("UserAgent")] string userAgent, [AliasAs("busobname")]string busobname, [AliasAs("publicid")]string publicid, [AliasAs("foredit")]bool? foredit, [AliasAs("formid")]string formid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get mobile form by Business Object name and record ID.
        /// </summary>
        /// <remarks>
        /// Operation that gets a mobile form for a specific Business Object by Business Object name and record ID.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <param name="foredit">Flag to get the edit mode version of a form. (optional)</param>
        /// <param name="formid">Specify the form ID if the default is not desired. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of MobileFormResponse</returns>
        [Get("/api/V1/getmobileformforbusob/busobname/{busobname}/busobrecid/{busobrecid}")]
        Task<MobileFormResponse> GetMobileFormForBusObByNameAndRecId([Header("UserAgent")] string userAgent, [AliasAs("busobname")]string busobname, [AliasAs("busobrecid")]string busobrecid, [AliasAs("foredit")]bool? foredit, [AliasAs("formid")]string formid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);
        #endregion Asynchronous Operations
    }
}