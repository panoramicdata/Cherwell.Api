using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BatchDeleteRequest
/// </summary>
[DataContract]
public class BatchDeleteRequest
{
	/// <summary>
	/// DeleteRequests
	/// </summary>
	[DataMember(Name = "deleteRequests", EmitDefaultValue = false)]
	public List<DeleteRequest> DeleteRequests { get; set; } = null!;

	/// <summary>
	/// StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool StopOnError { get; set; }
}