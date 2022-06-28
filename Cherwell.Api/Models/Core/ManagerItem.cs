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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreManagerItem {\n");
		sb.Append("  Association: ").Append(Association).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
		sb.Append("  Id: ").Append(Id).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  LocalizedScopeName: ").Append(LocalizedScopeName).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  ParentFolder: ").Append(ParentFolder).Append('\n');
		sb.Append("  ParentIsScopeFolder: ").Append(ParentIsScopeFolder).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if CoreManagerItem instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreManagerItem to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ManagerItem? other)
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
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					GalleryImage == other.GalleryImage ||
					GalleryImage != null &&
					GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
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
					ParentFolder == other.ParentFolder ||
					ParentFolder != null &&
					ParentFolder.Equals(other.ParentFolder, StringComparison.Ordinal)
				) &&
				(
					ParentIsScopeFolder == other.ParentIsScopeFolder ||
					ParentIsScopeFolder != null &&
					ParentIsScopeFolder.Equals(other.ParentIsScopeFolder)
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
					StandInKey == other.StandInKey ||
					StandInKey != null &&
					StandInKey.Equals(other.StandInKey, StringComparison.Ordinal)
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

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (GalleryImage != null)
			{
				hash = hash * 59 + GalleryImage.GetHashCode();
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

			if (ParentFolder != null)
			{
				hash = hash * 59 + ParentFolder.GetHashCode();
			}

			if (ParentIsScopeFolder != null)
			{
				hash = hash * 59 + ParentIsScopeFolder.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (StandInKey != null)
			{
				hash = hash * 59 + StandInKey.GetHashCode();
			}

			return hash;
		}
	}

	
}
