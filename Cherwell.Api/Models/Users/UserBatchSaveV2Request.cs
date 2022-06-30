using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveV2Request
/// </summary>
[DataContract]
public partial class UserBatchSaveV2Request
{
	/// <summary>
	/// SaveRequests
	/// </summary>
	[DataMember(Name = "saveRequests", EmitDefaultValue = false)]
	public List<UserSaveV2Request> SaveRequests { get; set; } = null!;

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }
}

