using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchSpecificByIdRequest
/// </summary>
[DataContract]
public class QuickSearchSpecificByIdRequest
{
	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; } = null!;

	/// <summary>
	/// StandIn
	/// </summary>
	[DataMember(Name = "standIn", EmitDefaultValue = false)]
	public string StandIn { get; set; } = null!;

	/// <summary>
	/// Ascending
	/// </summary>
	[DataMember(Name = "ascending", EmitDefaultValue = false)]
	public bool Ascending { get; set; }

	/// <summary>
	/// IsBusObTarget
	/// </summary>
	[DataMember(Name = "isBusObTarget", EmitDefaultValue = false)]
	public bool IsBusObTarget { get; set; }

	/// <summary>
	/// NonFinalState
	/// </summary>
	[DataMember(Name = "nonFinalState", EmitDefaultValue = false)]
	public bool NonFinalState { get; set; }

	/// <summary>
	/// SearchAnyWords
	/// </summary>
	[DataMember(Name = "searchAnyWords", EmitDefaultValue = false)]
	public bool SearchAnyWords { get; set; }

	/// <summary>
	/// SearchAttachments
	/// </summary>
	[DataMember(Name = "searchAttachments", EmitDefaultValue = false)]
	public bool SearchAttachments { get; set; }

	/// <summary>
	/// SearchRelated
	/// </summary>
	[DataMember(Name = "searchRelated", EmitDefaultValue = false)]
	public bool SearchRelated { get; set; }

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; } = null!;

	/// <summary>
	/// SelectedChangedLimit
	/// </summary>
	[DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
	public ChangedLimit SelectedChangedLimit { get; set; } = null!;

	/// <summary>
	/// SelectedSortByFieldId
	/// </summary>
	[DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
	public string SelectedSortByFieldId { get; set; } = null!;

	/// <summary>
	/// SortByRelevance
	/// </summary>
	[DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
	public bool SortByRelevance { get; set; }

	/// <summary>
	/// SpecificSearchTargetId
	/// </summary>
	[DataMember(Name = "specificSearchTargetId", EmitDefaultValue = false)]
	public string SpecificSearchTargetId { get; set; } = null!;

	/// <summary>
	/// UseSortBy
	/// </summary>
	[DataMember(Name = "useSortBy", EmitDefaultValue = false)]
	public bool UseSortBy { get; set; }
}
