using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBatchReadResponse
/// </summary>
[DataContract]
public partial class BatchReadResponse : Response

{
	/// <summary>
	/// Initializes a new instance of the <see cref="BatchReadResponse" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	public BatchReadResponse(List<ReadResponse> Responses)
	{
		this.Responses = Responses;
	}

	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<ReadResponse> Responses { get; set; }







	
}