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
    public interface IUsersApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserBatchDeleteResponse</returns>
        [Post("/api/V1/deleteuserbatch")]
        Task<UsersUserBatchDeleteResponse> UsersDeleteUserBatch([Header("UserAgent")] string userAgent, [Body]UserBatchDeleteRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Delete a batch of users
        /// </summary>
        /// <remarks>
        /// Operation to delete a batch of users. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing record IDs for users to be deleted and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserBatchDeleteV2Response</returns>
        [Post("/api/V2/deleteuserbatch")]
        Task<UsersUserBatchDeleteV2Response> UsersDeleteUserBatchV2([Header("UserAgent")] string userAgent, [Body]UserBatchDeleteRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserDeleteResponse</returns>
        [Delete("/api/V1/deleteuser/userrecordid/{userrecordid}")]
        Task<UsersUserDeleteResponse> UsersDeleteUser([Header("UserAgent")] string userAgent, [AliasAs("userrecordid")]string userrecordid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Delete a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to delete a user by record ID. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userrecordid">Specify the record ID of the user you want to delete</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserDeleteV2Response</returns>
        [Delete("/api/V2/deleteuser/userrecordid/{userrecordid}")]
        Task<UsersUserDeleteV2Response> UsersDeleteUserV2([Header("UserAgent")] string userAgent, [AliasAs("userrecordid")]string userrecordid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a list of all system users.
        /// </summary>
        /// <remarks>
        /// Operation to get a list of all system users.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginidfilter">Specify the login ID filter to apply to the users list.</param>
        /// <param name="stoponerror">Specify whether the operation is interrupted if retrieving any user causes an error. (optional)</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserListResponse</returns>
        [Get("/api/V1/getlistofusers")]
        Task<UsersUserListResponse> UsersGetListOfUsers([Header("UserAgent")] string userAgent, [AliasAs("loginidfilter")]string loginidfilter, [AliasAs("stoponerror")]bool? stoponerror = null, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get user information in a batch
        /// </summary>
        /// <remarks>
        /// Operation to get user information in a batch. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object that lists user record IDs or public IDs of users and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserBatchReadResponse</returns>
        [Post("/api/V1/getuserbatch")]
        Task<UsersUserBatchReadResponse> UsersGetUserBatch([Header("UserAgent")] string userAgent, [Body]UsersUserBatchReadRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a user by login ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example. This operation has been deprecated by a V2 operation of the same name, but with query string parameters.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of User</returns>
        [Get("/api/V1/getuserbyloginid/loginid/{loginid}")]
        Task<User> UsersGetUserByLoginId([Header("UserAgent")] string userAgent, [AliasAs("loginid")]string loginid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of User</returns>
        [Get("/api/V2/getuserbyloginid")]
        Task<User> UsersGetUserByLoginIdV2([Header("UserAgent")] string userAgent, [AliasAs("loginid")]string loginid, [AliasAs("loginidtype")]string loginidtype, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginid">Specify the user&#39;s login ID.</param>
        /// <param name="loginidtype">Specify the login ID type.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserV2</returns>
        [Get("/api/V3/getuserbyloginid")]
        Task<UsersUserV2> UsersGetUserByLoginIdV3([Header("UserAgent")] string userAgent, [AliasAs("loginid")]string loginid, [AliasAs("loginidtype")]string loginidtype, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserReadResponse</returns>
        [Get("/api/V1/getuserbypublicid/publicid/{publicid}")]
        Task<UsersUserReadResponse> UsersGetUserByPublicId([Header("UserAgent")] string userAgent, [AliasAs("publicid")]string publicid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a user by public ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by public ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="publicid">Specify the user&#39;s public ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserReadV2Response</returns>
        [Get("/api/V2/getuserbypublicid/publicid/{publicid}")]
        Task<UsersUserReadV2Response> UsersGetUserByPublicIdV2([Header("UserAgent")] string userAgent, [AliasAs("publicid")]string publicid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a user by record ID
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by record ID.  Use to get user public IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recid">Specify the user&#39;s record ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserV2</returns>
        [Get("/api/V1/getuserbyrecid/recid/{recid}")]
        Task<UsersUserV2> UsersGetUserByRecId([Header("UserAgent")] string userAgent, [AliasAs("recid")]string recid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserBatchSaveResponse</returns>
        [Post("/api/V1/saveuserbatch")]
        Task<UsersUserBatchSaveResponse> UsersSaveUserBatch([Header("UserAgent")] string userAgent, [Body]UsersUserBatchSaveRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update users in a batch
        /// </summary>
        /// <remarks>
        /// Operation to create or update users in a batch. To update, specify record ID. To create, leave record ID empty.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object listing user record IDs and an error flag.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserBatchSaveV2Response</returns>
        [Post("/api/V2/saveuserbatch")]
        Task<UsersUserBatchSaveV2Response> UsersSaveUserBatchV2([Header("UserAgent")] string userAgent, [Body]UsersUserBatchSaveV2Request request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserSaveResponse</returns>
        [Post("/api/V1/saveuser")]
        Task<UsersUserSaveResponse> UsersSaveUser([Header("UserAgent")] string userAgent, [Body]UsersUserSaveRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserSaveV2Response</returns>
        [Post("/api/V2/saveuser")]
        Task<UsersUserSaveV2Response> UsersSaveUserV2([Header("UserAgent")] string userAgent, [Body]UsersUserSaveV2Request request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);
        #endregion Asynchronous Operations
    }
}
