using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectNotificationTrigger
/// </summary>
[DataContract]
public partial class NotificationTrigger : IEquatable<NotificationTrigger>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="NotificationTrigger" /> class.
	/// </summary>
	/// <param name="SourceType">SourceType.</param>
	/// <param name="SourceId">SourceId.</param>
	/// <param name="SourceChange">SourceChange.</param>
	/// <param name="Key">Key.</param>
	public NotificationTrigger(string SourceType, string SourceId, string SourceChange, string Key)
	{
		this.SourceType = SourceType;
		this.SourceId = SourceId;
		this.SourceChange = SourceChange;
		this.Key = Key;
	}

	/// <summary>
	/// SourceType
	/// </summary>
	[DataMember(Name = "sourceType", EmitDefaultValue = false)]
	public string SourceType { get; set; }

	/// <summary>
	/// SourceId
	/// </summary>
	[DataMember(Name = "sourceId", EmitDefaultValue = false)]
	public string SourceId { get; set; }

	/// <summary>
	/// SourceChange
	/// </summary>
	[DataMember(Name = "sourceChange", EmitDefaultValue = false)]
	public string SourceChange { get; set; }

	/// <summary>
	/// Key
	/// </summary>
	[DataMember(Name = "key", EmitDefaultValue = false)]
	public string Key { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectNotificationTrigger {\n");
		sb.Append("  SourceType: ").Append(SourceType).Append('\n');
		sb.Append("  SourceId: ").Append(SourceId).Append('\n');
		sb.Append("  SourceChange: ").Append(SourceChange).Append('\n');
		sb.Append("  Key: ").Append(Key).Append('\n');
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
		return Equals(obj as NotificationTrigger);
	}

	/// <summary>
	/// Returns true if BusinessObjectNotificationTrigger instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectNotificationTrigger to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(NotificationTrigger? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					SourceType == other.SourceType ||
					SourceType != null &&
					SourceType.Equals(other.SourceType, StringComparison.Ordinal)
				) &&
				(
					SourceId == other.SourceId ||
					SourceId != null &&
					SourceId.Equals(other.SourceId, StringComparison.Ordinal)
				) &&
				(
					SourceChange == other.SourceChange ||
					SourceChange != null &&
					SourceChange.Equals(other.SourceChange, StringComparison.Ordinal)
				) &&
				(
					Key == other.Key ||
					Key != null &&
					Key.Equals(other.Key, StringComparison.Ordinal)
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
			if (SourceType != null)
			{
				hash = hash * 59 + SourceType.GetHashCode();
			}

			if (SourceId != null)
			{
				hash = hash * 59 + SourceId.GetHashCode();
			}

			if (SourceChange != null)
			{
				hash = hash * 59 + SourceChange.GetHashCode();
			}

			if (Key != null)
			{
				hash = hash * 59 + Key.GetHashCode();
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