using System.Runtime.Serialization;

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
		bool accountLocked,
		string busObId,
		string busObPublicId,
		string busObRecId,
		string displayName,
		string error,
		string errorCode,
		bool hasError,
		bool ldapRequired,
		string loginId,
		DateTime nextPasswordResetDate,
		string password,
		bool passwordNeverExpires,
		string securityGroupId,
		bool userCannotChangePassword,
		List<FieldTemplateItem> userInfoFields,
		bool userMustChangePasswordAtNextLogin,
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
	public bool AccountLocked { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; } = null!;

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; } = null!;

	/// <summary>
	/// LdapRequired
	/// </summary>
	[DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
	public bool LdapRequired { get; set; }

	/// <summary>
	/// LoginId
	/// </summary>
	[DataMember(Name = "loginId", EmitDefaultValue = false)]
	public string LoginId { get; set; } = null!;

	/// <summary>
	/// NextPasswordResetDate
	/// </summary>
	[DataMember(Name = "nextPasswordResetDate", EmitDefaultValue = false)]
	public DateTime NextPasswordResetDate { get; set; }

	/// <summary>
	/// Password
	/// </summary>
	[DataMember(Name = "password", EmitDefaultValue = false)]
	public string Password { get; set; } = null!;

	/// <summary>
	/// PasswordNeverExpires
	/// </summary>
	[DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
	public bool PasswordNeverExpires { get; set; }

	/// <summary>
	/// SecurityGroupId
	/// </summary>
	[DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
	public string SecurityGroupId { get; set; } = null!;

	/// <summary>
	/// UserCannotChangePassword
	/// </summary>
	[DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
	public bool UserCannotChangePassword { get; set; }

	/// <summary>
	/// UserInfoFields
	/// </summary>
	[DataMember(Name = "userInfoFields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> UserInfoFields { get; set; } = null!;

	/// <summary>
	/// UserMustChangePasswordAtNextLogin
	/// </summary>
	[DataMember(Name = "userMustChangePasswordAtNextLogin", EmitDefaultValue = false)]
	public bool UserMustChangePasswordAtNextLogin { get; set; }

	/// <summary>
	/// WindowsUserId
	/// </summary>
	[DataMember(Name = "windowsUserId", EmitDefaultValue = false)]
	public string WindowsUserId { get; set; } = null!;
}

