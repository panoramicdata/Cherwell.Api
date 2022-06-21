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
/// LifecycleGetStatusesResponseStatuses
/// </summary>
[DataContract]
public partial class LifecycleGetStatusesResponseStatuses :  IEquatable<LifecycleGetStatusesResponseStatuses>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LifecycleGetStatusesResponseStatuses" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="IsInitial">IsInitial.</param>
    /// <param name="Name">Name.</param>
    /// <param name="StageId">StageId.</param>
    public LifecycleGetStatusesResponseStatuses(string Id = default(string), bool? IsInitial = default(bool?), string Name = default(string), string StageId = default(string))
    {
        this.Id = Id;
        this.IsInitial = IsInitial;
        this.Name = Name;
        this.StageId = StageId;
    }
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }
    /// <summary>
    /// Gets or Sets IsInitial
    /// </summary>
    [DataMember(Name="isInitial", EmitDefaultValue=false)]
    public bool? IsInitial { get; set; }
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }
    /// <summary>
    /// Gets or Sets StageId
    /// </summary>
    [DataMember(Name="stageId", EmitDefaultValue=false)]
    public string StageId { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LifecycleGetStatusesResponseStatuses {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  IsInitial: ").Append(IsInitial).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  StageId: ").Append(StageId).Append("\n");
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
        return this.Equals(obj as LifecycleGetStatusesResponseStatuses);
    }

    /// <summary>
    /// Returns true if LifecycleGetStatusesResponseStatuses instances are equal
    /// </summary>
    /// <param name="other">Instance of LifecycleGetStatusesResponseStatuses to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LifecycleGetStatusesResponseStatuses other)
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
                this.IsInitial == other.IsInitial ||
                this.IsInitial != null &&
                this.IsInitial.Equals(other.IsInitial)
            ) && 
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) && 
            (
                this.StageId == other.StageId ||
                this.StageId != null &&
                this.StageId.Equals(other.StageId)
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
            if (this.IsInitial != null)
                hash = hash * 59 + this.IsInitial.GetHashCode();
            if (this.Name != null)
                hash = hash * 59 + this.Name.GetHashCode();
            if (this.StageId != null)
                hash = hash * 59 + this.StageId.GetHashCode();
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

