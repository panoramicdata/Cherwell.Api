using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesField
/// </summary>
[DataContract]
public partial class Field
{
	/// <summary>
	/// Caption
	/// </summary>
	[DataMember(Name = "caption", EmitDefaultValue = false)]
	public string Caption { get; set; } = null!;

	/// <summary>
	/// CurrencyCulture
	/// </summary>
	[DataMember(Name = "currencyCulture", EmitDefaultValue = false)]
	public string CurrencyCulture { get; set; } = null!;

	/// <summary>
	/// CurrencySymbol
	/// </summary>
	[DataMember(Name = "currencySymbol", EmitDefaultValue = false)]
	public string CurrencySymbol { get; set; } = null!;

	/// <summary>
	/// DecimalDigits
	/// </summary>
	[DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
	public int DecimalDigits { get; set; }

	/// <summary>
	/// DefaultSortOrderAscending
	/// </summary>
	[DataMember(Name = "defaultSortOrderAscending", EmitDefaultValue = false)]
	public bool DefaultSortOrderAscending { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// FieldName
	/// </summary>
	[DataMember(Name = "fieldName", EmitDefaultValue = false)]
	public string FieldName { get; set; } = null!;

	/// <summary>
	/// FullFieldId
	/// </summary>
	[DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
	public string FullFieldId { get; set; } = null!;

	/// <summary>
	/// HasDefaultSortField
	/// </summary>
	[DataMember(Name = "hasDefaultSortField", EmitDefaultValue = false)]
	public bool HasDefaultSortField { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// IsBinary
	/// </summary>
	[DataMember(Name = "isBinary", EmitDefaultValue = false)]
	public bool IsBinary { get; set; }

	/// <summary>
	/// IsCurrency
	/// </summary>
	[DataMember(Name = "isCurrency", EmitDefaultValue = false)]
	public bool IsCurrency { get; set; }

	/// <summary>
	/// IsDateTime
	/// </summary>
	[DataMember(Name = "isDateTime", EmitDefaultValue = false)]
	public bool IsDateTime { get; set; }

	/// <summary>
	/// IsFilterAllowed
	/// </summary>
	[DataMember(Name = "isFilterAllowed", EmitDefaultValue = false)]
	public bool IsFilterAllowed { get; set; }

	/// <summary>
	/// IsLogical
	/// </summary>
	[DataMember(Name = "isLogical", EmitDefaultValue = false)]
	public bool IsLogical { get; set; }

	/// <summary>
	/// IsNumber
	/// </summary>
	[DataMember(Name = "isNumber", EmitDefaultValue = false)]
	public bool IsNumber { get; set; }

	/// <summary>
	/// IsShortDate
	/// </summary>
	[DataMember(Name = "isShortDate", EmitDefaultValue = false)]
	public bool IsShortDate { get; set; }

	/// <summary>
	/// IsShortTime
	/// </summary>
	[DataMember(Name = "isShortTime", EmitDefaultValue = false)]
	public bool IsShortTime { get; set; }

	/// <summary>
	/// IsVisible
	/// </summary>
	[DataMember(Name = "isVisible", EmitDefaultValue = false)]
	public bool IsVisible { get; set; }

	/// <summary>
	/// Sortable
	/// </summary>
	[DataMember(Name = "sortable", EmitDefaultValue = false)]
	public bool Sortable { get; set; }

	/// <summary>
	/// SortOrder
	/// </summary>
	[DataMember(Name = "sortOrder", EmitDefaultValue = false)]
	public string SortOrder { get; set; } = null!;

	/// <summary>
	/// StorageName
	/// </summary>
	[DataMember(Name = "storageName", EmitDefaultValue = false)]
	public string StorageName { get; set; } = null!;

	/// <summary>
	/// WholeDigits
	/// </summary>
	[DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
	public int WholeDigits { get; set; }
}
