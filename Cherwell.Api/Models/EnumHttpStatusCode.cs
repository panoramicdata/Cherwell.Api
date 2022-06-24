using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Cherwell.Api.Models;

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