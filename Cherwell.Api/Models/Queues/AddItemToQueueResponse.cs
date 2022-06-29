using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesAddItemToQueueResponse
/// </summary>
[DataContract]
public partial class AddItemToQueueResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddItemToQueueResponse" /> class.
	/// </summary>
	/// <param name="HistoryRecId">HistoryRecId.</param>
	/// <param name="HistoryText">HistoryText.</param>
	/// <param name="HistoryTypeId">HistoryTypeId.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public AddItemToQueueResponse(string HistoryRecId, string HistoryText, string HistoryTypeId, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class QueuesAddItemToQueueResponse {\n");
		sb.Append("  HistoryRecId: ").Append(HistoryRecId).Append('\n');
		sb.Append("  HistoryText: ").Append(HistoryText).Append('\n');
		sb.Append("  HistoryTypeId: ").Append(HistoryTypeId).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
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
			if (HistoryRecId != null)
			{
				hash = hash * 59 + HistoryRecId.GetHashCode();
			}

			if (HistoryText != null)
			{
				hash = hash * 59 + HistoryText.GetHashCode();
			}

			if (HistoryTypeId != null)
			{
				hash = hash * 59 + HistoryTypeId.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	
}
