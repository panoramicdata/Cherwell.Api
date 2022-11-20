using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetApiClientSettingsResponseItem
/// </summary>
[DataContract]
public class GetApiClientSettingsResponseItem
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; } = null!;
}
