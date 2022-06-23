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

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserV2
/// </summary>
[DataContract]
public partial class UserV2 : IEquatable<UserV2>, IValidatableObject
{
    /// <summary>
    /// Gets or Sets HttpStatusCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnumhttpStatusCode
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
    public EnumhttpStatusCode? HttpStatusCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserV2" /> class.
    /// </summary>
    /// <param name="accountLocked">AccountLocked.</param>
    /// <param name="createDateTime">CreateDateTime.</param>
    /// <param name="displayName">DisplayName.</param>
    /// <param name="fields">Fields.</param>
    /// <param name="lastPasswordResetDate">LastPasswordResetDate.</param>
    /// <param name="lastResetDateTime">LastResetDateTime.</param>
    /// <param name="ldapRequired">LdapRequired.</param>
    /// <param name="passwordNeverExpires">PasswordNeverExpires.</param>
    /// <param name="publicId">PublicId.</param>
    /// <param name="recordId">RecordId.</param>
    /// <param name="securityGroupId">SecurityGroupId.</param>
    /// <param name="shortdisplayName">ShortdisplayName.</param>
    /// <param name="userCannotChangePassword">UserCannotChangePassword.</param>
    /// <param name="userMustResetPasswordAtNextLogin">UserMustResetPasswordAtNextLogin.</param>
    /// <param name="errorCode">ErrorCode.</param>
    /// <param name="errorMessage">ErrorMessage.</param>
    /// <param name="hasError">HasError.</param>
    /// <param name="httpStatusCode">HttpStatusCode.</param>
    public UserV2(bool? accountLocked, DateTime? createDateTime, string displayName, List<FieldTemplateItem> fields, DateTime? lastPasswordResetDate, DateTime? lastResetDateTime, bool? ldapRequired, bool? passwordNeverExpires, string publicId, string recordId, string securityGroupId, string shortdisplayName, bool? userCannotChangePassword, bool? userMustResetPasswordAtNextLogin, string errorCode, string errorMessage, bool? hasError, EnumhttpStatusCode? httpStatusCode)
    {
        this.AccountLocked = accountLocked;
        this.CreateDateTime = createDateTime;
        this.DisplayName = displayName;
        this.Fields = fields;
        this.LastPasswordResetDate = lastPasswordResetDate;
        this.LastResetDateTime = lastResetDateTime;
        this.LdapRequired = ldapRequired;
        this.PasswordNeverExpires = passwordNeverExpires;
        this.PublicId = publicId;
        this.RecordId = recordId;
        this.SecurityGroupId = securityGroupId;
        this.ShortdisplayName = shortdisplayName;
        this.UserCannotChangePassword = userCannotChangePassword;
        this.UserMustResetPasswordAtNextLogin = userMustResetPasswordAtNextLogin;
        this.ErrorCode = errorCode;
        this.ErrorMessage = errorMessage;
        this.HasError = hasError;
        this.HttpStatusCode = httpStatusCode;
    }

