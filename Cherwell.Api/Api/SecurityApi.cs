using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using Cherwell.Client;
using Cherwell.Model;

namespace Cherwell.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// Get client security settings
        /// </summary>
        /// <remarks>
        /// Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityClientSecuritySettingsResponse</returns>
        [Get("/api/V1/getclientsecuritysettings/applicationtype/{applicationtype}")]
        Task<SecurityClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1([Header("UserAgent")] string userAgent, [AliasAs("applicationtype")]string applicationtype, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityRoleReadResponse</returns>
        [Get("/api/V1/getroles")]
        Task<SecurityRoleReadResponse> SecurityGetRolesV1([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Roles
        /// </summary>
        /// <remarks>
        /// Operation to get all available Roles.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityRoleReadV2Response</returns>
        [Get("/api/V2/getroles")]
        Task<SecurityRoleReadV2Response> SecurityGetRolesV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityBusinessObjectPermission&gt;</returns>
        [Get("/api/V1/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}")]
        Task<List<SecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1([Header("UserAgent")] string userAgent, [AliasAs("groupid")]string groupid, [AliasAs("busObId")]string busObId, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID. </param>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        [Get("/api/V2/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}")]
        Task<SecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2([Header("UserAgent")] string userAgent, [AliasAs("groupid")]string groupid, [AliasAs("busObId")]string busObId, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityBusinessObjectPermission&gt;</returns>
        [Get("/api/V1/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}")]
        Task<List<SecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1([Header("UserAgent")] string userAgent, [AliasAs("groupname")]string groupname, [AliasAs("busobname")]string busobname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permissions by Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get specific Business Object permissions for a Security Group. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name. </param>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        [Get("/api/V2/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}")]
        Task<SecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2([Header("UserAgent")] string userAgent, [AliasAs("groupname")]string groupname, [AliasAs("busobname")]string busobname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityBusinessObjectPermission&gt;</returns>
        [Get("/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}")]
        Task<List<SecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1([Header("UserAgent")] string userAgent, [AliasAs("busObId")]string busObId, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permission for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busObId">Specify the Business Object ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        [Get("/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}")]
        Task<SecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2([Header("UserAgent")] string userAgent, [AliasAs("busObId")]string busObId, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityBusinessObjectPermission&gt;</returns>
        [Get("/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}")]
        Task<List<SecurityBusinessObjectPermission>> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1([Header("UserAgent")] string userAgent, [AliasAs("busobname")]string busobname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get Business Object permissions for current user
        /// </summary>
        /// <remarks>
        /// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify the Business Object name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecurityGetSecurityGroupBusinessObjectPermissionsResponse</returns>
        [Get("/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}")]
        Task<SecurityGetSecurityGroupBusinessObjectPermissionsResponse> SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2([Header("UserAgent")] string userAgent, [AliasAs("busobname")]string busobname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityRightCategory&gt;</returns>
        [Get("/api/V1/getsecuritygroupcategories")]
        Task<List<SecurityRightCategory>> SecurityGetSecurityGroupCategoriesV1([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all Security Group categories
        /// </summary>
        /// <remarks>
        /// Operation to get IDs and names for all available Security Group categories. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityRightCategoriesResponse</returns>
        [Get("/api/V2/getsecuritygroupcategories")]
        Task<SecuritySecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityRight&gt;</returns>
        [Get("/api/V1/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}")]
        Task<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1([Header("UserAgent")] string userAgent, [AliasAs("groupid")]string groupid, [AliasAs("categoryid")]string categoryid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID</param>
        /// <param name="categoryid">Specify the Security Group category ID</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityRightsResponse</returns>
        [Get("/api/V2/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}")]
        Task<SecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2([Header("UserAgent")] string userAgent, [AliasAs("groupid")]string groupid, [AliasAs("categoryid")]string categoryid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityRight&gt;</returns>
        [Get("/api/V1/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}")]
        Task<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1([Header("UserAgent")] string userAgent, [AliasAs("groupname")]string groupname, [AliasAs("categoryname")]string categoryname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get permissions for a Security Group by category
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for a Security Group by category.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupname">Specify the Security Group name.</param>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityRightsResponse</returns>
        [Get("/api/V2/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}")]
        Task<SecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2([Header("UserAgent")] string userAgent, [AliasAs("groupname")]string groupname, [AliasAs("categoryname")]string categoryname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityRight&gt;</returns>
        [Get("/api/V1/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}")]
        Task<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1([Header("UserAgent")] string userAgent, [AliasAs("categoryid")]string categoryid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by ID
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryid">Specify the Security Group category ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityRightsResponse</returns>
        [Get("/api/V2/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}")]
        Task<SecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2([Header("UserAgent")] string userAgent, [AliasAs("categoryid")]string categoryid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;SecurityRight&gt;</returns>
        [Get("/api/V1/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}")]
        Task<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1([Header("UserAgent")] string userAgent, [AliasAs("categoryname")]string categoryname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get current user&#39;s permissions by Security Group category by name
        /// </summary>
        /// <remarks>
        /// Operation to get permissions for the current user&#39;s Security Group by category.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryname">Specify the Security Group category name.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityRightsResponse</returns>
        [Get("/api/V2/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}")]
        Task<SecuritySecurityRightsResponse> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2([Header("UserAgent")] string userAgent, [AliasAs("categoryname")]string categoryname, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityGroupResponse</returns>
        [Get("/api/V1/getsecuritygroups")]
        Task<SecuritySecurityGroupResponse> SecurityGetSecurityGroupsV1([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get all available Security Groups
        /// </summary>
        /// <remarks>
        /// Operation to get IDs, names, and descriptions for all available Security Groups.
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of SecuritySecurityGroupV2Response</returns>
        [Get("/api/V2/getsecuritygroups")]
        Task<SecuritySecurityGroupV2Response> SecurityGetSecurityGroupsV2([Header("UserAgent")] string userAgent, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of List&lt;UsersUser&gt;</returns>
        [Get("/api/V1/getusersinsecuritygroup/groupid/{groupid}")]
        Task<List<UsersUser>> SecurityGetUsersInSecurityGroupV1([Header("UserAgent")] string userAgent, [AliasAs("groupid")]string groupid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);

        /// <summary>
        /// Get users in a Security Group
        /// </summary>
        /// <remarks>
        /// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
        /// </remarks>
        /// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupid">Specify the Security Group ID.</param>
        /// <param name="lang">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <param name="locale">Optional parameter to specify the culture of the request. Either \&quot;lang\&quot; or \&quot;locale\&quot; can be used to specify the culture. (optional)</param>
        /// <returns>Task of UsersUserReadV2Response</returns>
        [Get("/api/V2/getusersinsecuritygroup/groupid/{groupid}")]
        Task<UsersUserReadV2Response> SecurityGetUsersInSecurityGroupV2([Header("UserAgent")] string userAgent, [AliasAs("groupid")]string groupid, [AliasAs("lang")]string lang = null, [AliasAs("locale")]string locale = null);
        #endregion Asynchronous Operations
    }
}
