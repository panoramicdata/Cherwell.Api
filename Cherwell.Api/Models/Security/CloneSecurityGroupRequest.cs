using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// CloneSecurityGroupRequest
/// </summary>
[DataContract]
public partial class CloneSecurityGroupRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CloneSecurityGroupRequest" /> class.
	/// </summary>
	/// <param name="SecurityGroupName">SecurityGroupName.</param>
	/// <param name="SourceSecurityGroupNameOrId">SourceSecurityGroupNameOrId.</param>
	public CloneSecurityGroupRequest(string SecurityGroupName, string SourceSecurityGroupNameOrId)
	{
		this.SecurityGroupName = SecurityGroupName;
		this.SourceSecurityGroupNameOrId = SourceSecurityGroupNameOrId;
	}

	/// <summary>
	/// SecurityGroupName
	/// </summary>
	[DataMember(Name = "securityGroupName", EmitDefaultValue = false)]
	public string SecurityGroupName { get; set; }

	/// <summary>
	/// SourceSecurityGroupNameOrId
	/// </summary>
	[DataMember(Name = "sourceSecurityGroupNameOrId", EmitDefaultValue = false)]
	public string SourceSecurityGroupNameOrId { get; set; }
}
