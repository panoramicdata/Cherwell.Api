using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BatchReadRequest
/// </summary>
[DataContract]
public class BatchReadRequest
{
	/// <summary>
	/// ReadRequests
	/// </summary>
	[DataMember(Name = "readRequests", EmitDefaultValue = false)]
	public List<ReadRequest> ReadRequests { get; set; } = null!;

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }
}