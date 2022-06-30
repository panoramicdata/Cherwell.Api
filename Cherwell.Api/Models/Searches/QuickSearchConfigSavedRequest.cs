using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigSavedRequest
/// </summary>
[DataContract]
public partial class QuickSearchConfigSavedRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchConfigSavedRequest" /> class.
	/// </summary>
	/// <param name="StandIn">StandIn.</param>
	/// <param name="BusObIds">BusObIds.</param>
	/// <param name="IsGeneral">IsGeneral.</param>
	public QuickSearchConfigSavedRequest(string StandIn, List<string> BusObIds, bool IsGeneral)
	{
		this.StandIn = StandIn;
		this.BusObIds = BusObIds;
		this.IsGeneral = IsGeneral;
	}

	/// <summary>
	/// StandIn
	/// </summary>
	[DataMember(Name = "standIn", EmitDefaultValue = false)]
	public string StandIn { get; set; } = null!;

	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; } = null!;

	/// <summary>
	/// IsGeneral
	/// </summary>
	[DataMember(Name = "isGeneral", EmitDefaultValue = false)]
	public bool IsGeneral { get; set; }
}
