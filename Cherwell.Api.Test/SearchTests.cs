using Cherwell.Api.Exceptions;
using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class GetSearchResultsAdHocTests : CherwellClientTest
{
	public GetSearchResultsAdHocTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void SimpleSearch_Succeeds()
	{
		var searchResults = await TestCherwellClient
		.Searches
		.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = "6dd53665c0c24cab86870a21cf6434ae",
				Filters = new List<FilterInfo>()
				{
					new FilterInfo(
						"5eb3234ae1344c64a19819eda437f18d",
						"eq",
						"Resolved")
				}
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
	public async void WideSearch_Fails()
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
}