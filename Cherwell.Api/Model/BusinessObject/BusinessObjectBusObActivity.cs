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
/// BusinessObjectBusObActivity
/// </summary>
[DataContract]
public partial class BusinessObjectBusObActivity : IEquatable<BusinessObjectBusObActivity>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessObjectBusObActivity" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="ParentBusObDefId">ParentBusObDefId.</param>
    /// <param name="ParentBusObRecId">ParentBusObRecId.</param>
    /// <param name="HistoryBusObDefId">HistoryBusObDefId.</param>
    /// <param name="HistoryBusObRecId">HistoryBusObRecId.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Title">Title.</param>
    /// <param name="Body">Body.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="Created">Created.</param>
    /// <param name="Modified">Modified.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    public BusinessObjectBusObActivity(string Id = default(string), string ParentBusObDefId = default(string), string ParentBusObRecId = default(string), string HistoryBusObDefId = default(string), string HistoryBusObRecId = default(string), string Type = default(string), string Title = default(string), string Body = default(string), string CreatedBy = default(string), DateTime? Created = default(DateTime?), DateTime? Modified = default(DateTime?), string ModifiedBy = default(string))
    {
        this.Id = Id;
        this.ParentBusObDefId = ParentBusObDefId;
        this.ParentBusObRecId = ParentBusObRecId;
        this.HistoryBusObDefId = HistoryBusObDefId;
        this.HistoryBusObRecId = HistoryBusObRecId;
        this.Type = Type;
        this.Title = Title;
        this.Body = Body;
        this.CreatedBy = CreatedBy;
        this.Created = Created;
        this.Modified = Modified;
        this.ModifiedBy = ModifiedBy;
    }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }
    /// <summary>
    /// Gets or Sets ParentBusObDefId
    /// </summary>
    [DataMember(Name = "parentBusObDefId", EmitDefaultValue = false)]
    public string ParentBusObDefId { get; set; }
    /// <summary>
    /// Gets or Sets ParentBusObRecId
    /// </summary>
    [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
    public string ParentBusObRecId { get; set; }
    /// <summary>
    /// Gets or Sets HistoryBusObDefId
    /// </summary>
    [DataMember(Name = "historyBusObDefId", EmitDefaultValue = false)]
    public string HistoryBusObDefId { get; set; }
    /// <summary>
    /// Gets or Sets HistoryBusObRecId
    /// </summary>
    [DataMember(Name = "historyBusObRecId", EmitDefaultValue = false)]
    public string HistoryBusObRecId { get; set; }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }
    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }
    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name = "body", EmitDefaultValue = false)]
    public string Body { get; set; }
    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public string CreatedBy { get; set; }
    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name = "created", EmitDefaultValue = false)]
    public DateTime? Created { get; set; }
    /// <summary>
    /// Gets or Sets Modified
    /// </summary>
    [DataMember(Name = "modified", EmitDefaultValue = false)]
    public DateTime? Modified { get; set; }
    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public string ModifiedBy { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BusinessObjectBusObActivity {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ParentBusObDefId: ").Append(ParentBusObDefId).Append("\n");
        sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
        sb.Append("  HistoryBusObDefId: ").Append(HistoryBusObDefId).Append("\n");
        sb.Append("  HistoryBusObRecId: ").Append(HistoryBusObRecId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Created: ").Append(Created).Append("\n");
        sb.Append("  Modified: ").Append(Modified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
        return this.Equals(obj as BusinessObjectBusObActivity);
    }

    /// <summary>
    /// Returns true if BusinessObjectBusObActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of BusinessObjectBusObActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BusinessObjectBusObActivity other)
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
                this.ParentBusObDefId == other.ParentBusObDefId ||
                this.ParentBusObDefId != null &&
                this.ParentBusObDefId.Equals(other.ParentBusObDefId)
            ) &&
            (
                this.ParentBusObRecId == other.ParentBusObRecId ||
                this.ParentBusObRecId != null &&
                this.ParentBusObRecId.Equals(other.ParentBusObRecId)
            ) &&
            (
                this.HistoryBusObDefId == other.HistoryBusObDefId ||
                this.HistoryBusObDefId != null &&
                this.HistoryBusObDefId.Equals(other.HistoryBusObDefId)
            ) &&
            (
                this.HistoryBusObRecId == other.HistoryBusObRecId ||
                this.HistoryBusObRecId != null &&
                this.HistoryBusObRecId.Equals(other.HistoryBusObRecId)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Title == other.Title ||
                this.Title != null &&
                this.Title.Equals(other.Title)
            ) &&
            (
                this.Body == other.Body ||
                this.Body != null &&
                this.Body.Equals(other.Body)
            ) &&
            (
                this.CreatedBy == other.CreatedBy ||
                this.CreatedBy != null &&
                this.CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                this.Created == other.Created ||
                this.Created != null &&
                this.Created.Equals(other.Created)
            ) &&
            (
                this.Modified == other.Modified ||
                this.Modified != null &&
                this.Modified.Equals(other.Modified)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
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
            if (this.ParentBusObDefId != null)
                hash = hash * 59 + this.ParentBusObDefId.GetHashCode();
            if (this.ParentBusObRecId != null)
                hash = hash * 59 + this.ParentBusObRecId.GetHashCode();
            if (this.HistoryBusObDefId != null)
                hash = hash * 59 + this.HistoryBusObDefId.GetHashCode();
            if (this.HistoryBusObRecId != null)
                hash = hash * 59 + this.HistoryBusObRecId.GetHashCode();
            if (this.Type != null)
                hash = hash * 59 + this.Type.GetHashCode();
            if (this.Title != null)
                hash = hash * 59 + this.Title.GetHashCode();
            if (this.Body != null)
                hash = hash * 59 + this.Body.GetHashCode();
            if (this.CreatedBy != null)
                hash = hash * 59 + this.CreatedBy.GetHashCode();
            if (this.Created != null)
                hash = hash * 59 + this.Created.GetHashCode();
            if (this.Modified != null)
                hash = hash * 59 + this.Modified.GetHashCode();
            if (this.ModifiedBy != null)
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
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