using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesAddItemToQueueRequest
/// </summary>
[DataContract]
public partial class AddItemToQueueRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddItemToQueueRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="QueueStandInKey">QueueStandInKey.</param>
	public AddItemToQueueRequest(string BusObId, string BusObRecId, string QueueStandInKey)
	{
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
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
	/// QueueStandInKey
	/// </summary>
	[DataMember(Name = "queueStandInKey", EmitDefaultValue = false)]
	public string QueueStandInKey { get; set; }
}
