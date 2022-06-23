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

namespace Cherwell.Api.Model
{
    /// <summary>
    /// TrebuchetNameValuePair
    /// </summary>
    [DataContract]
    public partial class TrebuchetNameValuePair :  IEquatable<TrebuchetNameValuePair>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetNameValuePair" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ValueObject">ValueObject.</param>
        /// <param name="ValueString">ValueString.</param>
        /// <param name="Category">Category.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DisplayShowsValue">DisplayShowsValue.</param>
        /// <param name="SpecialUseFlag">SpecialUseFlag.</param>
        /// <param name="DisplayString">DisplayString.</param>
        public TrebuchetNameValuePair(string Name, Object ValueObject, string ValueString, string Category, string Description, bool? DisplayShowsValue, bool? SpecialUseFlag, string DisplayString)
        {
            this.Name = Name;
            this.ValueObject = ValueObject;
            this.ValueString = ValueString;
            this.Category = Category;
            this.Description = Description;
            this.DisplayShowsValue = DisplayShowsValue;
            this.SpecialUseFlag = SpecialUseFlag;
            this.DisplayString = DisplayString;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ValueObject
        /// </summary>
        [DataMember(Name="valueObject", EmitDefaultValue=false)]
        public Object ValueObject { get; set; }
        /// <summary>
        /// Gets or Sets ValueString
        /// </summary>
        [DataMember(Name="valueString", EmitDefaultValue=false)]
        public string ValueString { get; set; }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets DisplayShowsValue
        /// </summary>
        [DataMember(Name="displayShowsValue", EmitDefaultValue=false)]
        public bool? DisplayShowsValue { get; set; }
        /// <summary>
        /// Gets or Sets SpecialUseFlag
        /// </summary>
        [DataMember(Name="specialUseFlag", EmitDefaultValue=false)]
        public bool? SpecialUseFlag { get; set; }
        /// <summary>
        /// Gets or Sets DisplayString
        /// </summary>
        [DataMember(Name="displayString", EmitDefaultValue=false)]
        public string DisplayString { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetNameValuePair {\n");
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  ValueObject: ").Append(ValueObject).Append('\n');
            sb.Append("  ValueString: ").Append(ValueString).Append('\n');
            sb.Append("  Category: ").Append(Category).Append('\n');
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  DisplayShowsValue: ").Append(DisplayShowsValue).Append('\n');
            sb.Append("  SpecialUseFlag: ").Append(SpecialUseFlag).Append('\n');
            sb.Append("  DisplayString: ").Append(DisplayString).Append('\n');
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
            return this.Equals(obj as TrebuchetNameValuePair);
        }

        /// <summary>
        /// Returns true if TrebuchetNameValuePair instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetNameValuePair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetNameValuePair? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name, StringComparison.Ordinal)
                ) && 
                (
                    this.ValueObject == other.ValueObject ||
                    this.ValueObject != null &&
                    this.ValueObject.Equals(other.ValueObject)
                ) && 
                (
                    this.ValueString == other.ValueString ||
                    this.ValueString != null &&
                    this.ValueString.Equals(other.ValueString, StringComparison.Ordinal)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category, StringComparison.Ordinal)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description, StringComparison.Ordinal)
                ) && 
                (
                    this.DisplayShowsValue == other.DisplayShowsValue ||
                    this.DisplayShowsValue != null &&
                    this.DisplayShowsValue.Equals(other.DisplayShowsValue)
                ) && 
                (
                    this.SpecialUseFlag == other.SpecialUseFlag ||
                    this.SpecialUseFlag != null &&
                    this.SpecialUseFlag.Equals(other.SpecialUseFlag)
                ) && 
                (
                    this.DisplayString == other.DisplayString ||
                    this.DisplayString != null &&
                    this.DisplayString.Equals(other.DisplayString, StringComparison.Ordinal)
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
                if (this.ValueObject != null)
                    hash = hash * 59 + this.ValueObject.GetHashCode();
                if (this.ValueString != null)
                    hash = hash * 59 + this.ValueString.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DisplayShowsValue != null)
                    hash = hash * 59 + this.DisplayShowsValue.GetHashCode();
                if (this.SpecialUseFlag != null)
                    hash = hash * 59 + this.SpecialUseFlag.GetHashCode();
                if (this.DisplayString != null)
                    hash = hash * 59 + this.DisplayString.GetHashCode();
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
