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
    /// TrebuchetWebApiDataContractsCoreManagerFolder
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsCoreManagerFolder :  IEquatable<TrebuchetWebApiDataContractsCoreManagerFolder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsCoreManagerFolder" /> class.
        /// </summary>
        /// <param name="Association">Association.</param>
        /// <param name="ChildFolders">ChildFolders.</param>
        /// <param name="ChildItems">ChildItems.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="LocalizedScopeName">LocalizedScopeName.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        public TrebuchetWebApiDataContractsCoreManagerFolder(string Association = default(string), List<TrebuchetWebApiDataContractsCoreManagerFolder> ChildFolders = default(List<TrebuchetWebApiDataContractsCoreManagerFolder>), List<TrebuchetWebApiDataContractsCoreManagerItem> ChildItems = default(List<TrebuchetWebApiDataContractsCoreManagerItem>), string Id = default(string), List<TrebuchetWebApiDataContractsCoreLink> Links = default(List<TrebuchetWebApiDataContractsCoreLink>), string LocalizedScopeName = default(string), string Name = default(string), string ParentId = default(string), string Scope = default(string), string ScopeOwner = default(string))
        {
            this.Association = Association;
            this.ChildFolders = ChildFolders;
            this.ChildItems = ChildItems;
            this.Id = Id;
            this.Links = Links;
            this.LocalizedScopeName = LocalizedScopeName;
            this.Name = Name;
            this.ParentId = ParentId;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
        }
        
        /// <summary>
        /// Gets or Sets Association
        /// </summary>
        [DataMember(Name="association", EmitDefaultValue=false)]
        public string Association { get; set; }
        /// <summary>
        /// Gets or Sets ChildFolders
        /// </summary>
        [DataMember(Name="childFolders", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsCoreManagerFolder> ChildFolders { get; set; }
        /// <summary>
        /// Gets or Sets ChildItems
        /// </summary>
        [DataMember(Name="childItems", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsCoreManagerItem> ChildItems { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<TrebuchetWebApiDataContractsCoreLink> Links { get; set; }
        /// <summary>
        /// Gets or Sets LocalizedScopeName
        /// </summary>
        [DataMember(Name="localizedScopeName", EmitDefaultValue=false)]
        public string LocalizedScopeName { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsCoreManagerFolder {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  ChildFolders: ").Append(ChildFolders).Append("\n");
            sb.Append("  ChildItems: ").Append(ChildItems).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(obj as TrebuchetWebApiDataContractsCoreManagerFolder);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsCoreManagerFolder instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsCoreManagerFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsCoreManagerFolder other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.LocalizedScopeName != null)
                    hash = hash * 59 + this.LocalizedScopeName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
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
