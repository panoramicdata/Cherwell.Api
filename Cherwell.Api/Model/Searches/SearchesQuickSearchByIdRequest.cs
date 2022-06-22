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
    /// SearchesQuickSearchByIdRequest
    /// </summary>
    [DataContract]
    public partial class SearchesQuickSearchByIdRequest : IEquatable<SearchesQuickSearchByIdRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesQuickSearchByIdRequest" /> class.
        /// </summary>
        /// <param name="BusObIds">BusObIds.</param>
        /// <param name="IsGeneral">IsGeneral.</param>
        /// <param name="SearchText">SearchText.</param>
        /// <param name="StandIn">StandIn.</param>
        public SearchesQuickSearchByIdRequest(List<string> BusObIds = default(List<string>), bool? IsGeneral = default(bool?), string SearchText = default(string), string StandIn = default(string))
        {
            this.BusObIds = BusObIds;
            this.IsGeneral = IsGeneral;
            this.SearchText = SearchText;
            this.StandIn = StandIn;
        }

        /// <summary>
        /// Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name = "busObIds", EmitDefaultValue = false)]
        public List<string> BusObIds { get; set; }
        /// <summary>
        /// Gets or Sets IsGeneral
        /// </summary>
        [DataMember(Name = "isGeneral", EmitDefaultValue = false)]
        public bool? IsGeneral { get; set; }
        /// <summary>
        /// Gets or Sets SearchText
        /// </summary>
        [DataMember(Name = "searchText", EmitDefaultValue = false)]
        public string SearchText { get; set; }
        /// <summary>
        /// Gets or Sets StandIn
        /// </summary>
        [DataMember(Name = "standIn", EmitDefaultValue = false)]
        public string StandIn { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesQuickSearchByIdRequest {\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append("\n");
            sb.Append("  IsGeneral: ").Append(IsGeneral).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  StandIn: ").Append(StandIn).Append("\n");
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
            return this.Equals(obj as SearchesQuickSearchByIdRequest);
        }

        /// <summary>
        /// Returns true if SearchesQuickSearchByIdRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesQuickSearchByIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesQuickSearchByIdRequest other)
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
                    this.IsGeneral == other.IsGeneral ||
                    this.IsGeneral != null &&
                    this.IsGeneral.Equals(other.IsGeneral)
                ) &&
                (
                    this.SearchText == other.SearchText ||
                    this.SearchText != null &&
                    this.SearchText.Equals(other.SearchText)
                ) &&
                (
                    this.StandIn == other.StandIn ||
                    this.StandIn != null &&
                    this.StandIn.Equals(other.StandIn)
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
                if (this.IsGeneral != null)
                    hash = hash * 59 + this.IsGeneral.GetHashCode();
                if (this.SearchText != null)
                    hash = hash * 59 + this.SearchText.GetHashCode();
                if (this.StandIn != null)
                    hash = hash * 59 + this.StandIn.GetHashCode();
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
