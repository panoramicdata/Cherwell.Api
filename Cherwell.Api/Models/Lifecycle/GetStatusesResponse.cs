using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStatusesResponse
/// </summary>
[DataContract]
public partial class GetStatusesResponse : Response
{
	/// <summary>
	/// Statuses
	/// </summary>
	[DataMember(Name = "statuses", EmitDefaultValue = false)]
	public List<GetStatusesResponseStatuses> Statuses { get; set; } = null!;
}
