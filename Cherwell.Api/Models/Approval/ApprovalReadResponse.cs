using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Approval;

/// <summary>
/// ApprovalReadResponse
/// </summary>
[DataContract]
public partial class ApprovalReadResponse : Response
{
	/// <summary>
	/// properties
	/// </summary>
	[DataMember(Name = "properties", EmitDefaultValue = false)]
	public Dictionary<string, object>? Properties { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link>? Links { get; set; }
}
