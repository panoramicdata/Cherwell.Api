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

namespace Cherwell.Api.Models.Forms;

    /// <summary>
    /// FormsSection
    /// </summary>
    [DataContract]
    public partial class Section : IEquatable<Section>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="SectionFields">SectionFields.</param>
        /// <param name="GalleryImage">GalleryImage.</param>
        /// <param name="Title">Title.</param>
        /// <param name="RelationshipId">RelationshipId.</param>
        /// <param name="TargetBusObId">TargetBusObId.</param>
        /// <param name="TargetBusObRecId">TargetBusObRecId.</param>
        public Section(List<SectionField> SectionFields, string GalleryImage, string Title, string RelationshipId, string TargetBusObId, string TargetBusObRecId)
        {
            this.SectionFields = SectionFields;
            this.GalleryImage = GalleryImage;
            this.Title = Title;
            this.RelationshipId = RelationshipId;
            this.TargetBusObId = TargetBusObId;
            this.TargetBusObRecId = TargetBusObRecId;
        }

        /// <summary>
        /// Gets or Sets SectionFields
        /// </summary>
        [DataMember(Name = "sectionFields", EmitDefaultValue = false)]
        public List<SectionField> SectionFields { get; set; }
        /// <summary>
        /// Gets or Sets GalleryImage
        /// </summary>
        [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
        public string GalleryImage { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
        public string RelationshipId { get; set; }
        /// <summary>
        /// Gets or Sets TargetBusObId
        /// </summary>
        [DataMember(Name = "targetBusObId", EmitDefaultValue = false)]
        public string TargetBusObId { get; set; }
        /// <summary>
        /// Gets or Sets TargetBusObRecId
        /// </summary>
        [DataMember(Name = "targetBusObRecId", EmitDefaultValue = false)]
        public string TargetBusObRecId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormsSection {\n");
            sb.Append("  SectionFields: ").Append(SectionFields).Append('\n');
            sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
            sb.Append("  Title: ").Append(Title).Append('\n');
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append('\n');
            sb.Append("  TargetBusObId: ").Append(TargetBusObId).Append('\n');
            sb.Append("  TargetBusObRecId: ").Append(TargetBusObRecId).Append('\n');
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
            return this.Equals(obj as Section);
        }

        /// <summary>
        /// Returns true if FormsSection instances are equal
        /// </summary>
        /// <param name="other">Instance of FormsSection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Section? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return
                (
                    this.SectionFields == other.SectionFields ||
                    this.SectionFields != null &&
                    this.SectionFields.SequenceEqual(other.SectionFields)
                ) &&
                (
                    this.GalleryImage == other.GalleryImage ||
                    this.GalleryImage != null &&
                    this.GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title, StringComparison.Ordinal)
                ) &&
                (
                    this.RelationshipId == other.RelationshipId ||
                    this.RelationshipId != null &&
                    this.RelationshipId.Equals(other.RelationshipId, StringComparison.Ordinal)
                ) &&
                (
                    this.TargetBusObId == other.TargetBusObId ||
                    this.TargetBusObId != null &&
                    this.TargetBusObId.Equals(other.TargetBusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.TargetBusObRecId == other.TargetBusObRecId ||
                    this.TargetBusObRecId != null &&
                    this.TargetBusObRecId.Equals(other.TargetBusObRecId, StringComparison.Ordinal)
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
                if (this.SectionFields != null)
			{
				hash = hash * 59 + this.SectionFields.GetHashCode();
			}

			if (this.GalleryImage != null)
			{
				hash = hash * 59 + this.GalleryImage.GetHashCode();
			}

			if (this.Title != null)
			{
				hash = hash * 59 + this.Title.GetHashCode();
			}

			if (this.RelationshipId != null)
			{
				hash = hash * 59 + this.RelationshipId.GetHashCode();
			}

			if (this.TargetBusObId != null)
			{
				hash = hash * 59 + this.TargetBusObId.GetHashCode();
			}

			if (this.TargetBusObRecId != null)
			{
				hash = hash * 59 + this.TargetBusObRecId.GetHashCode();
			}

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
