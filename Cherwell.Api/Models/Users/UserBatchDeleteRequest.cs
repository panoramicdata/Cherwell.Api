using System.Runtime.Serialization;

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
}

