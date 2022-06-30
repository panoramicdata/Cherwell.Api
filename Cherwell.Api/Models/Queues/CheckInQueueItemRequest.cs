using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesCheckInQueueItemRequest
/// </summary>
[DataContract]
public partial class CheckInQueueItemRequest
{
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
