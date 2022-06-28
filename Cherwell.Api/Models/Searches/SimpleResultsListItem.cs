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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSimpleResultsListItem {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  DocRepositoryItemId: ").Append(DocRepositoryItemId).Append('\n');
		sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  PublicId: ").Append(PublicId).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  SubTitle: ").Append(SubTitle).Append('\n');
		sb.Append("  Text: ").Append(Text).Append('\n');
		sb.Append("  Title: ").Append(Title).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if SearchesSimpleResultsListItem instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSimpleResultsListItem to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SimpleResultsListItem? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					DocRepositoryItemId == other.DocRepositoryItemId ||
					DocRepositoryItemId != null &&
					DocRepositoryItemId.Equals(other.DocRepositoryItemId, StringComparison.Ordinal)
				) &&
				(
					GalleryImage == other.GalleryImage ||
					GalleryImage != null &&
					GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
				) &&
				(
					PublicId == other.PublicId ||
					PublicId != null &&
					PublicId.Equals(other.PublicId, StringComparison.Ordinal)
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
					SubTitle == other.SubTitle ||
					SubTitle != null &&
					SubTitle.Equals(other.SubTitle, StringComparison.Ordinal)
				) &&
				(
					Text == other.Text ||
					Text != null &&
					Text.Equals(other.Text, StringComparison.Ordinal)
				) &&
				(
					Title == other.Title ||
					Title != null &&
					Title.Equals(other.Title, StringComparison.Ordinal)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (DocRepositoryItemId != null)
			{
				hash = hash * 59 + DocRepositoryItemId.GetHashCode();
			}

			if (GalleryImage != null)
			{
				hash = hash * 59 + GalleryImage.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (PublicId != null)
			{
				hash = hash * 59 + PublicId.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (SubTitle != null)
			{
				hash = hash * 59 + SubTitle.GetHashCode();
			}

			if (Text != null)
			{
				hash = hash * 59 + Text.GetHashCode();
			}

			if (Title != null)
			{
				hash = hash * 59 + Title.GetHashCode();
			}

			return hash;
		}
	}

	
}
