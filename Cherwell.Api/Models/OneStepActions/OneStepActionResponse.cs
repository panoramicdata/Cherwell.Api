using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.OneStepActions;

/// <summary>
/// OneStepActionsOneStepActionResponse
/// </summary>
[DataContract]
public partial class OneStepActionResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="OneStepActionResponse" /> class.
	/// </summary>
	/// <param name="Completed">Completed.</param>
	/// <param name="CurrentPrimaryBusObId">CurrentPrimaryBusObId.</param>
	/// <param name="CurrentPrimaryBusObRecId">CurrentPrimaryBusObRecId.</param>
	/// <param name="HasNewAccessToken">HasNewAccessToken.</param>
	/// <param name="NewAccessToken">NewAccessToken.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public OneStepActionResponse(bool? Completed, string CurrentPrimaryBusObId, string CurrentPrimaryBusObRecId, bool? HasNewAccessToken, string NewAccessToken, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Completed = Completed;
		this.CurrentPrimaryBusObId = CurrentPrimaryBusObId;
		this.CurrentPrimaryBusObRecId = CurrentPrimaryBusObRecId;
		this.HasNewAccessToken = HasNewAccessToken;
		this.NewAccessToken = NewAccessToken;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Completed
	/// </summary>
	[DataMember(Name = "completed", EmitDefaultValue = false)]
	public bool? Completed { get; set; }

	/// <summary>
	/// CurrentPrimaryBusObId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObId { get; set; }

	/// <summary>
	/// CurrentPrimaryBusObRecId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObRecId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObRecId { get; set; }

	/// <summary>
	/// HasNewAccessToken
	/// </summary>
	[DataMember(Name = "hasNewAccessToken", EmitDefaultValue = false)]
	public bool? HasNewAccessToken { get; set; }

	/// <summary>
	/// NewAccessToken
	/// </summary>
	[DataMember(Name = "newAccessToken", EmitDefaultValue = false)]
	public string NewAccessToken { get; set; }
}
