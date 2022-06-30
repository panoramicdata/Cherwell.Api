using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamByBatchResponse
/// </summary>
[DataContract]
public partial class AddUserToTeamByBatchResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<AddUserToTeamResponse> Responses { get; set; } = null!;
}

