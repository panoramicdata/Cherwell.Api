using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// User
/// </summary>
[DataContract]
public partial class User : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="User" /> class.
	/// </summary>
	/// <param name="accountLocked">AccountLocked.</param>
	/// <param name="createDateTime">CreateDateTime.</param>
	/// <param name="displayName">DisplayName.</param>
	/// <param name="error">error.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="fields">Fields.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="lastPasswordResetDate">LastPasswordResetDate.</param>
	/// <param name="lastResetDateTime">LastResetDateTime.</param>
	/// <param name="ldapRequired">LdapRequired.</param>
	/// <param name="passwordNeverExpires">PasswordNeverExpires.</param>
	/// <param name="publicId">PublicId.</param>
	/// <param name="recordId">RecordId.</param>
	/// <param name="securityGroupId">SecurityGroupId.</param>
	/// <param name="shortDisplayName">shortDisplayName.</param>
	/// <param name="userCannotChangePassword">UserCannotChangePassword.</param>
	/// <param name="userMustResetPasswordAtNextLogin">UserMustResetPasswordAtNextLogin.</param>
	public User(bool? accountLocked, DateTime? createDateTime, string displayName, string error, string errorCode, List<FieldTemplateItem> fields, bool hasError, DateTime? lastPasswordResetDate, DateTime? lastResetDateTime, bool? ldapRequired, bool? passwordNeverExpires, string publicId, string recordId, string securityGroupId, string shortDisplayName, bool? userCannotChangePassword, bool? userMustResetPasswordAtNextLogin)
	{
		AccountLocked = accountLocked;
		CreateDateTime = createDateTime;
		DisplayName = displayName;
		Error = error;
		ErrorCode = errorCode;
		Fields = fields;
		HasError = hasError;
		LastPasswordResetDate = lastPasswordResetDate;
		LastResetDateTime = lastResetDateTime;
		LdapRequired = ldapRequired;
		PasswordNeverExpires = passwordNeverExpires;
		PublicId = publicId;
		RecordId = recordId;
		SecurityGroupId = securityGroupId;
		ShortDisplayName = shortDisplayName;
		UserCannotChangePassword = userCannotChangePassword;
		UserMustResetPasswordAtNextLogin = userMustResetPasswordAtNextLogin;
	}

	/// <summary>
	/// AccountLocked
	/// </summary>
	[DataMember(Name = "accountLocked", EmitDefaultValue = false)]
	public bool? AccountLocked { get; set; }

	/// <summary>
	/// CreateDateTime
	/// </summary>
	[DataMember(Name = "createDateTime", EmitDefaultValue = false)]
	public DateTime? CreateDateTime { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; }

	/// <summary>
	/// LastPasswordResetDate
	/// </summary>
	[DataMember(Name = "lastPasswordResetDate", EmitDefaultValue = false)]
	public DateTime? LastPasswordResetDate { get; set; }

	/// <summary>
	/// LastResetDateTime
	/// </summary>
	[DataMember(Name = "lastResetDateTime", EmitDefaultValue = false)]
	public DateTime? LastResetDateTime { get; set; }

	/// <summary>
	/// LdapRequired
	/// </summary>
	[DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
	public bool? LdapRequired { get; set; }

	/// <summary>
	/// PasswordNeverExpires
	/// </summary>
	[DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
	public bool? PasswordNeverExpires { get; set; }

	/// <summary>
	/// PublicId
	/// </summary>
	[DataMember(Name = "publicId", EmitDefaultValue = false)]
	public string PublicId { get; set; }

	/// <summary>
	/// RecordId
	/// </summary>
	[DataMember(Name = "recordId", EmitDefaultValue = false)]
	public string RecordId { get; set; }

	/// <summary>
	/// SecurityGroupId
	/// </summary>
	[DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
	public string SecurityGroupId { get; set; }

	/// <summary>
	/// shortDisplayName
	/// </summary>
	[DataMember(Name = "shortDisplayName", EmitDefaultValue = false)]
	public string ShortDisplayName { get; set; }

	/// <summary>
	/// UserCannotChangePassword
	/// </summary>
	[DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
	public bool? UserCannotChangePassword { get; set; }

	/// <summary>
	/// UserMustResetPasswordAtNextLogin
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
	/// Returns true if User instances are equal
	/// </summary>
	/// <param name="other">Instance of User to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(User? other)
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

			if (Error != null)
			{
				hash = hash * 59 + Error.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (Fields != null)
			{
				hash = hash * 59 + Fields.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
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

			if (ShortDisplayName != null)
			{
				hash = hash * 59 + ShortDisplayName.GetHashCode();
			}

			if (UserCannotChangePassword != null)
			{
				hash = hash * 59 + UserCannotChangePassword.GetHashCode();
			}

			if (UserMustResetPasswordAtNextLogin != null)
			{
				hash = hash * 59 + UserMustResetPasswordAtNextLogin.GetHashCode();
			}

			return hash;
		}
	}

	
}

