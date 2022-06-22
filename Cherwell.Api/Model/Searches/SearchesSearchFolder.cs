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
    /// SearchesSearchFolder
    /// </summary>
    [DataContract]
    public partial class SearchesSearchFolder : IEquatable<SearchesSearchFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesSearchFolder" /> class.
        /// </summary>
        /// <param name="Association">Association.</param>
        /// <param name="ChildFolders">ChildFolders.</param>
        /// <param name="ChildItems">ChildItems.</param>
        /// <param name="FolderId">FolderId.</param>
        /// <param name="FolderName">FolderName.</param>
        /// <param name="Links">Links.</param>
        /// <param name="LocalizedScopeName">LocalizedScopeName.</param>
        /// <param name="ParentFolderId">ParentFolderId.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        public SearchesSearchFolder(string Association = default(string), List<SearchesSearchFolder> ChildFolders = default(List<SearchesSearchFolder>), List<SearchesSearchItem> ChildItems = default(List<SearchesSearchItem>), string FolderId = default(string), string FolderName = default(string), List<CoreLink> Links = default(List<CoreLink>), string LocalizedScopeName = default(string), string ParentFolderId = default(string), string Scope = default(string), string ScopeOwner = default(string))
        {
            this.Association = Association;
            this.ChildFolders = ChildFolders;
            this.ChildItems = ChildItems;
            this.FolderId = FolderId;
            this.FolderName = FolderName;
            this.Links = Links;
            this.LocalizedScopeName = LocalizedScopeName;
            this.ParentFolderId = ParentFolderId;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
        }

        /// <summary>
        /// Gets or Sets Association
        /// </summary>
        [DataMember(Name = "association", EmitDefaultValue = false)]
        public string Association { get; set; }
        /// <summary>
        /// Gets or Sets ChildFolders
        /// </summary>
        [DataMember(Name = "childFolders", EmitDefaultValue = false)]
        public List<SearchesSearchFolder> ChildFolders { get; set; }
        /// <summary>
        /// Gets or Sets ChildItems
        /// </summary>
        [DataMember(Name = "childItems", EmitDefaultValue = false)]
        public List<SearchesSearchItem> ChildItems { get; set; }
        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public string FolderId { get; set; }
        /// <summary>
        /// Gets or Sets FolderName
        /// </summary>
        [DataMember(Name = "folderName", EmitDefaultValue = false)]
        public string FolderName { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<CoreLink> Links { get; set; }
        /// <summary>
        /// Gets or Sets LocalizedScopeName
        /// </summary>
        [DataMember(Name = "localizedScopeName", EmitDefaultValue = false)]
        public string LocalizedScopeName { get; set; }
        /// <summary>
        /// Gets or Sets ParentFolderId
        /// </summary>
        [DataMember(Name = "parentFolderId", EmitDefaultValue = false)]
        public string ParentFolderId { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }
        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
        public string ScopeOwner { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesSearchFolder {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  ChildFolders: ").Append(ChildFolders).Append("\n");
            sb.Append("  ChildItems: ").Append(ChildItems).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  FolderName: ").Append(FolderName).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
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
            return this.Equals(obj as SearchesSearchFolder);
        }

        /// <summary>
        /// Returns true if SearchesSearchFolder instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesSearchFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesSearchFolder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Association == other.Association ||
                    this.Association != null &&
                    this.Association.Equals(other.Association)
                ) &&
                (
                    this.ChildFolders == other.ChildFolders ||
                    this.ChildFolders != null &&
                    this.ChildFolders.SequenceEqual(other.ChildFolders)
                ) &&
                (
                    this.ChildItems == other.ChildItems ||
                    this.ChildItems != null &&
                    this.ChildItems.SequenceEqual(other.ChildItems)
                ) &&
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) &&
                (
                    this.FolderName == other.FolderName ||
                    this.FolderName != null &&
                    this.FolderName.Equals(other.FolderName)
                ) &&
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) &&
                (
                    this.LocalizedScopeName == other.LocalizedScopeName ||
                    this.LocalizedScopeName != null &&
                    this.LocalizedScopeName.Equals(other.LocalizedScopeName)
                ) &&
                (
                    this.ParentFolderId == other.ParentFolderId ||
                    this.ParentFolderId != null &&
                    this.ParentFolderId.Equals(other.ParentFolderId)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.ScopeOwner == other.ScopeOwner ||
                    this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(other.ScopeOwner)
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
                if (this.Association != null)
                    hash = hash * 59 + this.Association.GetHashCode();
                if (this.ChildFolders != null)
                    hash = hash * 59 + this.ChildFolders.GetHashCode();
                if (this.ChildItems != null)
                    hash = hash * 59 + this.ChildItems.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.FolderName != null)
                    hash = hash * 59 + this.FolderName.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.LocalizedScopeName != null)
                    hash = hash * 59 + this.LocalizedScopeName.GetHashCode();
                if (this.ParentFolderId != null)
                    hash = hash * 59 + this.ParentFolderId.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hash = hash * 59 + this.ScopeOwner.GetHashCode();
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
