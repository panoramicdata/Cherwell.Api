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
        /// <returns>Task of AddUserToTeamByBatchResponse</returns>
        [Post("/api/V1/addusertoteambybatch")]
        Task<AddUserToTeamByBatchResponse> AddUserToTeamByBatch([Header("UserAgent")] string userAgent, [Body]AddUserToTeamByBatchRequest request, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        Task AddUserToTeam([Header("UserAgent")] string userAgent, [Body]AddUserToTeamRequest dataRequest, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of AddUserToTeamResponse</returns>
        [Post("/api/V2/addusertoteam")]
        Task<AddUserToTeamResponse> AddUserToTeamV2([Header("UserAgent")] string userAgent, [Body]AddUserToTeamRequest dataRequest, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        Task DeleteTeam([Header("UserAgent")] string userAgent, [AliasAs("teamid")]string teamid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of TeamResponse</returns>
        [Get("/api/V1/getteam/{teamid}")]
        Task<TeamResponse> GetTeam([Header("UserAgent")] string userAgent, [AliasAs("teamid")]string teamid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TeamsResponse</returns>
        [Get("/api/V1/getteams")]
        Task<TeamsResponse> GetTeams([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get all available Teams
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Teams.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TeamsV2Response</returns>
        [Get("/api/V2/getteams")]
        Task<TeamsV2Response> GetTeamsV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of TeamsResponse</returns>
        [Get("/api/V1/getusersteams/userrecordid/{userRecordId}")]
        Task<TeamsResponse> GetUsersTeams([Header("UserAgent")] string userAgent, [AliasAs("userRecordId")]string userRecordId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of TeamsV2Response</returns>
        [Get("/api/V2/getusersteams/userrecordid/{userRecordId}")]
        Task<TeamsV2Response> GetUsersTeamsV2([Header("UserAgent")] string userAgent, [AliasAs("userRecordId")]string userRecordId, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TeamsResponse</returns>
        [Get("/api/V1/getworkgroups")]
        Task<TeamsResponse> GetWorkgroups([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

        /// <summary>
        /// Get all available Workgroups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Workgroups.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of TeamsV2Response</returns>
        [Get("/api/V2/getworkgroups")]
        Task<TeamsV2Response> GetWorkgroupsV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of RemoveCustomerFromWorkgroupResponse</returns>
        [Delete("/api/V1/removecustomerfromworkgroup/workgroupid/{workgroupid}/customerrecordid/{customerrecordid}")]
        Task<RemoveCustomerFromWorkgroupResponse> TeamsRemoveCustomerFromWorkgroup([Header("UserAgent")] string userAgent, [AliasAs("workgroupid")]string workgroupid, [AliasAs("customerrecordid")]string customerrecordid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        Task RemoveUserFromTeam([Header("UserAgent")] string userAgent, [AliasAs("teamId")]string teamId, [AliasAs("userrecordid")]string userrecordid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of RemoveUserFromTeamResponse</returns>
        [Delete("/api/V2/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}")]
        Task<RemoveUserFromTeamResponse> RemoveUserFromTeamV2([Header("UserAgent")] string userAgent, [AliasAs("teamId")]string teamId, [AliasAs("userrecordid")]string userrecordid, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of SaveTeamMemberResponse</returns>
        [Post("/api/V1/saveteammember")]
        Task<SaveTeamMemberResponse> SaveTeamMember([Header("UserAgent")] string userAgent, [Body]SaveTeamMemberRequest request, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of TeamSaveResponse</returns>
        [Post("/api/V1/saveteam")]
        Task<TeamSaveResponse> SaveTeam([Header("UserAgent")] string userAgent, [Body]TeamSaveRequest request, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);

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
        /// <returns>Task of SaveWorkgroupMemberResponse</returns>
        [Post("/api/V1/saveworkgroupmember")]
        Task<SaveWorkgroupMemberResponse> SaveWorkgroupMember([Header("UserAgent")] string userAgent, [Body]SaveWorkgroupMemberRequest request, [AliasAs("lang")]string lang, [AliasAs("locale")]string locale);
        #endregion Asynchronous Operations
    }
}
