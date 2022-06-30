using System.Runtime.Serialization;

namespace Cherwell.Api.Models.OneStepActions;

/// <summary>
/// OneStepActionsOneStepActionResponse
/// </summary>
[DataContract]
public partial class OneStepActionResponse : Response
{
	/// <summary>
	/// Completed
	/// </summary>
	[DataMember(Name = "completed", EmitDefaultValue = false)]
	public bool Completed { get; set; }

	/// <summary>
	/// CurrentPrimaryBusObId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObId { get; set; } = null!;
	/// <summary>
	/// CurrentPrimaryBusObRecId
	/// </summary>
	[DataMember(Name = "currentPrimaryBusObRecId", EmitDefaultValue = false)]
	public string CurrentPrimaryBusObRecId { get; set; } = null!;
	/// <summary>
	/// HasNewAccessToken
	/// </summary>
	[DataMember(Name = "hasNewAccessToken", EmitDefaultValue = false)]
	public bool HasNewAccessToken { get; set; }

	/// <summary>
	/// NewAccessToken
	/// </summary>
	[DataMember(Name = "newAccessToken", EmitDefaultValue = false)]
	public string NewAccessToken { get; set; } = null!;
}
