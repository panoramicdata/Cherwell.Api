using Cherwell.Api.Models.BusinessObject;

namespace Cherwell.Api.Test;

public class SchemaResponseTests
{
	/// <summary>
	/// A SchemaResponse with a typical set of values round-trips them.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var response = new SchemaResponse
		{
			BusObId = "busob",
			FieldDefinitions = new List<FieldDefinition>(),
			FirstRecIdField = "first",
			GridDefinitions = new List<GridDefinition>(),
			Name = "name",
			RecIdFields = "rec-fields",
			Relationships = new List<BusinessObjectRelationship>(),
			StateFieldId = "state",
			States = "states"
		};

		response.BusObId.Should().Be("busob");
		response.FieldDefinitions.Should().BeEmpty();
		response.FirstRecIdField.Should().Be("first");
		response.GridDefinitions.Should().BeEmpty();
		response.Name.Should().Be("name");
		response.RecIdFields.Should().Be("rec-fields");
		response.Relationships.Should().BeEmpty();
		response.StateFieldId.Should().Be("state");
		response.States.Should().Be("states");
	}
}
