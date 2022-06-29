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
}

