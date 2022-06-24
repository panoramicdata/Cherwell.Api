﻿using Cherwell.Api.Exceptions;
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