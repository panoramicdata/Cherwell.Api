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

namespace Cherwell.Api.Model.Users
{
    /// <summary>
    /// User
    /// </summary>
    [DataContract]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="AccountLocked">AccountLocked.</param>
        /// <param name="CreateDateTime">CreateDateTime.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Error">Error.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="LastPasswordResetDate">LastPasswordResetDate.</param>
        /// <param name="LastResetDateTime">LastResetDateTime.</param>
        /// <param name="LdapRequired">LdapRequired.</param>
        /// <param name="PasswordNeverExpires">PasswordNeverExpires.</param>
        /// <param name="PublicId">PublicId.</param>
        /// <param name="RecordId">RecordId.</param>
        /// <param name="SecurityGroupId">SecurityGroupId.</param>
        /// <param name="ShortDisplayName">ShortDisplayName.</param>
        /// <param name="UserCannotChangePassword">UserCannotChangePassword.</param>
        /// <param name="UserMustResetPasswordAtNextLogin">UserMustResetPasswordAtNextLogin.</param>
        public User(bool? AccountLocked = default, DateTime? CreateDateTime = default, string DisplayName = default, string Error = default, string ErrorCode = default, List<FieldTemplateItem> Fields = default, bool? HasError = default, DateTime? LastPasswordResetDate = default, DateTime? LastResetDateTime = default, bool? LdapRequired = default, bool? PasswordNeverExpires = default, string PublicId = default, string RecordId = default, string SecurityGroupId = default, string ShortDisplayName = default, bool? UserCannotChangePassword = default, bool? UserMustResetPasswordAtNextLogin = default)
        {
            this.AccountLocked = AccountLocked;
            this.CreateDateTime = CreateDateTime;
            this.DisplayName = DisplayName;
            this.Error = Error;
            this.ErrorCode = ErrorCode;
            this.Fields = Fields;
            this.HasError = HasError;
            this.LastPasswordResetDate = LastPasswordResetDate;
            this.LastResetDateTime = LastResetDateTime;
            this.LdapRequired = LdapRequired;
            this.PasswordNeverExpires = PasswordNeverExpires;
            this.PublicId = PublicId;
            this.RecordId = RecordId;
            this.SecurityGroupId = SecurityGroupId;
            this.ShortDisplayName = ShortDisplayName;
            this.UserCannotChangePassword = UserCannotChangePassword;
            this.UserMustResetPasswordAtNextLogin = UserMustResetPasswordAtNextLogin;
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
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> Fields { get; set; }
        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }
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
        /// Gets or Sets ShortDisplayName
        /// </summary>
        [DataMember(Name = "shortDisplayName", EmitDefaultValue = false)]
        public string ShortDisplayName { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  AccountLocked: ").Append(AccountLocked).Append('\n');
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append('\n');
            sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
            sb.Append("  Error: ").Append(Error).Append('\n');
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
            sb.Append("  Fields: ").Append(Fields).Append('\n');
            sb.Append("  HasError: ").Append(HasError).Append('\n');
            sb.Append("  LastPasswordResetDate: ").Append(LastPasswordResetDate).Append('\n');
            sb.Append("  LastResetDateTime: ").Append(LastResetDateTime).Append('\n');
            sb.Append("  LdapRequired: ").Append(LdapRequired).Append('\n');
            sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append('\n');
            sb.Append("  PublicId: ").Append(PublicId).Append('\n');
            sb.Append("  RecordId: ").Append(RecordId).Append('\n');
            sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append('\n');
            sb.Append("  ShortDisplayName: ").Append(ShortDisplayName).Append('\n');
            sb.Append("  UserCannotChangePassword: ").Append(UserCannotChangePassword).Append('\n');
            sb.Append("  UserMustResetPasswordAtNextLogin: ").Append(UserMustResetPasswordAtNextLogin).Append('\n');
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
            return Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

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
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error, StringComparison.Ordinal)
                ) &&
                (
                    ErrorCode == other.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
                ) &&
                (
                    Fields == other.Fields ||
                    Fields != null &&
                    Fields.SequenceEqual(other.Fields)
                ) &&
                (
                    HasError == other.HasError ||
                    HasError != null &&
                    HasError.Equals(other.HasError)
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
                    ShortDisplayName == other.ShortDisplayName ||
                    ShortDisplayName != null &&
                    ShortDisplayName.Equals(other.ShortDisplayName, StringComparison.Ordinal)
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
                    hash = hash * 59 + AccountLocked.GetHashCode();
                if (CreateDateTime != null)
                    hash = hash * 59 + CreateDateTime.GetHashCode();
                if (DisplayName != null)
                    hash = hash * 59 + DisplayName.GetHashCode();
                if (Error != null)
                    hash = hash * 59 + Error.GetHashCode();
                if (ErrorCode != null)
                    hash = hash * 59 + ErrorCode.GetHashCode();
                if (Fields != null)
                    hash = hash * 59 + Fields.GetHashCode();
                if (HasError != null)
                    hash = hash * 59 + HasError.GetHashCode();
                if (LastPasswordResetDate != null)
                    hash = hash * 59 + LastPasswordResetDate.GetHashCode();
                if (LastResetDateTime != null)
                    hash = hash * 59 + LastResetDateTime.GetHashCode();
                if (LdapRequired != null)
                    hash = hash * 59 + LdapRequired.GetHashCode();
                if (PasswordNeverExpires != null)
                    hash = hash * 59 + PasswordNeverExpires.GetHashCode();
                if (PublicId != null)
                    hash = hash * 59 + PublicId.GetHashCode();
                if (RecordId != null)
                    hash = hash * 59 + RecordId.GetHashCode();
                if (SecurityGroupId != null)
                    hash = hash * 59 + SecurityGroupId.GetHashCode();
                if (ShortDisplayName != null)
                    hash = hash * 59 + ShortDisplayName.GetHashCode();
                if (UserCannotChangePassword != null)
                    hash = hash * 59 + UserCannotChangePassword.GetHashCode();
                if (UserMustResetPasswordAtNextLogin != null)
                    hash = hash * 59 + UserMustResetPasswordAtNextLogin.GetHashCode();
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