using Cherwell.Api.Models.Searches;

namespace Cherwell.Api.Test;

public class FieldTests
{
	/// <summary>
	/// A Field with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var field = new Field
		{
			Caption = "Caption",
			CurrencyCulture = "en-US",
			CurrencySymbol = "$",
			DecimalDigits = 2,
			DefaultSortOrderAscending = true,
			DisplayName = "Display",
			FieldName = "field",
			FullFieldId = "full",
			HasDefaultSortField = true,
			FieldId = "field-id",
			IsBinary = true,
			IsCurrency = true,
			IsDateTime = true,
			IsFilterAllowed = true,
			IsLogical = true,
			IsNumber = true,
			IsShortDate = true,
			IsShortTime = true,
			IsVisible = true,
			Sortable = true,
			SortOrder = "asc",
			StorageName = "storage",
			WholeDigits = 6
		};

		field.Caption.Should().Be("Caption");
		field.CurrencyCulture.Should().Be("en-US");
		field.CurrencySymbol.Should().Be("$");
		field.DecimalDigits.Should().Be(2);
		field.DefaultSortOrderAscending.Should().BeTrue();
		field.DisplayName.Should().Be("Display");
		field.FieldName.Should().Be("field");
		field.FullFieldId.Should().Be("full");
		field.HasDefaultSortField.Should().BeTrue();
		field.FieldId.Should().Be("field-id");
		field.IsBinary.Should().BeTrue();
		field.IsCurrency.Should().BeTrue();
		field.IsDateTime.Should().BeTrue();
		field.IsFilterAllowed.Should().BeTrue();
		field.IsLogical.Should().BeTrue();
		field.IsNumber.Should().BeTrue();
		field.IsShortDate.Should().BeTrue();
		field.IsShortTime.Should().BeTrue();
		field.IsVisible.Should().BeTrue();
		field.Sortable.Should().BeTrue();
		field.SortOrder.Should().Be("asc");
		field.StorageName.Should().Be("storage");
		field.WholeDigits.Should().Be(6);
	}
}
