using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchRequest
/// </summary>
[DataContract]
public partial class QuickSearchRequest
{
	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; } = null!;

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; } = null!;
}
