using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesCheckOutQueueItemResponse
/// </summary>
[DataContract]
public partial class CheckOutQueueItemResponse : Response
{
	/// <summary>
	/// HistoryRecId
	/// </summary>
	[DataMember(Name = "historyRecId", EmitDefaultValue = false)]
	public string? HistoryRecId { get; set; }

	/// <summary>
	/// HistoryText
	/// </summary>
	[DataMember(Name = "historyText", EmitDefaultValue = false)]
	public string? HistoryText { get; set; }

	/// <summary>
	/// HistoryTypeId
	/// </summary>
	[DataMember(Name = "historyTypeId", EmitDefaultValue = false)]
	public string? HistoryTypeId { get; set; }
}
