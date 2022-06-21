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

namespace Cherwell.Model
{
    /// <summary>
    /// UsersUserSaveRequest
    /// </summary>
    [DataContract]
    public partial class UsersUserSaveRequest :  IEquatable<UsersUserSaveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersUserSaveRequest" /> class.
        /// </summary>
        /// <param name="AccountLocked">AccountLocked.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObPublicId">BusObPublicId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Error">Error.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="LdapRequired">LdapRequired.</param>
        /// <param name="LoginId">LoginId.</param>
        /// <param name="NextPasswordResetDate">NextPasswordResetDate.</param>
        /// <param name="Password">Password.</param>
        /// <param name="PasswordNeverExpires">PasswordNeverExpires.</param>
        /// <param name="SecurityGroupId">SecurityGroupId.</param>
        /// <param name="UserCannotChangePassword">UserCannotChangePassword.</param>
        /// <param name="UserInfoFields">UserInfoFields.</param>
        /// <param name="UserMustChangePasswordAtNextLogin">UserMustChangePasswordAtNextLogin.</param>
        /// <param name="WindowsUserId">WindowsUserId.</param>
        public UsersUserSaveRequest(bool? AccountLocked = default(bool?), string BusObId = default(string), string BusObPublicId = default(string), string BusObRecId = default(string), string DisplayName = default(string), string Error = default(string), string ErrorCode = default(string), bool? HasError = default(bool?), bool? LdapRequired = default(bool?), string LoginId = default(string), DateTime? NextPasswordResetDate = default(DateTime?), string Password = default(string), bool? PasswordNeverExpires = default(bool?), string SecurityGroupId = default(string), bool? UserCannotChangePassword = default(bool?), List<BusinessObjectFieldTemplateItem> UserInfoFields = default(List<BusinessObjectFieldTemplateItem>), bool? UserMustChangePasswordAtNextLogin = default(bool?), string WindowsUserId = default(string))
        {
            this.AccountLocked = AccountLocked;
            this.BusObId = BusObId;
            this.BusObPublicId = BusObPublicId;
            this.BusObRecId = BusObRecId;
            this.DisplayName = DisplayName;
            this.Error = Error;
            this.ErrorCode = ErrorCode;
            this.HasError = HasError;
            this.LdapRequired = LdapRequired;
            this.LoginId = LoginId;
            this.NextPasswordResetDate = NextPasswordResetDate;
            this.Password = Password;
            this.PasswordNeverExpires = PasswordNeverExpires;
            this.SecurityGroupId = SecurityGroupId;
            this.UserCannotChangePassword = UserCannotChangePassword;
            this.UserInfoFields = UserInfoFields;
            this.UserMustChangePasswordAtNextLogin = UserMustChangePasswordAtNextLogin;
            this.WindowsUserId = WindowsUserId;
        }
        
