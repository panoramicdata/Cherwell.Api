using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// RemoveUserFromTeamResponse
/// </summary>
[DataContract]
public partial class RemoveUserFromTeamResponse : Response
{
	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; } = null!;
	/// <summary>
	/// UserRecordId
	/// </summary>
	[DataMember(Name = "userRecordId", EmitDefaultValue = false)]
	public string UserRecordId { get; set; } = null!;
}

