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

namespace Cherwell.Api.Model.Core
{
    /// <summary>
    /// CoreSaveGalleryImageRequest
    /// </summary>
    [DataContract]
    public partial class CoreSaveGalleryImageRequest : IEquatable<CoreSaveGalleryImageRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageTypeEnum
        {

            /// <summary>
            /// Enum Imported for "Imported"
            /// </summary>
            [EnumMember(Value = "Imported")]
            Imported,

            /// <summary>
            /// Enum File for "File"
            /// </summary>
            [EnumMember(Value = "File")]
            File,

            /// <summary>
            /// Enum Url for "Url"
            /// </summary>
            [EnumMember(Value = "Url")]
            Url
        }

        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name = "imageType", EmitDefaultValue = false)]
        public ImageTypeEnum? ImageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreSaveGalleryImageRequest" /> class.
        /// </summary>
        /// <param name="Base64EncodedImageData">Base64EncodedImageData.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Folder">Folder.</param>
        /// <param name="ImageType">ImageType.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="StandInKey">StandInKey.</param>
        public CoreSaveGalleryImageRequest(string Base64EncodedImageData = default(string), string Description = default(string), string Folder = default(string), ImageTypeEnum? ImageType = default(ImageTypeEnum?), string Name = default(string), string Scope = default(string), string ScopeOwner = default(string), string StandInKey = default(string))
        {
            this.Base64EncodedImageData = Base64EncodedImageData;
            this.Description = Description;
            this.Folder = Folder;
            this.ImageType = ImageType;
            this.Name = Name;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.StandInKey = StandInKey;
        }

        /// <summary>
        /// Gets or Sets Base64EncodedImageData
        /// </summary>
        [DataMember(Name = "base64EncodedImageData", EmitDefaultValue = false)]
        public string Base64EncodedImageData { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false)]
        public string Folder { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
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
            sb.Append("class CoreSaveGalleryImageRequest {\n");
            sb.Append("  Base64EncodedImageData: ").Append(Base64EncodedImageData).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  Folder: ").Append(Folder).Append('\n');
            sb.Append("  ImageType: ").Append(ImageType).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Scope: ").Append(Scope).Append('\n');
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
            sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
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
            return this.Equals(obj as CoreSaveGalleryImageRequest);
        }

        /// <summary>
        /// Returns true if CoreSaveGalleryImageRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreSaveGalleryImageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreSaveGalleryImageRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Base64EncodedImageData == other.Base64EncodedImageData ||
                    this.Base64EncodedImageData != null &&
                    this.Base64EncodedImageData.Equals(other.Base64EncodedImageData)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) &&
                (
                    this.ImageType == other.ImageType ||
                    this.ImageType != null &&
                    this.ImageType.Equals(other.ImageType)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Base64EncodedImageData != null)
                    hash = hash * 59 + this.Base64EncodedImageData.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.ImageType != null)
                    hash = hash * 59 + this.ImageType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
