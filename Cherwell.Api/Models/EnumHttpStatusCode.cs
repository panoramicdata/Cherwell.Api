using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Cherwell.Api.Models;

/// <summary>
/// HttpStatusCode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EnumHttpStatusCode
{
	/// <summary>
	/// None
	/// </summary>
	None = 0,

	/// <summary>
	/// Enum Continue for "Continue"
	/// </summary>
	[EnumMember(Value = "Continue")]
	Continue = 100,

	/// <summary>
	/// Enum SwitchingProtocols for "SwitchingProtocols"
	/// </summary>
	[EnumMember(Value = "SwitchingProtocols")]
	SwitchingProtocols = 101,

	/// <summary>
	/// Enum OK for "OK"
	/// </summary>
	[EnumMember(Value = "OK")]
	OK = 200,

	/// <summary>
	/// Enum Created for "Created"
	/// </summary>
	[EnumMember(Value = "Created")]
	Created = 201,

	/// <summary>
	/// Enum Accepted for "Accepted"
	/// </summary>
	[EnumMember(Value = "Accepted")]
	Accepted = 202,

	/// <summary>
	/// Enum NonAuthoritativeInformation for "NonAuthoritativeInformation"
	/// </summary>
	[EnumMember(Value = "NonAuthoritativeInformation")]
	NonAuthoritativeInformation = 203,

	/// <summary>
	/// Enum NoContent for "NoContent"
	/// </summary>
	[EnumMember(Value = "NoContent")]
	NoContent = 204,

	/// <summary>
	/// Enum ResetContent for "ResetContent"
	/// </summary>
	[EnumMember(Value = "ResetContent")]
	ResetContent = 205,

	/// <summary>
	/// Enum PartialContent for "PartialContent"
	/// </summary>
	[EnumMember(Value = "PartialContent")]
	PartialContent = 206,

	/// <summary>
	/// Enum MultipleChoices for "MultipleChoices"
	/// </summary>
	[EnumMember(Value = "MultipleChoices")]
	MultipleChoices = 300,

	/// <summary>
	/// Enum Ambiguous for "Ambiguous"
	/// </summary>
	[EnumMember(Value = "Ambiguous")]
	Ambiguous,

	/// <summary>
	/// Enum MovedPermanently for "MovedPermanently"
	/// </summary>
	[EnumMember(Value = "MovedPermanently")]
	MovedPermanently = 301,

	/// <summary>
	/// Enum Moved for "Moved"
	/// </summary>
	[EnumMember(Value = "Moved")]
	Moved = 301,

	/// <summary>
	/// Enum Found for "Found"
	/// </summary>
	[EnumMember(Value = "Found")]
	Found = 302,

	/// <summary>
	/// Enum Redirect for "Redirect"
	/// </summary>
	[EnumMember(Value = "Redirect")]
	Redirect = 308,

	/// <summary>
	/// Enum SeeOther for "SeeOther"
	/// </summary>
	[EnumMember(Value = "SeeOther")]
	SeeOther = 303,

	/// <summary>
	/// Enum RedirectMethod for "RedirectMethod"
	/// </summary>
	[EnumMember(Value = "RedirectMethod")]
	RedirectMethod = 308,

	/// <summary>
	/// Enum NotModified for "NotModified"
	/// </summary>
	[EnumMember(Value = "NotModified")]
	NotModified = 304,

	/// <summary>
	/// Enum UseProxy for "UseProxy"
	/// </summary>
	[EnumMember(Value = "UseProxy")]
	UseProxy = 305,

	/// <summary>
	/// Enum Unused for "Unused"
	/// </summary>
	[EnumMember(Value = "Unused")]
	Unused = 306,

	/// <summary>
	/// Enum TemporaryRedirect for "TemporaryRedirect"
	/// </summary>
	[EnumMember(Value = "TemporaryRedirect")]
	TemporaryRedirect = 307,

	/// <summary>
	/// Enum RedirectKeepVerb for "RedirectKeepVerb"
	/// </summary>
	[EnumMember(Value = "RedirectKeepVerb")]
	RedirectKeepVerb = 308,

	/// <summary>
	/// Enum BadRequest for "BadRequest"
	/// </summary>
	[EnumMember(Value = "BadRequest")]
	BadRequest = 400,

	/// <summary>
	/// Enum Unauthorized for "Unauthorized"
	/// </summary>
	[EnumMember(Value = "Unauthorized")]
	Unauthorized = 401,

	/// <summary>
	/// Enum PaymentRequired for "PaymentRequired"
	/// </summary>
	[EnumMember(Value = "PaymentRequired")]
	PaymentRequired = 402,

	/// <summary>
	/// Enum Forbidden for "Forbidden"
	/// </summary>
	[EnumMember(Value = "Forbidden")]
	Forbidden = 403,

	/// <summary>
	/// Enum NotFound for "NotFound"
	/// </summary>
	[EnumMember(Value = "NotFound")]
	NotFound = 404,

	/// <summary>
	/// Enum MethodNotAllowed for "MethodNotAllowed"
	/// </summary>
	[EnumMember(Value = "MethodNotAllowed")]
	MethodNotAllowed = 405,

	/// <summary>
	/// Enum NotAcceptable for "NotAcceptable"
	/// </summary>
	[EnumMember(Value = "NotAcceptable")]
	NotAcceptable = 406,

	/// <summary>
	/// Enum ProxyAuthenticationRequired for "ProxyAuthenticationRequired"
	/// </summary>
	[EnumMember(Value = "ProxyAuthenticationRequired")]
	ProxyAuthenticationRequired = 407,

	/// <summary>
	/// Enum RequestTimeout for "RequestTimeout"
	/// </summary>
	[EnumMember(Value = "RequestTimeout")]
	RequestTimeout = 408,

	/// <summary>
	/// Enum Conflict for "Conflict"
	/// </summary>
	[EnumMember(Value = "Conflict")]
	Conflict = 409,

	/// <summary>
	/// Enum Gone for "Gone"
	/// </summary>
	[EnumMember(Value = "Gone")]
	Gone = 410,

	/// <summary>
	/// Enum LengthRequired for "LengthRequired"
	/// </summary>
	[EnumMember(Value = "LengthRequired")]
	LengthRequired = 411,

	/// <summary>
	/// Enum PreconditionFailed for "PreconditionFailed"
	/// </summary>
	[EnumMember(Value = "PreconditionFailed")]
	PreconditionFailed = 412,

	/// <summary>
	/// Enum RequestEntityTooLarge for "RequestEntityTooLarge"
	/// </summary>
	[EnumMember(Value = "RequestEntityTooLarge")]
	RequestEntityTooLarge = 413,

	/// <summary>
	/// Enum RequestUriTooLong for "RequestUriTooLong"
	/// </summary>
	[EnumMember(Value = "RequestUriTooLong")]
	RequestUriTooLong = 414,

	/// <summary>
	/// Enum UnsupportedMediaType for "UnsupportedMediaType"
	/// </summary>
	[EnumMember(Value = "UnsupportedMediaType")]
	UnsupportedMediaType = 415,

	/// <summary>
	/// Enum RequestedRangeNotSatisfiable for "RequestedRangeNotSatisfiable"
	/// </summary>
	[EnumMember(Value = "RequestedRangeNotSatisfiable")]
	RequestedRangeNotSatisfiable = 416,

	/// <summary>
	/// Enum ExpectationFailed for "ExpectationFailed"
	/// </summary>
	[EnumMember(Value = "ExpectationFailed")]
	ExpectationFailed = 417,

	/// <summary>
	/// Enum UpgradeRequired for "UpgradeRequired"
	/// </summary>
	[EnumMember(Value = "UpgradeRequired")]
	UpgradeRequired = 426,

	/// <summary>
	/// Enum InternalServerError for "InternalServerError"
	/// </summary>
	[EnumMember(Value = "InternalServerError")]
	InternalServerError = 500,

	/// <summary>
	/// Enum NotImplemented for "NotImplemented"
	/// </summary>
	[EnumMember(Value = "NotImplemented")]
	NotImplemented = 501,

	/// <summary>
	/// Enum BadGateway for "BadGateway"
	/// </summary>
	[EnumMember(Value = "BadGateway")]
	BadGateway = 502,

	/// <summary>
	/// Enum ServiceUnavailable for "ServiceUnavailable"
	/// </summary>
	[EnumMember(Value = "ServiceUnavailable")]
	ServiceUnavailable = 503,

	/// <summary>
	/// Enum GatewayTimeout for "GatewayTimeout"
	/// </summary>
	[EnumMember(Value = "GatewayTimeout")]
	GatewayTimeout = 504,

	/// <summary>
	/// Enum HttpVersionNotSupported for "HttpVersionNotSupported"
	/// </summary>
	[EnumMember(Value = "HttpVersionNotSupported")]
	HttpVersionNotSupported = 505
}