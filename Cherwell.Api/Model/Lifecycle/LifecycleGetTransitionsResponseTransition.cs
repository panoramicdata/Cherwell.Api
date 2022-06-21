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

namespace Cherwell.Model.Lifecycle;

/// <summary>
/// LifecycleGetTransitionsResponseTransition
/// </summary>
[DataContract]
public partial class LifecycleGetTransitionsResponseTransition :  IEquatable<LifecycleGetTransitionsResponseTransition>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LifecycleGetTransitionsResponseTransition" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="FromStatusId">FromStatusId.</param>
    /// <param name="ToStatusId">ToStatusId.</param>
    public LifecycleGetTransitionsResponseTransition(string Id = default(string), string Name = default(string), string FromStatusId = default(string), string ToStatusId = default(string))
    {
        this.Id = Id;
        this.Name = Name;
        this.FromStatusId = FromStatusId;
        this.ToStatusId = ToStatusId;
    }
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }
    /// <summary>
    /// Gets or Sets FromStatusId
    /// </summary>
    [DataMember(Name="fromStatusId", EmitDefaultValue=false)]
    public string FromStatusId { get; set; }
    /// <summary>
    /// Gets or Sets ToStatusId
    /// </summary>
    [DataMember(Name="toStatusId", EmitDefaultValue=false)]
    public string ToStatusId { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LifecycleGetTransitionsResponseTransition {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  FromStatusId: ").Append(FromStatusId).Append("\n");
        sb.Append("  ToStatusId: ").Append(ToStatusId).Append("\n");
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
        return this.Equals(obj as LifecycleGetTransitionsResponseTransition);
    }

    /// <summary>
    /// Returns true if LifecycleGetTransitionsResponseTransition instances are equal
    /// </summary>
    /// <param name="other">Instance of LifecycleGetTransitionsResponseTransition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LifecycleGetTransitionsResponseTransition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
            return false;

        return 
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) && 
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) && 
            (
                this.FromStatusId == other.FromStatusId ||
                this.FromStatusId != null &&
                this.FromStatusId.Equals(other.FromStatusId)
            ) && 
            (
                this.ToStatusId == other.ToStatusId ||
                this.ToStatusId != null &&
                this.ToStatusId.Equals(other.ToStatusId)
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
            if (this.Id != null)
                hash = hash * 59 + this.Id.GetHashCode();
            if (this.Name != null)
                hash = hash * 59 + this.Name.GetHashCode();
            if (this.FromStatusId != null)
                hash = hash * 59 + this.FromStatusId.GetHashCode();
            if (this.ToStatusId != null)
                hash = hash * 59 + this.ToStatusId.GetHashCode();
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

