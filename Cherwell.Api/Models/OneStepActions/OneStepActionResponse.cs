using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.OneStepActions;

/// <summary>
/// OneStepActionsOneStepActionResponse
/// </summary>
[DataContract]
public partial class OneStepActionResponse : IEquatable<OneStepActionResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumHttpStatusCode
	{

		/// <summary>
		/// Enum Continue for "Continue"
		/// </summary>
		[EnumMember(Value = "Continue")]
		Continue,

		/// <summary>
		/// Enum SwitchingProtocols for "SwitchingProtocols"
		/// </summary>
		[EnumMember(Value = "SwitchingProtocols")]
		SwitchingProtocols,

		/// <summary>
		/// Enum OK for "OK"
		/// </summary>
		[EnumMember(Value = "OK")]
		OK,

		/// <summary>
		/// Enum Created for "Created"
		/// </summary>
		[EnumMember(Value = "Created")]
		Created,

		/// <summary>
		/// Enum Accepted for "Accepted"
		/// </summary>
		[EnumMember(Value = "Accepted")]
		Accepted,

		/// <summary>
		/// Enum NonAuthoritativeInformation for "NonAuthoritativeInformation"
		/// </summary>
		[EnumMember(Value = "NonAuthoritativeInformation")]
		NonAuthoritativeInformation,

		/// <summary>
		/// Enum NoContent for "NoContent"
		/// </summary>
		[EnumMember(Value = "NoContent")]
		NoContent,

		/// <summary>
		/// Enum ResetContent for "ResetContent"
		/// </summary>
		[EnumMember(Value = "ResetContent")]
		ResetContent,

		/// <summary>
		/// Enum PartialContent for "PartialContent"
		/// </summary>
		[EnumMember(Value = "PartialContent")]
		PartialContent,

		/// <summary>
		/// Enum MultipleChoices for "MultipleChoices"
		/// </summary>
		[EnumMember(Value = "MultipleChoices")]
		MultipleChoices,

		/// <summary>
		/// Enum Ambiguous for "Ambiguous"
		/// </summary>
		[EnumMember(Value = "Ambiguous")]
		Ambiguous,

		/// <summary>
		/// Enum MovedPermanently for "MovedPermanently"
		/// </summary>
		[EnumMember(Value = "MovedPermanently")]
		MovedPermanently,

		/// <summary>
		/// Enum Moved for "Moved"
		/// </summary>
		[EnumMember(Value = "Moved")]
		Moved,

		/// <summary>
		/// Enum Found for "Found"
		/// </summary>
		[EnumMember(Value = "Found")]
		Found,

		/// <summary>
		/// Enum Redirect for "Redirect"
		/// </summary>
		[EnumMember(Value = "Redirect")]
		Redirect,

		/// <summary>
		/// Enum SeeOther for "SeeOther"
		/// </summary>
		[EnumMember(Value = "SeeOther")]
		SeeOther,

		/// <summary>
		/// Enum RedirectMethod for "RedirectMethod"
		/// </summary>
		[EnumMember(Value = "RedirectMethod")]
		RedirectMethod,

		/// <summary>
		/// Enum NotModified for "NotModified"
		/// </summary>
		[EnumMember(Value = "NotModified")]
		NotModified,

		/// <summary>
		/// Enum UseProxy for "UseProxy"
		/// </summary>
		[EnumMember(Value = "UseProxy")]
		UseProxy,

		/// <summary>
		/// Enum Unused for "Unused"
		/// </summary>
		[EnumMember(Value = "Unused")]
		Unused,

		/// <summary>
		/// Enum TemporaryRedirect for "TemporaryRedirect"
		/// </summary>
		[EnumMember(Value = "TemporaryRedirect")]
		TemporaryRedirect,

		/// <summary>
		/// Enum RedirectKeepVerb for "RedirectKeepVerb"
		/// </summary>
		[EnumMember(Value = "RedirectKeepVerb")]
		RedirectKeepVerb,

		/// <summary>
		/// Enum BadRequest for "BadRequest"
		/// </summary>
		[EnumMember(Value = "BadRequest")]
		BadRequest,

		/// <summary>
		/// Enum Unauthorized for "Unauthorized"
		/// </summary>
		[EnumMember(Value = "Unauthorized")]
		Unauthorized,

		/// <summary>
		/// Enum PaymentRequired for "PaymentRequired"
		/// </summary>
		[EnumMember(Value = "PaymentRequired")]
		PaymentRequired,

		/// <summary>
		/// Enum Forbidden for "Forbidden"
		/// </summary>
		[EnumMember(Value = "Forbidden")]
		Forbidden,

		/// <summary>
		/// Enum NotFound for "NotFound"
		/// </summary>
		[EnumMember(Value = "NotFound")]
		NotFound,

		/// <summary>
		/// Enum MethodNotAllowed for "MethodNotAllowed"
		/// </summary>
		[EnumMember(Value = "MethodNotAllowed")]
		MethodNotAllowed,

		/// <summary>
		/// Enum NotAcceptable for "NotAcceptable"
		/// </summary>
		[EnumMember(Value = "NotAcceptable")]
		NotAcceptable,

		/// <summary>
		/// Enum ProxyAuthenticationRequired for "ProxyAuthenticationRequired"
		/// </summary>
		[EnumMember(Value = "ProxyAuthenticationRequired")]
		ProxyAuthenticationRequired,

		/// <summary>
		/// Enum RequestTimeout for "RequestTimeout"
		/// </summary>
		[EnumMember(Value = "RequestTimeout")]
		RequestTimeout,

		/// <summary>
		/// Enum Conflict for "Conflict"
		/// </summary>
		[EnumMember(Value = "Conflict")]
		Conflict,

		/// <summary>
		/// Enum Gone for "Gone"
		/// </summary>
		[EnumMember(Value = "Gone")]
		Gone,

		/// <summary>
		/// Enum LengthRequired for "LengthRequired"
		/// </summary>
		[EnumMember(Value = "LengthRequired")]
		LengthRequired,

		/// <summary>
		/// Enum PreconditionFailed for "PreconditionFailed"
		/// </summary>
		[EnumMember(Value = "PreconditionFailed")]
		PreconditionFailed,

		/// <summary>
		/// Enum RequestEntityTooLarge for "RequestEntityTooLarge"
		/// </summary>
		[EnumMember(Value = "RequestEntityTooLarge")]
		RequestEntityTooLarge,

		/// <summary>
		/// Enum RequestUriTooLong for "RequestUriTooLong"
		/// </summary>
		[EnumMember(Value = "RequestUriTooLong")]
		RequestUriTooLong,

		/// <summary>
		/// Enum UnsupportedMediaType for "UnsupportedMediaType"
		/// </summary>
		[EnumMember(Value = "UnsupportedMediaType")]
		UnsupportedMediaType,

		/// <summary>
		/// Enum RequestedRangeNotSatisfiable for "RequestedRangeNotSatisfiable"
		/// </summary>
		[EnumMember(Value = "RequestedRangeNotSatisfiable")]
		RequestedRangeNotSatisfiable,

		/// <summary>
		/// Enum ExpectationFailed for "ExpectationFailed"
		/// </summary>
		[EnumMember(Value = "ExpectationFailed")]
		ExpectationFailed,

		/// <summary>
		/// Enum UpgradeRequired for "UpgradeRequired"
		/// </summary>
		[EnumMember(Value = "UpgradeRequired")]
		UpgradeRequired,

		/// <summary>
		/// Enum InternalServerError for "InternalServerError"
		/// </summary>
		[EnumMember(Value = "InternalServerError")]
		InternalServerError,

		/// <summary>
		/// Enum NotImplemented for "NotImplemented"
		/// </summary>
		[EnumMember(Value = "NotImplemented")]
		NotImplemented,

		/// <summary>
		/// Enum BadGateway for "BadGateway"
		/// </summary>
		[EnumMember(Value = "BadGateway")]
		BadGateway,

		/// <summary>
		/// Enum ServiceUnavailable for "ServiceUnavailable"
		/// </summary>
		[EnumMember(Value = "ServiceUnavailable")]
		ServiceUnavailable,

		/// <summary>
		/// Enum GatewayTimeout for "GatewayTimeout"
		/// </summary>
		[EnumMember(Value = "GatewayTimeout")]
		GatewayTimeout,

		/// <summary>
		/// Enum HttpVersionNotSupported for "HttpVersionNotSupported"
		/// </summary>
		[EnumMember(Value = "HttpVersionNotSupported")]
		HttpVersionNotSupported
	}

	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }
	/// <summary>
	/// Initializes a new instance of the <see cref="OneStepActionResponse" /> class.
	/// </summary>
	/// <param name="Completed">Completed.</param>
	/// <param name="CurrentPrimaryBusObId">CurrentPrimaryBusObId.</param>
	/// <param name="CurrentPrimaryBusObRecId">CurrentPrimaryBusObRecId.</param>
	/// <param name="HasNewAccessToken">HasNewAccessToken.</param>
	/// <param name="NewAccessToken">NewAccessToken.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public OneStepActionResponse(bool? Completed, string CurrentPrimaryBusObId, string CurrentPrimaryBusObRecId, bool? HasNewAccessToken, string NewAccessToken, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.Completed = Completed;
		this.CurrentPrimaryBusObId = CurrentPrimaryBusObId;
		this.CurrentPrimaryBusObRecId = CurrentPrimaryBusObRecId;
		this.HasNewAccessToken = HasNewAccessToken;
		this.NewAccessToken = NewAccessToken;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets Completed
	/// </summary>
	[DataMember(Name = "completed", EmitDefaultValue = false)]
	public bool? Completed { get; set; }
	/// <summary>
	/// Gets or Sets CurrentPrimaryBusObId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObId { get; set; }
	/// <summary>
	/// Gets or Sets CurrentPrimaryBusObRecId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObRecId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets HasNewAccessToken
	/// </summary>
	[DataMember(Name = "hasNewAccessToken", EmitDefaultValue = false)]
	public bool? HasNewAccessToken { get; set; }
	/// <summary>
	/// Gets or Sets NewAccessToken
	/// </summary>
	[DataMember(Name = "newAccessToken", EmitDefaultValue = false)]
	public string NewAccessToken { get; set; }
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
		sb.Append("class OneStepActionsOneStepActionResponse {\n");
		sb.Append("  Completed: ").Append(Completed).Append('\n');
		sb.Append("  CurrentPrimaryBusObId: ").Append(CurrentPrimaryBusObId).Append('\n');
		sb.Append("  CurrentPrimaryBusObRecId: ").Append(CurrentPrimaryBusObRecId).Append('\n');
		sb.Append("  HasNewAccessToken: ").Append(HasNewAccessToken).Append('\n');
		sb.Append("  NewAccessToken: ").Append(NewAccessToken).Append('\n');
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
		return Equals(obj as OneStepActionResponse);
	}

	/// <summary>
	/// Returns true if OneStepActionsOneStepActionResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of OneStepActionsOneStepActionResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(OneStepActionResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Completed == other.Completed ||
					Completed != null &&
					Completed.Equals(other.Completed)
				) &&
				(
					CurrentPrimaryBusObId == other.CurrentPrimaryBusObId ||
					CurrentPrimaryBusObId != null &&
					CurrentPrimaryBusObId.Equals(other.CurrentPrimaryBusObId, StringComparison.Ordinal)
				) &&
				(
					CurrentPrimaryBusObRecId == other.CurrentPrimaryBusObRecId ||
					CurrentPrimaryBusObRecId != null &&
					CurrentPrimaryBusObRecId.Equals(other.CurrentPrimaryBusObRecId, StringComparison.Ordinal)
				) &&
				(
					HasNewAccessToken == other.HasNewAccessToken ||
					HasNewAccessToken != null &&
					HasNewAccessToken.Equals(other.HasNewAccessToken)
				) &&
				(
					NewAccessToken == other.NewAccessToken ||
					NewAccessToken != null &&
					NewAccessToken.Equals(other.NewAccessToken, StringComparison.Ordinal)
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
			if (Completed != null)
			{
				hash = hash * 59 + Completed.GetHashCode();
			}

			if (CurrentPrimaryBusObId != null)
			{
				hash = hash * 59 + CurrentPrimaryBusObId.GetHashCode();
			}

			if (CurrentPrimaryBusObRecId != null)
			{
				hash = hash * 59 + CurrentPrimaryBusObRecId.GetHashCode();
			}

			if (HasNewAccessToken != null)
			{
				hash = hash * 59 + HasNewAccessToken.GetHashCode();
			}

			if (NewAccessToken != null)
			{
				hash = hash * 59 + NewAccessToken.GetHashCode();
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
