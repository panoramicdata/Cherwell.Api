using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchDeleteRequest
/// </summary>
[DataContract]
public partial class UserBatchDeleteRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchDeleteRequest" /> class.
	/// </summary>
	/// <param name="StopOnError">StopOnError.</param>
	/// <param name="UserRecordIds">UserRecordIds.</param>
	public UserBatchDeleteRequest(bool? StopOnError, List<string> UserRecordIds)
	{
		this.StopOnError = StopOnError;
		this.UserRecordIds = UserRecordIds;
	}

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }

	/// <summary>
	/// UserRecordIds
	/// </summary>
	[DataMember(Name = "userRecordIds", EmitDefaultValue = false)]
	public List<string> UserRecordIds { get; set; }






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

