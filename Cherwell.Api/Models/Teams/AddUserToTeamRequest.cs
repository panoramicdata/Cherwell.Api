using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamRequest
/// </summary>
[DataContract]
public partial class AddUserToTeamRequest : IEquatable<AddUserToTeamRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddUserToTeamRequest" /> class.
	/// </summary>
	/// <param name="TeamId">TeamId.</param>
	/// <param name="UserIsTeamManager">UserIsTeamManager.</param>
	/// <param name="UserRecordId">UserRecordId.</param>
	public AddUserToTeamRequest(string TeamId, bool? UserIsTeamManager, string UserRecordId)
	{
		this.TeamId = TeamId;
		this.UserIsTeamManager = UserIsTeamManager;
		this.UserRecordId = UserRecordId;
	}

	/// <summary>
	/// Gets or Sets TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }
	/// <summary>
	/// Gets or Sets UserIsTeamManager
	/// </summary>
	[DataMember(Name = "userIsTeamManager", EmitDefaultValue = false)]
	public bool? UserIsTeamManager { get; set; }
	/// <summary>
	/// Gets or Sets UserRecordId
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
		return Equals(obj as AddUserToTeamRequest);
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

