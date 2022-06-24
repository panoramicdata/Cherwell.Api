using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesFilterInfo
/// </summary>
[DataContract]
public partial class FilterInfo : IEquatable<FilterInfo>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FilterInfo" /> class.
	/// </summary>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="Operator">_Operator.</param>
	/// <param name="Value">Value.</param>
	public FilterInfo(string FieldId, string Operator, string Value)
	{
		this.FieldId = FieldId;
		this.Operator = Operator;
		this.Value = Value;
	}

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// _Operator
	/// </summary>
	[DataMember(Name = "operator", EmitDefaultValue = false)]
	public string Operator { get; set; }

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
		sb.Append("class SearchesFilterInfo {\n");
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  _Operator: ").Append(Operator).Append('\n');
		sb.Append("  Value: ").Append(Value).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as FilterInfo);
	}

	/// <summary>
	/// Returns true if SearchesFilterInfo instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesFilterInfo to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(FilterInfo? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					Operator == other.Operator ||
					Operator != null &&
					Operator.Equals(other.Operator, StringComparison.Ordinal)
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
			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (Operator != null)
			{
				hash = hash * 59 + Operator.GetHashCode();
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
