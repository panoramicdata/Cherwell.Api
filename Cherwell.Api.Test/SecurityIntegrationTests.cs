namespace Cherwell.Api.Test;

public class SecurityIntegrationTests : TestBase
{
	private const string AnnouncementBusObId = "93c5ca8e7dbd4cc21dead14df19c684298a78358dd";

	[Fact]
	public Task GetClientSecuritySettings_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetClientSecuritySettingsAsync("RichClient", CancellationToken));

	[Fact]
	public Task GetRolesV1_NotAuth() => AssertThrowsCherwellAsync(
		() => Client.Security.GetRolesAsync(CancellationToken),
		Message.UnknownException,
		ErrorCode.InsufficientRights);

	[Fact]
	public Task GetRolesV2_NotAuth() => AssertThrowsCherwellAsync(
		() => Client.Security.GetRolesV2Async(CancellationToken),
		Message.InsufficientRights,
		ErrorCode.InsufficientRights);

	// GetSecurityGroupBusinessObjectPermissionsByBusObIdAsync - unable to test, no groupId to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async - unable to test, no groupId to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObNameAsync - unable to test, no groupName to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async - unable to test, no groupName to test with

	[Fact]
	public Task GetBusinessObjectPermissions_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdAsync(AnnouncementBusObId, CancellationToken));

	[Fact]
	public Task GetBusinessObjectPermissionsV2_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async(AnnouncementBusObId, CancellationToken));

	[Fact]
	public Task GetBusinessObjectPermissionsByName_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameAsync("Announcement", CancellationToken));

	[Fact]
	public Task GetBusinessObjectPermissionsByNameV2_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async("Announcement", CancellationToken));

	[Fact]
	public Task GetSecurityGroupCategories_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupCategoriesAsync(CancellationToken));

	[Fact]
	public Task GetSecurityGroupCategoriesV2_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupCategoriesV2Async(CancellationToken));

	// GetSecurityGroupRightsByGroupIdAndCategoryIdAsync - unable to test, no groupId to test with
	// GetSecurityGroupRightsByGroupIdAndCategoryIdV2Async - unable to test, no groupId to test with
	// GetSecurityGroupRightsByGroupNameAndCategoryNameAsync - unable to test, no groupName to test with
	// GetSecurityGroupRightsByGroupNameAndCategoryNameV2Async - unable to test, no groupName to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryIdAsync - unable to test, no categoryId to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryIdV2Async - unable to test, no categoryId to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryNameAsync - unable to test, no categoryName to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryNameV2Async - unable to test, no categoryName to test with

	[Fact]
	public Task GetSecurityGroups_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupsAsync(CancellationToken));

	[Fact]
	public Task GetSecurityGroupsV2_Succeeds() => AssertSucceedsAsync(
		() => Client.Security.GetSecurityGroupsV2Async(CancellationToken));

	// GetUsersInSecurityGroupAsync - unable to test, no groupId to test with
	// GetUsersInSecurityGroupV2Async - unable to test, no groupId to test with
}
