using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserSaveV2Request
/// </summary>
[DataContract]
public partial class UserSaveV2Request
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserSaveV2Request" /> class.
	/// </summary>
	/// <param name="AccountLocked">AccountLocked.</param>
	/// <param name="AllCultures">AllCultures.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="LdapRequired">LdapRequired.</param>
	/// <param name="LoginId">LoginId.</param>
	/// <param name="NextPasswordResetDate">NextPasswordResetDate.</param>
	/// <param name="Password">Password.</param>
	/// <param name="PasswordNeverExpires">PasswordNeverExpires.</param>
	/// <param name="SecurityGroupId">SecurityGroupId.</param>
	/// <param name="SpecificCulture">SpecificCulture.</param>
	/// <param name="UserCannotChangePassword">UserCannotChangePassword.</param>
	/// <param name="UserInfoFields">UserInfoFields.</param>
	/// <param name="UserMustChangePasswordAtNextLogin">UserMustChangePasswordAtNextLogin.</param>
	/// <param name="WindowsUserId">WindowsUserId.</param>
	public UserSaveV2Request(bool? AccountLocked, bool? AllCultures, string BusObId, string BusObPublicId, string BusObRecId, string DisplayName, bool? LdapRequired, string LoginId, DateTime? NextPasswordResetDate, string Password, bool? PasswordNeverExpires, string SecurityGroupId, string SpecificCulture, bool? UserCannotChangePassword, List<FieldTemplateItem> UserInfoFields, bool? UserMustChangePasswordAtNextLogin, string WindowsUserId)
	{
		this.AccountLocked = AccountLocked;
		this.AllCultures = AllCultures;
		this.BusObId = BusObId;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.DisplayName = DisplayName;
		this.LdapRequired = LdapRequired;
		this.LoginId = LoginId;
		this.NextPasswordResetDate = NextPasswordResetDate;
		this.Password = Password;
		this.PasswordNeverExpires = PasswordNeverExpires;
		this.SecurityGroupId = SecurityGroupId;
		this.SpecificCulture = SpecificCulture;
		this.UserCannotChangePassword = UserCannotChangePassword;
		this.UserInfoFields = UserInfoFields;
		this.UserMustChangePasswordAtNextLogin = UserMustChangePasswordAtNextLogin;
		this.WindowsUserId = WindowsUserId;
	}

	/// <summary>
	/// AccountLocked
	/// </summary>
	[DataMember(Name = "accountLocked", EmitDefaultValue = false)]
	public bool? AccountLocked { get; set; }

	/// <summary>
	/// AllCultures
	/// </summary>
	[DataMember(Name = "allCultures", EmitDefaultValue = false)]
	public bool? AllCultures { get; set; }

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
	/// SpecificCulture
	/// </summary>
	[DataMember(Name = "specificCulture", EmitDefaultValue = false)]
	public string SpecificCulture { get; set; }

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
}