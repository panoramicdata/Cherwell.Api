﻿using Cherwell.Api.Exceptions;
using FluentAssertions;
using Xunit;

namespace Cherwell.Api.Test;

public class CoreIntegrationTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _testCherwellClient = cherwellClient;

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
			_ = await _testCherwellClient
			.Core
			.GetGalleryImagesAsync(true, cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError
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
			var response = await _testCherwellClient
			.Core
			.GetStoredValuesAsync(true, cancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError
		);
	}

	[Fact]
	public async Task Core_GetViews() =>
		await ((Func<Task>)(async () =>
		{
			var response = await _testCherwellClient
			.Core
			.GetViewsAsync(default)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError
		);
	// SaveGalleryImageAsync - unable to test, we don't want to modify anything

	// SaveStoredValueAsync - unable to test, we don't want to modify anything

	// SetCultureAsync - unable to test, we don't want to modify anything

}