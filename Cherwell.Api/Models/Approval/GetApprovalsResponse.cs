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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ApprovalGetApprovalsResponse {\n");
		sb.Append("  TotalRecords: ").Append(TotalRecords).Append('\n');
		sb.Append("  Approvals: ").Append(Approvals).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)
			if (TotalRecords != null)
			{
				hash = hash * 59 + TotalRecords.GetHashCode();
			}

			if (Approvals != null)
			{
				hash = hash * 59 + Approvals.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	
}