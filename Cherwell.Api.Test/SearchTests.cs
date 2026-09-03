namespace Cherwell.Api.Test;

public class SearchTests : TestBase
{
	private const string IncidentBusObId = "6dd53665c0c24cab86870a21cf6434ae";
	private const string PermissionedBusObId = "93c5ca8e7dbd4cc21dead14df19c684298a78358dd";
	private const string IncidentIdFieldId =
		"BO:6dd53665c0c24cab86870a21cf6434ae,FI:9487d346f460643b684abe471c821dbf0ef05ec471";

	private static QuickSearchSpecificRequest CreateQuickSearchSpecificRequest() => new()
	{
		SearchText = "test",
		SelectedChangedLimit = new ChangedLimit
		{
			DisplayName = "test",
			Units = "test"
		},
	};

	/// <summary>
	/// A filter that matches no incident, so the search succeeds but returns nothing.
	/// </summary>
	private static List<FilterInfo> CreateNonMatchingFilter() =>
	[
		new FilterInfo
		{
			FieldId = IncidentIdFieldId,
			Operator = "eq",
			Value = "LMD1234567890"
		}
	];

	[Fact]
	public async Task GetQuickSearchSpecificResults_Succeeds()
	{
		var response = await Client
			.Searches
			.GetQuickSearchSpecificResultsAsync(
				CreateQuickSearchSpecificRequest(), default, default, default, CancellationToken);

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
				CreateQuickSearchSpecificRequest(), default, default, default, CancellationToken);

