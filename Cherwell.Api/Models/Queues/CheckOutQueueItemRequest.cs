using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesCheckOutQueueItemRequest
/// </summary>
[DataContract]
public partial class CheckOutQueueItemRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CheckOutQueueItemRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="HistoryNotes">HistoryNotes.</param>
	/// <param name="QueueStandInKey">QueueStandInKey.</param>
	public CheckOutQueueItemRequest(string BusObId, string BusObRecId, string HistoryNotes, string QueueStandInKey)
	{
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.HistoryNotes = HistoryNotes;
		this.QueueStandInKey = QueueStandInKey;
	}

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
	/// HistoryNotes
	/// </summary>
	[DataMember(Name = "historyNotes", EmitDefaultValue = false)]
	public string HistoryNotes { get; set; }

	/// <summary>
	/// QueueStandInKey
	/// </summary>
	[DataMember(Name = "queueStandInKey", EmitDefaultValue = false)]
	public string QueueStandInKey { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class QueuesCheckOutQueueItemRequest {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  HistoryNotes: ").Append(HistoryNotes).Append('\n');
		sb.Append("  QueueStandInKey: ").Append(QueueStandInKey).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if QueuesCheckOutQueueItemRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of QueuesCheckOutQueueItemRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(CheckOutQueueItemRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
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
					HistoryNotes == other.HistoryNotes ||
					HistoryNotes != null &&
					HistoryNotes.Equals(other.HistoryNotes, StringComparison.Ordinal)
				) &&
				(
					QueueStandInKey == other.QueueStandInKey ||
					QueueStandInKey != null &&
					QueueStandInKey.Equals(other.QueueStandInKey, StringComparison.Ordinal)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (HistoryNotes != null)
			{
				hash = hash * 59 + HistoryNotes.GetHashCode();
			}

			if (QueueStandInKey != null)
			{
				hash = hash * 59 + QueueStandInKey.GetHashCode();
			}

			return hash;
		}
	}

	
}
