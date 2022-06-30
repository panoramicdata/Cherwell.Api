using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// RoleReadResponse
/// </summary>
[DataContract]
public partial class RoleReadResponse : Response
{
	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; } = null!;

	/// <summary>
	/// Roles
	/// </summary>
	[DataMember(Name = "roles", EmitDefaultValue = false)]
	public List<Role> Roles { get; set; } = null!;
}

