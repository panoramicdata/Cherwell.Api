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

namespace Cherwell.Model.Searches
{
    /// <summary>
    /// SearchesStoredSearchResults
    /// </summary>
    [DataContract]
    public partial class SearchesStoredSearchResults : IEquatable<SearchesStoredSearchResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesStoredSearchResults" /> class.
        /// </summary>
        /// <param name="Columns">Columns.</param>
        /// <param name="Rows">Rows.</param>
        public SearchesStoredSearchResults(List<SearchesColumnSchema> Columns = default(List<SearchesColumnSchema>), List<List<Object>> Rows = default(List<List<Object>>))
        {
            this.Columns = Columns;
            this.Rows = Rows;
        }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = false)]
        public List<SearchesColumnSchema> Columns { get; set; }
        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [DataMember(Name = "rows", EmitDefaultValue = false)]
        public List<List<Object>> Rows { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesStoredSearchResults {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(obj as SearchesStoredSearchResults);
        }

        /// <summary>
        /// Returns true if SearchesStoredSearchResults instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesStoredSearchResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesStoredSearchResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Columns == other.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(other.Columns)
                ) &&
                (
                    this.Rows == other.Rows ||
                    this.Rows != null &&
                    this.Rows.SequenceEqual(other.Rows)
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
                if (this.Columns != null)
                    hash = hash * 59 + this.Columns.GetHashCode();
                if (this.Rows != null)
                    hash = hash * 59 + this.Rows.GetHashCode();
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
