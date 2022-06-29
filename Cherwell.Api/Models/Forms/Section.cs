using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsSection
/// </summary>
[DataContract]
public partial class Section
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Section" /> class.
	/// </summary>
	/// <param name="SectionFields">SectionFields.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="Title">Title.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="TargetBusObId">TargetBusObId.</param>
	/// <param name="TargetBusObRecId">TargetBusObRecId.</param>
	public Section(List<SectionField> SectionFields, string GalleryImage, string Title, string RelationshipId, string TargetBusObId, string TargetBusObRecId)
	{
		this.SectionFields = SectionFields;
		this.GalleryImage = GalleryImage;
		this.Title = Title;
		this.RelationshipId = RelationshipId;
		this.TargetBusObId = TargetBusObId;
		this.TargetBusObRecId = TargetBusObRecId;
	}

	/// <summary>
	/// SectionFields
	/// </summary>
	[DataMember(Name = "sectionFields", EmitDefaultValue = false)]
	public List<SectionField> SectionFields { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; }

	/// <summary>
	/// TargetBusObId
	/// </summary>
	[DataMember(Name = "targetBusObId", EmitDefaultValue = false)]
	public string TargetBusObId { get; set; }

	/// <summary>
	/// TargetBusObRecId
	/// </summary>
	[DataMember(Name = "targetBusObRecId", EmitDefaultValue = false)]
	public string TargetBusObRecId { get; set; }










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
