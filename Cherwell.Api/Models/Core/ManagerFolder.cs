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
