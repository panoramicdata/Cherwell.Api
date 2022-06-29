using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreManagerItem
/// </summary>
[DataContract]
public partial class ManagerItem
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ManagerItem" /> class.
	/// </summary>
	/// <param name="Association">Association.</param>
	/// <param name="Description">Description.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="Id">Id.</param>
	/// <param name="Links">Links.</param>
	/// <param name="LocalizedScopeName">LocalizedScopeName.</param>
	/// <param name="Name">Name.</param>
	/// <param name="ParentFolder">ParentFolder.</param>
	/// <param name="ParentIsScopeFolder">ParentIsScopeFolder.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="StandInKey">StandInKey.</param>
	public ManagerItem(string Association, string Description, string DisplayName, string GalleryImage, string Id, List<Link> Links, string LocalizedScopeName, string Name, string ParentFolder, bool? ParentIsScopeFolder, string Scope, string ScopeOwner, string StandInKey)
	{
		this.Association = Association;
		this.Description = Description;
		this.DisplayName = DisplayName;
		this.GalleryImage = GalleryImage;
		this.Id = Id;
		this.Links = Links;
		this.LocalizedScopeName = LocalizedScopeName;
		this.Name = Name;
		this.ParentFolder = ParentFolder;
		this.ParentIsScopeFolder = ParentIsScopeFolder;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.StandInKey = StandInKey;
	}

	/// <summary>
	/// Association
	/// </summary>
	[DataMember(Name = "association", EmitDefaultValue = false)]
	public string Association { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

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
	/// ParentFolder
	/// </summary>
	[DataMember(Name = "parentFolder", EmitDefaultValue = false)]
	public string ParentFolder { get; set; }

	/// <summary>
	/// ParentIsScopeFolder
	/// </summary>
	[DataMember(Name = "parentIsScopeFolder", EmitDefaultValue = false)]
	public bool? ParentIsScopeFolder { get; set; }

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
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }
}
