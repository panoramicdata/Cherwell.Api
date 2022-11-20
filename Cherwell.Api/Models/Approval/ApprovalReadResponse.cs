using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Approval;

/// <summary>
/// ApprovalReadResponse
/// </summary>
[DataContract]
public class ApprovalReadResponse : Response
{
	/// <summary>
	/// properties
	/// </summary>
	[DataMember(Name = "properties", EmitDefaultValue = false)]
	public Dictionary<string, object> Properties { get; set; } = null!;

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; } = null!;
}
