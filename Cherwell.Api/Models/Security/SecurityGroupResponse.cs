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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecuritySecurityGroupResponse {\n");
		sb.Append("  SecurityGroups: ").Append(SecurityGroups).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

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
			if (SecurityGroups != null)
			{
				hash = hash * 59 + SecurityGroups.GetHashCode();
			}

			return hash;
		}
	}

	
}

