using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// SaveTeamMemberRequest
/// </summary>
[DataContract]
public partial class SaveTeamMemberRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveTeamMemberRequest" /> class.
	/// </summary>
	/// <param name="IsTeamManager">IsTeamManager.</param>
	/// <param name="SetAsDefaultTeam">SetAsDefaultTeam.</param>
	/// <param name="TeamId">TeamId.</param>
	/// <param name="UserRecId">UserRecId.</param>
	public SaveTeamMemberRequest(bool? IsTeamManager, bool? SetAsDefaultTeam, string TeamId, string UserRecId)
	{
		this.IsTeamManager = IsTeamManager;
		this.SetAsDefaultTeam = SetAsDefaultTeam;
		this.TeamId = TeamId;
		this.UserRecId = UserRecId;
	}

	/// <summary>
	/// IsTeamManager
	/// </summary>
	[DataMember(Name = "isTeamManager", EmitDefaultValue = false)]
	public bool? IsTeamManager { get; set; }

	/// <summary>
	/// SetAsDefaultTeam
	/// </summary>
	[DataMember(Name = "setAsDefaultTeam", EmitDefaultValue = false)]
	public bool? SetAsDefaultTeam { get; set; }

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// UserRecId
	/// </summary>
	[DataMember(Name = "userRecId", EmitDefaultValue = false)]
	public string UserRecId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsSaveTeamMemberRequest {\n");
		sb.Append("  IsTeamManager: ").Append(IsTeamManager).Append('\n');
		sb.Append("  SetAsDefaultTeam: ").Append(SetAsDefaultTeam).Append('\n');
		sb.Append("  TeamId: ").Append(TeamId).Append('\n');
		sb.Append("  UserRecId: ").Append(UserRecId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if SaveTeamMemberRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SaveTeamMemberRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveTeamMemberRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					IsTeamManager == other.IsTeamManager ||
					IsTeamManager != null &&
					IsTeamManager.Equals(other.IsTeamManager)
				) &&
				(
					SetAsDefaultTeam == other.SetAsDefaultTeam ||
					SetAsDefaultTeam != null &&
					SetAsDefaultTeam.Equals(other.SetAsDefaultTeam)
				) &&
				(
					TeamId == other.TeamId ||
					TeamId != null &&
					TeamId.Equals(other.TeamId, StringComparison.Ordinal)
				) &&
				(
					UserRecId == other.UserRecId ||
					UserRecId != null &&
					UserRecId.Equals(other.UserRecId, StringComparison.Ordinal)
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
			if (IsTeamManager != null)
			{
				hash = hash * 59 + IsTeamManager.GetHashCode();
			}

			if (SetAsDefaultTeam != null)
			{
				hash = hash * 59 + SetAsDefaultTeam.GetHashCode();
			}

			if (TeamId != null)
			{
				hash = hash * 59 + TeamId.GetHashCode();
			}

			if (UserRecId != null)
			{
				hash = hash * 59 + UserRecId.GetHashCode();
			}

			return hash;
		}
	}

	
}

