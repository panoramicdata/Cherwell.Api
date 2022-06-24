using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISecurity
{
	/// <summary>
	/// Get client security settings
	/// </summary>
	/// <remarks>
	/// Operation to get the configured client security settings. Returns true if internal, Windows, LDAP, or SAML are enabled as authentication methods.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="applicationtype">The type of CSM application to return security settings for.  Application type is Desktop Client, Browser Client, Browser Portal or Cherwell Mobile.</param>
	/// <returns>Task of ClientSecuritySettingsResponse</returns>
	[Get("/api/V1/getclientsecuritysettings/applicationtype/{applicationtype}")]
	Task<ClientSecuritySettingsResponse> GetClientSecuritySettingsAsync(
		[AliasAs("applicationtype")] string applicationtype,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all available Roles
	/// </summary>
	/// <remarks>
	/// Operation to get all available Roles.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of RoleReadResponse</returns>
	[Get("/api/V1/getroles")]
	Task<RoleReadResponse> GetRolesAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all available Roles
	/// </summary>
	/// <remarks>
	/// Operation to get all available Roles.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of RoleReadV2Response</returns>
	[Get("/api/V2/getroles")]
	Task<RoleReadV2Response> GetRolesV2Async(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permissions by Security Group
	/// </summary>
	/// <remarks>
	/// Operation to get specific Business Object permissions for a Security Group. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupid">Specify the Security Group ID. </param>
	/// <param name="busObId">Specify the Business Object ID.</param>
	/// <returns>Task of List&lt;BusinessObjectPermission&gt;</returns>
	[Get("/api/V1/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}")]
	Task<List<BusinessObjectPermission>> GetSecurityGroupBusinessObjectPermissionsByBusObIdAsync(
		[AliasAs("groupid")] string groupid,
		[AliasAs("busObId")] string busObId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permissions by Security Group
	/// </summary>
	/// <remarks>
	/// Operation to get specific Business Object permissions for a Security Group. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupid">Specify the Security Group ID. </param>
	/// <param name="busObId">Specify the Business Object ID.</param>
	/// <returns>Task of GetSecurityGroupBusinessObjectPermissionsResponse</returns>
	[Get("/api/V2/getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}")]
	Task<GetSecurityGroupBusinessObjectPermissionsResponse> GetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async(
		[AliasAs("groupid")] string groupid,
		[AliasAs("busObId")] string busObId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permissions by Security Group
	/// </summary>
	/// <remarks>
	/// Operation to get specific Business Object permissions for a Security Group. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupname">Specify the Security Group name. </param>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <returns>Task of List&lt;BusinessObjectPermission&gt;</returns>
	[Get("/api/V1/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}")]
	Task<List<BusinessObjectPermission>> GetSecurityGroupBusinessObjectPermissionsByBusObNameAsync(
		[AliasAs("groupname")] string groupname,
		[AliasAs("busobname")] string busobname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permissions by Security Group
	/// </summary>
	/// <remarks>
	/// Operation to get specific Business Object permissions for a Security Group. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupname">Specify the Security Group name. </param>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <returns>Task of GetSecurityGroupBusinessObjectPermissionsResponse</returns>
	[Get("/api/V2/getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}")]
	Task<GetSecurityGroupBusinessObjectPermissionsResponse> GetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async(
		[AliasAs("groupname")] string groupname,
		[AliasAs("busobname")] string busobname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permission for current user
	/// </summary>
	/// <remarks>
	/// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busObId">Specify the Business Object ID.</param>
	/// <returns>Task of List&lt;BusinessObjectPermission&gt;</returns>
	[Get("/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}")]
	Task<List<BusinessObjectPermission>> GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdAsync(
		[AliasAs("busObId")] string busObId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permission for current user
	/// </summary>
	/// <remarks>
	/// Operation to get Business Object permissions for the currently logged-in user&#39;s Security Group.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busObId">Specify the Business Object ID.</param>
	/// <returns>Task of GetSecurityGroupBusinessObjectPermissionsResponse</returns>
	[Get("/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}")]
	Task<GetSecurityGroupBusinessObjectPermissionsResponse> GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async(
		[AliasAs("busObId")] string busObId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permissions for current user
	/// </summary>
	/// <remarks>
	/// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <returns>Task of List&lt;BusinessObjectPermission&gt;</returns>
	[Get("/api/V1/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}")]
	Task<List<BusinessObjectPermission>> GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameAsync(
		[AliasAs("busobname")] string busobname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get Business Object permissions for current user
	/// </summary>
	/// <remarks>
	/// Operation to get Business Object permissions for currently logged in user&#39;s Security Group.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="busobname">Specify the Business Object name.</param>
	/// <returns>Task of GetSecurityGroupBusinessObjectPermissionsResponse</returns>
	[Get("/api/V2/getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}")]
	Task<GetSecurityGroupBusinessObjectPermissionsResponse> GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async(
		[AliasAs("busobname")] string busobname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all Security Group categories
	/// </summary>
	/// <remarks>
	/// Operation to get IDs and names for all available Security Group categories. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of List&lt;RightCategory&gt;</returns>
	[Get("/api/V1/getsecuritygroupcategories")]
	Task<List<RightCategory>> GetSecurityGroupCategoriesAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all Security Group categories
	/// </summary>
	/// <remarks>
	/// Operation to get IDs and names for all available Security Group categories. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of SecurityRightCategoriesResponse</returns>
	[Get("/api/V2/getsecuritygroupcategories")]
	Task<SecurityRightCategoriesResponse> GetSecurityGroupCategoriesV2Async(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get permissions for a Security Group by category
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupid">Specify the Security Group ID</param>
	/// <param name="categoryid">Specify the Security Group category ID</param>
	/// <returns>Task of List&lt;Right&gt;</returns>
	[Get("/api/V1/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}")]
	Task<List<Right>> GetSecurityGroupRightsByGroupIdAndCategoryIdAsync(
		[AliasAs("groupid")] string groupid,
		[AliasAs("categoryid")] string categoryid,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get permissions for a Security Group by category
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for a Security Group by category. To get Security Group IDs, use \&quot;Get all available Security Groups.\&quot; To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupid">Specify the Security Group ID</param>
	/// <param name="categoryid">Specify the Security Group category ID</param>
	/// <returns>Task of SecurityRightsResponse</returns>
	[Get("/api/V2/getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}")]
	Task<SecurityRightsResponse> GetSecurityGroupRightsByGroupIdAndCategoryIdV2Async(
		[AliasAs("groupid")] string groupid,
		[AliasAs("categoryid")] string categoryid,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get permissions for a Security Group by category
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for a Security Group by category.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupname">Specify the Security Group name.</param>
	/// <param name="categoryname">Specify the Security Group category name.</param>
	/// <returns>Task of List&lt;Right&gt;</returns>
	[Get("/api/V1/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}")]
	Task<List<Right>> GetSecurityGroupRightsByGroupNameAndCategoryNameAsync(
		[AliasAs("groupname")] string groupname,
		[AliasAs("categoryname")] string categoryname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get permissions for a Security Group by category
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for a Security Group by category.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupname">Specify the Security Group name.</param>
	/// <param name="categoryname">Specify the Security Group category name.</param>
	/// <returns>Task of SecurityRightsResponse</returns>
	[Get("/api/V2/getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}")]
	Task<SecurityRightsResponse> GetSecurityGroupRightsByGroupNameAndCategoryNameV2Async(
		[AliasAs("groupname")] string groupname,
		[AliasAs("categoryname")] string categoryname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get current user&#39;s permissions by Security Group category by ID
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="categoryid">Specify the Security Group category ID.</param>
	/// <returns>Task of List&lt;Right&gt;</returns>
	[Get("/api/V1/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}")]
	Task<List<Right>> GetSecurityGroupRightsForCurrentUserByCategoryIdAsync(
		[AliasAs("categoryid")] string categoryid,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get current user&#39;s permissions by Security Group category by ID
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for the current user&#39;s Security Group by category. To get Security Group category IDs, use \&quot;Get all Security Group categories.\&quot;
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="categoryid">Specify the Security Group category ID.</param>
	/// <returns>Task of SecurityRightsResponse</returns>
	[Get("/api/V2/getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}")]
	Task<SecurityRightsResponse> GetSecurityGroupRightsForCurrentUserByCategoryIdV2Async(
		[AliasAs("categoryid")] string categoryid,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get current user&#39;s permissions by Security Group category by name
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for the current user&#39;s Security Group by category.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="categoryname">Specify the Security Group category name.</param>
	/// <returns>Task of List&lt;Right&gt;</returns>
	[Get("/api/V1/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}")]
	Task<List<Right>> GetSecurityGroupRightsForCurrentUserByCategoryNameAsync(
		[AliasAs("categoryname")] string categoryname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get current user&#39;s permissions by Security Group category by name
	/// </summary>
	/// <remarks>
	/// Operation to get permissions for the current user&#39;s Security Group by category.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="categoryname">Specify the Security Group category name.</param>
	/// <returns>Task of SecurityRightsResponse</returns>
	[Get("/api/V2/getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}")]
	Task<SecurityRightsResponse> GetSecurityGroupRightsForCurrentUserByCategoryNameV2Async(
		[AliasAs("categoryname")] string categoryname,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all available Security Groups
	/// </summary>
	/// <remarks>
	/// Operation to get IDs, names, and descriptions for all available Security Groups.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of SecurityGroupResponse</returns>
	[Get("/api/V1/getsecuritygroups")]
	Task<SecurityGroupResponse> GetSecurityGroupsAsync(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get all available Security Groups
	/// </summary>
	/// <remarks>
	/// Operation to get IDs, names, and descriptions for all available Security Groups.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of SecurityGroupV2Response</returns>
	[Get("/api/V2/getsecuritygroups")]
	Task<SecurityGroupV2Response> GetSecurityGroupsV2Async(
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get users in a Security Group
	/// </summary>
	/// <remarks>
	/// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupid">Specify the Security Group ID.</param>
	/// <returns>Task of List&lt;User&gt;</returns>
	[Get("/api/V1/getusersinsecuritygroup/groupid/{groupid}")]
	Task<List<User>> GetUsersInSecurityGroupAsync(
		[AliasAs("groupid")] string groupid,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get users in a Security Group
	/// </summary>
	/// <remarks>
	/// Operation to get the users in a specified Security Group. Use \&quot;Get all available Security Groups\&quot; to get Security Group record IDs. 
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <param name="groupid">Specify the Security Group ID.</param>
	/// <returns>Task of UsersUserReadV2Response</returns>
	[Get("/api/V2/getusersinsecuritygroup/groupid/{groupid}")]
	Task<UserReadV2Response> GetUsersInSecurityGroupV2Async(
		[AliasAs("groupid")] string groupid,
		CancellationToken cancellationToken = default);
}
