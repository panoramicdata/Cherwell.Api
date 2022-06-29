using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroupResponse
/// </summary>
[DataContract]
public partial class SecurityGroupResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecurityGroupResponse" /> class.
	/// </summary>
	/// <param name="SecurityGroups">SecurityGroups.</param>
	public SecurityGroupResponse(List<SecurityGroup> SecurityGroups)
	{
		this.SecurityGroups = SecurityGroups;
	}

	/// <summary>
	/// SecurityGroups
	/// </summary>
	[DataMember(Name = "securityGroups", EmitDefaultValue = false)]
	public List<SecurityGroup> SecurityGroups { get; set; }







	
}

