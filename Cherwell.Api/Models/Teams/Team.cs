using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// Team
/// </summary>
[DataContract]
public partial class Team
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Team" /> class.
	/// </summary>
	/// <param name="TeamId">TeamId.</param>
	/// <param name="TeamName">TeamName.</param>
	public Team(string TeamId, string TeamName)
	{
		this.TeamId = TeamId;
		this.TeamName = TeamName;
	}

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// TeamName
	/// </summary>
	[DataMember(Name = "teamName", EmitDefaultValue = false)]
	public string TeamName { get; set; }






	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)

		}
	}

	
}

