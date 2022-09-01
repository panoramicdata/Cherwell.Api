using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class TicketTests : CherwellClientTest
{
	public TicketTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Theory]
	[InlineData("Event")]
	[InlineData("ChangeRequest")]
	[InlineData("Incident")]
	public async void GetTickets_Succeeds(string ticketType)
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

		//searchItemResponse
		//	.HttpStatusCode
		//	.Should()
		//	.NotBeNull();

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