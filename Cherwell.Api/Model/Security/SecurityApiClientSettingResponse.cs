using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Cherwell.Api.Model.Security
{
    /// <summary>
    /// SecurityApiClientSettingResponse
    /// </summary>
    [DataContract]
    public partial class SecurityApiClientSettingResponse : IEquatable<SecurityApiClientSettingResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets HttpStatusCode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpStatusCodeEnum
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
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApiClientSettingResponse" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Culture">Culture.</param>
        /// <param name="ClientKey">ClientKey.</param>
        /// <param name="TokenLifespanMinutes">TokenLifespanMinutes.</param>
        /// <param name="RefreshTokenLifespanMinutes">RefreshTokenLifespanMinutes.</param>
        /// <param name="ApiAccessIsEnabled">ApiAccessIsEnabled.</param>
        /// <param name="AllowAnonymousAccess">AllowAnonymousAccess.</param>
        /// <param name="StandInKey">StandInKey.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="HttpStatusCode">HttpStatusCode.</param>
        public SecurityApiClientSettingResponse(string Name = default(string), string Description = default(string), string Culture = default(string), string ClientKey = default(string), int? TokenLifespanMinutes = default(int?), int? RefreshTokenLifespanMinutes = default(int?), bool? ApiAccessIsEnabled = default(bool?), bool? AllowAnonymousAccess = default(bool?), string StandInKey = default(string), string ErrorCode = default(string), string ErrorMessage = default(string), bool? HasError = default(bool?), HttpStatusCodeEnum? HttpStatusCode = default(HttpStatusCodeEnum?))
        {
            this.Name = Name;
            this.Description = Description;
            this.Culture = Culture;
            this.ClientKey = ClientKey;
            this.TokenLifespanMinutes = TokenLifespanMinutes;
            this.RefreshTokenLifespanMinutes = RefreshTokenLifespanMinutes;
            this.ApiAccessIsEnabled = ApiAccessIsEnabled;
            this.AllowAnonymousAccess = AllowAnonymousAccess;
            this.StandInKey = StandInKey;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.HasError = HasError;
            this.HttpStatusCode = HttpStatusCode;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Culture
        /// </summary>
        [DataMember(Name = "culture", EmitDefaultValue = false)]
        public string Culture { get; set; }
        /// <summary>
        /// Gets or Sets ClientKey
        /// </summary>
        [DataMember(Name = "clientKey", EmitDefaultValue = false)]
        public string ClientKey { get; set; }
        /// <summary>
        /// Gets or Sets TokenLifespanMinutes
        /// </summary>
        [DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
        public int? TokenLifespanMinutes { get; set; }
        /// <summary>
        /// Gets or Sets RefreshTokenLifespanMinutes
        /// </summary>
        [DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
        public int? RefreshTokenLifespanMinutes { get; set; }
        /// <summary>
        /// Gets or Sets ApiAccessIsEnabled
        /// </summary>
        [DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
        public bool? ApiAccessIsEnabled { get; set; }
        /// <summary>
        /// Gets or Sets AllowAnonymousAccess
        /// </summary>
        [DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
        public bool? AllowAnonymousAccess { get; set; }
        /// <summary>
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }
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
            sb.Append("class SecurityApiClientSettingResponse {\n");
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  Culture: ").Append(Culture).Append('\n');
            sb.Append("  ClientKey: ").Append(ClientKey).Append('\n');
            sb.Append("  TokenLifespanMinutes: ").Append(TokenLifespanMinutes).Append('\n');
            sb.Append("  RefreshTokenLifespanMinutes: ").Append(RefreshTokenLifespanMinutes).Append('\n');
            sb.Append("  ApiAccessIsEnabled: ").Append(ApiAccessIsEnabled).Append('\n');
            sb.Append("  AllowAnonymousAccess: ").Append(AllowAnonymousAccess).Append('\n');
            sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
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
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SecurityApiClientSettingResponse);
        }

        /// <summary>
        /// Returns true if SecurityApiClientSettingResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityApiClientSettingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityApiClientSettingResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Culture == other.Culture ||
                    this.Culture != null &&
                    this.Culture.Equals(other.Culture)
                ) &&
                (
                    this.ClientKey == other.ClientKey ||
                    this.ClientKey != null &&
                    this.ClientKey.Equals(other.ClientKey)
                ) &&
                (
                    this.TokenLifespanMinutes == other.TokenLifespanMinutes ||
                    this.TokenLifespanMinutes != null &&
                    this.TokenLifespanMinutes.Equals(other.TokenLifespanMinutes)
                ) &&
                (
                    this.RefreshTokenLifespanMinutes == other.RefreshTokenLifespanMinutes ||
                    this.RefreshTokenLifespanMinutes != null &&
                    this.RefreshTokenLifespanMinutes.Equals(other.RefreshTokenLifespanMinutes)
                ) &&
                (
                    this.ApiAccessIsEnabled == other.ApiAccessIsEnabled ||
                    this.ApiAccessIsEnabled != null &&
                    this.ApiAccessIsEnabled.Equals(other.ApiAccessIsEnabled)
                ) &&
                (
                    this.AllowAnonymousAccess == other.AllowAnonymousAccess ||
                    this.AllowAnonymousAccess != null &&
                    this.AllowAnonymousAccess.Equals(other.AllowAnonymousAccess)
                ) &&
                (
                    this.StandInKey == other.StandInKey ||
                    this.StandInKey != null &&
                    this.StandInKey.Equals(other.StandInKey)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) &&
                (
                    this.HasError == other.HasError ||
                    this.HasError != null &&
                    this.HasError.Equals(other.HasError)
                ) &&
                (
                    this.HttpStatusCode == other.HttpStatusCode ||
                    this.HttpStatusCode != null &&
                    this.HttpStatusCode.Equals(other.HttpStatusCode)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Culture != null)
                    hash = hash * 59 + this.Culture.GetHashCode();
                if (this.ClientKey != null)
                    hash = hash * 59 + this.ClientKey.GetHashCode();
                if (this.TokenLifespanMinutes != null)
                    hash = hash * 59 + this.TokenLifespanMinutes.GetHashCode();
                if (this.RefreshTokenLifespanMinutes != null)
                    hash = hash * 59 + this.RefreshTokenLifespanMinutes.GetHashCode();
                if (this.ApiAccessIsEnabled != null)
                    hash = hash * 59 + this.ApiAccessIsEnabled.GetHashCode();
                if (this.AllowAnonymousAccess != null)
                    hash = hash * 59 + this.AllowAnonymousAccess.GetHashCode();
                if (this.StandInKey != null)
                    hash = hash * 59 + this.StandInKey.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.HasError != null)
                    hash = hash * 59 + this.HasError.GetHashCode();
                if (this.HttpStatusCode != null)
                    hash = hash * 59 + this.HttpStatusCode.GetHashCode();
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
}
