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

namespace Cherwell.Api.Models.Searches;

    /// <summary>
    /// SearchesSearchItemResponse
    /// </summary>
    [DataContract]
    public partial class SearchItemResponse : IEquatable<SearchItemResponse>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="SearchItemResponse" /> class.
        /// </summary>
        /// <param name="Root">Root.</param>
        /// <param name="SupportedAssociations">SupportedAssociations.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="HttpStatusCode">HttpStatusCode.</param>
        public SearchItemResponse(SearchFolder Root, List<Association> SupportedAssociations, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
        {
            this.Root = Root;
            this.SupportedAssociations = SupportedAssociations;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.HasError = HasError;
            this.HttpStatusCode = HttpStatusCode;
        }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false)]
        public SearchFolder Root { get; set; }
        /// <summary>
        /// Gets or Sets SupportedAssociations
        /// </summary>
        [DataMember(Name = "supportedAssociations", EmitDefaultValue = false)]
        public List<Association> SupportedAssociations { get; set; }
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
            sb.Append("class SearchesSearchItemResponse {\n");
            sb.Append("  Root: ").Append(Root).Append('\n');
            sb.Append("  SupportedAssociations: ").Append(SupportedAssociations).Append('\n');
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
            return this.Equals(obj as SearchItemResponse);
        }

        /// <summary>
        /// Returns true if SearchesSearchItemResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesSearchItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchItemResponse? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return
                (
                    this.Root == other.Root ||
                    this.Root != null &&
                    this.Root.Equals(other.Root)
                ) &&
                (
                    this.SupportedAssociations == other.SupportedAssociations ||
                    this.SupportedAssociations != null &&
                    this.SupportedAssociations.SequenceEqual(other.SupportedAssociations)
                ) &&
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
                ) &&
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
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
                if (this.Root != null)
			{
				hash = hash * 59 + this.Root.GetHashCode();
			}

			if (this.SupportedAssociations != null)
			{
				hash = hash * 59 + this.SupportedAssociations.GetHashCode();
			}

			if (this.ErrorCode != null)
			{
				hash = hash * 59 + this.ErrorCode.GetHashCode();
			}

			if (this.ErrorMessage != null)
			{
				hash = hash * 59 + this.ErrorMessage.GetHashCode();
			}

			if (this.HasError != null)
			{
				hash = hash * 59 + this.HasError.GetHashCode();
			}

			if (this.HttpStatusCode != null)
			{
				hash = hash * 59 + this.HttpStatusCode.GetHashCode();
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
