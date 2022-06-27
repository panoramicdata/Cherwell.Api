using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesChangedLimit
/// </summary>
[DataContract]
public partial class ChangedLimit : IEquatable<ChangedLimit>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ChangedLimit" /> class.
	/// </summary>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="Units">Units.</param>
	/// <param name="Value">Value.</param>
	public ChangedLimit(string DisplayName, string Units, int? Value)
	{
		this.DisplayName = DisplayName;
		this.Units = Units;
		this.Value = Value;
	}

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Units
	/// </summary>
	[DataMember(Name = "units", EmitDefaultValue = false)]
	public string Units { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public int? Value { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesChangedLimit {\n");
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  Units: ").Append(Units).Append('\n');
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
		return Equals(obj as ChangedLimit);
	}

	/// <summary>
	/// Returns true if SearchesChangedLimit instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesChangedLimit to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ChangedLimit? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					Units == other.Units ||
					Units != null &&
					Units.Equals(other.Units, StringComparison.Ordinal)
				) &&
				(
					Value == other.Value ||
					Value != null &&
					Value.Equals(other.Value)
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
			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (Units != null)
			{
				hash = hash * 59 + Units.GetHashCode();
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
