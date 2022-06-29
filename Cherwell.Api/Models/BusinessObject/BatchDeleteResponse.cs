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
	/// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	public BatchDeleteResponse(List<DeleteResponse> Responses)
	{
		this.Responses = Responses;
	}

	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<DeleteResponse> Responses { get; set; }







	
}