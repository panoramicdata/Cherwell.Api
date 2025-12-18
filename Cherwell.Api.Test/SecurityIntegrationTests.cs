namespace Cherwell.Api.Test;

public class SecurityIntegrationTests : TestBase
{
	[Fact]
	public async Task GetClientSecuritySettings_Succeeds()
	{
		var response = await Client
			.Security
			.GetClientSecuritySettingsAsync("RichClient", CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetRolesV1_NotAuth() => await ((Func<Task>)(async () =>
												   {
													   var response = await Client
													   .Security
													   .GetRolesAsync(CancellationToken)
													   ;
												   }))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.UnknownException)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.InsufficientRights
			&& e.Response.HasError);

	[Fact]
	public async Task GetRolesV2_NotAuth() => await ((Func<Task>)(async () =>
												   {
													   var response = await Client
													   .Security
													   .GetRolesV2Async(CancellationToken)
													   ;
												   }))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.InsufficientRights)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.InsufficientRights
			&& e.Response.HasError);

	// GetSecurityGroupBusinessObjectPermissionsByBusObIdAsync - unable to test, no groupId to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async - unable to test, no groupId to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObNameAsync - unable to test, no groupName to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async - unable to test, no groupName to test with

	[Fact]
	public async Task GetBusinessObjectPermissions_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdAsync("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusinessObjectPermissionsV2_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusinessObjectPermissionsByName_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameAsync("Announcement", CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusinessObjectPermissionsByNameV2_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async("Announcement", CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetSecurityGroupCategories_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupCategoriesAsync(CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetSecurityGroupCategoriesV2_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupCategoriesV2Async(CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// GetSecurityGroupRightsByGroupIdAndCategoryIdAsync - unable to test, no groupId to test with
	// GetSecurityGroupRightsByGroupIdAndCategoryIdV2Async - unable to test, no groupId to test with
	// GetSecurityGroupRightsByGroupNameAndCategoryNameAsync - unable to test, no groupName to test with
	// GetSecurityGroupRightsByGroupNameAndCategoryNameV2Async - unable to test, no groupName to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryIdAsync - unable to test, no categoryId to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryIdV2Async - unable to test, no categoryId to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryNameAsync - unable to test, no categoryName to test with
	// GetSecurityGroupRightsForCurrentUserByCategoryNameV2Async - unable to test, no categoryName to test with

	[Fact]
	public async Task GetSecurityGroups_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupsAsync(CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetSecurityGroupsV2_Succeeds()
	{
		var response = await Client
			.Security
			.GetSecurityGroupsV2Async(CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// GetUsersInSecurityGroupAsync - unable to test, no groupId to test with
	// GetUsersInSecurityGroupV2Async - unable to test, no groupId to test with
}