using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchItem
/// </summary>
[DataContract]
public partial class SearchItem
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SearchItem" /> class.
	/// </summary>
	/// <param name="Association">Association.</param>
	/// <param name="Links">Links.</param>
	/// <param name="LocalizedScopeName">LocalizedScopeName.</param>
	/// <param name="ParentFolderId">ParentFolderId.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="SearchId">SearchId.</param>
	/// <param name="SearchName">SearchName.</param>
	public SearchItem(string Association, List<Link> Links, string LocalizedScopeName, string ParentFolderId, string Scope, string ScopeOwner, string SearchId, string SearchName)
	{
		this.Association = Association;
		this.Links = Links;
		this.LocalizedScopeName = LocalizedScopeName;
		this.ParentFolderId = ParentFolderId;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.SearchId = SearchId;
		this.SearchName = SearchName;
	}

	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string Association { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }

	/// <summary>
	/// LocalizedScopeName
	/// </summary>
	[DataMember(Name = "localizedScopeName", EmitDefaultValue = false)]
	public string LocalizedScopeName { get; set; }

	/// <summary>
	/// ParentFolderId
	/// </summary>
	[DataMember(Name = "parentFolderId", EmitDefaultValue = false)]
	public string ParentFolderId { get; set; }

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
