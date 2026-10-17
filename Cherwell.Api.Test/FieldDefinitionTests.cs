using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class FieldDefinitionTests
{
	/// <summary>
	/// A FieldDefinition with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var definition = new FieldDefinition
		{
			AutoFill = true,
			Calculated = true,
			Category = "cat",
			DecimalDigits = 3,
			Description = "desc",
			Details = "details",
			DisplayName = "Display",
			Enabled = true,
			FieldId = "field-id",
			HasDate = true,
			HasTime = true,
			IsFullTextSearchable = true,
			MaximumSize = "max",
			Name = "name",
			ReadOnly = true,
			Required = true,
			Type = "text",
			TypeLocalized = "texte",
			Validated = true,
			WholeDigits = 8
		};

		definition.AutoFill.Should().BeTrue();
		definition.Calculated.Should().BeTrue();
		definition.Category.Should().Be("cat");
		definition.DecimalDigits.Should().Be(3);
		definition.Description.Should().Be("desc");
		definition.Details.Should().Be("details");
		definition.DisplayName.Should().Be("Display");
		definition.Enabled.Should().BeTrue();
		definition.FieldId.Should().Be("field-id");
		definition.HasDate.Should().BeTrue();
		definition.HasTime.Should().BeTrue();
		definition.IsFullTextSearchable.Should().BeTrue();
		definition.MaximumSize.Should().Be("max");
		definition.Name.Should().Be("name");
		definition.ReadOnly.Should().BeTrue();
		definition.Required.Should().BeTrue();
		definition.Type.Should().Be("text");
		definition.TypeLocalized.Should().Be("texte");
		definition.Validated.Should().BeTrue();
		definition.WholeDigits.Should().Be(8);
	}
}
