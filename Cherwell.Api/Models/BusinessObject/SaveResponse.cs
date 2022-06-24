using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveResponse
/// </summary>
[DataContract]
public partial class SaveResponse : IEquatable<SaveResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SaveResponse" /> class.
	/// </summary>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="CacheKey">CacheKey.</param>
	/// <param name="FieldValidationErrors">FieldValidationErrors.</param>
	/// <param name="NotificationTriggers">NotificationTriggers.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SaveResponse(string BusObPublicId, string BusObRecId, string CacheKey, List<FieldValidationError> FieldValidationErrors, List<NotificationTrigger> NotificationTriggers, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.CacheKey = CacheKey;
		this.FieldValidationErrors = FieldValidationErrors;
		this.NotificationTriggers = NotificationTriggers;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// Gets or Sets CacheKey
	/// </summary>
	[DataMember(Name = "cacheKey", EmitDefaultValue = false)]
	public string CacheKey { get; set; }

	/// <summary>
	/// Gets or Sets FieldValidationErrors
	/// </summary>
	[DataMember(Name = "fieldValidationErrors", EmitDefaultValue = false)]
	public List<FieldValidationError> FieldValidationErrors { get; set; }

	/// <summary>
	/// Gets or Sets NotificationTriggers
	/// </summary>
	[DataMember(Name = "notificationTriggers", EmitDefaultValue = false)]
	public List<NotificationTrigger> NotificationTriggers { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// Gets or Sets HasError
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
		sb.Append("class BusinessObjectSaveResponse {\n");
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  CacheKey: ").Append(CacheKey).Append('\n');
		sb.Append("  FieldValidationErrors: ").Append(FieldValidationErrors).Append('\n');
		sb.Append("  NotificationTriggers: ").Append(NotificationTriggers).Append('\n');
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
		return Equals(obj as SaveResponse);
	}

	/// <summary>
	/// Returns true if BusinessObjectSaveResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectSaveResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObPublicId == other.BusObPublicId ||
					BusObPublicId != null &&
					BusObPublicId.Equals(other.BusObPublicId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					CacheKey == other.CacheKey ||
					CacheKey != null &&
					CacheKey.Equals(other.CacheKey, StringComparison.Ordinal)
				) &&
				(
					FieldValidationErrors == other.FieldValidationErrors ||
					FieldValidationErrors != null &&
					FieldValidationErrors.SequenceEqual(other.FieldValidationErrors)
				) &&
				(
					NotificationTriggers == other.NotificationTriggers ||
					NotificationTriggers != null &&
					NotificationTriggers.SequenceEqual(other.NotificationTriggers)
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
			if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (CacheKey != null)
			{
				hash = hash * 59 + CacheKey.GetHashCode();
			}

			if (FieldValidationErrors != null)
			{
				hash = hash * 59 + FieldValidationErrors.GetHashCode();
			}

			if (NotificationTriggers != null)
			{
				hash = hash * 59 + NotificationTriggers.GetHashCode();
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
