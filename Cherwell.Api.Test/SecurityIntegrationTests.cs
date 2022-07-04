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
}