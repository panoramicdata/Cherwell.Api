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

namespace Cherwell.Model.BusinessObject;

/// <summary>
/// BusinessObjectGridDefinition
/// </summary>
[DataContract]
public partial class BusinessObjectGridDefinition : IEquatable<BusinessObjectGridDefinition>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessObjectGridDefinition" /> class.
    /// </summary>
    /// <param name="GridId">GridId.</param>
    /// <param name="Name">Name.</param>
    /// <param name="DisplayName">DisplayName.</param>
    public BusinessObjectGridDefinition(string GridId = default(string), string Name = default(string), string DisplayName = default(string))
    {
        this.GridId = GridId;
        this.Name = Name;
        this.DisplayName = DisplayName;
    }

    /// <summary>
    /// Gets or Sets GridId
    /// </summary>
    [DataMember(Name = "gridId", EmitDefaultValue = false)]
    public string GridId { get; set; }
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BusinessObjectGridDefinition {\n");
        sb.Append("  GridId: ").Append(GridId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
        return this.Equals(obj as BusinessObjectGridDefinition);
    }

    /// <summary>
    /// Returns true if BusinessObjectGridDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of BusinessObjectGridDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BusinessObjectGridDefinition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
            return false;

        return
            (
                this.GridId == other.GridId ||
                this.GridId != null &&
                this.GridId.Equals(other.GridId)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.DisplayName == other.DisplayName ||
                this.DisplayName != null &&
                this.DisplayName.Equals(other.DisplayName)
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
            if (this.GridId != null)
                hash = hash * 59 + this.GridId.GetHashCode();
            if (this.Name != null)
                hash = hash * 59 + this.Name.GetHashCode();
            if (this.DisplayName != null)
                hash = hash * 59 + this.DisplayName.GetHashCode();
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