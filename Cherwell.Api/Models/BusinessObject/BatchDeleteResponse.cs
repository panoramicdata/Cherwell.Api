using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BatchDeleteResponse
/// </summary>
[DataContract]
public class BatchDeleteResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<DeleteResponse> Responses { get; set; } = null!;
}