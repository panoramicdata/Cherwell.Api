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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesQuickSearchSpecificRequest {\n");
		sb.Append("  Ascending: ").Append(Ascending).Append('\n');
		sb.Append("  IsBusObTarget: ").Append(IsBusObTarget).Append('\n');
		sb.Append("  NonFinalState: ").Append(NonFinalState).Append('\n');
		sb.Append("  SearchAnyWords: ").Append(SearchAnyWords).Append('\n');
		sb.Append("  SearchAttachments: ").Append(SearchAttachments).Append('\n');
		sb.Append("  SearchRelated: ").Append(SearchRelated).Append('\n');
		sb.Append("  SearchText: ").Append(SearchText).Append('\n');
		sb.Append("  SelectedChangedLimit: ").Append(SelectedChangedLimit).Append('\n');
		sb.Append("  SelectedSortByFieldId: ").Append(SelectedSortByFieldId).Append('\n');
		sb.Append("  SortByRelevance: ").Append(SortByRelevance).Append('\n');
		sb.Append("  SpecificSearchTargetId: ").Append(SpecificSearchTargetId).Append('\n');
		sb.Append("  UseSortBy: ").Append(UseSortBy).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)
			if (Ascending != null)
			{
				hash = hash * 59 + Ascending.GetHashCode();
			}

			if (IsBusObTarget != null)
			{
				hash = hash * 59 + IsBusObTarget.GetHashCode();
			}

			if (NonFinalState != null)
			{
				hash = hash * 59 + NonFinalState.GetHashCode();
			}

			if (SearchAnyWords != null)
			{
				hash = hash * 59 + SearchAnyWords.GetHashCode();
			}

			if (SearchAttachments != null)
			{
				hash = hash * 59 + SearchAttachments.GetHashCode();
			}

			if (SearchRelated != null)
			{
				hash = hash * 59 + SearchRelated.GetHashCode();
			}

			if (SearchText != null)
			{
				hash = hash * 59 + SearchText.GetHashCode();
			}

			if (SelectedChangedLimit != null)
			{
				hash = hash * 59 + SelectedChangedLimit.GetHashCode();
			}

			if (SelectedSortByFieldId != null)
			{
				hash = hash * 59 + SelectedSortByFieldId.GetHashCode();
			}

			if (SortByRelevance != null)
			{
				hash = hash * 59 + SortByRelevance.GetHashCode();
			}

			if (SpecificSearchTargetId != null)
			{
				hash = hash * 59 + SpecificSearchTargetId.GetHashCode();
			}

			if (UseSortBy != null)
			{
				hash = hash * 59 + UseSortBy.GetHashCode();
			}

			return hash;
		}
	}

	
}