    /// <summary>
    /// Gets or Sets AccountLocked
    /// </summary>
    [DataMember(Name = "accountLocked", EmitDefaultValue = false)]
    public bool? AccountLocked { get; set; }
    /// <summary>
    /// Gets or Sets CreateDateTime
    /// </summary>
    [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
    public DateTime? CreateDateTime { get; set; }
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }
    /// <summary>
    /// Gets or Sets Fields
    /// </summary>
    [DataMember(Name = "fields", EmitDefaultValue = false)]
    public List<FieldTemplateItem> Fields { get; set; }
    /// <summary>
    /// Gets or Sets LastPasswordResetDate
    /// </summary>
    [DataMember(Name = "lastPasswordResetDate", EmitDefaultValue = false)]
    public DateTime? LastPasswordResetDate { get; set; }
    /// <summary>
    /// Gets or Sets LastResetDateTime
    /// </summary>
    [DataMember(Name = "lastResetDateTime", EmitDefaultValue = false)]
    public DateTime? LastResetDateTime { get; set; }
    /// <summary>
    /// Gets or Sets LdapRequired
    /// </summary>
    [DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
    public bool? LdapRequired { get; set; }
    /// <summary>
    /// Gets or Sets PasswordNeverExpires
    /// </summary>
    [DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
    public bool? PasswordNeverExpires { get; set; }
    /// <summary>
    /// Gets or Sets PublicId
    /// </summary>
    [DataMember(Name = "publicId", EmitDefaultValue = false)]
    public string PublicId { get; set; }
    /// <summary>
    /// Gets or Sets RecordId
    /// </summary>
    [DataMember(Name = "recordId", EmitDefaultValue = false)]
    public string RecordId { get; set; }
    /// <summary>
    /// Gets or Sets SecurityGroupId
    /// </summary>
    [DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
    public string SecurityGroupId { get; set; }
    /// <summary>
    /// Gets or Sets ShortdisplayName
    /// </summary>
    [DataMember(Name = "shortdisplayName", EmitDefaultValue = false)]
    public string ShortdisplayName { get; set; }
    /// <summary>
    /// Gets or Sets UserCannotChangePassword
    /// </summary>
    [DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
    public bool? UserCannotChangePassword { get; set; }
    /// <summary>
    /// Gets or Sets UserMustResetPasswordAtNextLogin
    /// </summary>
    [DataMember(Name = "userMustResetPasswordAtNextLogin", EmitDefaultValue = false)]
    public bool? UserMustResetPasswordAtNextLogin { get; set; }
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
        sb.Append("class UserV2 {\n");
        sb.Append("  accountLocked: ").Append(AccountLocked).Append('\n');
        sb.Append("  createDateTime: ").Append(CreateDateTime).Append('\n');
        sb.Append("  displayName: ").Append(DisplayName).Append('\n');
        sb.Append("  fields: ").Append(Fields).Append('\n');
        sb.Append("  lastPasswordResetDate: ").Append(LastPasswordResetDate).Append('\n');
        sb.Append("  lastResetDateTime: ").Append(LastResetDateTime).Append('\n');
        sb.Append("  ldapRequired: ").Append(LdapRequired).Append('\n');
        sb.Append("  passwordNeverExpires: ").Append(PasswordNeverExpires).Append('\n');
        sb.Append("  publicId: ").Append(PublicId).Append('\n');
        sb.Append("  recordId: ").Append(RecordId).Append('\n');
        sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append('\n');
        sb.Append("  shortdisplayName: ").Append(ShortdisplayName).Append('\n');
        sb.Append("  userCannotChangePassword: ").Append(UserCannotChangePassword).Append('\n');
        sb.Append("  userMustResetPasswordAtNextLogin: ").Append(UserMustResetPasswordAtNextLogin).Append('\n');
        sb.Append("  errorCode: ").Append(ErrorCode).Append('\n');
        sb.Append("  errorMessage: ").Append(ErrorMessage).Append('\n');
        sb.Append("  hasError: ").Append(HasError).Append('\n');
        sb.Append("  httpStatusCode: ").Append(HttpStatusCode).Append('\n');
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
        return Equals(obj as UserV2);
    }

    /// <summary>
    /// Returns true if UserV2 instances are equal
    /// </summary>
    /// <param name="other">Instance of UserV2 to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserV2? other)
    {
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
            (
                AccountLocked == other.AccountLocked ||
                AccountLocked != null &&
                AccountLocked.Equals(other.AccountLocked)
            ) &&
            (
                CreateDateTime == other.CreateDateTime ||
                CreateDateTime != null &&
                CreateDateTime.Equals(other.CreateDateTime)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
            ) &&
            (
                Fields == other.Fields ||
                Fields != null &&
                Fields.SequenceEqual(other.Fields)
            ) &&
            (
                LastPasswordResetDate == other.LastPasswordResetDate ||
                LastPasswordResetDate != null &&
                LastPasswordResetDate.Equals(other.LastPasswordResetDate)
            ) &&
            (
                LastResetDateTime == other.LastResetDateTime ||
                LastResetDateTime != null &&
                LastResetDateTime.Equals(other.LastResetDateTime)
            ) &&
            (
                LdapRequired == other.LdapRequired ||
                LdapRequired != null &&
                LdapRequired.Equals(other.LdapRequired)
            ) &&
            (
                PasswordNeverExpires == other.PasswordNeverExpires ||
                PasswordNeverExpires != null &&
                PasswordNeverExpires.Equals(other.PasswordNeverExpires)
            ) &&
            (
                PublicId == other.PublicId ||
                PublicId != null &&
                PublicId.Equals(other.PublicId, StringComparison.Ordinal)
            ) &&
            (
                RecordId == other.RecordId ||
                RecordId != null &&
                RecordId.Equals(other.RecordId, StringComparison.Ordinal)
            ) &&
            (
                SecurityGroupId == other.SecurityGroupId ||
                SecurityGroupId != null &&
                SecurityGroupId.Equals(other.SecurityGroupId, StringComparison.Ordinal)
            ) &&
            (
                ShortdisplayName == other.ShortdisplayName ||
                ShortdisplayName != null &&
                ShortdisplayName.Equals(other.ShortdisplayName, StringComparison.Ordinal)
            ) &&
            (
                UserCannotChangePassword == other.UserCannotChangePassword ||
                UserCannotChangePassword != null &&
                UserCannotChangePassword.Equals(other.UserCannotChangePassword)
            ) &&
            (
                UserMustResetPasswordAtNextLogin == other.UserMustResetPasswordAtNextLogin ||
                UserMustResetPasswordAtNextLogin != null &&
                UserMustResetPasswordAtNextLogin.Equals(other.UserMustResetPasswordAtNextLogin)
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
            if (AccountLocked != null)
			{
				hash = hash * 59 + AccountLocked.GetHashCode();
			}

			if (CreateDateTime != null)
			{
				hash = hash * 59 + CreateDateTime.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (Fields != null)
			{
				hash = hash * 59 + Fields.GetHashCode();
			}

			if (LastPasswordResetDate != null)
			{
				hash = hash * 59 + LastPasswordResetDate.GetHashCode();
			}

			if (LastResetDateTime != null)
			{
				hash = hash * 59 + LastResetDateTime.GetHashCode();
			}

			if (LdapRequired != null)
			{
				hash = hash * 59 + LdapRequired.GetHashCode();
			}

			if (PasswordNeverExpires != null)
			{
				hash = hash * 59 + PasswordNeverExpires.GetHashCode();
			}

			if (PublicId != null)
			{
				hash = hash * 59 + PublicId.GetHashCode();
			}

			if (RecordId != null)
			{
				hash = hash * 59 + RecordId.GetHashCode();
			}

			if (SecurityGroupId != null)
			{
				hash = hash * 59 + SecurityGroupId.GetHashCode();
			}

			if (ShortdisplayName != null)
			{
				hash = hash * 59 + ShortdisplayName.GetHashCode();
			}

			if (UserCannotChangePassword != null)
			{
				hash = hash * 59 + UserCannotChangePassword.GetHashCode();
			}

			if (UserMustResetPasswordAtNextLogin != null)
			{
				hash = hash * 59 + UserMustResetPasswordAtNextLogin.GetHashCode();
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

