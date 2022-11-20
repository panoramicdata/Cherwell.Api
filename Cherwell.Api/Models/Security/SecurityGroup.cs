using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroup
/// </summary>
[DataContract]
public class SecurityGroup
{
	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; } = null!;

	/// <summary>
	/// GroupId
	/// </summary>
	[DataMember(Name = "groupId", EmitDefaultValue = false)]
	public string GroupId { get; set; } = null!;

	/// <summary>
	/// GroupName
	/// </summary>
	[DataMember(Name = "groupName", EmitDefaultValue = false)]
	public string GroupName { get; set; } = null!;
}

