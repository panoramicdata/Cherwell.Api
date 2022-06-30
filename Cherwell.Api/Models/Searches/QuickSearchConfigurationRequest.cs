using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigurationRequest
/// </summary>
[DataContract]
public partial class QuickSearchConfigurationRequest
{
	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; } = null!;
}
