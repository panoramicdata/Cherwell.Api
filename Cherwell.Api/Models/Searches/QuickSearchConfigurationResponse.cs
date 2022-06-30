using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigurationResponse
/// </summary>
[DataContract]
public partial class QuickSearchConfigurationResponse : Response
{
	/// <summary>
	/// AllowQuickSearch
	/// </summary>
	[DataMember(Name = "allowQuickSearch", EmitDefaultValue = false)]
	public bool? AllowQuickSearch { get; set; }

	/// <summary>
	/// AllowSpecificSearch
	/// </summary>
	[DataMember(Name = "allowSpecificSearch", EmitDefaultValue = false)]
	public bool? AllowSpecificSearch { get; set; }

	/// <summary>
	/// DefaultToQuickSearch
	/// </summary>
	[DataMember(Name = "defaultToQuickSearch", EmitDefaultValue = false)]
	public bool? DefaultToQuickSearch { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string? DisplayName { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string? GalleryImage { get; set; }

	/// <summary>
	/// History
	/// </summary>
	[DataMember(Name = "history", EmitDefaultValue = false)]
	public List<string>? History { get; set; }

	/// <summary>
	/// IncludeAvailableInSpecific
	/// </summary>
	[DataMember(Name = "includeAvailableInSpecific", EmitDefaultValue = false)]
	public bool? IncludeAvailableInSpecific { get; set; }

	/// <summary>
	/// IncludeQuickSearchInSpecific
	/// </summary>
	[DataMember(Name = "includeQuickSearchInSpecific", EmitDefaultValue = false)]
	public bool? IncludeQuickSearchInSpecific { get; set; }

	/// <summary>
	/// QuickSearchId
	/// </summary>
	[DataMember(Name = "quickSearchId", EmitDefaultValue = false)]
	public string? QuickSearchId { get; set; }

	/// <summary>
	/// QuickSearchItems
	/// </summary>
	[DataMember(Name = "quickSearchItems", EmitDefaultValue = false)]
	public List<QuickSearchItem>? QuickSearchItems { get; set; }

	/// <summary>
	/// QuickSearchWatermark
	/// </summary>
	[DataMember(Name = "quickSearchWatermark", EmitDefaultValue = false)]
	public string? QuickSearchWatermark { get; set; }

	/// <summary>
	/// SortByRelevance
	/// </summary>
	[DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
	public bool? SortByRelevance { get; set; }

	/// <summary>
	/// ResolvedQuickSearchWatermark
	/// </summary>
	[DataMember(Name = "resolvedQuickSearchWatermark", EmitDefaultValue = false)]
	public string? ResolvedQuickSearchWatermark { get; set; }

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
	/// SpecificSearchItems
	/// </summary>
	[DataMember(Name = "specificSearchItems", EmitDefaultValue = false)]
	public List<QuickSearchItem>? SpecificSearchItems { get; set; }
}
