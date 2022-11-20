using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// GridDefinition
/// </summary>
[DataContract]
public class GridDefinition
{
	/// <summary>
	/// GridId
	/// </summary>
	[DataMember(Name = "gridId", EmitDefaultValue = false)]
	public string GridId { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;
}