using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchSpecificRequest
/// </summary>
[DataContract]
public partial class QuickSearchSpecificRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchSpecificRequest" /> class.
	/// </summary>
	/// <param name="Ascending">Ascending.</param>
	/// <param name="IsBusObTarget">IsBusObTarget.</param>
	/// <param name="NonFinalState">NonFinalState.</param>
	/// <param name="SearchAnyWords">SearchAnyWords.</param>
	/// <param name="SearchAttachments">SearchAttachments.</param>
	/// <param name="SearchRelated">SearchRelated.</param>
	/// <param name="SearchText">SearchText.</param>
	/// <param name="SelectedChangedLimit">SelectedChangedLimit.</param>
	/// <param name="SelectedSortByFieldId">SelectedSortByFieldId.</param>
	/// <param name="SortByRelevance">SortByRelevance.</param>
	/// <param name="SpecificSearchTargetId">SpecificSearchTargetId.</param>
	/// <param name="UseSortBy">UseSortBy.</param>
	public QuickSearchSpecificRequest(bool? Ascending, bool? IsBusObTarget, bool? NonFinalState, bool? SearchAnyWords, bool? SearchAttachments, bool? SearchRelated, string SearchText, ChangedLimit SelectedChangedLimit, string SelectedSortByFieldId, bool? SortByRelevance, string SpecificSearchTargetId, bool? UseSortBy)
	{
		this.Ascending = Ascending;
		this.IsBusObTarget = IsBusObTarget;
		this.NonFinalState = NonFinalState;
		this.SearchAnyWords = SearchAnyWords;
		this.SearchAttachments = SearchAttachments;
		this.SearchRelated = SearchRelated;
		this.SearchText = SearchText;
		this.SelectedChangedLimit = SelectedChangedLimit;
		this.SelectedSortByFieldId = SelectedSortByFieldId;
		this.SortByRelevance = SortByRelevance;
		this.SpecificSearchTargetId = SpecificSearchTargetId;
		this.UseSortBy = UseSortBy;
	}

	/// <summary>
	/// Ascending
	/// </summary>
	[DataMember(Name = "ascending", EmitDefaultValue = false)]
	public bool? Ascending { get; set; }

	/// <summary>
	/// IsBusObTarget
	/// </summary>
	[DataMember(Name = "isBusObTarget", EmitDefaultValue = false)]
	public bool? IsBusObTarget { get; set; }

	/// <summary>
	/// NonFinalState
	/// </summary>
	[DataMember(Name = "nonFinalState", EmitDefaultValue = false)]
	public bool? NonFinalState { get; set; }

	/// <summary>
	/// SearchAnyWords
	/// </summary>
	[DataMember(Name = "searchAnyWords", EmitDefaultValue = false)]
	public bool? SearchAnyWords { get; set; }

	/// <summary>
	/// SearchAttachments
	/// </summary>
	[DataMember(Name = "searchAttachments", EmitDefaultValue = false)]
	public bool? SearchAttachments { get; set; }

	/// <summary>
	/// SearchRelated
	/// </summary>
	[DataMember(Name = "searchRelated", EmitDefaultValue = false)]
	public bool? SearchRelated { get; set; }

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; }

	/// <summary>
	/// SelectedChangedLimit
	/// </summary>
	[DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
	public ChangedLimit SelectedChangedLimit { get; set; }

	/// <summary>
	/// SelectedSortByFieldId
	/// </summary>
	[DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
	public string SelectedSortByFieldId { get; set; }

	/// <summary>
	/// SortByRelevance
	/// </summary>
	[DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
	public bool? SortByRelevance { get; set; }

	/// <summary>
	/// SpecificSearchTargetId
	/// </summary>
	[DataMember(Name = "specificSearchTargetId", EmitDefaultValue = false)]
	public string SpecificSearchTargetId { get; set; }

	/// <summary>
	/// UseSortBy
	/// </summary>
	[DataMember(Name = "useSortBy", EmitDefaultValue = false)]
	public bool? UseSortBy { get; set; }
}
