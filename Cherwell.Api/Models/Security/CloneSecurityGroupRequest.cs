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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityCloneSecurityGroupRequest {\n");
		sb.Append("  SecurityGroupName: ").Append(SecurityGroupName).Append('\n');
		sb.Append("  SourceSecurityGroupNameOrId: ").Append(SourceSecurityGroupNameOrId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if CloneSecurityGroupRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of CloneSecurityGroupRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(CloneSecurityGroupRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					SecurityGroupName == other.SecurityGroupName ||
					SecurityGroupName != null &&
					SecurityGroupName.Equals(other.SecurityGroupName, StringComparison.Ordinal)
				) &&
				(
					SourceSecurityGroupNameOrId == other.SourceSecurityGroupNameOrId ||
					SourceSecurityGroupNameOrId != null &&
					SourceSecurityGroupNameOrId.Equals(other.SourceSecurityGroupNameOrId, StringComparison.Ordinal)
				);
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
			if (SecurityGroupName != null)
			{
				hash = hash * 59 + SecurityGroupName.GetHashCode();
			}

			if (SourceSecurityGroupNameOrId != null)
			{
				hash = hash * 59 + SourceSecurityGroupNameOrId.GetHashCode();
			}

			return hash;
		}
	}

	
}
