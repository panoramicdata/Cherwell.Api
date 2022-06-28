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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserBatchDeleteRequest {\n");
		sb.Append("  StopOnError: ").Append(StopOnError).Append('\n');
		sb.Append("  UserRecordIds: ").Append(UserRecordIds).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if UserBatchDeleteRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of UserBatchDeleteRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(UserBatchDeleteRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					StopOnError == other.StopOnError ||
					StopOnError != null &&
					StopOnError.Equals(other.StopOnError)
				) &&
				(
					UserRecordIds == other.UserRecordIds ||
					UserRecordIds != null &&
					UserRecordIds.SequenceEqual(other.UserRecordIds)
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
			if (StopOnError != null)
			{
				hash = hash * 59 + StopOnError.GetHashCode();
			}

			if (UserRecordIds != null)
			{
				hash = hash * 59 + UserRecordIds.GetHashCode();
			}

			return hash;
		}
	}

	
}

