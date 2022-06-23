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

namespace Cherwell.Api.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectSchemaResponse
    /// </summary>
    [DataContract]
    public partial class SchemaResponse : IEquatable<SchemaResponse>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="SchemaResponse" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="fieldDefinitions">FieldDefinitions.</param>
        /// <param name="firstRecIdField">FirstRecIdField.</param>
        /// <param name="GridDefinitions">GridDefinitions.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RecIdFields">RecIdFields.</param>
        /// <param name="Relationships">Relationships.</param>
        /// <param name="StateFieldId">StateFieldId.</param>
        /// <param name="states">States.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="ErrorMessage">ErrorMessage.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="HttpStatusCode">HttpStatusCode.</param>
        public SchemaResponse(string BusObId, List<FieldDefinition> fieldDefinitions, string firstRecIdField, List<GridDefinition> GridDefinitions, string Name, string RecIdFields, List<BusinessObjectRelationship> Relationships, string StateFieldId, string states, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
        {
            this.BusObId = BusObId;
            this.FieldDefinitions = fieldDefinitions;
            this.FirstRecIdField = firstRecIdField;
            this.GridDefinitions = GridDefinitions;
            this.Name = Name;
            this.RecIdFields = RecIdFields;
            this.Relationships = Relationships;
            this.StateFieldId = StateFieldId;
            this.States = states;
            this.ErrorCode = ErrorCode;
            this.ErrorMessage = ErrorMessage;
            this.HasError = HasError;
            this.HttpStatusCode = HttpStatusCode;
        }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets FieldDefinitions
        /// </summary>
        [DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
        public List<FieldDefinition> FieldDefinitions { get; set; }
        /// <summary>
        /// Gets or Sets FirstRecIdField
        /// </summary>
        [DataMember(Name = "firstRecIdField", EmitDefaultValue = false)]
        public string FirstRecIdField { get; set; }
        /// <summary>
        /// Gets or Sets GridDefinitions
        /// </summary>
        [DataMember(Name = "gridDefinitions", EmitDefaultValue = false)]
        public List<GridDefinition> GridDefinitions { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RecIdFields
        /// </summary>
        [DataMember(Name = "recIdFields", EmitDefaultValue = false)]
        public string RecIdFields { get; set; }
        /// <summary>
        /// Gets or Sets Relationships
        /// </summary>
        [DataMember(Name = "relationships", EmitDefaultValue = false)]
        public List<BusinessObjectRelationship> Relationships { get; set; }
        /// <summary>
        /// Gets or Sets StateFieldId
        /// </summary>
        [DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
        public string StateFieldId { get; set; }
        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [DataMember(Name = "states", EmitDefaultValue = false)]
        public string States { get; set; }
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
            sb.Append("class BusinessObjectSchemaResponse {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append('\n');
            sb.Append("  FirstRecIdField: ").Append(FirstRecIdField).Append('\n');
            sb.Append("  GridDefinitions: ").Append(GridDefinitions).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  RecIdFields: ").Append(RecIdFields).Append('\n');
            sb.Append("  Relationships: ").Append(Relationships).Append('\n');
            sb.Append("  StateFieldId: ").Append(StateFieldId).Append('\n');
            sb.Append("  States: ").Append(States).Append('\n');
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
            return this.Equals(obj as SchemaResponse);
        }

        /// <summary>
        /// Returns true if BusinessObjectSchemaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectSchemaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemaResponse? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
					this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
                (
                    this.FieldDefinitions == other.FieldDefinitions ||
                    this.FieldDefinitions != null &&
                    this.FieldDefinitions.SequenceEqual(other.FieldDefinitions)
                ) &&
                (
                    this.FirstRecIdField == other.FirstRecIdField ||
                    this.FirstRecIdField != null &&
                    this.FirstRecIdField.Equals(other.FirstRecIdField, StringComparison.Ordinal)
                ) &&
                (
                    this.GridDefinitions == other.GridDefinitions ||
                    this.GridDefinitions != null &&
                    this.GridDefinitions.SequenceEqual(other.GridDefinitions)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name, StringComparison.Ordinal)
                ) &&
                (
                    this.RecIdFields == other.RecIdFields ||
                    this.RecIdFields != null &&
                    this.RecIdFields.Equals(other.RecIdFields, StringComparison.Ordinal)
                ) &&
                (
                    this.Relationships == other.Relationships ||
                    this.Relationships != null &&
                    this.Relationships.SequenceEqual(other.Relationships)
                ) &&
                (
                    this.StateFieldId == other.StateFieldId ||
                    this.StateFieldId != null &&
                    this.StateFieldId.Equals(other.StateFieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.States == other.States ||
                    this.States != null &&
                    this.States.Equals(other.States, StringComparison.Ordinal)
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
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.FieldDefinitions != null)
                    hash = hash * 59 + this.FieldDefinitions.GetHashCode();
                if (this.FirstRecIdField != null)
                    hash = hash * 59 + this.FirstRecIdField.GetHashCode();
                if (this.GridDefinitions != null)
                    hash = hash * 59 + this.GridDefinitions.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RecIdFields != null)
                    hash = hash * 59 + this.RecIdFields.GetHashCode();
                if (this.Relationships != null)
                    hash = hash * 59 + this.Relationships.GetHashCode();
                if (this.StateFieldId != null)
                    hash = hash * 59 + this.StateFieldId.GetHashCode();
                if (this.States != null)
                    hash = hash * 59 + this.States.GetHashCode();
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