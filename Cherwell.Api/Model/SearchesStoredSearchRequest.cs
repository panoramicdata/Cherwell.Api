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
    /// SearchesStoredSearchRequest
    /// </summary>
    [DataContract]
    public partial class SearchesStoredSearchRequest :  IEquatable<SearchesStoredSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesStoredSearchRequest" /> class.
        /// </summary>
        /// <param name="AssociationId">AssociationId.</param>
        /// <param name="AssociationName">AssociationName.</param>
        /// <param name="GridId">GridId.</param>
        /// <param name="IncludeSchema">IncludeSchema.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwnerId">ScopeOwnerId.</param>
        /// <param name="SearchId">SearchId.</param>
        /// <param name="SearchName">SearchName.</param>
        public SearchesStoredSearchRequest(string AssociationId = default(string), string AssociationName = default(string), string GridId = default(string), bool? IncludeSchema = default(bool?), string Scope = default(string), string ScopeOwnerId = default(string), string SearchId = default(string), string SearchName = default(string))
        {
            this.AssociationId = AssociationId;
            this.AssociationName = AssociationName;
            this.GridId = GridId;
            this.IncludeSchema = IncludeSchema;
            this.Scope = Scope;
            this.ScopeOwnerId = ScopeOwnerId;
            this.SearchId = SearchId;
            this.SearchName = SearchName;
        }
        
        /// <summary>
        /// Gets or Sets AssociationId
        /// </summary>
        [DataMember(Name="associationId", EmitDefaultValue=false)]
        public string AssociationId { get; set; }
        /// <summary>
        /// Gets or Sets AssociationName
        /// </summary>
        [DataMember(Name="associationName", EmitDefaultValue=false)]
        public string AssociationName { get; set; }
        /// <summary>
        /// Gets or Sets GridId
        /// </summary>
        [DataMember(Name="gridId", EmitDefaultValue=false)]
        public string GridId { get; set; }
        /// <summary>
        /// Gets or Sets IncludeSchema
        /// </summary>
        [DataMember(Name="includeSchema", EmitDefaultValue=false)]
        public bool? IncludeSchema { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Gets or Sets ScopeOwnerId
        /// </summary>
        [DataMember(Name="scopeOwnerId", EmitDefaultValue=false)]
        public string ScopeOwnerId { get; set; }
        /// <summary>
        /// Gets or Sets SearchId
        /// </summary>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; set; }
        /// <summary>
        /// Gets or Sets SearchName
        /// </summary>
        [DataMember(Name="searchName", EmitDefaultValue=false)]
        public string SearchName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesStoredSearchRequest {\n");
            sb.Append("  AssociationId: ").Append(AssociationId).Append("\n");
            sb.Append("  AssociationName: ").Append(AssociationName).Append("\n");
            sb.Append("  GridId: ").Append(GridId).Append("\n");
            sb.Append("  IncludeSchema: ").Append(IncludeSchema).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwnerId: ").Append(ScopeOwnerId).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  SearchName: ").Append(SearchName).Append("\n");
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
            return this.Equals(obj as SearchesStoredSearchRequest);
        }

        /// <summary>
        /// Returns true if SearchesStoredSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesStoredSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesStoredSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssociationId == other.AssociationId ||
                    this.AssociationId != null &&
                    this.AssociationId.Equals(other.AssociationId)
                ) && 
                (
                    this.AssociationName == other.AssociationName ||
                    this.AssociationName != null &&
                    this.AssociationName.Equals(other.AssociationName)
                ) && 
                (
                    this.GridId == other.GridId ||
                    this.GridId != null &&
                    this.GridId.Equals(other.GridId)
                ) && 
                (
                    this.IncludeSchema == other.IncludeSchema ||
                    this.IncludeSchema != null &&
                    this.IncludeSchema.Equals(other.IncludeSchema)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.ScopeOwnerId == other.ScopeOwnerId ||
                    this.ScopeOwnerId != null &&
                    this.ScopeOwnerId.Equals(other.ScopeOwnerId)
                ) && 
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) && 
                (
                    this.SearchName == other.SearchName ||
                    this.SearchName != null &&
                    this.SearchName.Equals(other.SearchName)
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
                if (this.AssociationId != null)
                    hash = hash * 59 + this.AssociationId.GetHashCode();
                if (this.AssociationName != null)
                    hash = hash * 59 + this.AssociationName.GetHashCode();
                if (this.GridId != null)
                    hash = hash * 59 + this.GridId.GetHashCode();
                if (this.IncludeSchema != null)
                    hash = hash * 59 + this.IncludeSchema.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwnerId != null)
                    hash = hash * 59 + this.ScopeOwnerId.GetHashCode();
                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();
                if (this.SearchName != null)
                    hash = hash * 59 + this.SearchName.GetHashCode();
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
