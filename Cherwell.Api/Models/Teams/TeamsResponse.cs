using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamsResponse
/// </summary>
[DataContract]
public partial class TeamsResponse : Response
{
	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; } = null!;
	/// <summary>
	/// Teams
	/// </summary>
	[DataMember(Name = "teams", EmitDefaultValue = false)]
	public List<Team> Teams { get; set; } = null!;
}

