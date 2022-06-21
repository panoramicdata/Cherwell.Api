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
/// SearchesRelatedBusinessObjectRequest
/// </summary>
[DataContract]
public partial class SearchesRelatedBusinessObjectRequest :  IEquatable<SearchesRelatedBusinessObjectRequest>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchesRelatedBusinessObjectRequest" /> class.
    /// </summary>
    /// <param name="AllFields">AllFields.</param>
    /// <param name="CustomGridId">CustomGridId.</param>
    /// <param name="FieldsList">FieldsList.</param>
    /// <param name="Filters">Filters.</param>
    /// <param name="PageNumber">PageNumber.</param>
    /// <param name="PageSize">PageSize.</param>
    /// <param name="ParentBusObId">ParentBusObId.</param>
    /// <param name="ParentBusObRecId">ParentBusObRecId.</param>
    /// <param name="RelationshipId">RelationshipId.</param>
    /// <param name="Sorting">Sorting.</param>
    /// <param name="UseDefaultGrid">UseDefaultGrid.</param>
    public SearchesRelatedBusinessObjectRequest(bool? AllFields = default(bool?), string CustomGridId = default(string), List<string> FieldsList = default(List<string>), List<SearchesFilterInfo> Filters = default(List<SearchesFilterInfo>), int? PageNumber = default(int?), int? PageSize = default(int?), string ParentBusObId = default(string), string ParentBusObRecId = default(string), string RelationshipId = default(string), List<SearchesSortInfo> Sorting = default(List<SearchesSortInfo>), bool? UseDefaultGrid = default(bool?))
    {
        this.AllFields = AllFields;
        this.CustomGridId = CustomGridId;
        this.FieldsList = FieldsList;
        this.Filters = Filters;
        this.PageNumber = PageNumber;
        this.PageSize = PageSize;
        this.ParentBusObId = ParentBusObId;
        this.ParentBusObRecId = ParentBusObRecId;
        this.RelationshipId = RelationshipId;
        this.Sorting = Sorting;
        this.UseDefaultGrid = UseDefaultGrid;
    }
    
    /// <summary>
    /// Gets or Sets AllFields
    /// </summary>
    [DataMember(Name="allFields", EmitDefaultValue=false)]
    public bool? AllFields { get; set; }
    /// <summary>
    /// Gets or Sets CustomGridId
    /// </summary>
    [DataMember(Name="customGridId", EmitDefaultValue=false)]
    public string CustomGridId { get; set; }
    /// <summary>
    /// Gets or Sets FieldsList
    /// </summary>
    [DataMember(Name="fieldsList", EmitDefaultValue=false)]
    public List<string> FieldsList { get; set; }
    /// <summary>
    /// Gets or Sets Filters
    /// </summary>
    [DataMember(Name="filters", EmitDefaultValue=false)]
    public List<SearchesFilterInfo> Filters { get; set; }
    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    [DataMember(Name="pageNumber", EmitDefaultValue=false)]
    public int? PageNumber { get; set; }
    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    public int? PageSize { get; set; }
    /// <summary>
    /// Gets or Sets ParentBusObId
    /// </summary>
    [DataMember(Name="parentBusObId", EmitDefaultValue=false)]
    public string ParentBusObId { get; set; }
    /// <summary>
    /// Gets or Sets ParentBusObRecId
    /// </summary>
    [DataMember(Name="parentBusObRecId", EmitDefaultValue=false)]
    public string ParentBusObRecId { get; set; }
    /// <summary>
    /// Gets or Sets RelationshipId
    /// </summary>
    [DataMember(Name="relationshipId", EmitDefaultValue=false)]
    public string RelationshipId { get; set; }
    /// <summary>
    /// Gets or Sets Sorting
    /// </summary>
    [DataMember(Name="sorting", EmitDefaultValue=false)]
    public List<SearchesSortInfo> Sorting { get; set; }
    /// <summary>
    /// Gets or Sets UseDefaultGrid
    /// </summary>
    [DataMember(Name="useDefaultGrid", EmitDefaultValue=false)]
    public bool? UseDefaultGrid { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchesRelatedBusinessObjectRequest {\n");
        sb.Append("  AllFields: ").Append(AllFields).Append("\n");
        sb.Append("  CustomGridId: ").Append(CustomGridId).Append("\n");
        sb.Append("  FieldsList: ").Append(FieldsList).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append("\n");
        sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append("\n");
        sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
        sb.Append("  Sorting: ").Append(Sorting).Append("\n");
        sb.Append("  UseDefaultGrid: ").Append(UseDefaultGrid).Append("\n");
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
        return this.Equals(obj as SearchesRelatedBusinessObjectRequest);
    }

    /// <summary>
    /// Returns true if SearchesRelatedBusinessObjectRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchesRelatedBusinessObjectRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchesRelatedBusinessObjectRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
            return false;

        return 
            (
                this.AllFields == other.AllFields ||
                this.AllFields != null &&
                this.AllFields.Equals(other.AllFields)
            ) && 
            (
                this.CustomGridId == other.CustomGridId ||
                this.CustomGridId != null &&
                this.CustomGridId.Equals(other.CustomGridId)
            ) && 
            (
                this.FieldsList == other.FieldsList ||
                this.FieldsList != null &&
                this.FieldsList.SequenceEqual(other.FieldsList)
            ) && 
            (
                this.Filters == other.Filters ||
                this.Filters != null &&
                this.Filters.SequenceEqual(other.Filters)
            ) && 
            (
                this.PageNumber == other.PageNumber ||
                this.PageNumber != null &&
                this.PageNumber.Equals(other.PageNumber)
            ) && 
            (
                this.PageSize == other.PageSize ||
                this.PageSize != null &&
                this.PageSize.Equals(other.PageSize)
            ) && 
            (
                this.ParentBusObId == other.ParentBusObId ||
                this.ParentBusObId != null &&
                this.ParentBusObId.Equals(other.ParentBusObId)
            ) && 
            (
                this.ParentBusObRecId == other.ParentBusObRecId ||
                this.ParentBusObRecId != null &&
                this.ParentBusObRecId.Equals(other.ParentBusObRecId)
            ) && 
            (
                this.RelationshipId == other.RelationshipId ||
                this.RelationshipId != null &&
                this.RelationshipId.Equals(other.RelationshipId)
            ) && 
            (
                this.Sorting == other.Sorting ||
                this.Sorting != null &&
                this.Sorting.SequenceEqual(other.Sorting)
            ) && 
            (
                this.UseDefaultGrid == other.UseDefaultGrid ||
                this.UseDefaultGrid != null &&
                this.UseDefaultGrid.Equals(other.UseDefaultGrid)
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
            if (this.AllFields != null)
                hash = hash * 59 + this.AllFields.GetHashCode();
            if (this.CustomGridId != null)
                hash = hash * 59 + this.CustomGridId.GetHashCode();
            if (this.FieldsList != null)
                hash = hash * 59 + this.FieldsList.GetHashCode();
            if (this.Filters != null)
                hash = hash * 59 + this.Filters.GetHashCode();
            if (this.PageNumber != null)
                hash = hash * 59 + this.PageNumber.GetHashCode();
            if (this.PageSize != null)
                hash = hash * 59 + this.PageSize.GetHashCode();
            if (this.ParentBusObId != null)
                hash = hash * 59 + this.ParentBusObId.GetHashCode();
            if (this.ParentBusObRecId != null)
                hash = hash * 59 + this.ParentBusObRecId.GetHashCode();
            if (this.RelationshipId != null)
                hash = hash * 59 + this.RelationshipId.GetHashCode();
            if (this.Sorting != null)
                hash = hash * 59 + this.Sorting.GetHashCode();
            if (this.UseDefaultGrid != null)
                hash = hash * 59 + this.UseDefaultGrid.GetHashCode();
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

