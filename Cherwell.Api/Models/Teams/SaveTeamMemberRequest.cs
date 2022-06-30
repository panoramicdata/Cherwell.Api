using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// SaveTeamMemberRequest
/// </summary>
[DataContract]
public partial class SaveTeamMemberRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveTeamMemberRequest" /> class.
	/// </summary>
	/// <param name="IsTeamManager">IsTeamManager.</param>
	/// <param name="SetAsDefaultTeam">SetAsDefaultTeam.</param>
	/// <param name="TeamId">TeamId.</param>
	/// <param name="UserRecId">UserRecId.</param>
	public SaveTeamMemberRequest(bool? IsTeamManager, bool? SetAsDefaultTeam, string TeamId, string UserRecId)
	{
		this.IsTeamManager = IsTeamManager;
		this.SetAsDefaultTeam = SetAsDefaultTeam;
		this.TeamId = TeamId;
		this.UserRecId = UserRecId;
	}

	/// <summary>
	/// IsTeamManager
	/// </summary>
	[DataMember(Name = "isTeamManager", EmitDefaultValue = false)]
	public bool? IsTeamManager { get; set; }

	/// <summary>
	/// SetAsDefaultTeam
	/// </summary>
	[DataMember(Name = "setAsDefaultTeam", EmitDefaultValue = false)]
	public bool? SetAsDefaultTeam { get; set; }

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// UserRecId
	/// </summary>
	[DataMember(Name = "userRecId", EmitDefaultValue = false)]
	public string UserRecId { get; set; }
}

