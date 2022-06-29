using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSimpleResultsListItem
/// </summary>
[DataContract]
public partial class SimpleResultsListItem
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SimpleResultsListItem" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="DocRepositoryItemId">DocRepositoryItemId.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="Links">Links.</param>
	/// <param name="PublicId">PublicId.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="SubTitle">SubTitle.</param>
	/// <param name="Text">Text.</param>
	/// <param name="Title">Title.</param>
	public SimpleResultsListItem(string BusObId, string BusObRecId, string DocRepositoryItemId, string GalleryImage, List<Link> Links, string PublicId, string Scope, string ScopeOwner, string SubTitle, string Text, string Title)
	{
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.DocRepositoryItemId = DocRepositoryItemId;
		this.GalleryImage = GalleryImage;
		this.Links = Links;
		this.PublicId = PublicId;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.SubTitle = SubTitle;
		this.Text = Text;
		this.Title = Title;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// DocRepositoryItemId
	/// </summary>
	[DataMember(Name = "docRepositoryItemId", EmitDefaultValue = false)]
	public string DocRepositoryItemId { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }

	/// <summary>
	/// PublicId
	/// </summary>
	[DataMember(Name = "publicId", EmitDefaultValue = false)]
	public string PublicId { get; set; }

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
	/// SubTitle
	/// </summary>
	[DataMember(Name = "subTitle", EmitDefaultValue = false)]
	public string SubTitle { get; set; }

	/// <summary>
	/// Text
	/// </summary>
	[DataMember(Name = "text", EmitDefaultValue = false)]
	public string Text { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }
}
