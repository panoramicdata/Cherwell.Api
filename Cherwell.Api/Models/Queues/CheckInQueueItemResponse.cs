using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesCheckInQueueItemResponse
/// </summary>
[DataContract]
public partial class CheckInQueueItemResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CheckInQueueItemResponse" /> class.
	/// </summary>
	/// <param name="HistoryRecId">HistoryRecId.</param>
	/// <param name="HistoryText">HistoryText.</param>
	/// <param name="HistoryTypeId">HistoryTypeId.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public CheckInQueueItemResponse(string HistoryRecId, string HistoryText, string HistoryTypeId, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.HistoryRecId = HistoryRecId;
		this.HistoryText = HistoryText;
		this.HistoryTypeId = HistoryTypeId;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// HistoryRecId
	/// </summary>
	[DataMember(Name = "historyRecId", EmitDefaultValue = false)]
	public string HistoryRecId { get; set; }

	/// <summary>
	/// HistoryText
	/// </summary>
	[DataMember(Name = "historyText", EmitDefaultValue = false)]
	public string HistoryText { get; set; }

	/// <summary>
	/// HistoryTypeId
	/// </summary>
	[DataMember(Name = "historyTypeId", EmitDefaultValue = false)]
	public string HistoryTypeId { get; set; }
}
