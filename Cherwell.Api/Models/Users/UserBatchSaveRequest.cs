using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveRequest
/// </summary>
[DataContract]
public partial class UserBatchSaveRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchSaveRequest" /> class.
	/// </summary>
	/// <param name="SaveRequests">SaveRequests.</param>
	/// <param name="StopOnError">StopOnError.</param>
	public UserBatchSaveRequest(List<UserSaveRequest> SaveRequests, bool? StopOnError)
	{
		this.SaveRequests = SaveRequests;
		this.StopOnError = StopOnError;
	}

	/// <summary>
	/// SaveRequests
	/// </summary>
	[DataMember(Name = "saveRequests", EmitDefaultValue = false)]
	public List<UserSaveRequest> SaveRequests { get; set; }

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }
}

