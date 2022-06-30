using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchItem
/// </summary>
[DataContract]
public partial class SearchItem
{
	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string? Association { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link>? Links { get; set; }

	/// <summary>
	/// LocalizedScopeName
	/// </summary>
	[DataMember(Name = "localizedScopeName", EmitDefaultValue = false)]
	public string? LocalizedScopeName { get; set; }

	/// <summary>
	/// ParentFolderId
	/// </summary>
	[DataMember(Name = "parentFolderId", EmitDefaultValue = false)]
	public string? ParentFolderId { get; set; }

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
}
