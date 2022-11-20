using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionOptionsResponseTransition
/// </summary>
[DataContract]
public class GetTransitionOptionsResponseTransition
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; } = null!;

	/// <summary>
	/// IsAvailable
	/// </summary>
	[DataMember(Name = "isAvailable", EmitDefaultValue = false)]
	public bool IsAvailable { get; set; }

	/// <summary>
	/// Criteria
	/// </summary>
	[DataMember(Name = "criteria", EmitDefaultValue = false)]
	public List<string> Criteria { get; set; } = null!;
}
