using Cherwell.Api.Exceptions;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class CoreIntegrationTests : CherwellClientTest
{
	public CoreIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	// DeleteGalleryImageByStandInKeyAsync - unable to test, we don't want to delete anything

	// GetGalleryImagesFolderAsync - unable to test, we don't have a scope to test with

	// GetGalleryImagesScopeOwnerAsync - unable to test, we don't have a scope to test with

	// GetGalleryImagesScopeAsync - unable to test, we don't have a scope to test with

	[Fact]
	public async Task Core_GetImages()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			_ = await TestCherwellClient
			.Core
			.GetGalleryImagesAsync(true, cancellationToken)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError == true
		);
	}

	// GetGalleryImageAsync - unable to test, we don't have a name to test with

	// GetStoredValueAsync - unable to test, we don't have a scope to test with

	// GetStoredValuesFolderAsync - unable to test, we don't have a scope to test with

	// GetStoredValuesScopeOwnerAsync - unable to test, we don't have a scope to test with

	// GetStoredValuesScopeAsync - unable to test, we don't have a scope to test with

	[Fact]
	public async Task Core_GetStoredValues()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Core
			.GetStoredValuesAsync(true, cancellationToken)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError == true
		);
	}

	[Fact]
	public async Task Core_GetViews()
	{
		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Core
			.GetViewsAsync(default)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError == true
		);
	}
	// SaveGalleryImageAsync - unable to test, we don't want to modify anything

	// SaveStoredValueAsync - unable to test, we don't want to modify anything

	// SetCultureAsync - unable to test, we don't want to modify anything

}