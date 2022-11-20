using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BatchReadResponse
/// </summary>
[DataContract]
public class BatchReadResponse : Response

{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<ReadResponse> Responses { get; set; } = null!;
}