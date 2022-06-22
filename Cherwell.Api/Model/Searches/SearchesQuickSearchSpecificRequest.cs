using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Cherwell.Api.Model.Searches
{
    /// <summary>
    /// SearchesQuickSearchSpecificRequest
    /// </summary>
    [DataContract]
    public partial class SearchesQuickSearchSpecificRequest : IEquatable<SearchesQuickSearchSpecificRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesQuickSearchSpecificRequest" /> class.
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
        public SearchesQuickSearchSpecificRequest(bool? Ascending = default(bool?), bool? IsBusObTarget = default(bool?), bool? NonFinalState = default(bool?), bool? SearchAnyWords = default(bool?), bool? SearchAttachments = default(bool?), bool? SearchRelated = default(bool?), string SearchText = default(string), SearchesChangedLimit SelectedChangedLimit = default(SearchesChangedLimit), string SelectedSortByFieldId = default(string), bool? SortByRelevance = default(bool?), string SpecificSearchTargetId = default(string), bool? UseSortBy = default(bool?))
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
        public SearchesChangedLimit SelectedChangedLimit { get; set; }
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
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SearchesQuickSearchSpecificRequest);
        }

        /// <summary>
        /// Returns true if SearchesQuickSearchSpecificRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesQuickSearchSpecificRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesQuickSearchSpecificRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Ascending == other.Ascending ||
                    this.Ascending != null &&
                    this.Ascending.Equals(other.Ascending)
                ) &&
                (
                    this.IsBusObTarget == other.IsBusObTarget ||
                    this.IsBusObTarget != null &&
                    this.IsBusObTarget.Equals(other.IsBusObTarget)
                ) &&
                (
                    this.NonFinalState == other.NonFinalState ||
                    this.NonFinalState != null &&
                    this.NonFinalState.Equals(other.NonFinalState)
                ) &&
                (
                    this.SearchAnyWords == other.SearchAnyWords ||
                    this.SearchAnyWords != null &&
                    this.SearchAnyWords.Equals(other.SearchAnyWords)
                ) &&
                (
                    this.SearchAttachments == other.SearchAttachments ||
                    this.SearchAttachments != null &&
                    this.SearchAttachments.Equals(other.SearchAttachments)
                ) &&
                (
                    this.SearchRelated == other.SearchRelated ||
                    this.SearchRelated != null &&
                    this.SearchRelated.Equals(other.SearchRelated)
                ) &&
                (
                    this.SearchText == other.SearchText ||
                    this.SearchText != null &&
                    this.SearchText.Equals(other.SearchText)
                ) &&
                (
                    this.SelectedChangedLimit == other.SelectedChangedLimit ||
                    this.SelectedChangedLimit != null &&
                    this.SelectedChangedLimit.Equals(other.SelectedChangedLimit)
                ) &&
                (
                    this.SelectedSortByFieldId == other.SelectedSortByFieldId ||
                    this.SelectedSortByFieldId != null &&
                    this.SelectedSortByFieldId.Equals(other.SelectedSortByFieldId)
                ) &&
                (
                    this.SortByRelevance == other.SortByRelevance ||
                    this.SortByRelevance != null &&
                    this.SortByRelevance.Equals(other.SortByRelevance)
                ) &&
                (
                    this.SpecificSearchTargetId == other.SpecificSearchTargetId ||
                    this.SpecificSearchTargetId != null &&
                    this.SpecificSearchTargetId.Equals(other.SpecificSearchTargetId)
                ) &&
                (
                    this.UseSortBy == other.UseSortBy ||
                    this.UseSortBy != null &&
                    this.UseSortBy.Equals(other.UseSortBy)
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
                if (this.Ascending != null)
                    hash = hash * 59 + this.Ascending.GetHashCode();
                if (this.IsBusObTarget != null)
                    hash = hash * 59 + this.IsBusObTarget.GetHashCode();
                if (this.NonFinalState != null)
                    hash = hash * 59 + this.NonFinalState.GetHashCode();
                if (this.SearchAnyWords != null)
                    hash = hash * 59 + this.SearchAnyWords.GetHashCode();
                if (this.SearchAttachments != null)
                    hash = hash * 59 + this.SearchAttachments.GetHashCode();
                if (this.SearchRelated != null)
                    hash = hash * 59 + this.SearchRelated.GetHashCode();
                if (this.SearchText != null)
                    hash = hash * 59 + this.SearchText.GetHashCode();
                if (this.SelectedChangedLimit != null)
                    hash = hash * 59 + this.SelectedChangedLimit.GetHashCode();
                if (this.SelectedSortByFieldId != null)
                    hash = hash * 59 + this.SelectedSortByFieldId.GetHashCode();
                if (this.SortByRelevance != null)
                    hash = hash * 59 + this.SortByRelevance.GetHashCode();
                if (this.SpecificSearchTargetId != null)
                    hash = hash * 59 + this.SpecificSearchTargetId.GetHashCode();
                if (this.UseSortBy != null)
                    hash = hash * 59 + this.UseSortBy.GetHashCode();
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
}
