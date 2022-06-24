using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreStoredValueResponse
/// </summary>
[DataContract]
public partial class StoredValueResponse : IEquatable<StoredValueResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets StoredValueType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumStoredValueType
	{

		/// <summary>
		/// Enum Text for "Text"
		/// </summary>
		[EnumMember(Value = "Text")]
		Text,

		/// <summary>
		/// Enum Number for "Number"
		/// </summary>
		[EnumMember(Value = "Number")]
		Number,

		/// <summary>
		/// Enum DateTime for "DateTime"
		/// </summary>
		[EnumMember(Value = "DateTime")]
		DateTime,

		/// <summary>
		/// Enum Logical for "Logical"
		/// </summary>
		[EnumMember(Value = "Logical")]
		Logical,

		/// <summary>
		/// Enum Color for "Color"
		/// </summary>
		[EnumMember(Value = "Color")]
		Color,

		/// <summary>
		/// Enum Json for "Json"
		/// </summary>
		[EnumMember(Value = "Json")]
		Json,

		/// <summary>
		/// Enum JsonArray for "JsonArray"
		/// </summary>
		[EnumMember(Value = "JsonArray")]
		JsonArray,

		/// <summary>
		/// Enum Xml for "Xml"
		/// </summary>
		[EnumMember(Value = "Xml")]
		Xml,

		/// <summary>
		/// Enum XmlCollection for "XmlCollection"
		/// </summary>
		[EnumMember(Value = "XmlCollection")]
		XmlCollection
	}

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
	/// Gets or Sets StoredValueType
	/// </summary>
	[DataMember(Name = "storedValueType", EmitDefaultValue = false)]
	public EnumStoredValueType? StoredValueType { get; set; }

	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="StoredValueResponse" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="Folder">Folder.</param>
	/// <param name="Id">Id.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="StandInKey">StandInKey.</param>
	/// <param name="StoredValueType">StoredValueType.</param>
	/// <param name="Value">Value.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public StoredValueResponse(string Description, string Folder, string Id, string Name, string Scope, string ScopeOwner, string StandInKey, EnumStoredValueType? StoredValueType, string Value, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.Description = Description;
		this.Folder = Folder;
		this.Id = Id;
		this.Name = Name;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.StandInKey = StandInKey;
		this.StoredValueType = StoredValueType;
		this.Value = Value;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Gets or Sets Folder
	/// </summary>
	[DataMember(Name = "folder", EmitDefaultValue = false)]
	public string Folder { get; set; }

	/// <summary>
	/// Gets or Sets Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Gets or Sets Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; }

	/// <summary>
	/// Gets or Sets ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; }

	/// <summary>
	/// Gets or Sets StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }

	/// <summary>
	/// Gets or Sets Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; }

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
		sb.Append("class CoreStoredValueResponse {\n");
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  Folder: ").Append(Folder).Append('\n');
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
		sb.Append("  StoredValueType: ").Append(StoredValueType).Append('\n');
		sb.Append("  Value: ").Append(Value).Append('\n');
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
		return Equals(obj as StoredValueResponse);
	}

	/// <summary>
	/// Returns true if CoreStoredValueResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreStoredValueResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(StoredValueResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					Folder == other.Folder ||
					Folder != null &&
					Folder.Equals(other.Folder, StringComparison.Ordinal)
				) &&
				(
					Id == other.Id ||
					Id != null &&
					Id.Equals(other.Id, StringComparison.Ordinal)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					Scope == other.Scope ||
					Scope != null &&
					Scope.Equals(other.Scope, StringComparison.Ordinal)
				) &&
				(
					ScopeOwner == other.ScopeOwner ||
					ScopeOwner != null &&
					ScopeOwner.Equals(other.ScopeOwner, StringComparison.Ordinal)
				) &&
				(
					StandInKey == other.StandInKey ||
					StandInKey != null &&
					StandInKey.Equals(other.StandInKey, StringComparison.Ordinal)
				) &&
				(
					StoredValueType == other.StoredValueType ||
					StoredValueType != null &&
					StoredValueType.Equals(other.StoredValueType)
				) &&
				(
					Value == other.Value ||
					Value != null &&
					Value.Equals(other.Value, StringComparison.Ordinal)
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
			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (Folder != null)
			{
				hash = hash * 59 + Folder.GetHashCode();
			}

			if (Id != null)
			{
				hash = hash * 59 + Id.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (StandInKey != null)
			{
				hash = hash * 59 + StandInKey.GetHashCode();
			}

			if (StoredValueType != null)
			{
				hash = hash * 59 + StoredValueType.GetHashCode();
			}

			if (Value != null)
			{
				hash = hash * 59 + Value.GetHashCode();
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
