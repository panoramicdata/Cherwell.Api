using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamByBatchRequest
/// </summary>
[DataContract]
public class AddUserToTeamByBatchRequest
{
	/// <summary>
	/// AddUserToTeamRequests
	/// </summary>
	[DataMember(Name = "addUserToTeamRequests", EmitDefaultValue = false)]
	public List<AddUserToTeamRequest> AddUserToTeamRequests { get; set; } = null!;

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }
}

