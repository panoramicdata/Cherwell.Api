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
	/// AcquireLicense
	/// </summary>
	[DataMember(Name = "acquireLicense", EmitDefaultValue = false)]
	public bool? AcquireLicense { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// OneStepActionStandInKey
	/// </summary>
	[DataMember(Name = "oneStepActionStandInKey", EmitDefaultValue = false)]
	public string OneStepActionStandInKey { get; set; }

	/// <summary>
	/// PromptValues
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
		return Equals(obj as OneStepActionRequest);
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
					AcquireLicense == other.AcquireLicense ||
					AcquireLicense != null &&
					AcquireLicense.Equals(other.AcquireLicense)
				) &&
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					OneStepActionStandInKey == other.OneStepActionStandInKey ||
					OneStepActionStandInKey != null &&
					OneStepActionStandInKey.Equals(other.OneStepActionStandInKey, StringComparison.Ordinal)
				) &&
				(
					PromptValues == other.PromptValues ||
					PromptValues != null &&
					PromptValues.SequenceEqual(other.PromptValues)
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
			if (AcquireLicense != null)
			{
				hash = hash * 59 + AcquireLicense.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (OneStepActionStandInKey != null)
			{
				hash = hash * 59 + OneStepActionStandInKey.GetHashCode();
			}

			if (PromptValues != null)
			{
				hash = hash * 59 + PromptValues.GetHashCode();
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
