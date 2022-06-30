using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveRequest
/// </summary>
[DataContract]
public partial class UserBatchSaveRequest
{
	/// <summary>
	/// SaveRequests
	/// </summary>
	[DataMember(Name = "saveRequests", EmitDefaultValue = false)]
	public List<UserSaveRequest> SaveRequests { get; set; } = null!;

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }
}

