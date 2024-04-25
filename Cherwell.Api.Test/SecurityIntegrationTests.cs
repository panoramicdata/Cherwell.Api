using Cherwell.Api.Exceptions;
using FluentAssertions;
using Xunit;

namespace Cherwell.Api.Test;

public class SecurityIntegrationTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _testCherwellClient = cherwellClient;
	[Fact]
	public async Task GetClientSecuritySettings_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetClientSecuritySettingsAsync("RichClient", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetRolesV1_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await _testCherwellClient
			.Security
			.GetRolesAsync(cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.UnknownException)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.InsufficientRights
			&& e.Response.HasError == true
		);
	}

	[Fact]
	public async Task GetRolesV2_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await _testCherwellClient
			.Security
			.GetRolesV2Async(cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.InsufficientRights)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.InsufficientRights
			&& e.Response.HasError == true
		);
	}

	// GetSecurityGroupBusinessObjectPermissionsByBusObIdAsync - unable to test, no groupId to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObIdV2Async - unable to test, no groupId to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObNameAsync - unable to test, no groupName to test with
	// GetSecurityGroupBusinessObjectPermissionsByBusObNameV2Async - unable to test, no groupName to test with

	[Fact]
	public async Task GetBusinessObjectPermissions_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdAsync("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusinessObjectPermissionsV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusinessObjectPermissionsByName_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameAsync("Announcement", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetBusinessObjectPermissionsByNameV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async("Announcement", cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetSecurityGroupCategories_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupCategoriesAsync(cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetSecurityGroupCategoriesV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupCategoriesV2Async(cancellationToken)
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
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupsAsync(cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetSecurityGroupsV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.Security
			.GetSecurityGroupsV2Async(cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// GetUsersInSecurityGroupAsync - unable to test, no groupId to test with
	// GetUsersInSecurityGroupV2Async - unable to test, no groupId to test with
}