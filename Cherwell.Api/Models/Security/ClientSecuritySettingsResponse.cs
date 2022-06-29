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


		}
	}

	
}