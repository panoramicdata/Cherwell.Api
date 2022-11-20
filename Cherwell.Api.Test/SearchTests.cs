using Cherwell.Api.Exceptions;
using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class SearchTests : CherwellClientTest
{
	public SearchTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetQuickSearchSpecificResults_Succeeds()
	{
		var response = await TestCherwellClient
			.Searches
			.GetQuickSearchSpecificResultsAsync(
				new QuickSearchSpecificRequest
				{
					SearchText = "test",
					SelectedChangedLimit = new ChangedLimit
					{
						DisplayName = "test",
						Units = "test"
					},
				}, default, default, default, default)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetQuickSearchSpecificResultsV2_Succeeds()
	{
		var response = await TestCherwellClient
			.Searches
			.GetQuickSearchSpecificResultsV2Async(
				new QuickSearchSpecificRequest
				{
					SearchText = "test",
					SelectedChangedLimit = new ChangedLimit
					{
						DisplayName = "test",
						Units = "test"
					},
				}, default, default, default, default)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetQuickSearchResults_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Searches
			.GetQuickSearchResultsAsync(
				new QuickSearchRequest
				{
					BusObIds = new List<string> { "93c5ca8e7dbd4cc21dead14df19c684298a78358dd" },
					SearchText = "test"
				}, default, cancellationToken)
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
	public async Task GetQuickSearchWithViewRights_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Searches
			.GetQuickSearchConfigurationForBusObsWithViewRightsAsync(default)
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
	public async Task GetQuickSearchConfig_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Searches
			.GetQuickSearchConfigurationForBusObsAsync(
			new QuickSearchConfigurationRequest
			{
				BusObIds = new List<string> { "93c5ca8e7dbd4cc21dead14df19c684298a78358dd" }
			}, default)
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

	// GetSearchItemsByAssociationScopeScopeOwnerFolderAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerFolderV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationV2Async - unable to test, no association to test with

	[Fact]
	public async Task GetSearchItems_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Searches
			.GetSearchItemsAsync(default, default)
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
	public async Task GetSearchItemsV2_NotAuth()
	{
		var cancellationToken = CancellationToken.None;

		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Searches
			.GetSearchItemsV2Async(default, default)
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
	public async Task SimpleSearch_Succeeds()
	{
		var searchResults = await TestCherwellClient
		.Searches
		.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = "6dd53665c0c24cab86870a21cf6434ae",
				Filters = new List<FilterInfo>()
			},
			default)
		.ConfigureAwait(false);

		searchResults
			.Should()
			.NotBeNull();

		searchResults
			.BusinessObjects
			.Should()
			.NotBeNullOrEmpty();

		searchResults
			.BusinessObjects
			.ForEach(bo =>
			{
				bo.BusObId.Should().NotBeNullOrEmpty();
				bo.BusObPublicId.Should().NotBeNullOrEmpty();
				bo.BusObRecId.Should().NotBeNullOrEmpty();
				bo.Fields.Should().NotBeNullOrEmpty();
				bo.Fields.ForEach(f =>
				{
					f.Dirty.Should().BeFalse();
					f.DisplayName.Should().NotBeNullOrEmpty();
					f.FieldId.Should().NotBeNullOrEmpty();
					f.FullFieldId.Should().NotBeNullOrEmpty();
					f.Html.Should().BeNull();
					f.Name.Should().NotBeNullOrEmpty();
					f.Value.Should().NotBeNull();
				});
				bo.Links.Should().NotBeNullOrEmpty();
				bo.Links.ForEach(l =>
				{
					l.Name.Should().NotBeNullOrEmpty();
					l.Url.Should().NotBeNullOrEmpty();
				});
				bo.ErrorCode.Should().BeNull();
				bo.ErrorMessage.Should().BeNull();
				bo.HasError.Should().BeFalse();
			});

		searchResults.HasPrompts.Should().BeFalse();
		searchResults.Links.Should().BeEmpty();
		searchResults.Prompts.Should().BeEmpty();
		searchResults.SearchResultsFields.Should().BeEmpty();
		searchResults.SimpleResults.Should().BeNull();
		searchResults.TotalRows.Should().NotBe(0);
		searchResults.HasMoreRecords.Should().BeFalse();
		searchResults.ErrorCode.Should().BeNull();
		searchResults.ErrorMessage.Should().BeNull();
		searchResults.HasError.Should().BeFalse();
	}

	[Fact]
	public async Task WideSearch_Fails()
	{
		await ((Func<Task>)(async () =>
		{
			var views = await TestCherwellClient
			.Searches
			.GetSearchResultsAdHocAsync(
				new SearchResultsRequest(),
				default)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.NotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.NotFound
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.InternalServerError
			&& e.Response.HasError == true
		);
	}

	// GetSearchResultsByIdAsync - unable to test, no association to test with
	// GetSearchResultsByNameAsync - unable to test, no association to test with
	// GetSearchResultsExportAdHocAsync - unable to test, no request to test with
	// GetSearchResultsExportByIdAsync - unable to test, no association to test with
	// GetSearchResultsExportByNameAsync - unable to test, no association to test with
	// GetSearchResultsAsStringByIdV2Async - unable to test, no association to test with
}