using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesChangedLimit
/// </summary>
[DataContract]
public class ChangedLimit
{
	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// Units
	/// </summary>
	[DataMember(Name = "units", EmitDefaultValue = false)]
	public string Units { get; set; } = null!;

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public int Value { get; set; }
}
