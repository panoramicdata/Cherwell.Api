namespace Cherwell.Api.Test;

public class TicketTests : TestBase
{
	private static readonly Regex SubQueryRegex = new(
		"(?<field>.+?) (?<operator>.+?) '(?<value>.+)'",
		RegexOptions.Compiled);

	[Theory]
	[InlineData("")]
	[InlineData("Status eq 'In Progress' OR Status eq 'Reopened'")]
	[InlineData("Status eq 'Closed'")]
	public async Task GetQuickSearchSpecificResults_Succeeds(string query)
	{
		var summaries = await Client.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Incident", CancellationToken);
		var businessObjectId = summaries[0].BusObId;
		var schema = await Client.BusinessObject.GetBusinessObjectSchemaAsync(
			businessObjectId,
			true,
			CancellationToken);
		var request = new SearchResultsRequest
		{
			BusObId = businessObjectId,
			Filters = CreateFilters(query, schema),
			PageNumber = 1,
			PageSize = int.MaxValue
		};

		var response = await Client.Searches.GetSearchResultsAdHocAsync(request, CancellationToken);
		response.Should().NotBeNull();
	}

	[Theory]
	[InlineData("Event")]
	[InlineData("ChangeRequest")]
	[InlineData("Incident")]
	public async Task GetTickets_Succeeds(string ticketType)
	{
		var summaries = await Client.BusinessObject
			.GetBusinessObjectSummaryByNameAsync(ticketType, CancellationToken);
		summaries.Should().ContainSingle();
		var summary = summaries[0];
		var schema = await Client.BusinessObject.GetBusinessObjectSchemaAsync(
			summary.BusObId,
			true,
			CancellationToken);
		var request = new SearchResultsRequest
		{
			BusObId = summary.BusObId,
			Fields = [.. schema.FieldDefinitions.Take(5).Select(field => field.FieldId)],
			Filters = []
		};

		var response = await Client.Searches.GetSearchResultsAdHocAsync(request, CancellationToken);
		AssertSuccessfulSearch(response);
	}

	[Fact]
	public async Task GetIncidentSchema_Succeeds()
	{
		var summaries = await Client.BusinessObject
			.GetBusinessObjectSummaryByNameAsync("Incident", CancellationToken);
		summaries.Should().ContainSingle();
		var schema = await Client.BusinessObject.GetBusinessObjectSchemaAsync(
			summaries[0].BusObId,
			true,
			CancellationToken);

		AssertValidSchema(schema);
	}

	private static List<FilterInfo>? CreateFilters(
		string query,
		Models.BusinessObject.SchemaResponse schema)
	{
		if (string.IsNullOrWhiteSpace(query))
		{
			return null;
		}

		return [.. query.Split(" OR ").Select(subQuery => CreateFilter(subQuery, schema))];
	}

	private static FilterInfo CreateFilter(string subQuery, Models.BusinessObject.SchemaResponse schema)
	{
		var match = SubQueryRegex.Match(subQuery);
		match.Success.Should().BeTrue();
		var fieldName = match.Groups["field"].Value;
		var field = schema.FieldDefinitions.SingleOrDefault(definition => definition.Name == fieldName);
		field.Should().NotBeNull();
		return new FilterInfo
		{
			FieldId = field!.FieldId,
			Operator = match.Groups["operator"].Value,
			Value = match.Groups["value"].Value
		};
	}

	private static void AssertSuccessfulSearch(SearchResultsResponse response)
	{
		response.Should().NotBeNull();
		response.HasError.Should().BeFalse();
		response.ErrorCode.Should().BeNullOrEmpty();
		response.ErrorMessage.Should().BeNullOrEmpty();
		response.BusinessObjects.Should().NotBeNull();
		response.Links.Should().NotBeNull();
	}

	private static void AssertValidSchema(Models.BusinessObject.SchemaResponse schema)
	{
		schema.Should().NotBeNull();
		schema.HasError.Should().BeFalse();
		schema.ErrorCode.Should().BeNullOrEmpty();
		schema.ErrorMessage.Should().BeNullOrEmpty();
		schema.BusObId.Should().NotBeNullOrWhiteSpace();
		schema.FieldDefinitions.Should().NotBeNullOrEmpty();
		schema.FirstRecIdField.Should().NotBeNullOrWhiteSpace();
		schema.GridDefinitions.Should().NotBeNull();
		schema.Name.Should().NotBeNullOrWhiteSpace();
		schema.RecIdFields.Should().NotBeNullOrWhiteSpace();
		schema.Relationships.Should().NotBeNull();
		schema.StateFieldId.Should().NotBeNullOrWhiteSpace();
		schema.States.Should().NotBeNullOrWhiteSpace();
	}
}
