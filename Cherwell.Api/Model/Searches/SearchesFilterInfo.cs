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

namespace Cherwell.Model.Searches;

/// <summary>
/// SearchesFilterInfo
/// </summary>
[DataContract]
public partial class SearchesFilterInfo :  IEquatable<SearchesFilterInfo>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchesFilterInfo" /> class.
    /// </summary>
    /// <param name="FieldId">FieldId.</param>
    /// <param name="_Operator">_Operator.</param>
    /// <param name="Value">Value.</param>
    public SearchesFilterInfo(string FieldId = default(string), string _Operator = default(string), string Value = default(string))
    {
        this.FieldId = FieldId;
        this._Operator = _Operator;
        this.Value = Value;
    }
    
    /// <summary>
    /// Gets or Sets FieldId
    /// </summary>
    [DataMember(Name="fieldId", EmitDefaultValue=false)]
    public string FieldId { get; set; }
    /// <summary>
    /// Gets or Sets _Operator
    /// </summary>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    public string _Operator { get; set; }
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    public string Value { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchesFilterInfo {\n");
        sb.Append("  FieldId: ").Append(FieldId).Append("\n");
        sb.Append("  _Operator: ").Append(_Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return this.Equals(obj as SearchesFilterInfo);
    }

    /// <summary>
    /// Returns true if SearchesFilterInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchesFilterInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchesFilterInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
            return false;

        return 
            (
                this.FieldId == other.FieldId ||
                this.FieldId != null &&
                this.FieldId.Equals(other.FieldId)
            ) && 
            (
                this._Operator == other._Operator ||
                this._Operator != null &&
                this._Operator.Equals(other._Operator)
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
            if (this.FieldId != null)
                hash = hash * 59 + this.FieldId.GetHashCode();
            if (this._Operator != null)
                hash = hash * 59 + this._Operator.GetHashCode();
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

