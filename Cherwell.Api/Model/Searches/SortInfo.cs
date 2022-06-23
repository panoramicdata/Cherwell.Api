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
    /// SearchesSortInfo
    /// </summary>
    [DataContract]
    public partial class SortInfo : IEquatable<SortInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortInfo" /> class.
        /// </summary>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="SortDirection">SortDirection.</param>
        public SortInfo(string FieldId = default, int? SortDirection = default(int?))
        {
            this.FieldId = FieldId;
            this.SortDirection = SortDirection;
        }

        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public int? SortDirection { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesSortInfo {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append('\n');
            sb.Append("  SortDirection: ").Append(SortDirection).Append('\n');
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
            return this.Equals(obj as SortInfo);
        }

        /// <summary>
        /// Returns true if SearchesSortInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesSortInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortInfo? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.SortDirection == other.SortDirection ||
                    this.SortDirection != null &&
                    this.SortDirection.Equals(other.SortDirection)
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
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.SortDirection != null)
                    hash = hash * 59 + this.SortDirection.GetHashCode();
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
