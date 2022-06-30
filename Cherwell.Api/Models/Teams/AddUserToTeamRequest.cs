using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamRequest
/// </summary>
[DataContract]
public partial class AddUserToTeamRequest
{
	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; } = null!;

	/// <summary>
	/// UserIsTeamManager
	/// </summary>
	[DataMember(Name = "userIsTeamManager", EmitDefaultValue = false)]
	public bool UserIsTeamManager { get; set; }

	/// <summary>
	/// UserRecordId
	/// </summary>
	[DataMember(Name = "userRecordId", EmitDefaultValue = false)]
	public string UserRecordId { get; set; } = null!;
}

