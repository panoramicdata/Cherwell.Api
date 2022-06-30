using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroupResponse
/// </summary>
[DataContract]
public partial class SecurityGroupResponse : Response
{
	/// <summary>
	/// SecurityGroups
	/// </summary>
	[DataMember(Name = "securityGroups", EmitDefaultValue = false)]
	public List<SecurityGroup>? SecurityGroups { get; set; }
}

