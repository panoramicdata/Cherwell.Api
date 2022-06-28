using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreManagerFolder
/// </summary>
[DataContract]
public partial class ManagerFolder
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ManagerFolder" /> class.
	/// </summary>
	/// <param name="Association">Association.</param>
	/// <param name="ChildFolders">ChildFolders.</param>
	/// <param name="ChildItems">ChildItems.</param>
	/// <param name="Id">Id.</param>
	/// <param name="Links">Links.</param>
	/// <param name="LocalizedScopeName">LocalizedScopeName.</param>
	/// <param name="Name">Name.</param>
	/// <param name="ParentId">ParentId.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	public ManagerFolder(string Association, List<ManagerFolder> ChildFolders, List<ManagerItem> ChildItems, string Id, List<Link> Links, string LocalizedScopeName, string Name, string ParentId, string Scope, string ScopeOwner)
	{
		this.Association = Association;
		this.ChildFolders = ChildFolders;
		this.ChildItems = ChildItems;
		this.Id = Id;
		this.Links = Links;
		this.LocalizedScopeName = LocalizedScopeName;
		this.Name = Name;
		this.ParentId = ParentId;
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
	public List<ManagerFolder> ChildFolders { get; set; }

	/// <summary>
	/// ChildItems
	/// </summary>
	[DataMember(Name = "childItems", EmitDefaultValue = false)]
	public List<ManagerItem> ChildItems { get; set; }

	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id", EmitDefaultValue = false)]
	public string Id { get; set; }

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
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// ParentId
	/// </summary>
	[DataMember(Name = "parentId", EmitDefaultValue = false)]
	public string ParentId { get; set; }

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
		sb.Append("class CoreManagerFolder {\n");
		sb.Append("  Association: ").Append(Association).Append('\n');
		sb.Append("  ChildFolders: ").Append(ChildFolders).Append('\n');
		sb.Append("  ChildItems: ").Append(ChildItems).Append('\n');
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  ParentId: ").Append(ParentId).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if CoreManagerFolder instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreManagerFolder to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ManagerFolder? other)
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
					Id == other.Id ||
					Id != null &&
					Id.Equals(other.Id, StringComparison.Ordinal)
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
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					ParentId == other.ParentId ||
					ParentId != null &&
					ParentId.Equals(other.ParentId, StringComparison.Ordinal)
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

			if (Id != null)
			{
				hash = hash * 59 + Id.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (LocalizedScopeName != null)
			{
				hash = hash * 59 + LocalizedScopeName.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (ParentId != null)
			{
				hash = hash * 59 + ParentId.GetHashCode();
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

	
}
