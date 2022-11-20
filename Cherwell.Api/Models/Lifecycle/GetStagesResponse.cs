using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStagesResponse
/// </summary>
[DataContract]
public class GetStagesResponse : Response
{
	/// <summary>
	/// Stages
	/// </summary>
	[DataMember(Name = "stages", EmitDefaultValue = false)]
	public List<GetStagesResponseStages> Stages { get; set; } = null!;
}
