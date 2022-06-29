using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Approval;

/// <summary>
/// ApprovalApprovalReadResponse
/// </summary>
[DataContract]
public partial class ApprovalReadResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ApprovalReadResponse" /> class.
	/// </summary>
	/// <param name="properties">properties.</param>
	/// <param name="links">Links.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="httpStatusCode">HttpStatusCode.</param>
	public ApprovalReadResponse(
		Dictionary<string, object> properties,
		List<Link> links,
		string errorCode,
		string errorMessage,
		bool? hasError = default,
		EnumHttpStatusCode? httpStatusCode = default)
	{
		Properties = properties;
		Links = links;
		ErrorCode = errorCode;
		ErrorMessage = errorMessage;
		HasError = hasError;
		HttpStatusCode = httpStatusCode;
	}

	/// <summary>
	/// properties
	/// </summary>
	[DataMember(Name = "properties", EmitDefaultValue = false)]
	public Dictionary<string, object> Properties { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }



	
}
