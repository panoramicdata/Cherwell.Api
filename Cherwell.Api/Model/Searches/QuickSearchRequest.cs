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
    /// SearchesQuickSearchRequest
    /// </summary>
    [DataContract]
    public partial class QuickSearchRequest : IEquatable<QuickSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickSearchRequest" /> class.
        /// </summary>
        /// <param name="BusObIds">BusObIds.</param>
        /// <param name="SearchText">SearchText.</param>
        public QuickSearchRequest(List<string> BusObIds = default(List<string>), string SearchText = default)
        {
            this.BusObIds = BusObIds;
            this.SearchText = SearchText;
        }

        /// <summary>
        /// Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name = "busObIds", EmitDefaultValue = false)]
        public List<string> BusObIds { get; set; }
        /// <summary>
        /// Gets or Sets SearchText
        /// </summary>
        [DataMember(Name = "searchText", EmitDefaultValue = false)]
        public string SearchText { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesQuickSearchRequest {\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append('\n');
            sb.Append("  SearchText: ").Append(SearchText).Append('\n');
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
            return this.Equals(obj as QuickSearchRequest);
        }

        /// <summary>
        /// Returns true if SearchesQuickSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesQuickSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickSearchRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.BusObIds == other.BusObIds ||
                    this.BusObIds != null &&
                    this.BusObIds.SequenceEqual(other.BusObIds)
                ) &&
                (
                    this.SearchText == other.SearchText ||
                    this.SearchText != null &&
                    this.SearchText.Equals(other.SearchText, StringComparison.Ordinal)
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
                if (this.BusObIds != null)
                    hash = hash * 59 + this.BusObIds.GetHashCode();
                if (this.SearchText != null)
                    hash = hash * 59 + this.SearchText.GetHashCode();
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
