using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionOptionsResponse
/// </summary>
[DataContract]
public partial class GetTransitionOptionsResponse : Response
{
	/// <summary>
	/// Transitions
	/// </summary>
	[DataMember(Name = "transitions", EmitDefaultValue = false)]
	public List<GetTransitionOptionsResponseTransition> Transitions { get; set; } = null!;
}
