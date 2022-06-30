using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// Team
/// </summary>
[DataContract]
public partial class Team
{
	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string? TeamId { get; set; }

	/// <summary>
	/// TeamName
	/// </summary>
	[DataMember(Name = "teamName", EmitDefaultValue = false)]
	public string? TeamName { get; set; }
}

