using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionsResponseTransition
/// </summary>
[DataContract]
public partial class GetTransitionsResponseTransition
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; } = null!;
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;
	/// <summary>
	/// FromStatusId
	/// </summary>
	[DataMember(Name = "fromStatusId", EmitDefaultValue = false)]
	public string FromStatusId { get; set; } = null!;
	/// <summary>
	/// ToStatusId
	/// </summary>
	[DataMember(Name = "toStatusId", EmitDefaultValue = false)]
	public string ToStatusId { get; set; } = null!;
}
