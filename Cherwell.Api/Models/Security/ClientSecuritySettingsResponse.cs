using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// ClientSecuritySettingsResponse
/// </summary>
[DataContract]
public partial class ClientSecuritySettingsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ClientSecuritySettingsResponse" /> class.
	/// </summary>
	/// <param name="internalLoginAllowed">InternalLoginAllowed.</param>
	/// <param name="ldapLoginAllowed">LdapLoginAllowed.</param>
	/// <param name="samlLoginAllowed">SamlLoginAllowed.</param>
	/// <param name="windowsLoginAllowed">WindowsLoginAllowed.</param>
	public ClientSecuritySettingsResponse(
		bool? internalLoginAllowed = default,
		bool? ldapLoginAllowed = default,
		bool? samlLoginAllowed = default,
		bool? windowsLoginAllowed = default)
	{
		InternalLoginAllowed = internalLoginAllowed;
		LdapLoginAllowed = ldapLoginAllowed;
		SamlLoginAllowed = samlLoginAllowed;
		WindowsLoginAllowed = windowsLoginAllowed;
	}

	/// <summary>
	/// InternalLoginAllowed
	/// </summary>
	[DataMember(Name = "internalLoginAllowed", EmitDefaultValue = false)]
	public bool? InternalLoginAllowed { get; set; }

	/// <summary>
	/// LdapLoginAllowed
	/// </summary>
	[DataMember(Name = "ldapLoginAllowed", EmitDefaultValue = false)]
	public bool? LdapLoginAllowed { get; set; }

	/// <summary>
	/// SamlLoginAllowed
	/// </summary>
	[DataMember(Name = "samlLoginAllowed", EmitDefaultValue = false)]
	public bool? SamlLoginAllowed { get; set; }

	/// <summary>
	/// WindowsLoginAllowed
	/// </summary>
	[DataMember(Name = "windowsLoginAllowed", EmitDefaultValue = false)]
	public bool? WindowsLoginAllowed { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityClientSecuritySettingsResponse {\n");
		sb.Append("  InternalLoginAllowed: ").Append(InternalLoginAllowed).Append('\n');
		sb.Append("  LdapLoginAllowed: ").Append(LdapLoginAllowed).Append('\n');
		sb.Append("  SamlLoginAllowed: ").Append(SamlLoginAllowed).Append('\n');
		sb.Append("  WindowsLoginAllowed: ").Append(WindowsLoginAllowed).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if ClientSecuritySettingsResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of ClientSecuritySettingsResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ClientSecuritySettingsResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					InternalLoginAllowed == other.InternalLoginAllowed ||
					InternalLoginAllowed != null &&
					InternalLoginAllowed.Equals(other.InternalLoginAllowed)
				) &&
				(
					LdapLoginAllowed == other.LdapLoginAllowed ||
					LdapLoginAllowed != null &&
					LdapLoginAllowed.Equals(other.LdapLoginAllowed)
				) &&
				(
					SamlLoginAllowed == other.SamlLoginAllowed ||
					SamlLoginAllowed != null &&
					SamlLoginAllowed.Equals(other.SamlLoginAllowed)
				) &&
				(
					WindowsLoginAllowed == other.WindowsLoginAllowed ||
					WindowsLoginAllowed != null &&
					WindowsLoginAllowed.Equals(other.WindowsLoginAllowed)
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
			if (InternalLoginAllowed != null)
			{
				hash = hash * 59 + InternalLoginAllowed.GetHashCode();
			}

			if (LdapLoginAllowed != null)
			{
				hash = hash * 59 + LdapLoginAllowed.GetHashCode();
			}

			if (SamlLoginAllowed != null)
			{
				hash = hash * 59 + SamlLoginAllowed.GetHashCode();
			}

			if (WindowsLoginAllowed != null)
			{
				hash = hash * 59 + WindowsLoginAllowed.GetHashCode();
			}

			return hash;
		}
	}

	
}