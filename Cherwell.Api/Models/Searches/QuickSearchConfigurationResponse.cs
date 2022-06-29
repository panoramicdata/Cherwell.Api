using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigurationResponse
/// </summary>
[DataContract]
public partial class QuickSearchConfigurationResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchConfigurationResponse" /> class.
	/// </summary>
	/// <param name="AllowQuickSearch">AllowQuickSearch.</param>
	/// <param name="AllowSpecificSearch">AllowSpecificSearch.</param>
	/// <param name="DefaultToQuickSearch">DefaultToQuickSearch.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="History">History.</param>
	/// <param name="IncludeAvailableInSpecific">IncludeAvailableInSpecific.</param>
	/// <param name="IncludeQuickSearchInSpecific">IncludeQuickSearchInSpecific.</param>
	/// <param name="QuickSearchId">QuickSearchId.</param>
	/// <param name="QuickSearchItems">QuickSearchItems.</param>
	/// <param name="QuickSearchWatermark">QuickSearchWatermark.</param>
	/// <param name="SortByRelevance">SortByRelevance.</param>
	/// <param name="ResolvedQuickSearchWatermark">ResolvedQuickSearchWatermark.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="SpecificSearchItems">SpecificSearchItems.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public QuickSearchConfigurationResponse(bool? AllowQuickSearch, bool? AllowSpecificSearch, bool? DefaultToQuickSearch, string DisplayName, string GalleryImage, List<string> History, bool? IncludeAvailableInSpecific, bool? IncludeQuickSearchInSpecific, string QuickSearchId, List<QuickSearchItem> QuickSearchItems, string QuickSearchWatermark, bool? SortByRelevance, string ResolvedQuickSearchWatermark, string Scope, string ScopeOwner, List<QuickSearchItem> SpecificSearchItems, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.AllowQuickSearch = AllowQuickSearch;
		this.AllowSpecificSearch = AllowSpecificSearch;
		this.DefaultToQuickSearch = DefaultToQuickSearch;
		this.DisplayName = DisplayName;
		this.GalleryImage = GalleryImage;
		this.History = History;
		this.IncludeAvailableInSpecific = IncludeAvailableInSpecific;
		this.IncludeQuickSearchInSpecific = IncludeQuickSearchInSpecific;
		this.QuickSearchId = QuickSearchId;
		this.QuickSearchItems = QuickSearchItems;
		this.QuickSearchWatermark = QuickSearchWatermark;
		this.SortByRelevance = SortByRelevance;
		this.ResolvedQuickSearchWatermark = ResolvedQuickSearchWatermark;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.SpecificSearchItems = SpecificSearchItems;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

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
	public string DisplayName { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// History
	/// </summary>
	[DataMember(Name = "history", EmitDefaultValue = false)]
	public List<string> History { get; set; }

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
	public string QuickSearchId { get; set; }

	/// <summary>
	/// QuickSearchItems
	/// </summary>
	[DataMember(Name = "quickSearchItems", EmitDefaultValue = false)]
	public List<QuickSearchItem> QuickSearchItems { get; set; }

	/// <summary>
	/// QuickSearchWatermark
	/// </summary>
	[DataMember(Name = "quickSearchWatermark", EmitDefaultValue = false)]
	public string QuickSearchWatermark { get; set; }

	/// <summary>
	/// SortByRelevance
	/// </summary>
	[DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
	public bool? SortByRelevance { get; set; }

	/// <summary>
	/// ResolvedQuickSearchWatermark
	/// </summary>
	[DataMember(Name = "resolvedQuickSearchWatermark", EmitDefaultValue = false)]
	public string ResolvedQuickSearchWatermark { get; set; }

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
	/// SpecificSearchItems
	/// </summary>
	[DataMember(Name = "specificSearchItems", EmitDefaultValue = false)]
	public List<QuickSearchItem> SpecificSearchItems { get; set; }
























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










		}
	}

	
}
