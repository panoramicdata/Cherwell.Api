using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSchemaResponse
/// </summary>
[DataContract]
public partial class SchemaResponse : Response
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; } = null!;

	/// <summary>
	/// FieldDefinitions
	/// </summary>
	[DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
	public List<FieldDefinition>? FieldDefinitions { get; set; } = null!;

	/// <summary>
	/// FirstRecIdField
	/// </summary>
	[DataMember(Name = "firstRecIdField", EmitDefaultValue = false)]
	public string? FirstRecIdField { get; set; } = null!;

	/// <summary>
	/// GridDefinitions
	/// </summary>
	[DataMember(Name = "gridDefinitions", EmitDefaultValue = false)]
	public List<GridDefinition>? GridDefinitions { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; } = null!;

	/// <summary>
	/// RecIdFields
	/// </summary>
	[DataMember(Name = "recIdFields", EmitDefaultValue = false)]
	public string? RecIdFields { get; set; } = null!;

	/// <summary>
	/// Relationships
	/// </summary>
	[DataMember(Name = "relationships", EmitDefaultValue = false)]
	public List<BusinessObjectRelationship>? Relationships { get; set; } = null!;

	/// <summary>
	/// StateFieldId
	/// </summary>
	[DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
	public string? StateFieldId { get; set; } = null!;

	/// <summary>
	/// States
	/// </summary>
	[DataMember(Name = "states", EmitDefaultValue = false)]
	public string? States { get; set; } = null!;
}