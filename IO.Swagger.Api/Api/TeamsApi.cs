/* 
 * Cherwell Rest API
 *
 * <a href=\"https://xantes.sharepoint.com/sites/supporthelp\">Cherwell Rest API Documentation</a><br>Select version options from the header drop-down list (to the left of the Client Key box). Then, click Explore to view different versions of operations.
 *
 * OpenAPI spec version: 10.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITeamsApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Add users to a team by batch
        /// </summary>
        /// <remarks>
        /// Operation to add users to a Team by batch. To get internal IDs for users, use “Get User Information in a Batch.” To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify a list of add user to team request objects.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchResponse</returns>
        [Post("/api/V1/addusertoteambybatch")]
        Task<TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchResponse> TeamsAddUserToTeamByBatchV1([Header("UserAgent")] string userAgent, [Body]TrebuchetWebApiDataContractsTeamsAddUserToTeamByBatchRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        [Post("/api/V1/addusertoteam")]
        Task TeamsAddUserToTeamV1([Header("UserAgent")] string userAgent, [Body]TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest dataRequest, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Add a user to a team
        /// </summary>
        /// <remarks>
        /// Operation to add a user to a Team. To get the user&#39;s internal ID, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify user and team values.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsAddUserToTeamResponse</returns>
        [Post("/api/V2/addusertoteam")]
        Task<TrebuchetWebApiDataContractsTeamsAddUserToTeamResponse> TeamsAddUserToTeamV2([Header("UserAgent")] string userAgent, [Body]TrebuchetWebApiDataContractsTeamsAddUserToTeamRequest dataRequest, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Delete a Team
        /// </summary>
        /// <remarks>
        /// Operation to delete a Team by Team ID.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">Specify the Team ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        [Delete("/api/V1/deleteteam/{teamid}")]
        Task TeamsDeleteTeamV1([Header("UserAgent")] string userAgent, [AliasAs("teamid")]string teamid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get a team by its TeamId
        /// </summary>
        /// <remarks>
        /// Operation to get Team Info for a  single Team using its Team ID. To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot; Note that TeamType has two possible values, where TeamType &#x3D; 0 for User (CSM Users), or TeamType &#x3D; 1 for Workgroup (CSM Customers).
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamid">The Team ID of the Team to get.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamResponse</returns>
        [Get("/api/V1/getteam/{teamid}")]
        Task<TrebuchetWebApiDataContractsTeamsTeamResponse> TeamsGetTeamV1([Header("UserAgent")] string userAgent, [AliasAs("teamid")]string teamid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        [Get("/api/V1/getteams")]
        Task<TrebuchetWebApiDataContractsTeamsTeamsResponse> TeamsGetTeamsV1([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        [Get("/api/V2/getteams")]
        Task<TrebuchetWebApiDataContractsTeamsTeamsV2Response> TeamsGetTeamsV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        [Get("/api/V1/getusersteams/userrecordid/{userRecordId}")]
        Task<TrebuchetWebApiDataContractsTeamsTeamsResponse> TeamsGetUsersTeamsV1([Header("UserAgent")] string userAgent, [AliasAs("userRecordId")]string userRecordId, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Team assignments for a user
        /// </summary>
        /// <remarks>
        /// Operation to get Team assignments for a user. To get record IDs, use \&quot;Get a user by login ID\&quot; or \&quot;Get a user by public id.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userRecordId">Specify the user record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        [Get("/api/V2/getusersteams/userrecordid/{userRecordId}")]
        Task<TrebuchetWebApiDataContractsTeamsTeamsV2Response> TeamsGetUsersTeamsV2([Header("UserAgent")] string userAgent, [AliasAs("userRecordId")]string userRecordId, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsResponse</returns>
        [Get("/api/V1/getworkgroups")]
        Task<TrebuchetWebApiDataContractsTeamsTeamsResponse> TeamsGetWorkgroupsV1([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamsV2Response</returns>
        [Get("/api/V2/getworkgroups")]
        Task<TrebuchetWebApiDataContractsTeamsTeamsV2Response> TeamsGetWorkgroupsV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Remove a customer from a Workgroup
        /// </summary>
        /// <remarks>
        /// Operation to remove a Customer from a Workgroup.  To remove, specify the Workgroup ID and the Customer Record ID.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="workgroupid">Specify the Workgroup ID.</param>
        /// <param name="customerrecordid">Specify the Customer record ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsRemoveCustomerFromWorkgroupResponse</returns>
        [Delete("/api/V1/removecustomerfromworkgroup/workgroupid/{workgroupid}/customerrecordid/{customerrecordid}")]
        Task<TrebuchetWebApiDataContractsTeamsRemoveCustomerFromWorkgroupResponse> TeamsRemoveCustomerFromWorkgroupV1([Header("UserAgent")] string userAgent, [AliasAs("workgroupid")]string workgroupid, [AliasAs("customerrecordid")]string customerrecordid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of void</returns>
        [Delete("/api/V1/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}")]
        Task TeamsRemoveUserFromTeamV1([Header("UserAgent")] string userAgent, [AliasAs("teamId")]string teamId, [AliasAs("userrecordid")]string userrecordid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Operation to remove a User from a Team.
        /// </summary>
        /// <remarks>
        /// Operation to remove a User from a Team. To get the User&#39;s record ID, use \&quot;Get a User by login ID\&quot; or \&quot;Get a User by public ID.\&quot; To get a Team&#39;s internal ID, use \&quot;Get all available Teams.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="teamId">Specify the internal ID of the Team.</param>
        /// <param name="userrecordid">Specify the record ID of the User to remove.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsRemoveUserFromTeamResponse</returns>
        [Delete("/api/V2/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}")]
        Task<TrebuchetWebApiDataContractsTeamsRemoveUserFromTeamResponse> TeamsRemoveUserFromTeamV2([Header("UserAgent")] string userAgent, [AliasAs("teamId")]string teamId, [AliasAs("userrecordid")]string userrecordid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Add or Update a team member
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Team Member. To add or update, specify User ID, Team ID, and if Team Manager.   Optionally, set the Team as the User&#39;s default Team.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Team Member. User recID specifies the User to add or update. TeamId specifies the Team to update. IsTeamManager specifies whether the User is a Team Manager, and SetAsDefaultTeam specifies whether to set this Team as the User&#39;s default team. UserRecId, TeamId, and IsTeamManager are required.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsSaveTeamMemberResponse</returns>
        [Post("/api/V1/saveteammember")]
        Task<TrebuchetWebApiDataContractsTeamsSaveTeamMemberResponse> TeamsSaveTeamMemberV1([Header("UserAgent")] string userAgent, [Body]TrebuchetWebApiDataContractsTeamsSaveTeamMemberRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Create or update a team
        /// </summary>
        /// <remarks>
        /// Operation to create or update a Team or Workgroup. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to create Teams or Workgroups. To create a Team, use teamType and teamName. To update a team, use teamID. Team type values must be User or CustomerWorkgroup. The teamType cannot be changed for existing Teams or Workgroups.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsTeamSaveResponse</returns>
        [Post("/api/V1/saveteam")]
        Task<TrebuchetWebApiDataContractsTeamsTeamSaveResponse> TeamsSaveTeamV1([Header("UserAgent")] string userAgent, [Body]TrebuchetWebApiDataContractsTeamsTeamSaveRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Save the membership status of a Workgroup member.
        /// </summary>
        /// <remarks>
        /// Operation to add or update a Workgroup Member.  To add or update, specify Customer Record ID, Workgroup ID, and if Workgroup Manager.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">The request object to add or update a Workgroup Member. CustomerRecordId specifies the Customer to add or update. WorkgroupId specifies the Workgroup to update. CustomerIsWorkgroupManager specifies whether the Customer is a Workgroup Manager.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberResponse</returns>
        [Post("/api/V1/saveworkgroupmember")]
        Task<TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberResponse> TeamsSaveWorkgroupMemberV1([Header("UserAgent")] string userAgent, [Body]TrebuchetWebApiDataContractsTeamsSaveWorkgroupMemberRequest request, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);
        #endregion Asynchronous Operations
    }
}
