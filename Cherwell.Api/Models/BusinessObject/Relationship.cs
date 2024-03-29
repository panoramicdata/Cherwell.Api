using System.Diagnostics;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// Relationship
/// </summary>
[DataContract]
[DebuggerDisplay("{DisplayName} ({RelationshipId})")]
public class BusinessObjectRelationship
{
	/// <summary>
	/// Cardinality
	/// </summary>
	[DataMember(Name = "cardinality", EmitDefaultValue = false)]
	public string Cardinality { get; set; } = null!;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; } = null!;

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// FieldDefinitions
	/// </summary>
	[DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
	public List<FieldDefinition> FieldDefinitions { get; set; } = null!;

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; } = null!;

	/// <summary>
	/// Target
	/// </summary>
	[DataMember(Name = "target", EmitDefaultValue = false)]
	public string Target { get; set; } = null!;
}