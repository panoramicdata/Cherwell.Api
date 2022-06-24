using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchReadRequest
/// </summary>
[DataContract]
public partial class BatchReadRequest
{
	/// <summary>
	/// Gets or Sets ReadRequests
	/// </summary>
	[DataMember(Name = "readRequests", EmitDefaultValue = false)]
	public List<ReadRequest>? ReadRequests { get; set; }

	/// <summary>
	/// Gets or Sets StopOnError
	/// </summary>
	[DataMember(Name = "stopOnError", EmitDefaultValue = false)]
	public bool? StopOnError { get; set; }
}