using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserSaveV2Request
/// </summary>
[DataContract]
public partial class UserSaveV2Request : IEquatable<UserSaveV2Request>, IValidatableObject
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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserSaveV2Request {\n");
		sb.Append("  AccountLocked: ").Append(AccountLocked).Append('\n');
		sb.Append("  AllCultures: ").Append(AllCultures).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  LdapRequired: ").Append(LdapRequired).Append('\n');
		sb.Append("  LoginId: ").Append(LoginId).Append('\n');
		sb.Append("  NextPasswordResetDate: ").Append(NextPasswordResetDate).Append('\n');
		sb.Append("  Password: ").Append(Password).Append('\n');
		sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append('\n');
		sb.Append("  SecurityGroupId: ").Append(SecurityGroupId).Append('\n');
		sb.Append("  SpecificCulture: ").Append(SpecificCulture).Append('\n');
		sb.Append("  UserCannotChangePassword: ").Append(UserCannotChangePassword).Append('\n');
		sb.Append("  UserInfoFields: ").Append(UserInfoFields).Append('\n');
		sb.Append("  UserMustChangePasswordAtNextLogin: ").Append(UserMustChangePasswordAtNextLogin).Append('\n');
		sb.Append("  WindowsUserId: ").Append(WindowsUserId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as UserSaveV2Request);
	}

	/// <summary>
	/// Returns true if UserSaveV2Request instances are equal
	/// </summary>
	/// <param name="other">Instance of UserSaveV2Request to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(UserSaveV2Request? other)
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
					AllCultures == other.AllCultures ||
					AllCultures != null &&
					AllCultures.Equals(other.AllCultures)
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
					SpecificCulture == other.SpecificCulture ||
					SpecificCulture != null &&
					SpecificCulture.Equals(other.SpecificCulture, StringComparison.Ordinal)
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

			if (AllCultures != null)
			{
				hash = hash * 59 + AllCultures.GetHashCode();
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

			if (SpecificCulture != null)
			{
				hash = hash * 59 + SpecificCulture.GetHashCode();
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