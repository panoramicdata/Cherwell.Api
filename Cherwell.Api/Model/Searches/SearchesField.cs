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

namespace Cherwell.Model.Searches
{
    /// <summary>
    /// SearchesField
    /// </summary>
    [DataContract]
    public partial class SearchesField : IEquatable<SearchesField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesField" /> class.
        /// </summary>
        /// <param name="Caption">Caption.</param>
        /// <param name="CurrencyCulture">CurrencyCulture.</param>
        /// <param name="CurrencySymbol">CurrencySymbol.</param>
        /// <param name="DecimalDigits">DecimalDigits.</param>
        /// <param name="DefaultSortOrderAscending">DefaultSortOrderAscending.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="FullFieldId">FullFieldId.</param>
        /// <param name="HasDefaultSortField">HasDefaultSortField.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="IsBinary">IsBinary.</param>
        /// <param name="IsCurrency">IsCurrency.</param>
        /// <param name="IsDateTime">IsDateTime.</param>
        /// <param name="IsFilterAllowed">IsFilterAllowed.</param>
        /// <param name="IsLogical">IsLogical.</param>
        /// <param name="IsNumber">IsNumber.</param>
        /// <param name="IsShortDate">IsShortDate.</param>
        /// <param name="IsShortTime">IsShortTime.</param>
        /// <param name="IsVisible">IsVisible.</param>
        /// <param name="Sortable">Sortable.</param>
        /// <param name="SortOrder">SortOrder.</param>
        /// <param name="StorageName">StorageName.</param>
        /// <param name="WholeDigits">WholeDigits.</param>
        public SearchesField(string Caption = default(string), string CurrencyCulture = default(string), string CurrencySymbol = default(string), int? DecimalDigits = default(int?), bool? DefaultSortOrderAscending = default(bool?), string DisplayName = default(string), string FieldName = default(string), string FullFieldId = default(string), bool? HasDefaultSortField = default(bool?), string FieldId = default(string), bool? IsBinary = default(bool?), bool? IsCurrency = default(bool?), bool? IsDateTime = default(bool?), bool? IsFilterAllowed = default(bool?), bool? IsLogical = default(bool?), bool? IsNumber = default(bool?), bool? IsShortDate = default(bool?), bool? IsShortTime = default(bool?), bool? IsVisible = default(bool?), bool? Sortable = default(bool?), string SortOrder = default(string), string StorageName = default(string), int? WholeDigits = default(int?))
        {
            this.Caption = Caption;
            this.CurrencyCulture = CurrencyCulture;
            this.CurrencySymbol = CurrencySymbol;
            this.DecimalDigits = DecimalDigits;
            this.DefaultSortOrderAscending = DefaultSortOrderAscending;
            this.DisplayName = DisplayName;
            this.FieldName = FieldName;
            this.FullFieldId = FullFieldId;
            this.HasDefaultSortField = HasDefaultSortField;
            this.FieldId = FieldId;
            this.IsBinary = IsBinary;
            this.IsCurrency = IsCurrency;
            this.IsDateTime = IsDateTime;
            this.IsFilterAllowed = IsFilterAllowed;
            this.IsLogical = IsLogical;
            this.IsNumber = IsNumber;
            this.IsShortDate = IsShortDate;
            this.IsShortTime = IsShortTime;
            this.IsVisible = IsVisible;
            this.Sortable = Sortable;
            this.SortOrder = SortOrder;
            this.StorageName = StorageName;
            this.WholeDigits = WholeDigits;
        }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name = "caption", EmitDefaultValue = false)]
        public string Caption { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCulture
        /// </summary>
        [DataMember(Name = "currencyCulture", EmitDefaultValue = false)]
        public string CurrencyCulture { get; set; }
        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name = "currencySymbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// Gets or Sets DecimalDigits
        /// </summary>
        [DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
        public int? DecimalDigits { get; set; }
        /// <summary>
        /// Gets or Sets DefaultSortOrderAscending
        /// </summary>
        [DataMember(Name = "defaultSortOrderAscending", EmitDefaultValue = false)]
        public bool? DefaultSortOrderAscending { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }
        /// <summary>
        /// Gets or Sets FullFieldId
        /// </summary>
        [DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
        public string FullFieldId { get; set; }
        /// <summary>
        /// Gets or Sets HasDefaultSortField
        /// </summary>
        [DataMember(Name = "hasDefaultSortField", EmitDefaultValue = false)]
        public bool? HasDefaultSortField { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets IsBinary
        /// </summary>
        [DataMember(Name = "isBinary", EmitDefaultValue = false)]
        public bool? IsBinary { get; set; }
        /// <summary>
        /// Gets or Sets IsCurrency
        /// </summary>
        [DataMember(Name = "isCurrency", EmitDefaultValue = false)]
        public bool? IsCurrency { get; set; }
        /// <summary>
        /// Gets or Sets IsDateTime
        /// </summary>
        [DataMember(Name = "isDateTime", EmitDefaultValue = false)]
        public bool? IsDateTime { get; set; }
        /// <summary>
        /// Gets or Sets IsFilterAllowed
        /// </summary>
        [DataMember(Name = "isFilterAllowed", EmitDefaultValue = false)]
        public bool? IsFilterAllowed { get; set; }
        /// <summary>
        /// Gets or Sets IsLogical
        /// </summary>
        [DataMember(Name = "isLogical", EmitDefaultValue = false)]
        public bool? IsLogical { get; set; }
        /// <summary>
        /// Gets or Sets IsNumber
        /// </summary>
        [DataMember(Name = "isNumber", EmitDefaultValue = false)]
        public bool? IsNumber { get; set; }
        /// <summary>
        /// Gets or Sets IsShortDate
        /// </summary>
        [DataMember(Name = "isShortDate", EmitDefaultValue = false)]
        public bool? IsShortDate { get; set; }
        /// <summary>
        /// Gets or Sets IsShortTime
        /// </summary>
        [DataMember(Name = "isShortTime", EmitDefaultValue = false)]
        public bool? IsShortTime { get; set; }
        /// <summary>
        /// Gets or Sets IsVisible
        /// </summary>
        [DataMember(Name = "isVisible", EmitDefaultValue = false)]
        public bool? IsVisible { get; set; }
        /// <summary>
        /// Gets or Sets Sortable
        /// </summary>
        [DataMember(Name = "sortable", EmitDefaultValue = false)]
        public bool? Sortable { get; set; }
        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public string SortOrder { get; set; }
        /// <summary>
        /// Gets or Sets StorageName
        /// </summary>
        [DataMember(Name = "storageName", EmitDefaultValue = false)]
        public string StorageName { get; set; }
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
            sb.Append("class SearchesField {\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  CurrencyCulture: ").Append(CurrencyCulture).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append("\n");
            sb.Append("  DefaultSortOrderAscending: ").Append(DefaultSortOrderAscending).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FullFieldId: ").Append(FullFieldId).Append("\n");
            sb.Append("  HasDefaultSortField: ").Append(HasDefaultSortField).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  IsBinary: ").Append(IsBinary).Append("\n");
            sb.Append("  IsCurrency: ").Append(IsCurrency).Append("\n");
            sb.Append("  IsDateTime: ").Append(IsDateTime).Append("\n");
            sb.Append("  IsFilterAllowed: ").Append(IsFilterAllowed).Append("\n");
            sb.Append("  IsLogical: ").Append(IsLogical).Append("\n");
            sb.Append("  IsNumber: ").Append(IsNumber).Append("\n");
            sb.Append("  IsShortDate: ").Append(IsShortDate).Append("\n");
            sb.Append("  IsShortTime: ").Append(IsShortTime).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  Sortable: ").Append(Sortable).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  StorageName: ").Append(StorageName).Append("\n");
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
            return this.Equals(obj as SearchesField);
        }

        /// <summary>
        /// Returns true if SearchesField instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchesField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchesField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Caption == other.Caption ||
                    this.Caption != null &&
                    this.Caption.Equals(other.Caption)
                ) &&
                (
                    this.CurrencyCulture == other.CurrencyCulture ||
                    this.CurrencyCulture != null &&
                    this.CurrencyCulture.Equals(other.CurrencyCulture)
                ) &&
                (
                    this.CurrencySymbol == other.CurrencySymbol ||
                    this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(other.CurrencySymbol)
                ) &&
                (
                    this.DecimalDigits == other.DecimalDigits ||
                    this.DecimalDigits != null &&
                    this.DecimalDigits.Equals(other.DecimalDigits)
                ) &&
                (
                    this.DefaultSortOrderAscending == other.DefaultSortOrderAscending ||
                    this.DefaultSortOrderAscending != null &&
                    this.DefaultSortOrderAscending.Equals(other.DefaultSortOrderAscending)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) &&
                (
                    this.FullFieldId == other.FullFieldId ||
                    this.FullFieldId != null &&
                    this.FullFieldId.Equals(other.FullFieldId)
                ) &&
                (
                    this.HasDefaultSortField == other.HasDefaultSortField ||
                    this.HasDefaultSortField != null &&
                    this.HasDefaultSortField.Equals(other.HasDefaultSortField)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) &&
                (
                    this.IsBinary == other.IsBinary ||
                    this.IsBinary != null &&
                    this.IsBinary.Equals(other.IsBinary)
                ) &&
                (
                    this.IsCurrency == other.IsCurrency ||
                    this.IsCurrency != null &&
                    this.IsCurrency.Equals(other.IsCurrency)
                ) &&
                (
                    this.IsDateTime == other.IsDateTime ||
                    this.IsDateTime != null &&
                    this.IsDateTime.Equals(other.IsDateTime)
                ) &&
                (
                    this.IsFilterAllowed == other.IsFilterAllowed ||
                    this.IsFilterAllowed != null &&
                    this.IsFilterAllowed.Equals(other.IsFilterAllowed)
                ) &&
                (
                    this.IsLogical == other.IsLogical ||
                    this.IsLogical != null &&
                    this.IsLogical.Equals(other.IsLogical)
                ) &&
                (
                    this.IsNumber == other.IsNumber ||
                    this.IsNumber != null &&
                    this.IsNumber.Equals(other.IsNumber)
                ) &&
                (
                    this.IsShortDate == other.IsShortDate ||
                    this.IsShortDate != null &&
                    this.IsShortDate.Equals(other.IsShortDate)
                ) &&
                (
                    this.IsShortTime == other.IsShortTime ||
                    this.IsShortTime != null &&
                    this.IsShortTime.Equals(other.IsShortTime)
                ) &&
                (
                    this.IsVisible == other.IsVisible ||
                    this.IsVisible != null &&
                    this.IsVisible.Equals(other.IsVisible)
                ) &&
                (
                    this.Sortable == other.Sortable ||
                    this.Sortable != null &&
                    this.Sortable.Equals(other.Sortable)
                ) &&
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) &&
                (
                    this.StorageName == other.StorageName ||
                    this.StorageName != null &&
                    this.StorageName.Equals(other.StorageName)
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
                if (this.Caption != null)
                    hash = hash * 59 + this.Caption.GetHashCode();
                if (this.CurrencyCulture != null)
                    hash = hash * 59 + this.CurrencyCulture.GetHashCode();
                if (this.CurrencySymbol != null)
                    hash = hash * 59 + this.CurrencySymbol.GetHashCode();
                if (this.DecimalDigits != null)
                    hash = hash * 59 + this.DecimalDigits.GetHashCode();
                if (this.DefaultSortOrderAscending != null)
                    hash = hash * 59 + this.DefaultSortOrderAscending.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.FullFieldId != null)
                    hash = hash * 59 + this.FullFieldId.GetHashCode();
                if (this.HasDefaultSortField != null)
                    hash = hash * 59 + this.HasDefaultSortField.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.IsBinary != null)
                    hash = hash * 59 + this.IsBinary.GetHashCode();
                if (this.IsCurrency != null)
                    hash = hash * 59 + this.IsCurrency.GetHashCode();
                if (this.IsDateTime != null)
                    hash = hash * 59 + this.IsDateTime.GetHashCode();
                if (this.IsFilterAllowed != null)
                    hash = hash * 59 + this.IsFilterAllowed.GetHashCode();
                if (this.IsLogical != null)
                    hash = hash * 59 + this.IsLogical.GetHashCode();
                if (this.IsNumber != null)
                    hash = hash * 59 + this.IsNumber.GetHashCode();
                if (this.IsShortDate != null)
                    hash = hash * 59 + this.IsShortDate.GetHashCode();
                if (this.IsShortTime != null)
                    hash = hash * 59 + this.IsShortTime.GetHashCode();
                if (this.IsVisible != null)
                    hash = hash * 59 + this.IsVisible.GetHashCode();
                if (this.Sortable != null)
                    hash = hash * 59 + this.Sortable.GetHashCode();
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                if (this.StorageName != null)
                    hash = hash * 59 + this.StorageName.GetHashCode();
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
