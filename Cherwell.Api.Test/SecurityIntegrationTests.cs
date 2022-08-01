﻿using Cherwell.Api.Exceptions;
using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class SecurityIntegrationTests : CherwellClientTest
{
	public SecurityIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void GetClientSecuritySettings_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetClientSecuritySettingsAsync("RichClient", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetRolesV1_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Security
			.GetRolesAsync(cancellationToken)
			.ConfigureAwait(false);
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
	public async void GetRolesV2_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Security
			.GetRolesV2Async(cancellationToken)
			.ConfigureAwait(false);
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
	public async void GetBusinessObjectPermissions_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdAsync("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetBusinessObjectPermissionsV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2Async("93c5ca8e7dbd4cc21dead14df19c684298a78358dd", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetBusinessObjectPermissionsByName_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameAsync("Announcement", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetBusinessObjectPermissionsByNameV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2Async("Announcement", cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetSecurityGroupCategories_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupCategoriesAsync(cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetSecurityGroupCategoriesV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupCategoriesV2Async(cancellationToken)
			.ConfigureAwait(false);

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
	public async void GetSecurityGroups_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupsAsync(cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetSecurityGroupsV2_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.Security
			.GetSecurityGroupsV2Async(cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	// GetUsersInSecurityGroupAsync - unable to test, no groupId to test with
	// GetUsersInSecurityGroupV2Async - unable to test, no groupId to test with
}