using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchDeleteResponse
/// </summary>
[DataContract]
public partial class BatchDeleteResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<DeleteResponse>? Responses { get; set; }
}