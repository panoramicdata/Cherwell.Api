namespace Cherwell.Api.Test;

public class SearchTests : TestBase
{
	[Fact]
	public async Task GetQuickSearchSpecificResults_Succeeds()
	{
		var response = await Client
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
				}, default, default, default, CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetQuickSearchSpecificResultsV2_Succeeds()
	{
		var response = await Client
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
				}, default, default, default, CancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetQuickSearchResults_NotAuth() => await ((Func<Task>)(async () =>
														 {
															 var response = await Client
															 .Searches
															 .GetQuickSearchResultsAsync(
																 new QuickSearchRequest
																 {
																	 BusObIds = ["93c5ca8e7dbd4cc21dead14df19c684298a78358dd"],
																	 SearchText = "test"
																 }, default, CancellationToken)
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

	[Fact]
	public async Task GetQuickSearchWithViewRights_NotAuth() => await ((Func<Task>)(async () =>
																{
																	var response = await Client
																	.Searches
																	.GetQuickSearchConfigurationForBusObsWithViewRightsAsync(CancellationToken)
																	;
																}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError);

	[Fact]
	public async Task GetQuickSearchConfig_NotAuth() => await ((Func<Task>)(async () =>
														{
															var response = await Client
															.Searches
															.GetQuickSearchConfigurationForBusObsAsync(
															new QuickSearchConfigurationRequest
															{
																BusObIds = ["93c5ca8e7dbd4cc21dead14df19c684298a78358dd"]
															}, CancellationToken)
															;
														}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError);

	// GetSearchItemsByAssociationScopeScopeOwnerFolderAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerFolderV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationV2Async - unable to test, no association to test with

	[Fact]
	public async Task GetSearchItems_NotAuth() => await ((Func<Task>)(async () =>
												  {
													  var response = await Client
													  .Searches
													  .GetSearchItemsAsync(default, CancellationToken)
													  ;
												  }))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError);

	[Fact]
	public async Task GetSearchItemsV2_NotAuth() => await ((Func<Task>)(async () =>
													{
														var response = await Client
														.Searches
														.GetSearchItemsV2Async(default, CancellationToken)
														;
													}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError);

	[Fact]
	public async Task GetSearchResultsAdHocAsync_SimpleSearch_Succeeds()
	{
		var searchResults = await Client
		.Searches
		.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = "6dd53665c0c24cab86870a21cf6434ae",
				Filters = []
			},
			CancellationToken)
		;

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
		searchResults.ErrorCode.Should().BeNull();
		searchResults.ErrorMessage.Should().BeNull();
		searchResults.HasError.Should().BeFalse();
	}

	[Fact]
	public async Task GetSearchResultsAdhocAsync_FilteredSearch_ReturnsValidStatusCode()
	{
		var searchResults = await Client
		.Searches
		.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = "6dd53665c0c24cab86870a21cf6434ae",
				Filters = [
					new FilterInfo
					{
						FieldId = "BO:6dd53665c0c24cab86870a21cf6434ae,FI:9487d346f460643b684abe471c821dbf0ef05ec471",
						Operator = "eq",
						Value = "LMD1234567890"
					}
				]
			},
			CancellationToken)
		;

		searchResults
			.Should()
			.NotBeNull();

		searchResults.HasPrompts.Should().BeFalse();
		searchResults.Links.Should().BeEmpty();
		searchResults.Prompts.Should().BeEmpty();
		searchResults.SearchResultsFields.Should().BeEmpty();
		searchResults.SimpleResults.Should().BeNull();
		searchResults.ErrorCode.Should().BeNull();
		searchResults.ErrorMessage.Should().BeNull();
		searchResults.HasError.Should().BeFalse();
	}

	[Fact]
	public async Task GetSearchResultsAdhocAsync_FilteredSearchWithPageNumber_ReturnsValidStatusCode()
	{
		var searchResults = await Client
		.Searches
		.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = "6dd53665c0c24cab86870a21cf6434ae",
				Filters = [
					new FilterInfo
					{
						FieldId = "BO:6dd53665c0c24cab86870a21cf6434ae,FI:9487d346f460643b684abe471c821dbf0ef05ec471",
						Operator = "eq",
						Value = "LMD1234567890"
					}
				],
				PageNumber = 0,
				PageSize = 100,
			},
			CancellationToken)
		;

		searchResults
			.Should()
			.NotBeNull();

		searchResults.HasPrompts.Should().BeFalse();
		searchResults.Links.Should().BeEmpty();
		searchResults.Prompts.Should().BeEmpty();
		searchResults.SearchResultsFields.Should().BeEmpty();
		searchResults.SimpleResults.Should().BeNull();
		searchResults.ErrorCode.Should().BeNull();
		searchResults.ErrorMessage.Should().BeNull();
		searchResults.HasError.Should().BeFalse();
	}

	[Fact]
	public async Task GetSearchResultsAdhocAsync_FilteredSearchExcludingSchema_ReturnsValidStatusCode()
	{
		var searchResults = await Client
		.Searches
		.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = "6dd53665c0c24cab86870a21cf6434ae",
				Filters = [
					new FilterInfo
					{
						FieldId = "BO:6dd53665c0c24cab86870a21cf6434ae,FI:9487d346f460643b684abe471c821dbf0ef05ec471",
						Operator = "eq",
						Value = "LMD1234567890"
					}
				],
				IncludeSchema = false,
				PageNumber = 0,
				PageSize = 100,
			},
			CancellationToken)
		;

		searchResults
			.Should()
			.NotBeNull();

		searchResults.HasPrompts.Should().BeFalse();
		searchResults.Links.Should().BeEmpty();
		searchResults.Prompts.Should().BeEmpty();
		searchResults.SearchResultsFields.Should().BeEmpty();
		searchResults.SimpleResults.Should().BeNull();
		searchResults.ErrorCode.Should().BeNull();
		searchResults.ErrorMessage.Should().BeNull();
		searchResults.HasError.Should().BeFalse();
	}

	[Fact]
	public async Task GetSearchResultsAdHocAsync_WideSearch_Fails()
		=> await ((Func<Task>)(async () =>
		{
			var views = await Client
			.Searches
			.GetSearchResultsAdHocAsync(
				new SearchResultsRequest(),
				CancellationToken)
			;
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.NotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.NotFound
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.InternalServerError
			&& e.Response.HasError);

	// GetSearchResultsByIdAsync - unable to test, no association to test with
	// GetSearchResultsByNameAsync - unable to test, no association to test with
	// GetSearchResultsExportAdHocAsync - unable to test, no request to test with
	// GetSearchResultsExportByIdAsync - unable to test, no association to test with
	// GetSearchResultsExportByNameAsync - unable to test, no association to test with
	// GetSearchResultsAsStringByIdV2Async - unable to test, no association to test with
}