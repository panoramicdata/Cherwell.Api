using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleTransitionRecordRequest
/// </summary>
[DataContract]
public partial class TransitionRecordRequest
{
	/// <summary>
	/// TransitionOptionId
	/// </summary>
	[DataMember(Name = "transitionOptionId", EmitDefaultValue = false)]
	public string TransitionOptionId { get; set; } = null!;
}
