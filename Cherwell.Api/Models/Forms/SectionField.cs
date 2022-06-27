using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsSectionField
/// </summary>
[DataContract]
public partial class SectionField : IEquatable<SectionField>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SectionField" /> class.
	/// </summary>
	/// <param name="attributes">Attributes.</param>
	/// <param name="fieldId">FieldId.</param>
	/// <param name="fieldType">FieldType.</param>
	/// <param name="label">Label.</param>
	/// <param name="multiline">Multiline.</param>
	/// <param name="value">Value.</param>
	public SectionField(
		List<object> attributes,
		string fieldId,
		string fieldType,
		string label,
		bool? multiline,
		string value)
	{
		Attributes = attributes;
		FieldId = fieldId;
		FieldType = fieldType;
		Label = label;
		Multiline = multiline;
		Value = value;
	}

	/// <summary>
	/// Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	public List<object> Attributes { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// FieldType
	/// </summary>
	[DataMember(Name = "fieldType", EmitDefaultValue = false)]
	public string FieldType { get; set; }

	/// <summary>
	/// Label
	/// </summary>
	[DataMember(Name = "label", EmitDefaultValue = false)]
	public string Label { get; set; }

	/// <summary>
	/// Multiline
	/// </summary>
	[DataMember(Name = "multiline", EmitDefaultValue = false)]
	public bool? Multiline { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class FormsSectionField {\n");
		sb.Append("  Attributes: ").Append(Attributes).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  FieldType: ").Append(FieldType).Append('\n');
		sb.Append("  Label: ").Append(Label).Append('\n');
		sb.Append("  Multiline: ").Append(Multiline).Append('\n');
		sb.Append("  Value: ").Append(Value).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as SectionField);
	}

	/// <summary>
	/// Returns true if FormsSectionField instances are equal
	/// </summary>
	/// <param name="other">Instance of FormsSectionField to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SectionField? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Attributes == other.Attributes ||
					Attributes != null &&
					Attributes.SequenceEqual(other.Attributes)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					FieldType == other.FieldType ||
					FieldType != null &&
					FieldType.Equals(other.FieldType, StringComparison.Ordinal)
				) &&
				(
					Label == other.Label ||
					Label != null &&
					Label.Equals(other.Label, StringComparison.Ordinal)
				) &&
				(
					Multiline == other.Multiline ||
					Multiline != null &&
					Multiline.Equals(other.Multiline)
				) &&
				(
					Value == other.Value ||
					Value != null &&
					Value.Equals(other.Value, StringComparison.Ordinal)
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
			if (Attributes != null)
			{
				hash = hash * 59 + Attributes.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (FieldType != null)
			{
				hash = hash * 59 + FieldType.GetHashCode();
			}

			if (Label != null)
			{
				hash = hash * 59 + Label.GetHashCode();
			}

			if (Multiline != null)
			{
				hash = hash * 59 + Multiline.GetHashCode();
			}

			if (Value != null)
			{
				hash = hash * 59 + Value.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
