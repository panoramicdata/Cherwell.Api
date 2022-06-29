using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStatusesResponse
/// </summary>
[DataContract]
public partial class GetStatusesResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetStatusesResponse" /> class.
	/// </summary>
	/// <param name="Statuses">Statuses.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public GetStatusesResponse(List<GetStatusesResponseStatuses> Statuses, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Statuses = Statuses;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Statuses
	/// </summary>
	[DataMember(Name = "statuses", EmitDefaultValue = false)]
	public List<GetStatusesResponseStatuses> Statuses { get; set; }











	
}
