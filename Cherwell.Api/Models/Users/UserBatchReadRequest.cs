using System.Runtime.Serialization;

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
	public UserBatchReadRequest(List<UserReadRequest> ReadRequests, bool StopOnError)
	{
		this.ReadRequests = ReadRequests;
		this.StopOnError = StopOnError;
	}

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

