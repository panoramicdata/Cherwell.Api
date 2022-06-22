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
    /// SearchesSimpleResultsListItem
    /// </summary>
    [DataContract]
    public partial class SearchesSimpleResultsListItem : IEquatable<SearchesSimpleResultsListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesSimpleResultsListItem" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="DocRepositoryItemId">DocRepositoryItemId.</param>
        /// <param name="GalleryImage">GalleryImage.</param>
        /// <param name="Links">Links.</param>
        /// <param name="PublicId">PublicId.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="SubTitle">SubTitle.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Title">Title.</param>
        public SearchesSimpleResultsListItem(string BusObId = default(string), string BusObRecId = default(string), string DocRepositoryItemId = default(string), string GalleryImage = default(string), List<CoreLink> Links = default(List<CoreLink>), string PublicId = default(string), string Scope = default(string), string ScopeOwner = default(string), string SubTitle = default(string), string Text = default(string), string Title = default(string))
        {
            this.BusObId = BusObId;
            this.BusObRecId = BusObRecId;
            this.DocRepositoryItemId = DocRepositoryItemId;
            this.GalleryImage = GalleryImage;
            this.Links = Links;
            this.PublicId = PublicId;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.SubTitle = SubTitle;
            this.Text = Text;
            this.Title = Title;
        }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets DocRepositoryItemId
        /// </summary>
        [DataMember(Name = "docRepositoryItemId", EmitDefaultValue = false)]
        public string DocRepositoryItemId { get; set; }
        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<CoreLink> Links { get; set; }
        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name = "publicId", EmitDefaultValue = false)]
        public string PublicId { get; set; }
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
        /// Gets or Sets SubTitle
        /// </summary>
        [DataMember(Name = "subTitle", EmitDefaultValue = false)]
        public string SubTitle { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesSimpleResultsListItem {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
            sb.Append("  DocRepositoryItemId: ").Append(DocRepositoryItemId).Append('\n');
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
            sb.Append("  Links: ").Append(Links).Append('\n');
            sb.Append("  PublicId: ").Append(PublicId).Append('\n');
            sb.Append("  Scope: ").Append(Scope).Append('\n');
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
            sb.Append("  SubTitle: ").Append(SubTitle).Append('\n');
            sb.Append("  Text: ").Append(Text).Append('\n');
            sb.Append("  Title: ").Append(Title).Append('\n');
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
            return this.Equals(obj as SearchesSimpleResultsListItem);
        }

        /// <summary>
        /// Returns true if SearchesSimpleResultsListItem instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesSimpleResultsListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesSimpleResultsListItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
                ) &&
                (
                    this.DocRepositoryItemId == other.DocRepositoryItemId ||
                    this.DocRepositoryItemId != null &&
                    this.DocRepositoryItemId.Equals(other.DocRepositoryItemId, StringComparison.Ordinal)
                ) &&
                (
                    this.GalleryImage == other.GalleryImage ||
                    this.GalleryImage != null &&
                    this.GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
                ) &&
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) &&
                (
                    this.PublicId == other.PublicId ||
                    this.PublicId != null &&
                    this.PublicId.Equals(other.PublicId, StringComparison.Ordinal)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope, StringComparison.Ordinal)
                ) &&
                (
                    this.ScopeOwner == other.ScopeOwner ||
                    this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(other.ScopeOwner, StringComparison.Ordinal)
                ) &&
                (
                    this.SubTitle == other.SubTitle ||
                    this.SubTitle != null &&
                    this.SubTitle.Equals(other.SubTitle, StringComparison.Ordinal)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text, StringComparison.Ordinal)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title, StringComparison.Ordinal)
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
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.BusObRecId != null)
                    hash = hash * 59 + this.BusObRecId.GetHashCode();
                if (this.DocRepositoryItemId != null)
                    hash = hash * 59 + this.DocRepositoryItemId.GetHashCode();
                if (this.GalleryImage != null)
                    hash = hash * 59 + this.GalleryImage.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.PublicId != null)
                    hash = hash * 59 + this.PublicId.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hash = hash * 59 + this.ScopeOwner.GetHashCode();
                if (this.SubTitle != null)
                    hash = hash * 59 + this.SubTitle.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
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
