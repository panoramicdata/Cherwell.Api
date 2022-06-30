using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// Relationship
/// </summary>
[DataContract]
public partial class BusinessObjectRelationship
{
	/// <summary>
	/// Cardinality
	/// </summary>
	[DataMember(Name = "cardinality", EmitDefaultValue = false)]
	public string? Cardinality { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string? Description { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string? DisplayName { get; set; }

	/// <summary>
	/// FieldDefinitions
	/// </summary>
	[DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
	public List<FieldDefinition>? FieldDefinitions { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string? RelationshipId { get; set; }

	/// <summary>
	/// Target
	/// </summary>
	[DataMember(Name = "target", EmitDefaultValue = false)]
	public string? Target { get; set; }
}