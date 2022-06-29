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
	/// Initializes a new instance of the <see cref="LogBatchRequest" /> class.
	/// </summary>
	/// <param name="LogRequests">LogRequests.</param>
	public LogBatchRequest(List<LogRequest> LogRequests)
	{
		this.LogRequests = LogRequests;
	}

	/// <summary>
	/// LogRequests
	/// </summary>
	[DataMember(Name = "logRequests", EmitDefaultValue = false)]
	public List<LogRequest> LogRequests { get; set; }







	
}
