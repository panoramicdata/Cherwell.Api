using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchFolder
/// </summary>
[DataContract]
public partial class SearchFolder : IEquatable<SearchFolder>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SearchFolder" /> class.
	/// </summary>
	/// <param name="Association">Association.</param>
	/// <param name="ChildFolders">ChildFolders.</param>
	/// <param name="ChildItems">ChildItems.</param>
	/// <param name="FolderId">FolderId.</param>
	/// <param name="FolderName">FolderName.</param>
	/// <param name="Links">Links.</param>
	/// <param name="LocalizedScopeName">LocalizedScopeName.</param>
	/// <param name="ParentFolderId">ParentFolderId.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	public SearchFolder(string Association,
		List<SearchFolder> ChildFolders,
		List<SearchItem> ChildItems,
		string FolderId,
		string FolderName,
		List<Link> Links,
		string LocalizedScopeName,
		string ParentFolderId,
		string Scope,
		string ScopeOwner)
	{
		this.Association = Association;
		this.ChildFolders = ChildFolders;
		this.ChildItems = ChildItems;
		this.FolderId = FolderId;
		this.FolderName = FolderName;
		this.Links = Links;
		this.LocalizedScopeName = LocalizedScopeName;
		this.ParentFolderId = ParentFolderId;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
	}

	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string Association { get; set; }

	/// <summary>
	/// ChildFolders
	/// </summary>
	[DataMember(Name = "childFolders", EmitDefaultValue = false)]
	public List<SearchFolder> ChildFolders { get; set; }

	/// <summary>
	/// ChildItems
	/// </summary>
	[DataMember(Name = "childItems", EmitDefaultValue = false)]
	public List<SearchItem> ChildItems { get; set; }

	/// <summary>
	/// FolderId
	/// </summary>
	[DataMember(Name = "folderId", EmitDefaultValue = false)]
	public string FolderId { get; set; }

	/// <summary>
	/// FolderName
	/// </summary>
	[DataMember(Name = "folderName", EmitDefaultValue = false)]
	public string FolderName { get; set; }

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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSearchFolder {\n");
		sb.Append("  Association: ").Append(Association).Append('\n');
		sb.Append("  ChildFolders: ").Append(ChildFolders).Append('\n');
		sb.Append("  ChildItems: ").Append(ChildItems).Append('\n');
		sb.Append("  FolderId: ").Append(FolderId).Append('\n');
		sb.Append("  FolderName: ").Append(FolderName).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append('\n');
		sb.Append("  ParentFolderId: ").Append(ParentFolderId).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as SearchFolder);
	}

	/// <summary>
	/// Returns true if SearchesSearchFolder instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSearchFolder to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SearchFolder? other)
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
					ChildFolders == other.ChildFolders ||
					ChildFolders != null &&
					ChildFolders.SequenceEqual(other.ChildFolders)
				) &&
				(
					ChildItems == other.ChildItems ||
					ChildItems != null &&
					ChildItems.SequenceEqual(other.ChildItems)
				) &&
				(
					FolderId == other.FolderId ||
					FolderId != null &&
					FolderId.Equals(other.FolderId, StringComparison.Ordinal)
				) &&
				(
					FolderName == other.FolderName ||
					FolderName != null &&
					FolderName.Equals(other.FolderName, StringComparison.Ordinal)
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

			if (ChildFolders != null)
			{
				hash = hash * 59 + ChildFolders.GetHashCode();
			}

			if (ChildItems != null)
			{
				hash = hash * 59 + ChildItems.GetHashCode();
			}

			if (FolderId != null)
			{
				hash = hash * 59 + FolderId.GetHashCode();
			}

			if (FolderName != null)
			{
				hash = hash * 59 + FolderName.GetHashCode();
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

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
