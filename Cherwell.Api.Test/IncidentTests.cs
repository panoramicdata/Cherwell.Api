using Cherwell.Api.Models.Searches;
using FluentAssertions;
using System.Text.RegularExpressions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public partial class TicketTests : CherwellClientTest
{
	public TicketTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Theory]
	[InlineData("")]
	[InlineData("Status eq 'In Progress' OR Status eq 'Reopened'")]
	[InlineData("Status eq 'Closed'")]
	public async Task GetQuickSearchSpecificResults_Succeeds(string query)
	{
		var summaries = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Incident", default)
			.ConfigureAwait(false);
		var summary = summaries[0];

		var businessObjectId = summary.BusObId;

		var businessObjectSchema = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(businessObjectId, true, default)
			.ConfigureAwait(false);

		var filters = string.IsNullOrWhiteSpace(query)
			? null
			: query.Split(" OR ").Select(subQuery =>
			{
				var subQueryMatches = SubQueryRegex().Matches(subQuery);
				var fieldName = subQueryMatches[0].Groups["field"].Value;
				var @operator = subQueryMatches[0].Groups["operator"].Value;
				var value = subQueryMatches[0].Groups["value"].Value;

				var fieldDefinition = businessObjectSchema
					.FieldDefinitions
					.SingleOrDefault(fd => fd.Name == fieldName);

				fieldDefinition
					.Should()
					.NotBeNull();

				var fieldId = fieldDefinition!.FieldId;

				return new FilterInfo
				{
					FieldId = fieldId,
					Operator = @operator,
					Value = value
				};
			}
			)
			.ToList();

		List<string>? fields = null;

		var skip = 0;
		var take = int.MaxValue;

		var searchResultsRequest = new SearchResultsRequest
		{
			BusObId = businessObjectId,
			Fields = fields?.Count != 0 ? fields : null,
			Filters = filters,
			PageNumber = skip / take + 1,
			PageSize = take
		};

		var searchItemResponse = await TestCherwellClient
			.Searches
			.GetSearchResultsAdHocAsync(
				searchResultsRequest,
				default)
			.ConfigureAwait(false);

		searchItemResponse
			.Should()
			.NotBeNull();
	}

	[Theory]
	[InlineData("Event")]
	[InlineData("ChangeRequest")]
	[InlineData("Incident")]
	public async Task GetTickets_Succeeds(string ticketType)
	{
		var cancellationToken = CancellationToken.None;

		// Get a summary of the given object type, if there is one
		var businessObjectSummaries = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync(ticketType, cancellationToken)
			.ConfigureAwait(false);

		businessObjectSummaries
			.Should()
			.NotBeNull();

		businessObjectSummaries
			.Should()
			.ContainSingle();

		var businessObjectSummary = businessObjectSummaries[0];

		// Possible statuses for the Incident object type
		var possibleStatuses = businessObjectSummary
			.States
			.Split(",", StringSplitOptions.RemoveEmptyEntries);

		// Retrieve the schema that explains the available fields on the object
		var businessObjectSchema = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(
			businessObjectSummary.BusObId,
			true,
			cancellationToken)
			.ConfigureAwait(false);

		var searchItemResponse = await TestCherwellClient
			.Searches
			.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = businessObjectSummary.BusObId,
				Fields = businessObjectSchema
					.FieldDefinitions
					.Take(5)
					.Select(f => f.FieldId)
					.ToList(),
				Filters = new List<FilterInfo>()
			},
			cancellationToken)
		.ConfigureAwait(false);

		searchItemResponse
			.Should()
			.NotBeNull();

		searchItemResponse
			.HasError
			.Should()
			.BeFalse();

		searchItemResponse
			.ErrorCode
			.Should()
			.BeNullOrEmpty();

		searchItemResponse
			.ErrorMessage
			.Should()
			.BeNullOrEmpty();

		searchItemResponse
			.BusinessObjects
			.Should()
			.NotBeNull();

		searchItemResponse
			.Links
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async Task GetIncidentSchema_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		// Get a summary of the 'Incident' object type, if there is one
		var objectSummaries = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Incident", cancellationToken)
			.ConfigureAwait(false);

		objectSummaries
			.Should()
			.NotBeNull();

		objectSummaries
			.Should()
			.ContainSingle();

		var incidentSummary = objectSummaries[0];

		// Retrieve the schema that explains the available fields on the object
		var incidentSchema = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(
			incidentSummary.BusObId,
			true,
			cancellationToken)
			.ConfigureAwait(false);

		incidentSchema
			.Should()
			.NotBeNull();

		incidentSchema
			.HasError
			.Should()
			.BeFalse();

		incidentSchema
			.ErrorCode
			.Should()
			.BeNullOrEmpty();

		incidentSchema
			.ErrorMessage
			.Should()
			.BeNullOrEmpty();

		incidentSchema
			.BusObId
			.Should()
			.NotBeNullOrWhiteSpace();

		incidentSchema
			.FieldDefinitions
			.Should()
			.NotBeNull();

		incidentSchema
			.FieldDefinitions
			.Count
			.Should()
			.BePositive();

		incidentSchema
			.FirstRecIdField
			.Should()
			.NotBeNullOrWhiteSpace();

		incidentSchema
			.GridDefinitions
			.Should()
			.NotBeNull();

		incidentSchema
			.Name
			.Should()
			.NotBeNullOrWhiteSpace();

		incidentSchema
			.RecIdFields
			.Should()
			.NotBeNullOrWhiteSpace();

		incidentSchema
			.Relationships
			.Should()
			.NotBeNull();

		incidentSchema
			.StateFieldId
			.Should()
			.NotBeNullOrWhiteSpace();

		incidentSchema
			.States
			.Should()
			.NotBeNullOrWhiteSpace();

	}

	[GeneratedRegex("(?<field>.+?) (?<operator>.+?) '(?<value>.+)'")]
	private static partial Regex SubQueryRegex();
}