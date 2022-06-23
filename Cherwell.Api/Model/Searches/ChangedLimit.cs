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
    /// SearchesChangedLimit
    /// </summary>
    [DataContract]
    public partial class ChangedLimit : IEquatable<ChangedLimit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangedLimit" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Units">Units.</param>
        /// <param name="Value">Value.</param>
        public ChangedLimit(string DisplayName = default, string Units = default, int? Value = default(int?))
        {
            this.DisplayName = DisplayName;
            this.Units = Units;
            this.Value = Value;
        }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        public string Units { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public int? Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesChangedLimit {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
            sb.Append("  Units: ").Append(Units).Append('\n');
            sb.Append("  Value: ").Append(Value).Append('\n');
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
            return this.Equals(obj as ChangedLimit);
        }

        /// <summary>
        /// Returns true if SearchesChangedLimit instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesChangedLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangedLimit? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
                ) &&
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.Equals(other.Units, StringComparison.Ordinal)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
