using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// RoleReadV2Response
/// </summary>
[DataContract]
public class RoleReadV2Response : Response
{
	/// <summary>
	/// Roles
	/// </summary>
	[DataMember(Name = "roles", EmitDefaultValue = false)]
	public List<Role> Roles { get; set; } = null!;
}

