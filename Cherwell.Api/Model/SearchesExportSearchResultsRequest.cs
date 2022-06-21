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

namespace Cherwell.Model
{
    /// <summary>
    /// SearchesExportSearchResultsRequest
    /// </summary>
    [DataContract]
    public partial class SearchesExportSearchResultsRequest :  IEquatable<SearchesExportSearchResultsRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ExportFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExportFormatEnum
        {
            
            /// <summary>
            /// Enum CSV for "CSV"
            /// </summary>
            [EnumMember(Value = "CSV")]
            CSV,
            
            /// <summary>
            /// Enum Excel for "Excel"
            /// </summary>
            [EnumMember(Value = "Excel")]
            Excel,
            
            /// <summary>
            /// Enum Tab for "Tab"
            /// </summary>
            [EnumMember(Value = "Tab")]
            Tab,
            
            /// <summary>
            /// Enum Word for "Word"
            /// </summary>
            [EnumMember(Value = "Word")]
            Word,
            
            /// <summary>
            /// Enum CustomSeparator for "CustomSeparator"
            /// </summary>
            [EnumMember(Value = "CustomSeparator")]
            CustomSeparator,
            
            /// <summary>
            /// Enum Json for "Json"
            /// </summary>
            [EnumMember(Value = "Json")]
            Json
        }

        /// <summary>
        /// Gets or Sets ExportFormat
        /// </summary>
        [DataMember(Name="exportFormat", EmitDefaultValue=false)]
        public ExportFormatEnum? ExportFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesExportSearchResultsRequest" /> class.
        /// </summary>
        /// <param name="CustomSeparator">CustomSeparator.</param>
        /// <param name="ExportFormat">ExportFormat.</param>
        /// <param name="ExportTitle">ExportTitle.</param>
        /// <param name="Association">Association.</param>
        /// <param name="AssociationName">AssociationName.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="CustomGridDefId">CustomGridDefId.</param>
        /// <param name="DateTimeFormatting">DateTimeFormatting.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="Filters">Filters.</param>
        /// <param name="IncludeAllFields">IncludeAllFields.</param>
        /// <param name="IncludeSchema">IncludeSchema.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="PageSize">PageSize.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="SearchId">SearchId.</param>
        /// <param name="SearchName">SearchName.</param>
        /// <param name="SearchText">SearchText.</param>
        /// <param name="Sorting">Sorting.</param>
        /// <param name="PromptValues">PromptValues.</param>
        public SearchesExportSearchResultsRequest(string CustomSeparator = default(string), ExportFormatEnum? ExportFormat = default(ExportFormatEnum?), string ExportTitle = default(string), string Association = default(string), string AssociationName = default(string), string BusObId = default(string), string CustomGridDefId = default(string), string DateTimeFormatting = default(string), string FieldId = default(string), List<string> Fields = default(List<string>), List<SearchesFilterInfo> Filters = default(List<SearchesFilterInfo>), bool? IncludeAllFields = default(bool?), bool? IncludeSchema = default(bool?), int? PageNumber = default(int?), int? PageSize = default(int?), string Scope = default(string), string ScopeOwner = default(string), string SearchId = default(string), string SearchName = default(string), string SearchText = default(string), List<SearchesSortInfo> Sorting = default(List<SearchesSortInfo>), List<CorePromptValue> PromptValues = default(List<CorePromptValue>))
        {
            this.CustomSeparator = CustomSeparator;
            this.ExportFormat = ExportFormat;
            this.ExportTitle = ExportTitle;
            this.Association = Association;
            this.AssociationName = AssociationName;
            this.BusObId = BusObId;
            this.CustomGridDefId = CustomGridDefId;
            this.DateTimeFormatting = DateTimeFormatting;
            this.FieldId = FieldId;
            this.Fields = Fields;
            this.Filters = Filters;
            this.IncludeAllFields = IncludeAllFields;
            this.IncludeSchema = IncludeSchema;
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.SearchId = SearchId;
            this.SearchName = SearchName;
            this.SearchText = SearchText;
            this.Sorting = Sorting;
            this.PromptValues = PromptValues;
        }
        
