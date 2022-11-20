using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchDeleteRequest
/// </summary>
[DataContract]
public class UserBatchDeleteRequest
{
	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }

	/// <summary>
	/// UserRecordIds
	/// </summary>
	[DataMember(Name = "userRecordIds", EmitDefaultValue = false)]
	public List<string> UserRecordIds { get; set; } = null!;
}

