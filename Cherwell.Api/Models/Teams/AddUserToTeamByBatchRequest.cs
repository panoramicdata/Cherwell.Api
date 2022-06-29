using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// AddUserToTeamByBatchRequest
/// </summary>
[DataContract]
public partial class AddUserToTeamByBatchRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AddUserToTeamByBatchRequest" /> class.
	/// </summary>
	/// <param name="AddUserToTeamRequests">AddUserToTeamRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public AddUserToTeamByBatchRequest(List<AddUserToTeamRequest> AddUserToTeamRequests, bool? StopOnError)
	{
		this.AddUserToTeamRequests = AddUserToTeamRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// AddUserToTeamRequests
	/// </summary>
	[DataMember(Name = "addUserToTeamRequests", EmitDefaultValue = false)]
	public List<AddUserToTeamRequest> AddUserToTeamRequests { get; set; }

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsAddUserToTeamByBatchRequest {\n");
		sb.Append("  AddUserToTeamRequests: ").Append(AddUserToTeamRequests).Append('\n');
		sb.Append("  StopOnError: ").Append(StopOnError).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
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
			if (AddUserToTeamRequests != null)
			{
				hash = hash * 59 + AddUserToTeamRequests.GetHashCode();
			}

			if (StopOnError != null)
			{
				hash = hash * 59 + StopOnError.GetHashCode();
			}

			return hash;
		}
	}

	
}

