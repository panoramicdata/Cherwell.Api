using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsRequest
/// </summary>
[DataContract]
public partial class SearchResultsRequest
{
	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string? Association { get; set; }

	/// <summary>
	/// AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string? AssociationName { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// CustomGridDefId
	/// </summary>
	[DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
	public string? CustomGridDefId { get; set; }

	/// <summary>
	/// DateTimeFormatting
	/// </summary>
	[DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
	public string? DateTimeFormatting { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string? FieldId { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<string>? Fields { get; set; }

	/// <summary>
	/// Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo>? Filters { get; set; }

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
	public string? Scope { get; set; }

	/// <summary>
	/// ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string? ScopeOwner { get; set; }

	/// <summary>
	/// SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string? SearchId { get; set; }

	/// <summary>
	/// SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string? SearchName { get; set; }

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string? SearchText { get; set; }

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo>? Sorting { get; set; }

	/// <summary>
	/// PromptValues
	/// </summary>
	[DataMember(Name = "promptValues", EmitDefaultValue = false)]
	public List<PromptValue>? PromptValues { get; set; }
}
