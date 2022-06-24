using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsRequest
/// </summary>
[DataContract]
public partial class SearchResultsRequest
{
	/// <summary>
	/// Gets or Sets Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string? Association { get; set; }

	/// <summary>
	/// Gets or Sets AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string? AssociationName { get; set; }

	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// Gets or Sets CustomGridDefId
	/// </summary>
	[DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
	public string? CustomGridDefId { get; set; }

	/// <summary>
	/// Gets or Sets DateTimeFormatting
	/// </summary>
	[DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
	public string? DateTimeFormatting { get; set; }

	/// <summary>
	/// Gets or Sets FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string? FieldId { get; set; }

	/// <summary>
	/// Gets or Sets Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<string>? Fields { get; set; }

	/// <summary>
	/// Gets or Sets Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo>? Filters { get; set; }

	/// <summary>
	/// Gets or Sets IncludeAllFields
	/// </summary>
	[DataMember(Name = "includeAllFields", EmitDefaultValue = false)]
	public bool? IncludeAllFields { get; set; }

	/// <summary>
	/// Gets or Sets IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool? IncludeSchema { get; set; }

	/// <summary>
	/// Gets or Sets PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int? PageNumber { get; set; }

	/// <summary>
	/// Gets or Sets PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int? PageSize { get; set; }

	/// <summary>
	/// Gets or Sets Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string? Scope { get; set; }

	/// <summary>
	/// Gets or Sets ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string? ScopeOwner { get; set; }

	/// <summary>
	/// Gets or Sets SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string? SearchId { get; set; }

	/// <summary>
	/// Gets or Sets SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string? SearchName { get; set; }

	/// <summary>
	/// Gets or Sets SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string? SearchText { get; set; }

	/// <summary>
	/// Gets or Sets Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo>? Sorting { get; set; }

	/// <summary>
	/// Gets or Sets PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<PromptValue>? PromptValues { get; set; }
}
