using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStagesResponse
/// </summary>
[DataContract]
public partial class GetStagesResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetStagesResponse" /> class.
	/// </summary>
	/// <param name="Stages">Stages.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public GetStagesResponse(List<GetStagesResponseStages> Stages, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Stages = Stages;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Stages
	/// </summary>
	[DataMember(Name = "stages", EmitDefaultValue = false)]
	public List<GetStagesResponseStages> Stages { get; set; }











	
}
