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

namespace Cherwell.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectFieldDefinition
    /// </summary>
    [DataContract]
    public partial class BusinessObjectFieldDefinition : IEquatable<BusinessObjectFieldDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectFieldDefinition" /> class.
        /// </summary>
        /// <param name="AutoFill">AutoFill.</param>
        /// <param name="Calculated">Calculated.</param>
        /// <param name="Category">Category.</param>
        /// <param name="DecimalDigits">DecimalDigits.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Details">Details.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="HasDate">HasDate.</param>
        /// <param name="HasTime">HasTime.</param>
        /// <param name="IsFullTextSearchable">IsFullTextSearchable.</param>
        /// <param name="MaximumSize">MaximumSize.</param>
        /// <param name="Name">Name.</param>
        /// <param name="_ReadOnly">_ReadOnly.</param>
        /// <param name="Required">Required.</param>
        /// <param name="Type">Type.</param>
        /// <param name="TypeLocalized">TypeLocalized.</param>
        /// <param name="Validated">Validated.</param>
        /// <param name="WholeDigits">WholeDigits.</param>
        public BusinessObjectFieldDefinition(bool? AutoFill = default(bool?), bool? Calculated = default(bool?), string Category = default(string), int? DecimalDigits = default(int?), string Description = default(string), string Details = default(string), string DisplayName = default(string), bool? Enabled = default(bool?), string FieldId = default(string), bool? HasDate = default(bool?), bool? HasTime = default(bool?), bool? IsFullTextSearchable = default(bool?), string MaximumSize = default(string), string Name = default(string), bool? _ReadOnly = default(bool?), bool? Required = default(bool?), string Type = default(string), string TypeLocalized = default(string), bool? Validated = default(bool?), int? WholeDigits = default(int?))
        {
            this.AutoFill = AutoFill;
            this.Calculated = Calculated;
            this.Category = Category;
            this.DecimalDigits = DecimalDigits;
            this.Description = Description;
            this.Details = Details;
            this.DisplayName = DisplayName;
            this.Enabled = Enabled;
            this.FieldId = FieldId;
            this.HasDate = HasDate;
            this.HasTime = HasTime;
            this.IsFullTextSearchable = IsFullTextSearchable;
            this.MaximumSize = MaximumSize;
            this.Name = Name;
            this._ReadOnly = _ReadOnly;
            this.Required = Required;
            this.Type = Type;
            this.TypeLocalized = TypeLocalized;
            this.Validated = Validated;
            this.WholeDigits = WholeDigits;
        }

        /// <summary>
        /// Gets or Sets AutoFill
        /// </summary>
        [DataMember(Name = "autoFill", EmitDefaultValue = false)]
        public bool? AutoFill { get; set; }
        /// <summary>
        /// Gets or Sets Calculated
        /// </summary>
        [DataMember(Name = "calculated", EmitDefaultValue = false)]
        public bool? Calculated { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }
        /// <summary>
        /// Gets or Sets DecimalDigits
        /// </summary>
        [DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
        public int? DecimalDigits { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets HasDate
        /// </summary>
        [DataMember(Name = "hasDate", EmitDefaultValue = false)]
        public bool? HasDate { get; set; }
        /// <summary>
        /// Gets or Sets HasTime
        /// </summary>
        [DataMember(Name = "hasTime", EmitDefaultValue = false)]
        public bool? HasTime { get; set; }
        /// <summary>
        /// Gets or Sets IsFullTextSearchable
        /// </summary>
        [DataMember(Name = "isFullTextSearchable", EmitDefaultValue = false)]
        public bool? IsFullTextSearchable { get; set; }
        /// <summary>
        /// Gets or Sets MaximumSize
        /// </summary>
        [DataMember(Name = "maximumSize", EmitDefaultValue = false)]
        public string MaximumSize { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets _ReadOnly
        /// </summary>
        [DataMember(Name = "readOnly", EmitDefaultValue = false)]
        public bool? _ReadOnly { get; set; }
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        public bool? Required { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets TypeLocalized
        /// </summary>
        [DataMember(Name = "typeLocalized", EmitDefaultValue = false)]
        public string TypeLocalized { get; set; }
        /// <summary>
        /// Gets or Sets Validated
        /// </summary>
        [DataMember(Name = "validated", EmitDefaultValue = false)]
        public bool? Validated { get; set; }
        /// <summary>
        /// Gets or Sets WholeDigits
        /// </summary>
        [DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
        public int? WholeDigits { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectFieldDefinition {\n");
            sb.Append("  AutoFill: ").Append(AutoFill).Append("\n");
            sb.Append("  Calculated: ").Append(Calculated).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  HasDate: ").Append(HasDate).Append("\n");
            sb.Append("  HasTime: ").Append(HasTime).Append("\n");
            sb.Append("  IsFullTextSearchable: ").Append(IsFullTextSearchable).Append("\n");
            sb.Append("  MaximumSize: ").Append(MaximumSize).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeLocalized: ").Append(TypeLocalized).Append("\n");
            sb.Append("  Validated: ").Append(Validated).Append("\n");
            sb.Append("  WholeDigits: ").Append(WholeDigits).Append("\n");
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
            return this.Equals(obj as BusinessObjectFieldDefinition);
        }

        /// <summary>
        /// Returns true if BusinessObjectFieldDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectFieldDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectFieldDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AutoFill == other.AutoFill ||
                    this.AutoFill != null &&
                    this.AutoFill.Equals(other.AutoFill)
                ) &&
                (
                    this.Calculated == other.Calculated ||
                    this.Calculated != null &&
                    this.Calculated.Equals(other.Calculated)
                ) &&
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) &&
                (
                    this.DecimalDigits == other.DecimalDigits ||
                    this.DecimalDigits != null &&
                    this.DecimalDigits.Equals(other.DecimalDigits)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) &&
                (
                    this.HasDate == other.HasDate ||
                    this.HasDate != null &&
                    this.HasDate.Equals(other.HasDate)
                ) &&
                (
                    this.HasTime == other.HasTime ||
                    this.HasTime != null &&
                    this.HasTime.Equals(other.HasTime)
                ) &&
                (
                    this.IsFullTextSearchable == other.IsFullTextSearchable ||
                    this.IsFullTextSearchable != null &&
                    this.IsFullTextSearchable.Equals(other.IsFullTextSearchable)
                ) &&
                (
                    this.MaximumSize == other.MaximumSize ||
                    this.MaximumSize != null &&
                    this.MaximumSize.Equals(other.MaximumSize)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.TypeLocalized == other.TypeLocalized ||
                    this.TypeLocalized != null &&
                    this.TypeLocalized.Equals(other.TypeLocalized)
                ) &&
                (
                    this.Validated == other.Validated ||
                    this.Validated != null &&
                    this.Validated.Equals(other.Validated)
                ) &&
                (
                    this.WholeDigits == other.WholeDigits ||
                    this.WholeDigits != null &&
                    this.WholeDigits.Equals(other.WholeDigits)
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
                if (this.AutoFill != null)
                    hash = hash * 59 + this.AutoFill.GetHashCode();
                if (this.Calculated != null)
                    hash = hash * 59 + this.Calculated.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.DecimalDigits != null)
                    hash = hash * 59 + this.DecimalDigits.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.HasDate != null)
                    hash = hash * 59 + this.HasDate.GetHashCode();
                if (this.HasTime != null)
                    hash = hash * 59 + this.HasTime.GetHashCode();
                if (this.IsFullTextSearchable != null)
                    hash = hash * 59 + this.IsFullTextSearchable.GetHashCode();
                if (this.MaximumSize != null)
                    hash = hash * 59 + this.MaximumSize.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.TypeLocalized != null)
                    hash = hash * 59 + this.TypeLocalized.GetHashCode();
                if (this.Validated != null)
                    hash = hash * 59 + this.Validated.GetHashCode();
                if (this.WholeDigits != null)
                    hash = hash * 59 + this.WholeDigits.GetHashCode();
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