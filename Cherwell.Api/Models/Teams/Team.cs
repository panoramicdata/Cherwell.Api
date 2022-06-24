using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// Team
/// </summary>
[DataContract]
public partial class Team : IEquatable<Team>, IValidatableObject
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsTeam {\n");
		sb.Append("  TeamId: ").Append(TeamId).Append('\n');
		sb.Append("  TeamName: ").Append(TeamName).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as Team);
	}

	/// <summary>
	/// Returns true if Team instances are equal
	/// </summary>
	/// <param name="other">Instance of Team to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Team? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					TeamId == other.TeamId ||
					TeamId != null &&
					TeamId.Equals(other.TeamId, StringComparison.Ordinal)
				) &&
				(
					TeamName == other.TeamName ||
					TeamName != null &&
					TeamName.Equals(other.TeamName, StringComparison.Ordinal)
				);
	}

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
			if (TeamId != null)
			{
				hash = hash * 59 + TeamId.GetHashCode();
			}

			if (TeamName != null)
			{
				hash = hash * 59 + TeamName.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}

