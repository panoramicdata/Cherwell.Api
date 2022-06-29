using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroup
/// </summary>
[DataContract]
public partial class SecurityGroup
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecurityGroup" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="GroupId">GroupId.</param>
	/// <param name="GroupName">GroupName.</param>
	public SecurityGroup(string Description, string GroupId, string GroupName)
	{
		this.Description = Description;
		this.GroupId = GroupId;
		this.GroupName = GroupName;
	}

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// GroupId
	/// </summary>
	[DataMember(Name = "groupId", EmitDefaultValue = false)]
	public string GroupId { get; set; }

	/// <summary>
	/// GroupName
	/// </summary>
	[DataMember(Name = "groupName", EmitDefaultValue = false)]
	public string GroupName { get; set; }







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
			return hash;
		}
	}

	
}