		response
			.Should()
			.NotBeNull();
	}

	[Fact]
	public Task GetQuickSearchResults_NotAuth() => AssertForbiddenAsync(
		() => Client.Searches.GetQuickSearchResultsAsync(
			new QuickSearchRequest
			{
				BusObIds = [PermissionedBusObId],
				SearchText = "test"
			}, default, CancellationToken));

	[Fact]
	public Task GetQuickSearchWithViewRights_NotAuth() => AssertForbiddenAsync(
		() => Client.Searches.GetQuickSearchConfigurationForBusObsWithViewRightsAsync(CancellationToken));

	[Fact]
	public Task GetQuickSearchConfig_NotAuth() => AssertForbiddenAsync(
		() => Client.Searches.GetQuickSearchConfigurationForBusObsAsync(
			new QuickSearchConfigurationRequest
			{
				BusObIds = [PermissionedBusObId]
			}, CancellationToken));

	// GetSearchItemsByAssociationScopeScopeOwnerFolderAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerFolderV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeScopeOwnerV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationScopeV2Async - unable to test, no association to test with
	// GetSearchItemsByAssociationAsync - unable to test, no association to test with
	// GetSearchItemsByAssociationV2Async - unable to test, no association to test with

	[Fact]
	public Task GetSearchItems_NotAuth() => AssertForbiddenAsync(
		() => Client.Searches.GetSearchItemsAsync(default, CancellationToken));

	[Fact]
	public Task GetSearchItemsV2_NotAuth() => AssertForbiddenAsync(
		() => Client.Searches.GetSearchItemsV2Async(default, CancellationToken));

	[Fact]
	public async Task GetSearchResultsAdHocAsync_SimpleSearch_Succeeds()
	{
		var searchResults = await Client
			.Searches
			.GetSearchResultsAdHocAsync(
				new SearchResultsRequest
				{
					BusObId = IncidentBusObId,
					Filters = []
				},
				CancellationToken);

		AssertValidBusinessObjects(searchResults);
		AssertNoPromptsOrErrors(searchResults);
		searchResults.TotalRows.Should().NotBe(0);
	}

	public static TheoryData<string, SearchResultsRequest> FilteredSearchRequests => new()
	{
		{
			"filter only",
			new SearchResultsRequest
			{
				BusObId = IncidentBusObId,
				Filters = CreateNonMatchingFilter()
			}
		},
		{
			"filter with paging",
			new SearchResultsRequest
			{
				BusObId = IncidentBusObId,
				Filters = CreateNonMatchingFilter(),
				PageNumber = 0,
				PageSize = 100
			}
		},
		{
			"filter with paging, excluding schema",
			new SearchResultsRequest
			{
				BusObId = IncidentBusObId,
				Filters = CreateNonMatchingFilter(),
				IncludeSchema = false,
				PageNumber = 0,
				PageSize = 100
			}
		}
	};

	[Theory]
	[MemberData(nameof(FilteredSearchRequests))]
	public async Task GetSearchResultsAdhocAsync_FilteredSearch_ReturnsValidStatusCode(
		string description,
		SearchResultsRequest request)
	{
		description.Should().NotBeNullOrWhiteSpace();

		var searchResults = await Client
			.Searches
			.GetSearchResultsAdHocAsync(request, CancellationToken);

		AssertNoPromptsOrErrors(searchResults);
	}

	[Fact]
	public Task GetSearchResultsAdHocAsync_WideSearch_Fails() => AssertThrowsCherwellAsync(
		() => Client.Searches.GetSearchResultsAdHocAsync(new SearchResultsRequest(), CancellationToken),
		Message.NotFound,
		ErrorCode.NotFound,
		Models.EnumHttpStatusCode.InternalServerError);

	// GetSearchResultsByIdAsync - unable to test, no association to test with
	// GetSearchResultsByNameAsync - unable to test, no association to test with
	// GetSearchResultsExportAdHocAsync - unable to test, no request to test with
	// GetSearchResultsExportByIdAsync - unable to test, no association to test with
	// GetSearchResultsExportByNameAsync - unable to test, no association to test with
	// GetSearchResultsAsStringByIdV2Async - unable to test, no association to test with

	private static void AssertNoPromptsOrErrors(SearchResultsResponse searchResults)
	{
		searchResults.Should().NotBeNull();
		searchResults.HasPrompts.Should().BeFalse();
		searchResults.Links.Should().BeEmpty();
		searchResults.Prompts.Should().BeEmpty();
		searchResults.SearchResultsFields.Should().BeEmpty();
		searchResults.SimpleResults.Should().BeNull();
		searchResults.ErrorCode.Should().BeNull();
		searchResults.ErrorMessage.Should().BeNull();
		searchResults.HasError.Should().BeFalse();
	}

	private static void AssertValidBusinessObjects(SearchResultsResponse searchResults)
	{
		searchResults.BusinessObjects.Should().NotBeNullOrEmpty();
		foreach (var businessObject in searchResults.BusinessObjects)
		{
			businessObject.BusObId.Should().NotBeNullOrEmpty();
			businessObject.BusObPublicId.Should().NotBeNullOrEmpty();
			businessObject.BusObRecId.Should().NotBeNullOrEmpty();
			businessObject.Fields.Should().NotBeNullOrEmpty();
			AssertValidFields(businessObject.Fields);

			businessObject.Links.Should().NotBeNullOrEmpty();
			businessObject.Links.Should().OnlyContain(link =>
				!string.IsNullOrEmpty(link.Name) && !string.IsNullOrEmpty(link.Url));
			businessObject.ErrorCode.Should().BeNull();
			businessObject.ErrorMessage.Should().BeNull();
			businessObject.HasError.Should().BeFalse();
		}
	}

	private static void AssertValidFields(IEnumerable<Models.BusinessObject.FieldTemplateItem> fields)
	{
		foreach (var field in fields)
		{
			field.Dirty.Should().BeFalse();
			field.DisplayName.Should().NotBeNullOrEmpty();
			field.FieldId.Should().NotBeNullOrEmpty();
			field.FullFieldId.Should().NotBeNullOrEmpty();
			field.Html.Should().BeNull();
			field.Name.Should().NotBeNullOrEmpty();
			field.Value.Should().NotBeNull();
		}
	}
}