        /// <summary>
        /// Gets or Sets AccountLocked
        /// </summary>
        [DataMember(Name="accountLocked", EmitDefaultValue=false)]
        public bool? AccountLocked { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }
        /// <summary>
        /// Gets or Sets LdapRequired
        /// </summary>
        [DataMember(Name="ldapRequired", EmitDefaultValue=false)]
        public bool? LdapRequired { get; set; }
        /// <summary>
        /// Gets or Sets LoginId
        /// </summary>
        [DataMember(Name="loginId", EmitDefaultValue=false)]
        public string LoginId { get; set; }
        /// <summary>
        /// Gets or Sets NextPasswordResetDate
        /// </summary>
        [DataMember(Name="nextPasswordResetDate", EmitDefaultValue=false)]
        public DateTime? NextPasswordResetDate { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets PasswordNeverExpires
        /// </summary>
        [DataMember(Name="passwordNeverExpires", EmitDefaultValue=false)]
        public bool? PasswordNeverExpires { get; set; }
        /// <summary>
        /// Gets or Sets SecurityGroupId
        /// </summary>
        [DataMember(Name="securityGroupId", EmitDefaultValue=false)]
        public string SecurityGroupId { get; set; }
        /// <summary>
        /// Gets or Sets UserCannotChangePassword
        /// </summary>
        [DataMember(Name="userCannotChangePassword", EmitDefaultValue=false)]
        public bool? UserCannotChangePassword { get; set; }
        /// <summary>
        /// Gets or Sets UserInfoFields
        /// </summary>
        [DataMember(Name="userInfoFields", EmitDefaultValue=false)]
        public List<BusinessObjectFieldTemplateItem> UserInfoFields { get; set; }
        /// <summary>
        /// Gets or Sets UserMustChangePasswordAtNextLogin
        /// </summary>
        [DataMember(Name="userMustChangePasswordAtNextLogin", EmitDefaultValue=false)]
        public bool? UserMustChangePasswordAtNextLogin { get; set; }
        /// <summary>
        /// Gets or Sets WindowsUserId
        /// </summary>
        [DataMember(Name="windowsUserId", EmitDefaultValue=false)]
        public string WindowsUserId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsersUserSaveRequest {\n");
            sb.Append("  AccountLocked: ").Append(AccountLocked).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  HasError: ").Append(HasError).Append("\n");
            sb.Append("  LdapRequired: ").Append(LdapRequired).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  NextPasswordResetDate: ").Append(NextPasswordResetDate).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append("\n");
            sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  UserCannotChangePassword: ").Append(UserCannotChangePassword).Append("\n");
            sb.Append("  UserInfoFields: ").Append(UserInfoFields).Append("\n");
            sb.Append("  UserMustChangePasswordAtNextLogin: ").Append(UserMustChangePasswordAtNextLogin).Append("\n");
            sb.Append("  WindowsUserId: ").Append(WindowsUserId).Append("\n");
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
            return this.Equals(obj as UsersUserSaveRequest);
        }

        /// <summary>
        /// Returns true if UsersUserSaveRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UsersUserSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsersUserSaveRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountLocked == other.AccountLocked ||
                    this.AccountLocked != null &&
                    this.AccountLocked.Equals(other.AccountLocked)
                ) && 
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId)
                ) && 
                (
                    this.BusObPublicId == other.BusObPublicId ||
                    this.BusObPublicId != null &&
                    this.BusObPublicId.Equals(other.BusObPublicId)
                ) && 
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.HasError == other.HasError ||
                    this.HasError != null &&
                    this.HasError.Equals(other.HasError)
                ) && 
                (
                    this.LdapRequired == other.LdapRequired ||
                    this.LdapRequired != null &&
                    this.LdapRequired.Equals(other.LdapRequired)
                ) && 
                (
                    this.LoginId == other.LoginId ||
                    this.LoginId != null &&
                    this.LoginId.Equals(other.LoginId)
                ) && 
                (
                    this.NextPasswordResetDate == other.NextPasswordResetDate ||
                    this.NextPasswordResetDate != null &&
                    this.NextPasswordResetDate.Equals(other.NextPasswordResetDate)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.PasswordNeverExpires == other.PasswordNeverExpires ||
                    this.PasswordNeverExpires != null &&
                    this.PasswordNeverExpires.Equals(other.PasswordNeverExpires)
                ) && 
                (
                    this.SecurityGroupId == other.SecurityGroupId ||
                    this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(other.SecurityGroupId)
                ) && 
                (
                    this.UserCannotChangePassword == other.UserCannotChangePassword ||
                    this.UserCannotChangePassword != null &&
                    this.UserCannotChangePassword.Equals(other.UserCannotChangePassword)
                ) && 
                (
                    this.UserInfoFields == other.UserInfoFields ||
                    this.UserInfoFields != null &&
                    this.UserInfoFields.SequenceEqual(other.UserInfoFields)
                ) && 
                (
                    this.UserMustChangePasswordAtNextLogin == other.UserMustChangePasswordAtNextLogin ||
                    this.UserMustChangePasswordAtNextLogin != null &&
                    this.UserMustChangePasswordAtNextLogin.Equals(other.UserMustChangePasswordAtNextLogin)
                ) && 
                (
                    this.WindowsUserId == other.WindowsUserId ||
                    this.WindowsUserId != null &&
                    this.WindowsUserId.Equals(other.WindowsUserId)
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
                if (this.AccountLocked != null)
                    hash = hash * 59 + this.AccountLocked.GetHashCode();
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.BusObPublicId != null)
                    hash = hash * 59 + this.BusObPublicId.GetHashCode();
                if (this.BusObRecId != null)
                    hash = hash * 59 + this.BusObRecId.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.HasError != null)
                    hash = hash * 59 + this.HasError.GetHashCode();
                if (this.LdapRequired != null)
                    hash = hash * 59 + this.LdapRequired.GetHashCode();
                if (this.LoginId != null)
                    hash = hash * 59 + this.LoginId.GetHashCode();
                if (this.NextPasswordResetDate != null)
                    hash = hash * 59 + this.NextPasswordResetDate.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.PasswordNeverExpires != null)
                    hash = hash * 59 + this.PasswordNeverExpires.GetHashCode();
                if (this.SecurityGroupId != null)
                    hash = hash * 59 + this.SecurityGroupId.GetHashCode();
                if (this.UserCannotChangePassword != null)
                    hash = hash * 59 + this.UserCannotChangePassword.GetHashCode();
                if (this.UserInfoFields != null)
                    hash = hash * 59 + this.UserInfoFields.GetHashCode();
                if (this.UserMustChangePasswordAtNextLogin != null)
                    hash = hash * 59 + this.UserMustChangePasswordAtNextLogin.GetHashCode();
                if (this.WindowsUserId != null)
                    hash = hash * 59 + this.WindowsUserId.GetHashCode();
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
