using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamsV2Response
/// </summary>
[DataContract]
public class TeamsV2Response : Response
{
	/// <summary>
	/// Teams
	/// </summary>
	[DataMember(Name = "teams", EmitDefaultValue = false)]
	public List<Team> Teams { get; set; } = null!;
}

