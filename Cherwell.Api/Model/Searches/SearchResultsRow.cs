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
    /// SearchesSearchResultsRow
    /// </summary>
    [DataContract]
    public partial class SearchesSearchResultsRow : IEquatable<SearchesSearchResultsRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesSearchResultsRow" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Links">Links.</param>
        /// <param name="PublicId">PublicId.</param>
        /// <param name="RowColor">RowColor.</param>
        /// <param name="SearchResultsFieldValues">SearchResultsFieldValues.</param>
        public SearchesSearchResultsRow(string BusObId = default, string BusObRecId = default, List<Link> Links = default(List<Link>), string PublicId = default, string RowColor = default, List<FieldTemplateItem> SearchResultsFieldValues = default(List<FieldTemplateItem>))
        {
            this.BusObId = BusObId;
            this.BusObRecId = BusObRecId;
            this.Links = Links;
            this.PublicId = PublicId;
            this.RowColor = RowColor;
            this.SearchResultsFieldValues = SearchResultsFieldValues;
        }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<Link> Links { get; set; }
        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name = "publicId", EmitDefaultValue = false)]
        public string PublicId { get; set; }
        /// <summary>
        /// Gets or Sets RowColor
        /// </summary>
        [DataMember(Name = "rowColor", EmitDefaultValue = false)]
        public string RowColor { get; set; }
        /// <summary>
        /// Gets or Sets SearchResultsFieldValues
        /// </summary>
        [DataMember(Name = "searchResultsFieldValues", EmitDefaultValue = false)]
        public List<FieldTemplateItem> SearchResultsFieldValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesSearchResultsRow {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
            sb.Append("  Links: ").Append(Links).Append('\n');
            sb.Append("  PublicId: ").Append(PublicId).Append('\n');
            sb.Append("  RowColor: ").Append(RowColor).Append('\n');
            sb.Append("  SearchResultsFieldValues: ").Append(SearchResultsFieldValues).Append('\n');
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
            return this.Equals(obj as SearchesSearchResultsRow);
        }

        /// <summary>
        /// Returns true if SearchesSearchResultsRow instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesSearchResultsRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesSearchResultsRow? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
                ) &&
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) &&
                (
                    this.PublicId == other.PublicId ||
                    this.PublicId != null &&
                    this.PublicId.Equals(other.PublicId, StringComparison.Ordinal)
                ) &&
                (
                    this.RowColor == other.RowColor ||
                    this.RowColor != null &&
                    this.RowColor.Equals(other.RowColor, StringComparison.Ordinal)
                ) &&
                (
                    this.SearchResultsFieldValues == other.SearchResultsFieldValues ||
                    this.SearchResultsFieldValues != null &&
                    this.SearchResultsFieldValues.SequenceEqual(other.SearchResultsFieldValues)
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
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.BusObRecId != null)
                    hash = hash * 59 + this.BusObRecId.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.PublicId != null)
                    hash = hash * 59 + this.PublicId.GetHashCode();
                if (this.RowColor != null)
                    hash = hash * 59 + this.RowColor.GetHashCode();
                if (this.SearchResultsFieldValues != null)
                    hash = hash * 59 + this.SearchResultsFieldValues.GetHashCode();
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
