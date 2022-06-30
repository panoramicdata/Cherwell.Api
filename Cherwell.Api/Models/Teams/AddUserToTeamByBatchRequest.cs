using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamByBatchRequest
/// </summary>
[DataContract]
public partial class AddUserToTeamByBatchRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddUserToTeamByBatchRequest" /> class.
	/// </summary>
	/// <param name="AddUserToTeamRequests">AddUserToTeamRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public AddUserToTeamByBatchRequest(List<AddUserToTeamRequest> AddUserToTeamRequests, bool? StopOnError)
	{
		this.AddUserToTeamRequests = AddUserToTeamRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// AddUserToTeamRequests
	/// </summary>
	[DataMember(Name = "addUserToTeamRequests", EmitDefaultValue = false)]
	public List<AddUserToTeamRequest> AddUserToTeamRequests { get; set; }

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }
}

