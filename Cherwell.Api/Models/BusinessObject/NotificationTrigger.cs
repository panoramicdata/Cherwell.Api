using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectNotificationTrigger
/// </summary>
[DataContract]
public partial class NotificationTrigger
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

	
}