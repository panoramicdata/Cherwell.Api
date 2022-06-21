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

namespace Cherwell.Model
{
    /// <summary>
    /// SearchesQuickSearchConfigSavedRequest
    /// </summary>
    [DataContract]
    public partial class SearchesQuickSearchConfigSavedRequest :  IEquatable<SearchesQuickSearchConfigSavedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesQuickSearchConfigSavedRequest" /> class.
        /// </summary>
        /// <param name="StandIn">StandIn.</param>
        /// <param name="BusObIds">BusObIds.</param>
        /// <param name="IsGeneral">IsGeneral.</param>
        public SearchesQuickSearchConfigSavedRequest(string StandIn = default(string), List<string> BusObIds = default(List<string>), bool? IsGeneral = default(bool?))
        {
            this.StandIn = StandIn;
            this.BusObIds = BusObIds;
            this.IsGeneral = IsGeneral;
        }
        
        /// <summary>
        /// Gets or Sets StandIn
        /// </summary>
        [DataMember(Name="standIn", EmitDefaultValue=false)]
        public string StandIn { get; set; }
        /// <summary>
        /// Gets or Sets BusObIds
        /// </summary>
        [DataMember(Name="busObIds", EmitDefaultValue=false)]
        public List<string> BusObIds { get; set; }
        /// <summary>
        /// Gets or Sets IsGeneral
        /// </summary>
        [DataMember(Name="isGeneral", EmitDefaultValue=false)]
        public bool? IsGeneral { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesQuickSearchConfigSavedRequest {\n");
            sb.Append("  StandIn: ").Append(StandIn).Append("\n");
            sb.Append("  BusObIds: ").Append(BusObIds).Append("\n");
            sb.Append("  IsGeneral: ").Append(IsGeneral).Append("\n");
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
            return this.Equals(obj as SearchesQuickSearchConfigSavedRequest);
        }

        /// <summary>
        /// Returns true if SearchesQuickSearchConfigSavedRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesQuickSearchConfigSavedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesQuickSearchConfigSavedRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StandIn == other.StandIn ||
                    this.StandIn != null &&
                    this.StandIn.Equals(other.StandIn)
                ) && 
                (
                    this.BusObIds == other.BusObIds ||
                    this.BusObIds != null &&
                    this.BusObIds.SequenceEqual(other.BusObIds)
                ) && 
                (
                    this.IsGeneral == other.IsGeneral ||
                    this.IsGeneral != null &&
                    this.IsGeneral.Equals(other.IsGeneral)
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
                if (this.StandIn != null)
                    hash = hash * 59 + this.StandIn.GetHashCode();
                if (this.BusObIds != null)
                    hash = hash * 59 + this.BusObIds.GetHashCode();
                if (this.IsGeneral != null)
                    hash = hash * 59 + this.IsGeneral.GetHashCode();
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
