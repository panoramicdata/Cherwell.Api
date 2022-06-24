using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleTransitionRecordRequest
/// </summary>
[DataContract]
public partial class TransitionRecordRequest : IEquatable<TransitionRecordRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TransitionRecordRequest" /> class.
	/// </summary>
	/// <param name="TransitionOptionId">TransitionOptionId.</param>
	public TransitionRecordRequest(string TransitionOptionId)
	{
		this.TransitionOptionId = TransitionOptionId;
	}

	/// <summary>
	/// Gets or Sets TransitionOptionId
	/// </summary>
	[DataMember(Name = "transitionOptionId", EmitDefaultValue = false)]
	public string TransitionOptionId { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class LifecycleTransitionRecordRequest {\n");
		sb.Append("  TransitionOptionId: ").Append(TransitionOptionId).Append('\n');
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
		return Equals(obj as TransitionRecordRequest);
	}

	/// <summary>
	/// Returns true if LifecycleTransitionRecordRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of LifecycleTransitionRecordRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TransitionRecordRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					TransitionOptionId == other.TransitionOptionId ||
					TransitionOptionId != null &&
					TransitionOptionId.Equals(other.TransitionOptionId, StringComparison.Ordinal)
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
			if (TransitionOptionId != null)
			{
				hash = hash * 59 + TransitionOptionId.GetHashCode();
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
