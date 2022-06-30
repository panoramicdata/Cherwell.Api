using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigurationRequest
/// </summary>
[DataContract]
public partial class QuickSearchConfigurationRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchConfigurationRequest" /> class.
	/// </summary>
	/// <param name="BusObIds">BusObIds.</param>
	public QuickSearchConfigurationRequest(List<string> BusObIds)
	{
		this.BusObIds = BusObIds;
	}

	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; } = null!;
}
