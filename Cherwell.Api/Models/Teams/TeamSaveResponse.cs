using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamSaveResponse
/// </summary>
[DataContract]
public partial class TeamSaveResponse : Response
{
	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; } = null!;
}

