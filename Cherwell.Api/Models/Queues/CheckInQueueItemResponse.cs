using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Queues;

/// <summary>
/// QueuesCheckInQueueItemResponse
/// </summary>
[DataContract]
public partial class CheckInQueueItemResponse : IEquatable<CheckInQueueItemResponse>, IValidatableObject
{
	/// <summary>
	/// HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="CheckInQueueItemResponse" /> class.
	/// </summary>
	/// <param name="HistoryRecId">HistoryRecId.</param>
	/// <param name="HistoryText">HistoryText.</param>
	/// <param name="HistoryTypeId">HistoryTypeId.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public CheckInQueueItemResponse(string HistoryRecId, string HistoryText, string HistoryTypeId, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.HistoryRecId = HistoryRecId;
		this.HistoryText = HistoryText;
		this.HistoryTypeId = HistoryTypeId;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
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
	/// ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class QueuesCheckInQueueItemResponse {\n");
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
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as CheckInQueueItemResponse);
	}

	/// <summary>
	/// Returns true if QueuesCheckInQueueItemResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of QueuesCheckInQueueItemResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(CheckInQueueItemResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					HistoryRecId == other.HistoryRecId ||
					HistoryRecId != null &&
					HistoryRecId.Equals(other.HistoryRecId, StringComparison.Ordinal)
				) &&
				(
					HistoryText == other.HistoryText ||
					HistoryText != null &&
					HistoryText.Equals(other.HistoryText, StringComparison.Ordinal)
				) &&
				(
					HistoryTypeId == other.HistoryTypeId ||
					HistoryTypeId != null &&
					HistoryTypeId.Equals(other.HistoryTypeId, StringComparison.Ordinal)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
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
