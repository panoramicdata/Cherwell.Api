using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Approval;

/// <summary>
/// ApprovalGetApprovalsResponse
/// </summary>
[DataContract]
public partial class GetApprovalsResponse : Response 
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetApprovalsResponse" /> class.
	/// </summary>
	/// <param name="TotalRecords">TotalRecords.</param>
	/// <param name="Approvals">Approvals.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public GetApprovalsResponse(int? TotalRecords, List<ApprovalReadResponse> Approvals, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.TotalRecords = TotalRecords;
		this.Approvals = Approvals;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// TotalRecords
	/// </summary>
	[DataMember(Name = "totalRecords", EmitDefaultValue = false)]
	public int? TotalRecords { get; set; }

	/// <summary>
	/// Approvals
	/// </summary>
	[DataMember(Name = "approvals", EmitDefaultValue = false)]
	public List<ApprovalReadResponse> Approvals { get; set; }












	
}