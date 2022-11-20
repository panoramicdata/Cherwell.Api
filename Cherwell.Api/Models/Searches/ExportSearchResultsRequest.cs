using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesExportSearchResultsRequest
/// </summary>
[DataContract]
public class ExportSearchResultsRequest
{
	/// <summary>
	/// ExportFormat
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumExportFormat
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
	/// ExportFormat
	/// </summary>
	[DataMember(Name = "exportFormat", EmitDefaultValue = false)]
	public EnumExportFormat ExportFormat { get; set; }

	/// <summary>
	/// CustomSeparator
	/// </summary>
	[DataMember(Name = "customSeparator", EmitDefaultValue = false)]
	public string CustomSeparator { get; set; } = null!;

	/// <summary>
	/// ExportTitle
	/// </summary>
	[DataMember(Name = "exportTitle", EmitDefaultValue = false)]
	public string ExportTitle { get; set; } = null!;

	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string Association { get; set; } = null!;

	/// <summary>
	/// AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string AssociationName { get; set; } = null!;

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// CustomGridDefId
	/// </summary>
	[DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
	public string CustomGridDefId { get; set; } = null!;

	/// <summary>
	/// DateTimeFormatting
	/// </summary>
	[DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
	public string DateTimeFormatting { get; set; } = null!;

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<string> Fields { get; set; } = null!;

	/// <summary>
	/// Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo> Filters { get; set; } = null!;

	/// <summary>
	/// IncludeAllFields
	/// </summary>
	[DataMember(Name = "includeAllFields", EmitDefaultValue = false)]
	public bool IncludeAllFields { get; set; }

	/// <summary>
	/// IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool IncludeSchema { get; set; }

	/// <summary>
	/// PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int PageNumber { get; set; }

	/// <summary>
	/// PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int PageSize { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; } = null!;

	/// <summary>
	/// ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; } = null!;

	/// <summary>
	/// SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string SearchId { get; set; } = null!;

	/// <summary>
	/// SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string SearchName { get; set; } = null!;

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; } = null!;

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; } = null!;

	/// <summary>
	/// PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<PromptValue> PromptValues { get; set; } = null!;
}
