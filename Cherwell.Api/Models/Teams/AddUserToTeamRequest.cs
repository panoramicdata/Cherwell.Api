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
			return hash;
		}
	}

	
}

