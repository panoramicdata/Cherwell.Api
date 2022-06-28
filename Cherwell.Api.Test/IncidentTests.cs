using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class IncidentTests : CherwellClientTest
{
	public IncidentTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void GetIncidents_Succeeds()
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

		// Possible statuses for the Incident object type
		var possibleStatuses = incidentSummary
			.States
			.Split(",", StringSplitOptions.RemoveEmptyEntries);

		// Retrieve the schema that explains the available fields on the object
		var incidentSchema = await TestCherwellClient
			.BusinessObject
			.GetBusinessObjectSchemaAsync(
			incidentSummary.BusObId,
			true,
			cancellationToken)
			.ConfigureAwait(false);

		var searchItemResponse = await TestCherwellClient
			.Searches
			.GetSearchResultsAdHocAsync(
			new SearchResultsRequest
			{
				BusObId = incidentSummary.BusObId,
				Fields = incidentSchema
					.FieldDefinitions
					.Take(5)
					.Select(f => f.FieldId)
					.ToList(),
				Filters = new List<FilterInfo>()
				{
					// Multiple filters on the same field are treated as an OR operation
					new FilterInfo(
						FieldId : incidentSummary.StateFieldId,
						Operator : "eq",
						Value : "In Progress"			// The first status of interest
					),
					new FilterInfo(
						FieldId : incidentSummary.StateFieldId,
						Operator : "eq",
						Value : "Reopened"				// The second status of interest
					)
				},
				PageNumber = 1,
				PageSize = 100
			},
			cancellationToken)
		.ConfigureAwait(false);

		searchItemResponse
			.Should()
			.NotBeNull();
	}

	[Fact]
	public async void GetIncidentSchema_Succeeds()
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

}