using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetApiClientSettingsResponse
/// </summary>
[DataContract]
public class GetApiClientSettingsResponse : Response
{
	/// <summary>
	/// Settings
	/// </summary>
	[DataMember(Name = "settings", EmitDefaultValue = false)]
	public List<GetApiClientSettingsResponseItem> Settings { get; set; } = null!;
}
