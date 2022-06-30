using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// SaveTeamMemberRequest
/// </summary>
[DataContract]
public partial class SaveTeamMemberRequest
{
	/// <summary>
	/// IsTeamManager
	/// </summary>
	[DataMember(Name = "isTeamManager", EmitDefaultValue = false)]
	public bool IsTeamManager { get; set; }

	/// <summary>
	/// SetAsDefaultTeam
	/// </summary>
	[DataMember(Name = "setAsDefaultTeam", EmitDefaultValue = false)]
	public bool SetAsDefaultTeam { get; set; }

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; } = null!;

	/// <summary>
	/// UserRecId
	/// </summary>
	[DataMember(Name = "userRecId", EmitDefaultValue = false)]
	public string UserRecId { get; set; } = null!;
}

