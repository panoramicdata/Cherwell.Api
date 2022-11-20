using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Approval;

/// <summary>
/// GetApprovalsResponse
/// </summary>
[DataContract]
public class GetApprovalsResponse : Response 
{
	/// <summary>
	/// TotalRecords
	/// </summary>
	[DataMember(Name = "totalRecords", EmitDefaultValue = false)]
	public int TotalRecords { get; set; }

	/// <summary>
	/// Approvals
	/// </summary>
	[DataMember(Name = "approvals", EmitDefaultValue = false)]
	public List<ApprovalReadResponse> Approvals { get; set; } = null!;
}