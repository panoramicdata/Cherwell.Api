using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// Summary
/// </summary>
[DataContract]
public class Summary
{
	/// <summary>
	/// FirstRecIdField
	/// </summary>
	[DataMember(Name = "firstRecIdField", EmitDefaultValue = false)]
	public string FirstRecIdField { get; set; } = null!;

	/// <summary>
	/// GroupSummaries
	/// </summary>
	[DataMember(Name = "groupSummaries", EmitDefaultValue = false)]
	public List<Summary> GroupSummaries { get; set; } = null!;

	/// <summary>
	/// RecIdFields
	/// </summary>
	[DataMember(Name = "recIdFields", EmitDefaultValue = false)]
	public string RecIdFields { get; set; } = null!;

	/// <summary>
	/// StateFieldId
	/// </summary>
	[DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
	public string StateFieldId { get; set; } = null!;

	/// <summary>
	/// States
	/// </summary>
	[DataMember(Name = "states", EmitDefaultValue = false)]
	public string States { get; set; } = null!;

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// Group
	/// </summary>
	[DataMember(Name = "group", EmitDefaultValue = false)]
	public bool Group { get; set; }

	/// <summary>
	/// Lookup
	/// </summary>
	[DataMember(Name = "lookup", EmitDefaultValue = false)]
	public bool Lookup { get; set; }

	/// <summary>
	/// Major
	/// </summary>
	[DataMember(Name = "major", EmitDefaultValue = false)]
	public bool Major { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Supporting
	/// </summary>
	[DataMember(Name = "supporting", EmitDefaultValue = false)]
	public bool Supporting { get; set; }
}
