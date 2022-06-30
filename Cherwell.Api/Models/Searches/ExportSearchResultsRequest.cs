using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesExportSearchResultsRequest
/// </summary>
[DataContract]
public partial class ExportSearchResultsRequest
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
	public EnumExportFormat? ExportFormat { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ExportSearchResultsRequest" /> class.
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
	public ExportSearchResultsRequest(string CustomSeparator, EnumExportFormat? ExportFormat, string ExportTitle, string Association, string AssociationName, string BusObId, string CustomGridDefId, string DateTimeFormatting, string FieldId, List<string> Fields, List<FilterInfo> Filters, bool? IncludeAllFields, bool? IncludeSchema, int? PageNumber, int? PageSize, string Scope, string ScopeOwner, string SearchId, string SearchName, string SearchText, List<SortInfo> Sorting, List<PromptValue> PromptValues)
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
	/// CustomSeparator
	/// </summary>
	[DataMember(Name = "customSeparator", EmitDefaultValue = false)]
	public string CustomSeparator { get; set; }

	/// <summary>
	/// ExportTitle
	/// </summary>
	[DataMember(Name = "exportTitle", EmitDefaultValue = false)]
	public string ExportTitle { get; set; }

	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string Association { get; set; }

	/// <summary>
	/// AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string AssociationName { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// CustomGridDefId
	/// </summary>
	[DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
	public string CustomGridDefId { get; set; }

	/// <summary>
	/// DateTimeFormatting
	/// </summary>
	[DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
	public string DateTimeFormatting { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<string> Fields { get; set; }

	/// <summary>
	/// Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo> Filters { get; set; }

	/// <summary>
	/// IncludeAllFields
	/// </summary>
	[DataMember(Name = "includeAllFields", EmitDefaultValue = false)]
	public bool? IncludeAllFields { get; set; }

	/// <summary>
	/// IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool? IncludeSchema { get; set; }

	/// <summary>
	/// PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int? PageNumber { get; set; }

	/// <summary>
	/// PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int? PageSize { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; }

	/// <summary>
	/// ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; }

	/// <summary>
	/// SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string SearchId { get; set; }

	/// <summary>
	/// SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string SearchName { get; set; }

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; }

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; }

	/// <summary>
	/// PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<PromptValue> PromptValues { get; set; }
}
