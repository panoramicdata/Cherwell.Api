using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesRemoveItemFromQueueRequest
/// </summary>
[DataContract]
public partial class RemoveItemFromQueueRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RemoveItemFromQueueRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="HistoryNotes">HistoryNotes.</param>
	/// <param name="QueueStandInKey">QueueStandInKey.</param>
	public RemoveItemFromQueueRequest(string BusObId, string BusObRecId, string HistoryNotes, string QueueStandInKey)
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
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// HistoryNotes
	/// </summary>
	[DataMember(Name = "historyNotes", EmitDefaultValue = false)]
	public string HistoryNotes { get; set; } = null!;

	/// <summary>
	/// QueueStandInKey
	/// </summary>
	[DataMember(Name = "queueStandInKey", EmitDefaultValue = false)]
	public string QueueStandInKey { get; set; } = null!;
}
