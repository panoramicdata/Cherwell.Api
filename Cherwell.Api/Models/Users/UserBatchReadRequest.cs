using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchReadRequest
/// </summary>
[DataContract]
public class UserBatchReadRequest
{
	/// <summary>
	/// ReadRequests
	/// </summary>
	[DataMember(Name = "readRequests", EmitDefaultValue = false)]
	public List<UserReadRequest> ReadRequests { get; set; } = null!;

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }
}

