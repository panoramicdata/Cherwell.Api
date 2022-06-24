using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchSpecificByIdRequest
/// </summary>
[DataContract]
public partial class QuickSearchSpecificByIdRequest : IEquatable<QuickSearchSpecificByIdRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchSpecificByIdRequest" /> class.
	/// </summary>
	/// <param name="BusObIds">BusObIds.</param>
	/// <param name="StandIn">StandIn.</param>
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
	public QuickSearchSpecificByIdRequest(List<string> BusObIds, string StandIn, bool? Ascending, bool? IsBusObTarget, bool? NonFinalState, bool? SearchAnyWords, bool? SearchAttachments, bool? SearchRelated, string SearchText, ChangedLimit SelectedChangedLimit, string SelectedSortByFieldId, bool? SortByRelevance, string SpecificSearchTargetId, bool? UseSortBy)
	{
		this.BusObIds = BusObIds;
		this.StandIn = StandIn;
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
	/// Gets or Sets BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; }

	/// <summary>
	/// Gets or Sets StandIn
	/// </summary>
	[DataMember(Name = "standIn", EmitDefaultValue = false)]
	public string StandIn { get; set; }

	/// <summary>
	/// Gets or Sets Ascending
	/// </summary>
	[DataMember(Name = "ascending", EmitDefaultValue = false)]
	public bool? Ascending { get; set; }

	/// <summary>
	/// Gets or Sets IsBusObTarget
	/// </summary>
	[DataMember(Name = "isBusObTarget", EmitDefaultValue = false)]
	public bool? IsBusObTarget { get; set; }

	/// <summary>
	/// Gets or Sets NonFinalState
	/// </summary>
	[DataMember(Name = "nonFinalState", EmitDefaultValue = false)]
	public bool? NonFinalState { get; set; }

	/// <summary>
	/// Gets or Sets SearchAnyWords
	/// </summary>
	[DataMember(Name = "searchAnyWords", EmitDefaultValue = false)]
	public bool? SearchAnyWords { get; set; }

	/// <summary>
	/// Gets or Sets SearchAttachments
	/// </summary>
	[DataMember(Name = "searchAttachments", EmitDefaultValue = false)]
	public bool? SearchAttachments { get; set; }

	/// <summary>
	/// Gets or Sets SearchRelated
	/// </summary>
	[DataMember(Name = "searchRelated", EmitDefaultValue = false)]
	public bool? SearchRelated { get; set; }

	/// <summary>
	/// Gets or Sets SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; }

	/// <summary>
	/// Gets or Sets SelectedChangedLimit
	/// </summary>
	[DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
	public ChangedLimit SelectedChangedLimit { get; set; }

	/// <summary>
	/// Gets or Sets SelectedSortByFieldId
	/// </summary>
	[DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
	public string SelectedSortByFieldId { get; set; }

	/// <summary>
	/// Gets or Sets SortByRelevance
	/// </summary>
	[DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
	public bool? SortByRelevance { get; set; }

	/// <summary>
	/// Gets or Sets SpecificSearchTargetId
	/// </summary>
	[DataMember(Name = "specificSearchTargetId", EmitDefaultValue = false)]
	public string SpecificSearchTargetId { get; set; }

	/// <summary>
	/// Gets or Sets UseSortBy
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
		sb.Append("class SearchesQuickSearchSpecificByIdRequest {\n");
		sb.Append("  BusObIds: ").Append(BusObIds).Append('\n');
		sb.Append("  StandIn: ").Append(StandIn).Append('\n');
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
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as QuickSearchSpecificByIdRequest);
	}

	/// <summary>
	/// Returns true if SearchesQuickSearchSpecificByIdRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesQuickSearchSpecificByIdRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(QuickSearchSpecificByIdRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObIds == other.BusObIds ||
					BusObIds != null &&
					BusObIds.SequenceEqual(other.BusObIds)
				) &&
				(
					StandIn == other.StandIn ||
					StandIn != null &&
					StandIn.Equals(other.StandIn, StringComparison.Ordinal)
				) &&
				(
					Ascending == other.Ascending ||
					Ascending != null &&
					Ascending.Equals(other.Ascending)
				) &&
				(
					IsBusObTarget == other.IsBusObTarget ||
					IsBusObTarget != null &&
					IsBusObTarget.Equals(other.IsBusObTarget)
				) &&
				(
					NonFinalState == other.NonFinalState ||
					NonFinalState != null &&
					NonFinalState.Equals(other.NonFinalState)
				) &&
				(
					SearchAnyWords == other.SearchAnyWords ||
					SearchAnyWords != null &&
					SearchAnyWords.Equals(other.SearchAnyWords)
				) &&
				(
					SearchAttachments == other.SearchAttachments ||
					SearchAttachments != null &&
					SearchAttachments.Equals(other.SearchAttachments)
				) &&
				(
					SearchRelated == other.SearchRelated ||
					SearchRelated != null &&
					SearchRelated.Equals(other.SearchRelated)
				) &&
				(
					SearchText == other.SearchText ||
					SearchText != null &&
					SearchText.Equals(other.SearchText, StringComparison.Ordinal)
				) &&
				(
					SelectedChangedLimit == other.SelectedChangedLimit ||
					SelectedChangedLimit != null &&
					SelectedChangedLimit.Equals(other.SelectedChangedLimit)
				) &&
				(
					SelectedSortByFieldId == other.SelectedSortByFieldId ||
					SelectedSortByFieldId != null &&
					SelectedSortByFieldId.Equals(other.SelectedSortByFieldId, StringComparison.Ordinal)
				) &&
				(
					SortByRelevance == other.SortByRelevance ||
					SortByRelevance != null &&
					SortByRelevance.Equals(other.SortByRelevance)
				) &&
				(
					SpecificSearchTargetId == other.SpecificSearchTargetId ||
					SpecificSearchTargetId != null &&
					SpecificSearchTargetId.Equals(other.SpecificSearchTargetId, StringComparison.Ordinal)
				) &&
				(
					UseSortBy == other.UseSortBy ||
					UseSortBy != null &&
					UseSortBy.Equals(other.UseSortBy)
				);
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
			if (BusObIds != null)
			{
				hash = hash * 59 + BusObIds.GetHashCode();
			}

			if (StandIn != null)
			{
				hash = hash * 59 + StandIn.GetHashCode();
			}

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

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
