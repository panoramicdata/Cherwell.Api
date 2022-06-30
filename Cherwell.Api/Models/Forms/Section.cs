using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsSection
/// </summary>
[DataContract]
public partial class Section
{
	/// <summary>
	/// SectionFields
	/// </summary>
	[DataMember(Name = "sectionFields", EmitDefaultValue = false)]
	public List<SectionField> SectionFields { get; set; } = null!;

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; } = null!;

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; } = null!;

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; } = null!;

	/// <summary>
	/// TargetBusObId
	/// </summary>
	[DataMember(Name = "targetBusObId", EmitDefaultValue = false)]
	public string TargetBusObId { get; set; } = null!;

	/// <summary>
	/// TargetBusObRecId
	/// </summary>
	[DataMember(Name = "targetBusObRecId", EmitDefaultValue = false)]
	public string TargetBusObRecId { get; set; } = null!;
}
