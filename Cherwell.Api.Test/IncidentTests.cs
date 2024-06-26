﻿using Cherwell.Api.Models.Searches;
using FluentAssertions;
using System.Text.RegularExpressions;
using Xunit;

namespace Cherwell.Api.Test;

public partial class TicketTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _testCherwellClient = cherwellClient;

	[Theory]
	[InlineData("")]
	[InlineData("Status eq 'In Progress' OR Status eq 'Reopened'")]
	[InlineData("Status eq 'Closed'")]
	public async Task GetQuickSearchSpecificResults_Succeeds(string query)
	{
		var summaries = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Incident", default)
			;
		var summary = summaries[0];

		var businessObjectId = summary.BusObId;

		var businessObjectSchema = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(businessObjectId, true, default)
			;

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

		var searchItemResponse = await _testCherwellClient
			.Searches
			.GetSearchResultsAdHocAsync(
				searchResultsRequest,
				default)
			;

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
		var businessObjectSummaries = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync(ticketType, cancellationToken)
			;

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
		var businessObjectSchema = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(
			businessObjectSummary.BusObId,
			true,
			cancellationToken)
			;

		var searchItemResponse = await _testCherwellClient
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
				Filters = []
			},
			cancellationToken)
		;

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
		var objectSummaries = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Incident", cancellationToken)
			;

		objectSummaries
			.Should()
			.NotBeNull();

		objectSummaries
			.Should()
			.ContainSingle();

		var incidentSummary = objectSummaries[0];

		// Retrieve the schema that explains the available fields on the object
		var incidentSchema = await _testCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(
			incidentSummary.BusObId,
			true,
			cancellationToken)
			;

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