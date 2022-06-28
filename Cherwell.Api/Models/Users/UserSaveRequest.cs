using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserSaveRequest
/// </summary>
[DataContract]
public partial class UserSaveRequest : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserSaveRequest" /> class.
	/// </summary>
	/// <param name="accountLocked">AccountLocked.</param>
	/// <param name="busObId">BusObId.</param>
	/// <param name="busObPublicId">BusObPublicId.</param>
	/// <param name="busObRecId">BusObRecId.</param>
	/// <param name="displayName">DisplayName.</param>
	/// <param name="error">Error.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="ldapRequired">LdapRequired.</param>
	/// <param name="loginId">LoginId.</param>
	/// <param name="nextPasswordResetDate">NextPasswordResetDate.</param>
	/// <param name="password">Password.</param>
	/// <param name="passwordNeverExpires">PasswordNeverExpires.</param>
	/// <param name="securityGroupId">SecurityGroupId.</param>
	/// <param name="userCannotChangePassword">UserCannotChangePassword.</param>
	/// <param name="userInfoFields">UserInfoFields.</param>
	/// <param name="userMustChangePasswordAtNextLogin">UserMustChangePasswordAtNextLogin.</param>
	/// <param name="windowsUserId">WindowsUserId.</param>
	public UserSaveRequest(
		bool? accountLocked,
		string busObId,
		string busObPublicId,
		string busObRecId,
		string displayName,
		string error,
		string errorCode,
		bool hasError,
		bool? ldapRequired,
		string loginId,
		DateTime? nextPasswordResetDate,
		string password,
		bool? passwordNeverExpires,
		string securityGroupId,
		bool? userCannotChangePassword,
		List<FieldTemplateItem> userInfoFields,
		bool? userMustChangePasswordAtNextLogin,
		string windowsUserId)
	{
		AccountLocked = accountLocked;
		BusObId = busObId;
		BusObPublicId = busObPublicId;
		BusObRecId = busObRecId;
		DisplayName = displayName;
		Error = error;
		ErrorCode = errorCode;
		HasError = hasError;
		LdapRequired = ldapRequired;
		LoginId = loginId;
		NextPasswordResetDate = nextPasswordResetDate;
		Password = password;
		PasswordNeverExpires = passwordNeverExpires;
		SecurityGroupId = securityGroupId;
		UserCannotChangePassword = userCannotChangePassword;
		UserInfoFields = userInfoFields;
		UserMustChangePasswordAtNextLogin = userMustChangePasswordAtNextLogin;
		WindowsUserId = windowsUserId;
	}

	/// <summary>
	/// AccountLocked
	/// </summary>
	[DataMember(Name = "accountLocked", EmitDefaultValue = false)]
	public bool? AccountLocked { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }

	/// <summary>
	/// LdapRequired
	/// </summary>
	[DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
	public bool? LdapRequired { get; set; }

	/// <summary>
	/// LoginId
	/// </summary>
	[DataMember(Name = "loginId", EmitDefaultValue = false)]
	public string LoginId { get; set; }

	/// <summary>
	/// NextPasswordResetDate
	/// </summary>
	[DataMember(Name = "nextPasswordResetDate", EmitDefaultValue = false)]
	public DateTime? NextPasswordResetDate { get; set; }

	/// <summary>
	/// Password
	/// </summary>
	[DataMember(Name = "password", EmitDefaultValue = false)]
	public string Password { get; set; }

	/// <summary>
	/// PasswordNeverExpires
	/// </summary>
	[DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
	public bool? PasswordNeverExpires { get; set; }

	/// <summary>
	/// SecurityGroupId
	/// </summary>
	[DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
	public string SecurityGroupId { get; set; }

	/// <summary>
	/// UserCannotChangePassword
	/// </summary>
	[DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
	public bool? UserCannotChangePassword { get; set; }

	/// <summary>
	/// UserInfoFields
	/// </summary>
	[DataMember(Name = "userInfoFields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> UserInfoFields { get; set; }

	/// <summary>
	/// UserMustChangePasswordAtNextLogin
	/// </summary>
	[DataMember(Name = "userMustChangePasswordAtNextLogin", EmitDefaultValue = false)]
	public bool? UserMustChangePasswordAtNextLogin { get; set; }

	/// <summary>
	/// WindowsUserId
	/// </summary>
	[DataMember(Name = "windowsUserId", EmitDefaultValue = false)]
	public string WindowsUserId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserSaveRequest {\n");
		sb.Append("  AccountLocked: ").Append(AccountLocked).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  Error: ").Append(Error).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  LdapRequired: ").Append(LdapRequired).Append('\n');
		sb.Append("  LoginId: ").Append(LoginId).Append('\n');
		sb.Append("  NextPasswordResetDate: ").Append(NextPasswordResetDate).Append('\n');
		sb.Append("  Password: ").Append(Password).Append('\n');
		sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append('\n');
		sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append('\n');
		sb.Append("  UserCannotChangePassword: ").Append(UserCannotChangePassword).Append('\n');
		sb.Append("  UserInfoFields: ").Append(UserInfoFields).Append('\n');
		sb.Append("  UserMustChangePasswordAtNextLogin: ").Append(UserMustChangePasswordAtNextLogin).Append('\n');
		sb.Append("  WindowsUserId: ").Append(WindowsUserId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if UserSaveRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of UserSaveRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(UserSaveRequest? other)
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
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObPublicId == other.BusObPublicId ||
					BusObPublicId != null &&
					BusObPublicId.Equals(other.BusObPublicId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
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
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					LdapRequired == other.LdapRequired ||
					LdapRequired != null &&
					LdapRequired.Equals(other.LdapRequired)
				) &&
				(
					LoginId == other.LoginId ||
					LoginId != null &&
					LoginId.Equals(other.LoginId, StringComparison.Ordinal)
				) &&
				(
					NextPasswordResetDate == other.NextPasswordResetDate ||
					NextPasswordResetDate != null &&
					NextPasswordResetDate.Equals(other.NextPasswordResetDate)
				) &&
				(
					Password == other.Password ||
					Password != null &&
					Password.Equals(other.Password, StringComparison.Ordinal)
				) &&
				(
					PasswordNeverExpires == other.PasswordNeverExpires ||
					PasswordNeverExpires != null &&
					PasswordNeverExpires.Equals(other.PasswordNeverExpires)
				) &&
				(
					SecurityGroupId == other.SecurityGroupId ||
					SecurityGroupId != null &&
					SecurityGroupId.Equals(other.SecurityGroupId, StringComparison.Ordinal)
				) &&
				(
					UserCannotChangePassword == other.UserCannotChangePassword ||
					UserCannotChangePassword != null &&
					UserCannotChangePassword.Equals(other.UserCannotChangePassword)
				) &&
				(
					UserInfoFields == other.UserInfoFields ||
					UserInfoFields != null &&
					UserInfoFields.SequenceEqual(other.UserInfoFields)
				) &&
				(
					UserMustChangePasswordAtNextLogin == other.UserMustChangePasswordAtNextLogin ||
					UserMustChangePasswordAtNextLogin != null &&
					UserMustChangePasswordAtNextLogin.Equals(other.UserMustChangePasswordAtNextLogin)
				) &&
				(
					WindowsUserId == other.WindowsUserId ||
					WindowsUserId != null &&
					WindowsUserId.Equals(other.WindowsUserId, StringComparison.Ordinal)
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

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
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

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (LdapRequired != null)
			{
				hash = hash * 59 + LdapRequired.GetHashCode();
			}

			if (LoginId != null)
			{
				hash = hash * 59 + LoginId.GetHashCode();
			}

			if (NextPasswordResetDate != null)
			{
				hash = hash * 59 + NextPasswordResetDate.GetHashCode();
			}

			if (Password != null)
			{
				hash = hash * 59 + Password.GetHashCode();
			}

			if (PasswordNeverExpires != null)
			{
				hash = hash * 59 + PasswordNeverExpires.GetHashCode();
			}

			if (SecurityGroupId != null)
			{
				hash = hash * 59 + SecurityGroupId.GetHashCode();
			}

			if (UserCannotChangePassword != null)
			{
				hash = hash * 59 + UserCannotChangePassword.GetHashCode();
			}

			if (UserInfoFields != null)
			{
				hash = hash * 59 + UserInfoFields.GetHashCode();
			}

			if (UserMustChangePasswordAtNextLogin != null)
			{
				hash = hash * 59 + UserMustChangePasswordAtNextLogin.GetHashCode();
			}

			if (WindowsUserId != null)
			{
				hash = hash * 59 + WindowsUserId.GetHashCode();
			}

			return hash;
		}
	}

	
}

