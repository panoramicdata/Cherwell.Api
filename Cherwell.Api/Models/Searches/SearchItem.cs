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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSearchItem {\n");
		sb.Append("  Association: ").Append(Association).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append('\n');
		sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  SearchId: ").Append(SearchId).Append('\n');
		sb.Append("  SearchName: ").Append(SearchName).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if SearchesSearchItem instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSearchItem to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SearchItem? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Association == other.Association ||
					Association != null &&
					Association.Equals(other.Association, StringComparison.Ordinal)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
				) &&
				(
					LocalizedScopeName == other.LocalizedScopeName ||
					LocalizedScopeName != null &&
					LocalizedScopeName.Equals(other.LocalizedScopeName, StringComparison.Ordinal)
				) &&
				(
					ParentFolderId == other.ParentFolderId ||
					ParentFolderId != null &&
					ParentFolderId.Equals(other.ParentFolderId, StringComparison.Ordinal)
				) &&
				(
					Scope == other.Scope ||
					Scope != null &&
					Scope.Equals(other.Scope, StringComparison.Ordinal)
				) &&
				(
					ScopeOwner == other.ScopeOwner ||
					ScopeOwner != null &&
					ScopeOwner.Equals(other.ScopeOwner, StringComparison.Ordinal)
				) &&
				(
					SearchId == other.SearchId ||
					SearchId != null &&
					SearchId.Equals(other.SearchId, StringComparison.Ordinal)
				) &&
				(
					SearchName == other.SearchName ||
					SearchName != null &&
					SearchName.Equals(other.SearchName, StringComparison.Ordinal)
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
			if (Association != null)
			{
				hash = hash * 59 + Association.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (LocalizedScopeName != null)
			{
				hash = hash * 59 + LocalizedScopeName.GetHashCode();
			}

			if (ParentFolderId != null)
			{
				hash = hash * 59 + ParentFolderId.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (SearchId != null)
			{
				hash = hash * 59 + SearchId.GetHashCode();
			}

			if (SearchName != null)
			{
				hash = hash * 59 + SearchName.GetHashCode();
			}

			return hash;
		}
	}

	
}
