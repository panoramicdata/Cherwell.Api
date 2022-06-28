using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchReadRequest
/// </summary>
[DataContract]
public partial class UserBatchReadRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchReadRequest" /> class.
	/// </summary>
	/// <param name="ReadRequests">ReadRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public UserBatchReadRequest(List<UserReadRequest> ReadRequests, bool? StopOnError)
	{
		this.ReadRequests = ReadRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// ReadRequests
	/// </summary>
	[DataMember(Name = "readRequests", EmitDefaultValue = false)]
	public List<UserReadRequest> ReadRequests { get; set; }

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
		sb.Append("class UserBatchReadRequest {\n");
		sb.Append("  ReadRequests: ").Append(ReadRequests).Append('\n');
		sb.Append("  StopOnError: ").Append(StopOnError).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if UserBatchReadRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of UserBatchReadRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(UserBatchReadRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					ReadRequests == other.ReadRequests ||
					ReadRequests != null &&
					ReadRequests.SequenceEqual(other.ReadRequests)
				) &&
				(
					StopOnError == other.StopOnError ||
					StopOnError != null &&
					StopOnError.Equals(other.StopOnError)
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
			if (ReadRequests != null)
			{
				hash = hash * 59 + ReadRequests.GetHashCode();
			}

			if (StopOnError != null)
			{
				hash = hash * 59 + StopOnError.GetHashCode();
			}

			return hash;
		}
	}

	
}

