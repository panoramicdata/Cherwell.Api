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
    /// CoreView
    /// </summary>
    [DataContract]
    public partial class CoreView : IEquatable<CoreView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreView" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ViewId">ViewId.</param>
        /// <param name="Image">Image.</param>
        public CoreView(string Name = default(string), string ViewId = default(string), string Image = default(string))
        {
            this.Name = Name;
            this.ViewId = ViewId;
            this.Image = Image;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ViewId
        /// </summary>
        [DataMember(Name = "viewId", EmitDefaultValue = false)]
        public string ViewId { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreView {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ViewId: ").Append(ViewId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(obj as CoreView);
        }

        /// <summary>
        /// Returns true if CoreView instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreView other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ViewId == other.ViewId ||
                    this.ViewId != null &&
                    this.ViewId.Equals(other.ViewId)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ViewId != null)
                    hash = hash * 59 + this.ViewId.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
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