        /// <summary>
        /// Gets or Sets CustomSeparator
        /// </summary>
        [DataMember(Name="customSeparator", EmitDefaultValue=false)]
        public string CustomSeparator { get; set; }
        /// <summary>
        /// Gets or Sets ExportTitle
        /// </summary>
        [DataMember(Name="exportTitle", EmitDefaultValue=false)]
        public string ExportTitle { get; set; }
        /// <summary>
        /// Gets or Sets Association
        /// </summary>
        [DataMember(Name="association", EmitDefaultValue=false)]
        public string Association { get; set; }
        /// <summary>
        /// Gets or Sets AssociationName
        /// </summary>
        [DataMember(Name="associationName", EmitDefaultValue=false)]
        public string AssociationName { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets CustomGridDefId
        /// </summary>
        [DataMember(Name="customGridDefId", EmitDefaultValue=false)]
        public string CustomGridDefId { get; set; }
        /// <summary>
        /// Gets or Sets DateTimeFormatting
        /// </summary>
        [DataMember(Name="dateTimeFormatting", EmitDefaultValue=false)]
        public string DateTimeFormatting { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<SearchesFilterInfo> Filters { get; set; }
        /// <summary>
        /// Gets or Sets IncludeAllFields
        /// </summary>
        [DataMember(Name="includeAllFields", EmitDefaultValue=false)]
        public bool? IncludeAllFields { get; set; }
        /// <summary>
        /// Gets or Sets IncludeSchema
        /// </summary>
        [DataMember(Name="includeSchema", EmitDefaultValue=false)]
        public bool? IncludeSchema { get; set; }
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
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }
        /// <summary>
        /// Gets or Sets SearchId
        /// </summary>
        [DataMember(Name="searchId", EmitDefaultValue=false)]
        public string SearchId { get; set; }
        /// <summary>
        /// Gets or Sets SearchName
        /// </summary>
        [DataMember(Name="searchName", EmitDefaultValue=false)]
        public string SearchName { get; set; }
        /// <summary>
        /// Gets or Sets SearchText
        /// </summary>
        [DataMember(Name="searchText", EmitDefaultValue=false)]
        public string SearchText { get; set; }
        /// <summary>
        /// Gets or Sets Sorting
        /// </summary>
        [DataMember(Name="sorting", EmitDefaultValue=false)]
        public List<SearchesSortInfo> Sorting { get; set; }
        /// <summary>
        /// Gets or Sets PromptValues
        /// </summary>
        [DataMember(Name="promptValues", EmitDefaultValue=false)]
        public List<CorePromptValue> PromptValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesExportSearchResultsRequest {\n");
            sb.Append("  CustomSeparator: ").Append(CustomSeparator).Append("\n");
            sb.Append("  ExportFormat: ").Append(ExportFormat).Append("\n");
            sb.Append("  ExportTitle: ").Append(ExportTitle).Append("\n");
            sb.Append("  Association: ").Append(Association).Append("\n");
            sb.Append("  AssociationName: ").Append(AssociationName).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  CustomGridDefId: ").Append(CustomGridDefId).Append("\n");
            sb.Append("  DateTimeFormatting: ").Append(DateTimeFormatting).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  IncludeAllFields: ").Append(IncludeAllFields).Append("\n");
            sb.Append("  IncludeSchema: ").Append(IncludeSchema).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  SearchId: ").Append(SearchId).Append("\n");
            sb.Append("  SearchName: ").Append(SearchName).Append("\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
            sb.Append("  PromptValues: ").Append(PromptValues).Append("\n");
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
            return this.Equals(obj as SearchesExportSearchResultsRequest);
        }

        /// <summary>
        /// Returns true if SearchesExportSearchResultsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesExportSearchResultsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesExportSearchResultsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomSeparator == other.CustomSeparator ||
                    this.CustomSeparator != null &&
                    this.CustomSeparator.Equals(other.CustomSeparator)
                ) && 
                (
                    this.ExportFormat == other.ExportFormat ||
                    this.ExportFormat != null &&
                    this.ExportFormat.Equals(other.ExportFormat)
                ) && 
                (
                    this.ExportTitle == other.ExportTitle ||
                    this.ExportTitle != null &&
                    this.ExportTitle.Equals(other.ExportTitle)
                ) && 
                (
                    this.Association == other.Association ||
                    this.Association != null &&
                    this.Association.Equals(other.Association)
                ) && 
                (
                    this.AssociationName == other.AssociationName ||
                    this.AssociationName != null &&
                    this.AssociationName.Equals(other.AssociationName)
                ) && 
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId)
                ) && 
                (
                    this.CustomGridDefId == other.CustomGridDefId ||
                    this.CustomGridDefId != null &&
                    this.CustomGridDefId.Equals(other.CustomGridDefId)
                ) && 
                (
                    this.DateTimeFormatting == other.DateTimeFormatting ||
                    this.DateTimeFormatting != null &&
                    this.DateTimeFormatting.Equals(other.DateTimeFormatting)
                ) && 
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) && 
                (
                    this.IncludeAllFields == other.IncludeAllFields ||
                    this.IncludeAllFields != null &&
                    this.IncludeAllFields.Equals(other.IncludeAllFields)
                ) && 
                (
                    this.IncludeSchema == other.IncludeSchema ||
                    this.IncludeSchema != null &&
                    this.IncludeSchema.Equals(other.IncludeSchema)
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
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) && 
                (
                    this.ScopeOwner == other.ScopeOwner ||
                    this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(other.ScopeOwner)
                ) && 
                (
                    this.SearchId == other.SearchId ||
                    this.SearchId != null &&
                    this.SearchId.Equals(other.SearchId)
                ) && 
                (
                    this.SearchName == other.SearchName ||
                    this.SearchName != null &&
                    this.SearchName.Equals(other.SearchName)
                ) && 
                (
                    this.SearchText == other.SearchText ||
                    this.SearchText != null &&
                    this.SearchText.Equals(other.SearchText)
                ) && 
                (
                    this.Sorting == other.Sorting ||
                    this.Sorting != null &&
                    this.Sorting.SequenceEqual(other.Sorting)
                ) && 
                (
                    this.PromptValues == other.PromptValues ||
                    this.PromptValues != null &&
                    this.PromptValues.SequenceEqual(other.PromptValues)
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
                if (this.CustomSeparator != null)
                    hash = hash * 59 + this.CustomSeparator.GetHashCode();
                if (this.ExportFormat != null)
                    hash = hash * 59 + this.ExportFormat.GetHashCode();
                if (this.ExportTitle != null)
                    hash = hash * 59 + this.ExportTitle.GetHashCode();
                if (this.Association != null)
                    hash = hash * 59 + this.Association.GetHashCode();
                if (this.AssociationName != null)
                    hash = hash * 59 + this.AssociationName.GetHashCode();
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.CustomGridDefId != null)
                    hash = hash * 59 + this.CustomGridDefId.GetHashCode();
                if (this.DateTimeFormatting != null)
                    hash = hash * 59 + this.DateTimeFormatting.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.IncludeAllFields != null)
                    hash = hash * 59 + this.IncludeAllFields.GetHashCode();
                if (this.IncludeSchema != null)
                    hash = hash * 59 + this.IncludeSchema.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.PageSize != null)
                    hash = hash * 59 + this.PageSize.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hash = hash * 59 + this.ScopeOwner.GetHashCode();
                if (this.SearchId != null)
                    hash = hash * 59 + this.SearchId.GetHashCode();
                if (this.SearchName != null)
                    hash = hash * 59 + this.SearchName.GetHashCode();
                if (this.SearchText != null)
                    hash = hash * 59 + this.SearchText.GetHashCode();
                if (this.Sorting != null)
                    hash = hash * 59 + this.Sorting.GetHashCode();
                if (this.PromptValues != null)
                    hash = hash * 59 + this.PromptValues.GetHashCode();
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
