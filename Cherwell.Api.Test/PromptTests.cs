using Cherwell.Api.Models.Core;

namespace Cherwell.Api.Test;

public class PromptTests
{
	/// <summary>
	/// A Prompt with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var prompt = new Prompt
		{
			ListDisplayOption = Prompt.EnumListDisplayOption.Combo,
			PromptType = Prompt.EnumPromptType.DateTime,
			AllowValuesOnly = true,
			BusObId = "busob",
			CollectionStoreEntireRow = "yes",
			CollectionValueField = "value",
			ConstraintXml = "<x/>",
			Contents = "content",
			Default = "dflt",
			FieldId = "field",
			IsDateRange = true,
			ListReturnFieldId = "listret",
			MultiLine = true,
			PromptId = "prompt-id",
			PromptTypeName = "datetime",
			Required = true,
			Text = "prompt text",
			Value = 42,
			Values = new List<string> { "a", "b" }
		};

		prompt.ListDisplayOption.Should().Be(Prompt.EnumListDisplayOption.Combo);
		prompt.PromptType.Should().Be(Prompt.EnumPromptType.DateTime);
		prompt.AllowValuesOnly.Should().BeTrue();
		prompt.BusObId.Should().Be("busob");
		prompt.CollectionStoreEntireRow.Should().Be("yes");
		prompt.CollectionValueField.Should().Be("value");
		prompt.ConstraintXml.Should().Be("<x/>");
		prompt.Contents.Should().Be("content");
		prompt.Default.Should().Be("dflt");
		prompt.FieldId.Should().Be("field");
		prompt.IsDateRange.Should().BeTrue();
		prompt.ListReturnFieldId.Should().Be("listret");
		prompt.MultiLine.Should().BeTrue();
		prompt.PromptId.Should().Be("prompt-id");
		prompt.PromptTypeName.Should().Be("datetime");
		prompt.Required.Should().BeTrue();
		prompt.Text.Should().Be("prompt text");
		prompt.Value.Should().Be(42);
		prompt.Values.Should().Contain("a").And.Contain("b");
		prompt.Values.Should().HaveCount(2);
	}
}
