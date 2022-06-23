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

namespace Cherwell.Api.Model.Forms
{
    /// <summary>
    /// FormsSectionField
    /// </summary>
    [DataContract]
    public partial class SectionField : IEquatable<SectionField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionField" /> class.
        /// </summary>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="FieldType">FieldType.</param>
        /// <param name="Label">Label.</param>
        /// <param name="Multiline">Multiline.</param>
        /// <param name="Value">Value.</param>
        public SectionField(List<Object> Attributes, string FieldId, string FieldType, string Label, bool? Multiline, string Value)
        {
            this.Attributes = Attributes;
            this.FieldId = FieldId;
            this.FieldType = FieldType;
            this.Label = Label;
            this.Multiline = Multiline;
            this.Value = Value;
        }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public List<Object> Attributes { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = false)]
        public string FieldType { get; set; }
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }
        /// <summary>
        /// Gets or Sets Multiline
        /// </summary>
        [DataMember(Name = "multiline", EmitDefaultValue = false)]
        public bool? Multiline { get; set; }
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
            sb.Append("class FormsSectionField {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append('\n');
            sb.Append("  FieldId: ").Append(FieldId).Append('\n');
            sb.Append("  FieldType: ").Append(FieldType).Append('\n');
            sb.Append("  Label: ").Append(Label).Append('\n');
            sb.Append("  Multiline: ").Append(Multiline).Append('\n');
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
        public override bool Equals(object? obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SectionField);
        }

        /// <summary>
        /// Returns true if FormsSectionField instances are equal
        /// </summary>
        /// <param name="other">Instance of FormsSectionField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SectionField? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.FieldType == other.FieldType ||
                    this.FieldType != null &&
                    this.FieldType.Equals(other.FieldType, StringComparison.Ordinal)
                ) &&
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label, StringComparison.Ordinal)
                ) &&
                (
                    this.Multiline == other.Multiline ||
                    this.Multiline != null &&
                    this.Multiline.Equals(other.Multiline)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value, StringComparison.Ordinal)
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
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.FieldType != null)
                    hash = hash * 59 + this.FieldType.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Multiline != null)
                    hash = hash * 59 + this.Multiline.GetHashCode();
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