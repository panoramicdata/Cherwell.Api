using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesField
/// </summary>
[DataContract]
public partial class Field : IEquatable<Field>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Field" /> class.
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
	public Field(string Caption, string CurrencyCulture, string CurrencySymbol, int? DecimalDigits, bool? DefaultSortOrderAscending, string DisplayName, string FieldName, string FullFieldId, bool? HasDefaultSortField, string FieldId, bool? IsBinary, bool? IsCurrency, bool? IsDateTime, bool? IsFilterAllowed, bool? IsLogical, bool? IsNumber, bool? IsShortDate, bool? IsShortTime, bool? IsVisible, bool? Sortable, string SortOrder, string StorageName, int? WholeDigits)
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
		sb.Append("  Caption: ").Append(Caption).Append('\n');
		sb.Append("  CurrencyCulture: ").Append(CurrencyCulture).Append('\n');
		sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append('\n');
		sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append('\n');
		sb.Append("  DefaultSortOrderAscending: ").Append(DefaultSortOrderAscending).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  FieldName: ").Append(FieldName).Append('\n');
		sb.Append("  FullFieldId: ").Append(FullFieldId).Append('\n');
		sb.Append("  HasDefaultSortField: ").Append(HasDefaultSortField).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  IsBinary: ").Append(IsBinary).Append('\n');
		sb.Append("  IsCurrency: ").Append(IsCurrency).Append('\n');
		sb.Append("  IsDateTime: ").Append(IsDateTime).Append('\n');
		sb.Append("  IsFilterAllowed: ").Append(IsFilterAllowed).Append('\n');
		sb.Append("  IsLogical: ").Append(IsLogical).Append('\n');
		sb.Append("  IsNumber: ").Append(IsNumber).Append('\n');
		sb.Append("  IsShortDate: ").Append(IsShortDate).Append('\n');
		sb.Append("  IsShortTime: ").Append(IsShortTime).Append('\n');
		sb.Append("  IsVisible: ").Append(IsVisible).Append('\n');
		sb.Append("  Sortable: ").Append(Sortable).Append('\n');
		sb.Append("  SortOrder: ").Append(SortOrder).Append('\n');
		sb.Append("  StorageName: ").Append(StorageName).Append('\n');
		sb.Append("  WholeDigits: ").Append(WholeDigits).Append('\n');
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
		return Equals(obj as Field);
	}

	/// <summary>
	/// Returns true if SearchesField instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesField to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Field? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Caption == other.Caption ||
					Caption != null &&
					Caption.Equals(other.Caption, StringComparison.Ordinal)
				) &&
				(
					CurrencyCulture == other.CurrencyCulture ||
					CurrencyCulture != null &&
					CurrencyCulture.Equals(other.CurrencyCulture, StringComparison.Ordinal)
				) &&
				(
					CurrencySymbol == other.CurrencySymbol ||
					CurrencySymbol != null &&
					CurrencySymbol.Equals(other.CurrencySymbol, StringComparison.Ordinal)
				) &&
				(
					DecimalDigits == other.DecimalDigits ||
					DecimalDigits != null &&
					DecimalDigits.Equals(other.DecimalDigits)
				) &&
				(
					DefaultSortOrderAscending == other.DefaultSortOrderAscending ||
					DefaultSortOrderAscending != null &&
					DefaultSortOrderAscending.Equals(other.DefaultSortOrderAscending)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					FieldName == other.FieldName ||
					FieldName != null &&
					FieldName.Equals(other.FieldName, StringComparison.Ordinal)
				) &&
				(
					FullFieldId == other.FullFieldId ||
					FullFieldId != null &&
					FullFieldId.Equals(other.FullFieldId, StringComparison.Ordinal)
				) &&
				(
					HasDefaultSortField == other.HasDefaultSortField ||
					HasDefaultSortField != null &&
					HasDefaultSortField.Equals(other.HasDefaultSortField)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					IsBinary == other.IsBinary ||
					IsBinary != null &&
					IsBinary.Equals(other.IsBinary)
				) &&
				(
					IsCurrency == other.IsCurrency ||
					IsCurrency != null &&
					IsCurrency.Equals(other.IsCurrency)
				) &&
				(
					IsDateTime == other.IsDateTime ||
					IsDateTime != null &&
					IsDateTime.Equals(other.IsDateTime)
				) &&
				(
					IsFilterAllowed == other.IsFilterAllowed ||
					IsFilterAllowed != null &&
					IsFilterAllowed.Equals(other.IsFilterAllowed)
				) &&
				(
					IsLogical == other.IsLogical ||
					IsLogical != null &&
					IsLogical.Equals(other.IsLogical)
				) &&
				(
					IsNumber == other.IsNumber ||
					IsNumber != null &&
					IsNumber.Equals(other.IsNumber)
				) &&
				(
					IsShortDate == other.IsShortDate ||
					IsShortDate != null &&
					IsShortDate.Equals(other.IsShortDate)
				) &&
				(
					IsShortTime == other.IsShortTime ||
					IsShortTime != null &&
					IsShortTime.Equals(other.IsShortTime)
				) &&
				(
					IsVisible == other.IsVisible ||
					IsVisible != null &&
					IsVisible.Equals(other.IsVisible)
				) &&
				(
					Sortable == other.Sortable ||
					Sortable != null &&
					Sortable.Equals(other.Sortable)
				) &&
				(
					SortOrder == other.SortOrder ||
					SortOrder != null &&
					SortOrder.Equals(other.SortOrder, StringComparison.Ordinal)
				) &&
				(
					StorageName == other.StorageName ||
					StorageName != null &&
					StorageName.Equals(other.StorageName, StringComparison.Ordinal)
				) &&
				(
					WholeDigits == other.WholeDigits ||
					WholeDigits != null &&
					WholeDigits.Equals(other.WholeDigits)
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
			if (Caption != null)
			{
				hash = hash * 59 + Caption.GetHashCode();
			}

			if (CurrencyCulture != null)
			{
				hash = hash * 59 + CurrencyCulture.GetHashCode();
			}

			if (CurrencySymbol != null)
			{
				hash = hash * 59 + CurrencySymbol.GetHashCode();
			}

			if (DecimalDigits != null)
			{
				hash = hash * 59 + DecimalDigits.GetHashCode();
			}

			if (DefaultSortOrderAscending != null)
			{
				hash = hash * 59 + DefaultSortOrderAscending.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (FieldName != null)
			{
				hash = hash * 59 + FieldName.GetHashCode();
			}

			if (FullFieldId != null)
			{
				hash = hash * 59 + FullFieldId.GetHashCode();
			}

			if (HasDefaultSortField != null)
			{
				hash = hash * 59 + HasDefaultSortField.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (IsBinary != null)
			{
				hash = hash * 59 + IsBinary.GetHashCode();
			}

			if (IsCurrency != null)
			{
				hash = hash * 59 + IsCurrency.GetHashCode();
			}

			if (IsDateTime != null)
			{
				hash = hash * 59 + IsDateTime.GetHashCode();
			}

			if (IsFilterAllowed != null)
			{
				hash = hash * 59 + IsFilterAllowed.GetHashCode();
			}

			if (IsLogical != null)
			{
				hash = hash * 59 + IsLogical.GetHashCode();
			}

			if (IsNumber != null)
			{
				hash = hash * 59 + IsNumber.GetHashCode();
			}

			if (IsShortDate != null)
			{
				hash = hash * 59 + IsShortDate.GetHashCode();
			}

			if (IsShortTime != null)
			{
				hash = hash * 59 + IsShortTime.GetHashCode();
			}

			if (IsVisible != null)
			{
				hash = hash * 59 + IsVisible.GetHashCode();
			}

			if (Sortable != null)
			{
				hash = hash * 59 + Sortable.GetHashCode();
			}

			if (SortOrder != null)
			{
				hash = hash * 59 + SortOrder.GetHashCode();
			}

			if (StorageName != null)
			{
				hash = hash * 59 + StorageName.GetHashCode();
			}

			if (WholeDigits != null)
			{
				hash = hash * 59 + WholeDigits.GetHashCode();
			}

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
