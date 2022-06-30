using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetStatusesResponseStatuses
/// </summary>
[DataContract]
public partial class GetStatusesResponseStatuses
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; } = null!;

	/// <summary>
	/// IsInitial
	/// </summary>
	[DataMember(Name = "isInitial", EmitDefaultValue = false)]
	public bool IsInitial { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// StageId
	/// </summary>
	[DataMember(Name = "stageId", EmitDefaultValue = false)]
	public string StageId { get; set; } = null!;
}
