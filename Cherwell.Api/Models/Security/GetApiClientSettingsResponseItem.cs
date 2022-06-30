using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetApiClientSettingsResponseItem
/// </summary>
[DataContract]
public partial class GetApiClientSettingsResponseItem
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string? StandInKey { get; set; }
}
