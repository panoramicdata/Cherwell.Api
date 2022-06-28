using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamRequest
/// </summary>
[DataContract]
public partial class AddUserToTeamRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddUserToTeamRequest" /> class.
	/// </summary>
	/// <param name="teamId">TeamId.</param>
	/// <param name="userIsTeamManager">UserIsTeamManager.</param>
	/// <param name="userRecordId">UserRecordId.</param>
	public AddUserToTeamRequest(
		string teamId,
		bool? userIsTeamManager,
		string userRecordId)
	{
		TeamId = teamId;
		UserIsTeamManager = userIsTeamManager;
		UserRecordId = userRecordId;
	}

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// UserIsTeamManager
	/// </summary>
	[DataMember(Name = "userIsTeamManager", EmitDefaultValue = false)]
	public bool? UserIsTeamManager { get; set; }

	/// <summary>
	/// UserRecordId
	/// </summary>
	[DataMember(Name = "userRecordId", EmitDefaultValue = false)]
	public string UserRecordId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsAddUserToTeamRequest {\n");
		sb.Append("  TeamId: ").Append(TeamId).Append('\n');
		sb.Append("  UserIsTeamManager: ").Append(UserIsTeamManager).Append('\n');
		sb.Append("  UserRecordId: ").Append(UserRecordId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if AddUserToTeamRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of AddUserToTeamRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(AddUserToTeamRequest? other)
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
					UserIsTeamManager == other.UserIsTeamManager ||
					UserIsTeamManager != null &&
					UserIsTeamManager.Equals(other.UserIsTeamManager)
				) &&
				(
					UserRecordId == other.UserRecordId ||
					UserRecordId != null &&
					UserRecordId.Equals(other.UserRecordId, StringComparison.Ordinal)
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

			if (UserIsTeamManager != null)
			{
				hash = hash * 59 + UserIsTeamManager.GetHashCode();
			}

			if (UserRecordId != null)
			{
				hash = hash * 59 + UserRecordId.GetHashCode();
			}

			return hash;
		}
	}

	
}

