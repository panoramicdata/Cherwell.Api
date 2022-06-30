using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchFolder
/// </summary>
[DataContract]
public partial class SearchFolder
{
	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string? Association { get; set; }

	/// <summary>
	/// ChildFolders
	/// </summary>
	[DataMember(Name = "childFolders", EmitDefaultValue = false)]
	public List<SearchFolder>? ChildFolders { get; set; }

	/// <summary>
	/// ChildItems
	/// </summary>
	[DataMember(Name = "childItems", EmitDefaultValue = false)]
	public List<SearchItem>? ChildItems { get; set; }

	/// <summary>
	/// FolderId
	/// </summary>
	[DataMember(Name = "folderId", EmitDefaultValue = false)]
	public string? FolderId { get; set; }

	/// <summary>
	/// FolderName
	/// </summary>
	[DataMember(Name = "folderName", EmitDefaultValue = false)]
	public string? FolderName { get; set; }

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
}
