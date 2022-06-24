using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.OneStepActions;

/// <summary>
/// OneStepActionsOneStepActionRequest
/// </summary>
[DataContract]
public partial class OneStepActionRequest : IEquatable<OneStepActionRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="OneStepActionRequest" /> class.
	/// </summary>
	/// <param name="AcquireLicense">AcquireLicense.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="OneStepActionStandInKey">OneStepActionStandInKey.</param>
	/// <param name="PromptValues">PromptValues.</param>
	public OneStepActionRequest(bool? AcquireLicense, string BusObId, string BusObRecId, string OneStepActionStandInKey, List<SimplePromptValue> PromptValues)
	{
		this.AcquireLicense = AcquireLicense;
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.OneStepActionStandInKey = OneStepActionStandInKey;
		this.PromptValues = PromptValues;
	}

	/// <summary>
	/// Gets or Sets AcquireLicense
	/// </summary>
	[DataMember(Name = "acquireLicense", EmitDefaultValue = false)]
	public bool? AcquireLicense { get; set; }
	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets OneStepActionStandInKey
	/// </summary>
	[DataMember(Name = "oneStepActionStandInKey", EmitDefaultValue = false)]
	public string OneStepActionStandInKey { get; set; }
	/// <summary>
	/// Gets or Sets PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<SimplePromptValue> PromptValues { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class OneStepActionsOneStepActionRequest {\n");
		sb.Append("  AcquireLicense: ").Append(AcquireLicense).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  OneStepActionStandInKey: ").Append(OneStepActionStandInKey).Append('\n');
		sb.Append("  PromptValues: ").Append(PromptValues).Append('\n');
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
		return this.Equals(obj as OneStepActionRequest);
	}

	/// <summary>
	/// Returns true if OneStepActionsOneStepActionRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of OneStepActionsOneStepActionRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(OneStepActionRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					this.AcquireLicense == other.AcquireLicense ||
					this.AcquireLicense != null &&
					this.AcquireLicense.Equals(other.AcquireLicense)
				) &&
				(
					this.BusObId == other.BusObId ||
					this.BusObId != null &&
					this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					this.BusObRecId == other.BusObRecId ||
					this.BusObRecId != null &&
					this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					this.OneStepActionStandInKey == other.OneStepActionStandInKey ||
					this.OneStepActionStandInKey != null &&
					this.OneStepActionStandInKey.Equals(other.OneStepActionStandInKey, StringComparison.Ordinal)
				) &&
				(
					this.PromptValues == other.PromptValues ||
					this.PromptValues != null &&
					this.PromptValues.SequenceEqual(other.PromptValues)
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
			if (this.AcquireLicense != null)
			{
				hash = hash * 59 + this.AcquireLicense.GetHashCode();
			}

			if (this.BusObId != null)
			{
				hash = hash * 59 + this.BusObId.GetHashCode();
			}

			if (this.BusObRecId != null)
			{
				hash = hash * 59 + this.BusObRecId.GetHashCode();
			}

			if (this.OneStepActionStandInKey != null)
			{
				hash = hash * 59 + this.OneStepActionStandInKey.GetHashCode();
			}

			if (this.PromptValues != null)
			{
				hash = hash * 59 + this.PromptValues.GetHashCode();
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
