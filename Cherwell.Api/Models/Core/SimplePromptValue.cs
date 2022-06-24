using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreSimplePromptValue
/// </summary>
[DataContract]
public partial class SimplePromptValue : IEquatable<SimplePromptValue>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SimplePromptValue" /> class.
	/// </summary>
	/// <param name="PromptDefId">PromptDefId.</param>
	/// <param name="PromptName">PromptName.</param>
	/// <param name="Value">Value.</param>
	public SimplePromptValue(string PromptDefId, string PromptName, string Value)
	{
		this.PromptDefId = PromptDefId;
		this.PromptName = PromptName;
		this.Value = Value;
	}

	/// <summary>
	/// PromptDefId
	/// </summary>
	[DataMember(Name = "promptDefId", EmitDefaultValue = false)]
	public string PromptDefId { get; set; }

	/// <summary>
	/// PromptName
	/// </summary>
	[DataMember(Name = "promptName", EmitDefaultValue = false)]
	public string PromptName { get; set; }

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
		sb.Append("class CoreSimplePromptValue {\n");
		sb.Append("  PromptDefId: ").Append(PromptDefId).Append('\n');
		sb.Append("  PromptName: ").Append(PromptName).Append('\n');
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
		return Equals(obj as SimplePromptValue);
	}

	/// <summary>
	/// Returns true if CoreSimplePromptValue instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreSimplePromptValue to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SimplePromptValue? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					PromptDefId == other.PromptDefId ||
					PromptDefId != null &&
					PromptDefId.Equals(other.PromptDefId, StringComparison.Ordinal)
				) &&
				(
					PromptName == other.PromptName ||
					PromptName != null &&
					PromptName.Equals(other.PromptName, StringComparison.Ordinal)
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
			if (PromptDefId != null)
			{
				hash = hash * 59 + PromptDefId.GetHashCode();
			}

			if (PromptName != null)
			{
				hash = hash * 59 + PromptName.GetHashCode();
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
