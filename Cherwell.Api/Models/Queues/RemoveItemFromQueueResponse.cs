using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesRemoveItemFromQueueResponse
/// </summary>
[DataContract]
public class RemoveItemFromQueueResponse : Response
{
	/// <summary>
	/// HistoryRecId
	/// </summary>
	[DataMember(Name = "historyRecId", EmitDefaultValue = false)]
	public string HistoryRecId { get; set; } = null!;

	/// <summary>
	/// HistoryText
	/// </summary>
	[DataMember(Name = "historyText", EmitDefaultValue = false)]
	public string HistoryText { get; set; } = null!;

	/// <summary>
	/// HistoryTypeId
	/// </summary>
	[DataMember(Name = "historyTypeId", EmitDefaultValue = false)]
	public string HistoryTypeId { get; set; } = null!;
}
