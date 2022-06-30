using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// CloneSecurityGroupRequest
/// </summary>
[DataContract]
public partial class CloneSecurityGroupRequest
{
	/// <summary>
	/// SecurityGroupName
	/// </summary>
	[DataMember(Name = "securityGroupName", EmitDefaultValue = false)]
	public string SecurityGroupName { get; set; } = null!;

	/// <summary>
	/// SourceSecurityGroupNameOrId
	/// </summary>
	[DataMember(Name = "sourceSecurityGroupNameOrId", EmitDefaultValue = false)]
	public string SourceSecurityGroupNameOrId { get; set; } = null!;
}
