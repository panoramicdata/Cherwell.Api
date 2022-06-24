using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IUsers
{
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
	/// <returns>Task of UserBatchDeleteResponse</returns>
	[Post("/api/V1/deleteuserbatch")]
	Task<UserBatchDeleteResponse> DeleteUserBatchAsync([Body] UserBatchDeleteRequest request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserBatchDeleteV2Response</returns>
	[Post("/api/V2/deleteuserbatch")]
	Task<UserBatchDeleteV2Response> DeleteUserBatchV2Async([Body] UserBatchDeleteRequest request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserDeleteResponse</returns>
	[Delete("/api/V1/deleteuser/userrecordid/{userrecordid}")]
	Task<UserDeleteResponse> DeleteUserAsync([AliasAs("userrecordid")] string userrecordid, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserDeleteV2Response</returns>
	[Delete("/api/V2/deleteuser/userrecordid/{userrecordid}")]
	Task<UserDeleteV2Response> DeleteUserV2Async([AliasAs("userrecordid")] string userrecordid, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserListResponse</returns>
	[Get("/api/V1/getlistofusers")]
	Task<UserListResponse> GetListOfUsersAsync([AliasAs("loginidfilter")] string loginidfilter, [AliasAs("stoponerror")] bool? stoponerror, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserBatchReadResponse</returns>
	[Post("/api/V1/getuserbatch")]
	Task<UserBatchReadResponse> GetUserBatchAsync([Body] UserBatchReadRequest request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	Task<User> GetUserByLoginIdAsync([AliasAs("loginid")] string loginid, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	Task<User> GetUserByLoginIdV2Async([AliasAs("loginid")] string loginid, [AliasAs("loginidtype")] string loginidtype, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserV2</returns>
	[Get("/api/V3/getuserbyloginid")]
	Task<UserV2> GetUserByLoginIdV3Async([AliasAs("loginid")] string loginid, [AliasAs("loginidtype")] string loginidtype, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserReadResponse</returns>
	[Get("/api/V1/getuserbypublicid/publicid/{publicid}")]
	Task<UserReadResponse> GetUserByPublicIdAsync([AliasAs("publicid")] string publicid, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserReadV2Response</returns>
	[Get("/api/V2/getuserbypublicid/publicid/{publicid}")]
	Task<UserReadV2Response> GetUserByPublicIdV2Async([AliasAs("publicid")] string publicid, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserV2</returns>
	[Get("/api/V1/getuserbyrecid/recid/{recid}")]
	Task<UserV2> GetUserByRecIdAsync([AliasAs("recid")] string recid, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserBatchSaveResponse</returns>
	[Post("/api/V1/saveuserbatch")]
	Task<UserBatchSaveResponse> SaveUserBatchAsync([Body] UserBatchSaveRequest request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

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
	/// <returns>Task of UserBatchSaveV2Response</returns>
	[Post("/api/V2/saveuserbatch")]
	Task<UserBatchSaveV2Response> SaveUserBatchV2Async([Body] UserBatchSaveV2Request request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

	/// <summary>
	/// Create or update a user
	/// </summary>
	/// <remarks>
	/// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object to specify user parameters and Fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
	/// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <returns>Task of UserSaveResponse</returns>
	[Post("/api/V1/saveuser")]
	Task<UserSaveResponse> SaveUserAsync([Body] UserSaveRequest request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);

	/// <summary>
	/// Create or update a user
	/// </summary>
	/// <remarks>
	/// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="request">Request object to specify user parameters and Fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
	/// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
	/// <returns>Task of UserSaveV2Response</returns>
	[Post("/api/V2/saveuser")]
	Task<UserSaveV2Response> SaveUserV2Async([Body] UserSaveV2Request request, [AliasAs("lang")] string? lang = null, [AliasAs("locale")] string? locale = null, CancellationToken cancellationToken = default);
}
