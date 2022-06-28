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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectRelationship {\n");
		sb.Append("  Cardinality: ").Append(Cardinality).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append('\n');
		sb.Append("  RelationshipId: ").Append(RelationshipId).Append('\n');
		sb.Append("  Target: ").Append(Target).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if BusinessObjectRelationship instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectRelationship to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(BusinessObjectRelationship? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Cardinality == other.Cardinality ||
					Cardinality != null &&
					Cardinality.Equals(other.Cardinality, StringComparison.Ordinal)
				) &&
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					FieldDefinitions == other.FieldDefinitions ||
					FieldDefinitions != null &&
					FieldDefinitions.SequenceEqual(other.FieldDefinitions)
				) &&
				(
					RelationshipId == other.RelationshipId ||
					RelationshipId != null &&
					RelationshipId.Equals(other.RelationshipId, StringComparison.Ordinal)
				) &&
				(
					Target == other.Target ||
					Target != null &&
					Target.Equals(other.Target, StringComparison.Ordinal)
				);
	}

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
			if (Cardinality != null)
			{
				hash = hash * 59 + Cardinality.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (FieldDefinitions != null)
			{
				hash = hash * 59 + FieldDefinitions.GetHashCode();
			}

			if (RelationshipId != null)
			{
				hash = hash * 59 + RelationshipId.GetHashCode();
			}

			if (Target != null)
			{
				hash = hash * 59 + Target.GetHashCode();
			}

			return hash;
		}
	}

	
}