using Cherwell.Api.Models.Core;
using Cherwell.Api.Models.Searches;

namespace Cherwell.Api.Test;

public class ExportSearchResultsRequestTests
{
	/// <summary>
	/// An ExportSearchResultsRequest populated with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var request = new ExportSearchResultsRequest
		{
			ExportFormat = ExportSearchResultsRequest.EnumExportFormat.Excel,
			CustomSeparator = "|",
			ExportTitle = "export",
			Association = "inc",
			AssociationName = "Incident",
			BusObId = "busob",
			CustomGridDefId = "grid",
			DateTimeFormatting = "ISO",
			FieldId = "field",
			Fields = new List<string> { "f1", "f2" },
			Filters = new List<FilterInfo>
			{
				new() { FieldId = "f1", Operator = "eq", Value = "v1" }
			},
			IncludeAllFields = true,
			IncludeSchema = true,
			PageNumber = 2,
			PageSize = 50,
			Scope = "global",
			ScopeOwner = "owner",
			SearchId = "search",
			SearchName = "my search",
			SearchText = "filter text",
			Sorting = new List<SortInfo>
			{
				new() { FieldId = "f1", SortDirection = 1 }
			},
			PromptValues = new List<PromptValue>
			{
				new() { PromptId = "p1", Value = 7 }
			}
		};

		request.ExportFormat.Should().Be(ExportSearchResultsRequest.EnumExportFormat.Excel);
		request.CustomSeparator.Should().Be("|");
		request.ExportTitle.Should().Be("export");
		request.Association.Should().Be("inc");
		request.AssociationName.Should().Be("Incident");
		request.BusObId.Should().Be("busob");
		request.CustomGridDefId.Should().Be("grid");
		request.DateTimeFormatting.Should().Be("ISO");
		request.FieldId.Should().Be("field");
		request.Fields.Should().Contain("f1").And.Contain("f2");
		request.Filters.Should().ContainSingle().Which.FieldId.Should().Be("f1");
		request.IncludeAllFields.Should().BeTrue();
		request.IncludeSchema.Should().BeTrue();
		request.PageNumber.Should().Be(2);
		request.PageSize.Should().Be(50);
		request.Scope.Should().Be("global");
		request.ScopeOwner.Should().Be("owner");
		request.SearchId.Should().Be("search");
		request.SearchName.Should().Be("my search");
		request.SearchText.Should().Be("filter text");
		request.Sorting.Should().ContainSingle().Which.FieldId.Should().Be("f1");
		request.PromptValues.Should().ContainSingle().Which.PromptId.Should().Be("p1");
	}
}
