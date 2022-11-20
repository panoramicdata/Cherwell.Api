using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroupV2Response
/// </summary>
[DataContract]
public class SecurityGroupV2Response : Response
{
	/// <summary>
	/// SecurityGroups
	/// </summary>
	[DataMember(Name = "securityGroups", EmitDefaultValue = false)]
	public List<SecurityGroup> SecurityGroups { get; set; } = null!;
}

