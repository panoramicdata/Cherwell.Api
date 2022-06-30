using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLogBatchRequest
/// </summary>
[DataContract]
public partial class LogBatchRequest
{
	/// <summary>
	/// LogRequests
	/// </summary>
	[DataMember(Name = "logRequests", EmitDefaultValue = false)]
	public List<LogRequest>? LogRequests { get; set; }
}
