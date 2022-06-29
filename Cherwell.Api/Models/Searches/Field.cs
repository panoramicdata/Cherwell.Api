using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesField
/// </summary>
[DataContract]
public partial class Field
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
	/// Caption
	/// </summary>
	[DataMember(Name = "caption", EmitDefaultValue = false)]
	public string Caption { get; set; }

	/// <summary>
	/// CurrencyCulture
	/// </summary>
	[DataMember(Name = "currencyCulture", EmitDefaultValue = false)]
	public string CurrencyCulture { get; set; }

	/// <summary>
	/// CurrencySymbol
	/// </summary>
	[DataMember(Name = "currencySymbol", EmitDefaultValue = false)]
	public string CurrencySymbol { get; set; }

	/// <summary>
	/// DecimalDigits
	/// </summary>
	[DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
	public int? DecimalDigits { get; set; }

	/// <summary>
	/// DefaultSortOrderAscending
	/// </summary>
	[DataMember(Name = "defaultSortOrderAscending", EmitDefaultValue = false)]
	public bool? DefaultSortOrderAscending { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// FieldName
	/// </summary>
	[DataMember(Name = "fieldName", EmitDefaultValue = false)]
	public string FieldName { get; set; }

	/// <summary>
	/// FullFieldId
	/// </summary>
	[DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
	public string FullFieldId { get; set; }

	/// <summary>
	/// HasDefaultSortField
	/// </summary>
	[DataMember(Name = "hasDefaultSortField", EmitDefaultValue = false)]
	public bool? HasDefaultSortField { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// IsBinary
	/// </summary>
	[DataMember(Name = "isBinary", EmitDefaultValue = false)]
	public bool? IsBinary { get; set; }

	/// <summary>
	/// IsCurrency
	/// </summary>
	[DataMember(Name = "isCurrency", EmitDefaultValue = false)]
	public bool? IsCurrency { get; set; }

	/// <summary>
	/// IsDateTime
	/// </summary>
	[DataMember(Name = "isDateTime", EmitDefaultValue = false)]
	public bool? IsDateTime { get; set; }

	/// <summary>
	/// IsFilterAllowed
	/// </summary>
	[DataMember(Name = "isFilterAllowed", EmitDefaultValue = false)]
	public bool? IsFilterAllowed { get; set; }

	/// <summary>
	/// IsLogical
	/// </summary>
	[DataMember(Name = "isLogical", EmitDefaultValue = false)]
	public bool? IsLogical { get; set; }

	/// <summary>
	/// IsNumber
	/// </summary>
	[DataMember(Name = "isNumber", EmitDefaultValue = false)]
	public bool? IsNumber { get; set; }

	/// <summary>
	/// IsShortDate
	/// </summary>
	[DataMember(Name = "isShortDate", EmitDefaultValue = false)]
	public bool? IsShortDate { get; set; }

	/// <summary>
	/// IsShortTime
	/// </summary>
	[DataMember(Name = "isShortTime", EmitDefaultValue = false)]
	public bool? IsShortTime { get; set; }

	/// <summary>
	/// IsVisible
	/// </summary>
	[DataMember(Name = "isVisible", EmitDefaultValue = false)]
	public bool? IsVisible { get; set; }

	/// <summary>
	/// Sortable
	/// </summary>
	[DataMember(Name = "sortable", EmitDefaultValue = false)]
	public bool? Sortable { get; set; }

	/// <summary>
	/// SortOrder
	/// </summary>
	[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
	public string SortOrder { get; set; }

	/// <summary>
	/// StorageName
	/// </summary>
	[DataMember(Name = "storageName", EmitDefaultValue = false)]
	public string StorageName { get; set; }

	/// <summary>
	/// WholeDigits
	/// </summary>
	[DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
	public int? WholeDigits { get; set; }
}
