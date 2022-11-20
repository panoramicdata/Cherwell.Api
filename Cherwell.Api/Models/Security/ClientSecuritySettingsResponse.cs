using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// ClientSecuritySettingsResponse
/// </summary>
[DataContract]
public class ClientSecuritySettingsResponse : Response
{
	/// <summary>
	/// InternalLoginAllowed
	/// </summary>
	[DataMember(Name = "internalLoginAllowed", EmitDefaultValue = false)]
	public bool InternalLoginAllowed { get; set; }

	/// <summary>
	/// LdapLoginAllowed
	/// </summary>
	[DataMember(Name = "ldapLoginAllowed", EmitDefaultValue = false)]
	public bool LdapLoginAllowed { get; set; }

	/// <summary>
	/// SamlLoginAllowed
	/// </summary>
	[DataMember(Name = "samlLoginAllowed", EmitDefaultValue = false)]
	public bool SamlLoginAllowed { get; set; }

	/// <summary>
	/// WindowsLoginAllowed
	/// </summary>
	[DataMember(Name = "windowsLoginAllowed", EmitDefaultValue = false)]
	public bool WindowsLoginAllowed { get; set; }
}