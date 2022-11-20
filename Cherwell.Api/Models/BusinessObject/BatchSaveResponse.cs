using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BatchSaveResponse
/// </summary>
[DataContract]
public class BatchSaveResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<SaveResponse> Responses { get; set; } = null!;
}