using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamRequest
/// </summary>
[DataContract]
public partial class AddUserToTeamRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddUserToTeamRequest" /> class.
	/// </summary>
	/// <param name="teamId">TeamId.</param>
	/// <param name="userIsTeamManager">UserIsTeamManager.</param>
	/// <param name="userRecordId">UserRecordId.</param>
	public AddUserToTeamRequest(
		string teamId,
		bool? userIsTeamManager,
		string userRecordId)
	{
		TeamId = teamId;
		UserIsTeamManager = userIsTeamManager;
		UserRecordId = userRecordId;
	}

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// UserIsTeamManager
	/// </summary>
	[DataMember(Name = "userIsTeamManager", EmitDefaultValue = false)]
	public bool? UserIsTeamManager { get; set; }

	/// <summary>
	/// UserRecordId
	/// </summary>
	[DataMember(Name = "userRecordId", EmitDefaultValue = false)]
	public string UserRecordId { get; set; }
}

