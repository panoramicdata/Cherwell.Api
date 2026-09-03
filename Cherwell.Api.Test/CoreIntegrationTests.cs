namespace Cherwell.Api.Test;

public class CoreIntegrationTests : TestBase
{
	// DeleteGalleryImageByStandInKeyAsync - unable to test, we don't want to delete anything

	// GetGalleryImagesFolderAsync - unable to test, we don't have a scope to test with

	// GetGalleryImagesScopeOwnerAsync - unable to test, we don't have a scope to test with

	// GetGalleryImagesScopeAsync - unable to test, we don't have a scope to test with

	[Fact]
	public Task Core_GetImages() => AssertForbiddenAsync(
		() => Client.Core.GetGalleryImagesAsync(true, CancellationToken));

	// GetGalleryImageAsync - unable to test, we don't have a name to test with

	// GetStoredValueAsync - unable to test, we don't have a scope to test with

	// GetStoredValuesFolderAsync - unable to test, we don't have a scope to test with

	// GetStoredValuesScopeOwnerAsync - unable to test, we don't have a scope to test with

	// GetStoredValuesScopeAsync - unable to test, we don't have a scope to test with

	[Fact]
	public Task Core_GetStoredValues() => AssertForbiddenAsync(
		() => Client.Core.GetStoredValuesAsync(true, CancellationToken));

	[Fact]
	public Task Core_GetViews() => AssertForbiddenAsync(
		() => Client.Core.GetViewsAsync(CancellationToken));

	// SaveGalleryImageAsync - unable to test, we don't want to modify anything

	// SaveStoredValueAsync - unable to test, we don't want to modify anything

	// SetCultureAsync - unable to test, we don't want to modify anything
}
