using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionsResponse
/// </summary>
[DataContract]
public partial class GetTransitionsResponse : Response
{
	/// <summary>
	/// Transitions
	/// </summary>
	[DataMember(Name = "transitions", EmitDefaultValue = false)]
	public List<GetTransitionsResponseTransition>? Transitions { get; set; }
}
