using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldTemplateItem
/// </summary>
[DataContract]
public partial class FieldTemplateItem : IEquatable<FieldTemplateItem>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldTemplateItem" /> class.
	/// </summary>
	/// <param name="Dirty">Dirty.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="FullFieldId">FullFieldId.</param>
	/// <param name="Html">Html.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Value">Value.</param>
	public FieldTemplateItem(bool? Dirty, string DisplayName, string FieldId, string FullFieldId, string Html, string Name, string Value)
	{
		this.Dirty = Dirty;
		this.DisplayName = DisplayName;
		this.FieldId = FieldId;
		this.FullFieldId = FullFieldId;
		this.Html = Html;
		this.Name = Name;
		this.Value = Value;
	}

	/// <summary>
	/// Dirty
	/// </summary>
	[DataMember(Name = "dirty", EmitDefaultValue = false)]
	public bool? Dirty { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// FullFieldId
	/// </summary>
	[DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
	public string FullFieldId { get; set; }

	/// <summary>
	/// Html
	/// </summary>
	[DataMember(Name = "html", EmitDefaultValue = false)]
	public string Html { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

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
		sb.Append("class BusinessObjectFieldTemplateItem {\n");
		sb.Append("  Dirty: ").Append(Dirty).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  FullFieldId: ").Append(FullFieldId).Append('\n');
		sb.Append("  Html: ").Append(Html).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
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
		return Equals(obj as FieldTemplateItem);
	}

	/// <summary>
	/// Returns true if BusinessObjectFieldTemplateItem instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectFieldTemplateItem to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(FieldTemplateItem? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Dirty == other.Dirty ||
					Dirty != null &&
					Dirty.Equals(other.Dirty)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					FullFieldId == other.FullFieldId ||
					FullFieldId != null &&
					FullFieldId.Equals(other.FullFieldId, StringComparison.Ordinal)
				) &&
				(
					Html == other.Html ||
					Html != null &&
					Html.Equals(other.Html, StringComparison.Ordinal)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
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
			if (Dirty != null)
			{
				hash = hash * 59 + Dirty.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (FullFieldId != null)
			{
				hash = hash * 59 + FullFieldId.GetHashCode();
			}

			if (Html != null)
			{
				hash = hash * 59 + Html.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
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