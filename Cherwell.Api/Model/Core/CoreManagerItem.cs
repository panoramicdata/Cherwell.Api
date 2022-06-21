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

namespace Cherwell.Model.Core
{
    /// <summary>
    /// CoreManagerItem
    /// </summary>
    [DataContract]
    public partial class CoreManagerItem : IEquatable<CoreManagerItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreManagerItem" /> class.
        /// </summary>
        /// <param name="Association">Association.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="GalleryImage">GalleryImage.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Links">Links.</param>
        /// <param name="LocalizedScopeName">LocalizedScopeName.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ParentFolder">ParentFolder.</param>
        /// <param name="ParentIsScopeFolder">ParentIsScopeFolder.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="StandInKey">StandInKey.</param>
        public CoreManagerItem(string Association = default(string), string Description = default(string), string DisplayName = default(string), string GalleryImage = default(string), string Id = default(string), List<CoreLink> Links = default(List<CoreLink>), string LocalizedScopeName = default(string), string Name = default(string), string ParentFolder = default(string), bool? ParentIsScopeFolder = default(bool?), string Scope = default(string), string ScopeOwner = default(string), string StandInKey = default(string))
        {
            this.Association = Association;
            this.Description = Description;
            this.DisplayName = DisplayName;
            this.GalleryImage = GalleryImage;
            this.Id = Id;
            this.Links = Links;
            this.LocalizedScopeName = LocalizedScopeName;
            this.Name = Name;
            this.ParentFolder = ParentFolder;
            this.ParentIsScopeFolder = ParentIsScopeFolder;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.StandInKey = StandInKey;
        }

        /// <summary>
        /// Gets or Sets Association
        /// </summary>
        [DataMember(Name = "association", EmitDefaultValue = false)]
        public string Association { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ParentFolder
        /// </summary>
        [DataMember(Name = "parentFolder", EmitDefaultValue = false)]
        public string ParentFolder { get; set; }
        /// <summary>
        /// Gets or Sets ParentIsScopeFolder
        /// </summary>
        [DataMember(Name = "parentIsScopeFolder", EmitDefaultValue = false)]
        public bool? ParentIsScopeFolder { get; set; }
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
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreManagerItem {\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentFolder: ").Append(ParentFolder).Append("\n");
            sb.Append("  ParentIsScopeFolder: ").Append(ParentIsScopeFolder).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
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
            return this.Equals(obj as CoreManagerItem);
        }

        /// <summary>
        /// Returns true if CoreManagerItem instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreManagerItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreManagerItem other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.GalleryImage == other.GalleryImage ||
                    this.GalleryImage != null &&
                    this.GalleryImage.Equals(other.GalleryImage)
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
                    this.ParentFolder == other.ParentFolder ||
                    this.ParentFolder != null &&
                    this.ParentFolder.Equals(other.ParentFolder)
                ) &&
                (
                    this.ParentIsScopeFolder == other.ParentIsScopeFolder ||
                    this.ParentIsScopeFolder != null &&
                    this.ParentIsScopeFolder.Equals(other.ParentIsScopeFolder)
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
                ) &&
                (
                    this.StandInKey == other.StandInKey ||
                    this.StandInKey != null &&
                    this.StandInKey.Equals(other.StandInKey)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.GalleryImage != null)
                    hash = hash * 59 + this.GalleryImage.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.LocalizedScopeName != null)
                    hash = hash * 59 + this.LocalizedScopeName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ParentFolder != null)
                    hash = hash * 59 + this.ParentFolder.GetHashCode();
                if (this.ParentIsScopeFolder != null)
                    hash = hash * 59 + this.ParentIsScopeFolder.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hash = hash * 59 + this.ScopeOwner.GetHashCode();
                if (this.StandInKey != null)
                    hash = hash * 59 + this.StandInKey.GetHashCode();
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
