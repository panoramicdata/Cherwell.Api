using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// CloneSecurityGroupResponse
/// </summary>
[DataContract]
public partial class CloneSecurityGroupResponse : Response
{
	/// <summary>
	/// SecurityGroupId
	/// </summary>
	[DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
	public string? SecurityGroupId { get; set; }
}
