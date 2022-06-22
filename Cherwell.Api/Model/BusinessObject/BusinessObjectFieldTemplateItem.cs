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

namespace Cherwell.Api.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectFieldTemplateItem
    /// </summary>
    [DataContract]
    public partial class BusinessObjectFieldTemplateItem : IEquatable<BusinessObjectFieldTemplateItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectFieldTemplateItem" /> class.
        /// </summary>
        /// <param name="Dirty">Dirty.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="FullFieldId">FullFieldId.</param>
        /// <param name="Html">Html.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Value">Value.</param>
        public BusinessObjectFieldTemplateItem(bool? Dirty = default(bool?), string DisplayName = default(string), string FieldId = default(string), string FullFieldId = default(string), string Html = default(string), string Name = default(string), string Value = default(string))
        {
            this.Dirty = Dirty;
            this.DisplayName = DisplayName;
            this.FieldId = FieldId;
            this.FullFieldId = FullFieldId;
            this.Html = Html;
            this.Name = Name;
            this.Value = Value;
        }

        /// <summary>
        /// Gets or Sets Dirty
        /// </summary>
        [DataMember(Name = "dirty", EmitDefaultValue = false)]
        public bool? Dirty { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets FullFieldId
        /// </summary>
        [DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
        public string FullFieldId { get; set; }
        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = false)]
        public string Html { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectFieldTemplateItem {\n");
            sb.Append("  Dirty: ").Append(Dirty).Append('\n');
            sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
            sb.Append("  FieldId: ").Append(FieldId).Append('\n');
            sb.Append("  FullFieldId: ").Append(FullFieldId).Append('\n');
            sb.Append("  Html: ").Append(Html).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
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
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BusinessObjectFieldTemplateItem);
        }

        /// <summary>
        /// Returns true if BusinessObjectFieldTemplateItem instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectFieldTemplateItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectFieldTemplateItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Dirty == other.Dirty ||
                    this.Dirty != null &&
                    this.Dirty.Equals(other.Dirty)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) &&
                (
                    this.FullFieldId == other.FullFieldId ||
                    this.FullFieldId != null &&
                    this.FullFieldId.Equals(other.FullFieldId)
                ) &&
                (
                    this.Html == other.Html ||
                    this.Html != null &&
                    this.Html.Equals(other.Html)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Dirty != null)
                    hash = hash * 59 + this.Dirty.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.FullFieldId != null)
                    hash = hash * 59 + this.FullFieldId.GetHashCode();
                if (this.Html != null)
                    hash = hash * 59 + this.Html.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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