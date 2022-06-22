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
    /// SearchesQuickSearchItem
    /// </summary>
    [DataContract]
    public partial class SearchesQuickSearchItem : IEquatable<SearchesQuickSearchItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ChangedOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChangedOptionEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Use for "Use"
            /// </summary>
            [EnumMember(Value = "Use")]
            Use,

            /// <summary>
            /// Enum Display for "Display"
            /// </summary>
            [EnumMember(Value = "Display")]
            Display,

            /// <summary>
            /// Enum UseAndDisplay for "UseAndDisplay"
            /// </summary>
            [EnumMember(Value = "UseAndDisplay")]
            UseAndDisplay
        }

        /// <summary>
        /// Gets or Sets NonFinalStateOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NonFinalStateOptionEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Use for "Use"
            /// </summary>
            [EnumMember(Value = "Use")]
            Use,

            /// <summary>
            /// Enum Display for "Display"
            /// </summary>
            [EnumMember(Value = "Display")]
            Display,

            /// <summary>
            /// Enum UseAndDisplay for "UseAndDisplay"
            /// </summary>
            [EnumMember(Value = "UseAndDisplay")]
            UseAndDisplay
        }

        /// <summary>
        /// Gets or Sets SearchAnyWordsOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchAnyWordsOptionEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Use for "Use"
            /// </summary>
            [EnumMember(Value = "Use")]
            Use,

            /// <summary>
            /// Enum Display for "Display"
            /// </summary>
            [EnumMember(Value = "Display")]
            Display,

            /// <summary>
            /// Enum UseAndDisplay for "UseAndDisplay"
            /// </summary>
            [EnumMember(Value = "UseAndDisplay")]
            UseAndDisplay
        }

        /// <summary>
        /// Gets or Sets SearchAttachmentsOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchAttachmentsOptionEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Use for "Use"
            /// </summary>
            [EnumMember(Value = "Use")]
            Use,

            /// <summary>
            /// Enum Display for "Display"
            /// </summary>
            [EnumMember(Value = "Display")]
            Display,

            /// <summary>
            /// Enum UseAndDisplay for "UseAndDisplay"
            /// </summary>
            [EnumMember(Value = "UseAndDisplay")]
            UseAndDisplay
        }

        /// <summary>
        /// Gets or Sets SearchRelatedOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchRelatedOptionEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Use for "Use"
            /// </summary>
            [EnumMember(Value = "Use")]
            Use,

            /// <summary>
            /// Enum Display for "Display"
            /// </summary>
            [EnumMember(Value = "Display")]
            Display,

            /// <summary>
            /// Enum UseAndDisplay for "UseAndDisplay"
            /// </summary>
            [EnumMember(Value = "UseAndDisplay")]
            UseAndDisplay
        }

        /// <summary>
        /// Gets or Sets SearchTargetType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SearchTargetTypeEnum
        {

            /// <summary>
            /// Enum BusOb for "BusOb"
            /// </summary>
            [EnumMember(Value = "BusOb")]
            BusOb,

            /// <summary>
            /// Enum DocRepository for "DocRepository"
            /// </summary>
            [EnumMember(Value = "DocRepository")]
            DocRepository
        }

        /// <summary>
        /// Gets or Sets SortByOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortByOptionEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Use for "Use"
            /// </summary>
            [EnumMember(Value = "Use")]
            Use,

            /// <summary>
            /// Enum Display for "Display"
            /// </summary>
            [EnumMember(Value = "Display")]
            Display,

            /// <summary>
            /// Enum UseAndDisplay for "UseAndDisplay"
            /// </summary>
            [EnumMember(Value = "UseAndDisplay")]
            UseAndDisplay
        }

        /// <summary>
        /// Gets or Sets ChangedOption
        /// </summary>
        [DataMember(Name = "changedOption", EmitDefaultValue = false)]
        public ChangedOptionEnum? ChangedOption { get; set; }
        /// <summary>
        /// Gets or Sets NonFinalStateOption
        /// </summary>
        [DataMember(Name = "nonFinalStateOption", EmitDefaultValue = false)]
        public NonFinalStateOptionEnum? NonFinalStateOption { get; set; }
        /// <summary>
        /// Gets or Sets SearchAnyWordsOption
        /// </summary>
        [DataMember(Name = "searchAnyWordsOption", EmitDefaultValue = false)]
        public SearchAnyWordsOptionEnum? SearchAnyWordsOption { get; set; }
        /// <summary>
        /// Gets or Sets SearchAttachmentsOption
        /// </summary>
        [DataMember(Name = "searchAttachmentsOption", EmitDefaultValue = false)]
        public SearchAttachmentsOptionEnum? SearchAttachmentsOption { get; set; }
        /// <summary>
        /// Gets or Sets SearchRelatedOption
        /// </summary>
        [DataMember(Name = "searchRelatedOption", EmitDefaultValue = false)]
        public SearchRelatedOptionEnum? SearchRelatedOption { get; set; }
        /// <summary>
        /// Gets or Sets SearchTargetType
        /// </summary>
        [DataMember(Name = "searchTargetType", EmitDefaultValue = false)]
        public SearchTargetTypeEnum? SearchTargetType { get; set; }
        /// <summary>
        /// Gets or Sets SortByOption
        /// </summary>
        [DataMember(Name = "sortByOption", EmitDefaultValue = false)]
        public SortByOptionEnum? SortByOption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesQuickSearchItem" /> class.
        /// </summary>
        /// <param name="Ascending">Ascending.</param>
        /// <param name="ChangedLimits">ChangedLimits.</param>
        /// <param name="ChangedOption">ChangedOption.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="GalleryImage">GalleryImage.</param>
        /// <param name="HasAnyOptions">HasAnyOptions.</param>
        /// <param name="NonFinalStateOption">NonFinalStateOption.</param>
        /// <param name="SearchAnyWordsOption">SearchAnyWordsOption.</param>
        /// <param name="SearchAttachmentsOption">SearchAttachmentsOption.</param>
        /// <param name="SearchRelatedOption">SearchRelatedOption.</param>
        /// <param name="SearchTargetId">SearchTargetId.</param>
        /// <param name="SearchTargetType">SearchTargetType.</param>
        /// <param name="SelectedChangedLimit">SelectedChangedLimit.</param>
        /// <param name="SelectedSortByFieldId">SelectedSortByFieldId.</param>
        /// <param name="SortByFields">SortByFields.</param>
        /// <param name="SortByOption">SortByOption.</param>
        /// <param name="WatermarkText">WatermarkText.</param>
        public SearchesQuickSearchItem(bool? Ascending = default(bool?), List<SearchesChangedLimit> ChangedLimits = default(List<SearchesChangedLimit>), ChangedOptionEnum? ChangedOption = default(ChangedOptionEnum?), string DisplayName = default(string), string GalleryImage = default(string), bool? HasAnyOptions = default(bool?), NonFinalStateOptionEnum? NonFinalStateOption = default(NonFinalStateOptionEnum?), SearchAnyWordsOptionEnum? SearchAnyWordsOption = default(SearchAnyWordsOptionEnum?), SearchAttachmentsOptionEnum? SearchAttachmentsOption = default(SearchAttachmentsOptionEnum?), SearchRelatedOptionEnum? SearchRelatedOption = default(SearchRelatedOptionEnum?), string SearchTargetId = default(string), SearchTargetTypeEnum? SearchTargetType = default(SearchTargetTypeEnum?), SearchesChangedLimit SelectedChangedLimit = default(SearchesChangedLimit), string SelectedSortByFieldId = default(string), Dictionary<string, string> SortByFields = default(Dictionary<string, string>), SortByOptionEnum? SortByOption = default(SortByOptionEnum?), string WatermarkText = default(string))
        {
            this.Ascending = Ascending;
            this.ChangedLimits = ChangedLimits;
            this.ChangedOption = ChangedOption;
            this.DisplayName = DisplayName;
            this.GalleryImage = GalleryImage;
            this.HasAnyOptions = HasAnyOptions;
            this.NonFinalStateOption = NonFinalStateOption;
            this.SearchAnyWordsOption = SearchAnyWordsOption;
            this.SearchAttachmentsOption = SearchAttachmentsOption;
            this.SearchRelatedOption = SearchRelatedOption;
            this.SearchTargetId = SearchTargetId;
            this.SearchTargetType = SearchTargetType;
            this.SelectedChangedLimit = SelectedChangedLimit;
            this.SelectedSortByFieldId = SelectedSortByFieldId;
            this.SortByFields = SortByFields;
            this.SortByOption = SortByOption;
            this.WatermarkText = WatermarkText;
        }

        /// <summary>
        /// Gets or Sets Ascending
        /// </summary>
        [DataMember(Name = "ascending", EmitDefaultValue = false)]
        public bool? Ascending { get; set; }
        /// <summary>
        /// Gets or Sets ChangedLimits
        /// </summary>
        [DataMember(Name = "changedLimits", EmitDefaultValue = false)]
        public List<SearchesChangedLimit> ChangedLimits { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }
        /// <summary>
        /// Gets or Sets HasAnyOptions
        /// </summary>
        [DataMember(Name = "hasAnyOptions", EmitDefaultValue = false)]
        public bool? HasAnyOptions { get; set; }
        /// <summary>
        /// Gets or Sets SearchTargetId
        /// </summary>
        [DataMember(Name = "searchTargetId", EmitDefaultValue = false)]
        public string SearchTargetId { get; set; }
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
        /// Gets or Sets SortByFields
        /// </summary>
        [DataMember(Name = "sortByFields", EmitDefaultValue = false)]
        public Dictionary<string, string> SortByFields { get; set; }
        /// <summary>
        /// Gets or Sets WatermarkText
        /// </summary>
        [DataMember(Name = "watermarkText", EmitDefaultValue = false)]
        public string WatermarkText { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesQuickSearchItem {\n");
            sb.Append("  Ascending: ").Append(Ascending).Append('\n');
            sb.Append("  ChangedLimits: ").Append(ChangedLimits).Append('\n');
            sb.Append("  ChangedOption: ").Append(ChangedOption).Append('\n');
            sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
            sb.Append("  HasAnyOptions: ").Append(HasAnyOptions).Append('\n');
            sb.Append("  NonFinalStateOption: ").Append(NonFinalStateOption).Append('\n');
            sb.Append("  SearchAnyWordsOption: ").Append(SearchAnyWordsOption).Append('\n');
            sb.Append("  SearchAttachmentsOption: ").Append(SearchAttachmentsOption).Append('\n');
            sb.Append("  SearchRelatedOption: ").Append(SearchRelatedOption).Append('\n');
            sb.Append("  SearchTargetId: ").Append(SearchTargetId).Append('\n');
            sb.Append("  SearchTargetType: ").Append(SearchTargetType).Append('\n');
            sb.Append("  SelectedChangedLimit: ").Append(SelectedChangedLimit).Append('\n');
            sb.Append("  SelectedSortByFieldId: ").Append(SelectedSortByFieldId).Append('\n');
            sb.Append("  SortByFields: ").Append(SortByFields).Append('\n');
            sb.Append("  SortByOption: ").Append(SortByOption).Append('\n');
            sb.Append("  WatermarkText: ").Append(WatermarkText).Append('\n');
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
            return this.Equals(obj as SearchesQuickSearchItem);
        }

        /// <summary>
        /// Returns true if SearchesQuickSearchItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesQuickSearchItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesQuickSearchItem other)
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
                    this.ChangedLimits == other.ChangedLimits ||
                    this.ChangedLimits != null &&
                    this.ChangedLimits.SequenceEqual(other.ChangedLimits)
                ) &&
                (
                    this.ChangedOption == other.ChangedOption ||
                    this.ChangedOption != null &&
                    this.ChangedOption.Equals(other.ChangedOption)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.GalleryImage == other.GalleryImage ||
                    this.GalleryImage != null &&
                    this.GalleryImage.Equals(other.GalleryImage)
                ) &&
                (
                    this.HasAnyOptions == other.HasAnyOptions ||
                    this.HasAnyOptions != null &&
                    this.HasAnyOptions.Equals(other.HasAnyOptions)
                ) &&
                (
                    this.NonFinalStateOption == other.NonFinalStateOption ||
                    this.NonFinalStateOption != null &&
                    this.NonFinalStateOption.Equals(other.NonFinalStateOption)
                ) &&
                (
                    this.SearchAnyWordsOption == other.SearchAnyWordsOption ||
                    this.SearchAnyWordsOption != null &&
                    this.SearchAnyWordsOption.Equals(other.SearchAnyWordsOption)
                ) &&
                (
                    this.SearchAttachmentsOption == other.SearchAttachmentsOption ||
                    this.SearchAttachmentsOption != null &&
                    this.SearchAttachmentsOption.Equals(other.SearchAttachmentsOption)
                ) &&
                (
                    this.SearchRelatedOption == other.SearchRelatedOption ||
                    this.SearchRelatedOption != null &&
                    this.SearchRelatedOption.Equals(other.SearchRelatedOption)
                ) &&
                (
                    this.SearchTargetId == other.SearchTargetId ||
                    this.SearchTargetId != null &&
                    this.SearchTargetId.Equals(other.SearchTargetId)
                ) &&
                (
                    this.SearchTargetType == other.SearchTargetType ||
                    this.SearchTargetType != null &&
                    this.SearchTargetType.Equals(other.SearchTargetType)
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
                    this.SortByFields == other.SortByFields ||
                    this.SortByFields != null &&
                    this.SortByFields.SequenceEqual(other.SortByFields)
                ) &&
                (
                    this.SortByOption == other.SortByOption ||
                    this.SortByOption != null &&
                    this.SortByOption.Equals(other.SortByOption)
                ) &&
                (
                    this.WatermarkText == other.WatermarkText ||
                    this.WatermarkText != null &&
                    this.WatermarkText.Equals(other.WatermarkText)
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
                if (this.ChangedLimits != null)
                    hash = hash * 59 + this.ChangedLimits.GetHashCode();
                if (this.ChangedOption != null)
                    hash = hash * 59 + this.ChangedOption.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.GalleryImage != null)
                    hash = hash * 59 + this.GalleryImage.GetHashCode();
                if (this.HasAnyOptions != null)
                    hash = hash * 59 + this.HasAnyOptions.GetHashCode();
                if (this.NonFinalStateOption != null)
                    hash = hash * 59 + this.NonFinalStateOption.GetHashCode();
                if (this.SearchAnyWordsOption != null)
                    hash = hash * 59 + this.SearchAnyWordsOption.GetHashCode();
                if (this.SearchAttachmentsOption != null)
                    hash = hash * 59 + this.SearchAttachmentsOption.GetHashCode();
                if (this.SearchRelatedOption != null)
                    hash = hash * 59 + this.SearchRelatedOption.GetHashCode();
                if (this.SearchTargetId != null)
                    hash = hash * 59 + this.SearchTargetId.GetHashCode();
                if (this.SearchTargetType != null)
                    hash = hash * 59 + this.SearchTargetType.GetHashCode();
                if (this.SelectedChangedLimit != null)
                    hash = hash * 59 + this.SelectedChangedLimit.GetHashCode();
                if (this.SelectedSortByFieldId != null)
                    hash = hash * 59 + this.SelectedSortByFieldId.GetHashCode();
                if (this.SortByFields != null)
                    hash = hash * 59 + this.SortByFields.GetHashCode();
                if (this.SortByOption != null)
                    hash = hash * 59 + this.SortByOption.GetHashCode();
                if (this.WatermarkText != null)
                    hash = hash * 59 + this.WatermarkText.GetHashCode();
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
