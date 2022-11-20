using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// LogBatchRequest
/// </summary>
[DataContract]
public class LogBatchRequest
{
	/// <summary>
	/// LogRequests
	/// </summary>
	[DataMember(Name = "logRequests", EmitDefaultValue = false)]
	public List<LogRequest> LogRequests { get; set; } = null!;
}
