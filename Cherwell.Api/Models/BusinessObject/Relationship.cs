using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectRelationship
/// </summary>
[DataContract]
public partial class BusinessObjectRelationship
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BusinessObjectRelationship" /> class.
	/// </summary>
	/// <param name="Cardinality">Cardinality.</param>
	/// <param name="Description">Description.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="FieldDefinitions">FieldDefinitions.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="Target">Target.</param>
	public BusinessObjectRelationship(string Cardinality, string Description, string DisplayName, List<FieldDefinition> FieldDefinitions, string RelationshipId, string Target)
	{
		this.Cardinality = Cardinality;
		this.Description = Description;
		this.DisplayName = DisplayName;
		this.FieldDefinitions = FieldDefinitions;
		this.RelationshipId = RelationshipId;
		this.Target = Target;
	}

	/// <summary>
	/// Cardinality
	/// </summary>
	[DataMember(Name = "cardinality", EmitDefaultValue = false)]
	public string Cardinality { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// FieldDefinitions
	/// </summary>
	[DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
	public List<FieldDefinition> FieldDefinitions { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; }

	/// <summary>
	/// Target
	/// </summary>
	[DataMember(Name = "target", EmitDefaultValue = false)]
	public string Target { get; set; }










	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)



		}
	}

	
}