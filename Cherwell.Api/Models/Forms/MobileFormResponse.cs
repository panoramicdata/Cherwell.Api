using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsMobileFormResponse
/// </summary>
[DataContract]
public partial class MobileFormResponse : Response
{
	/// <summary>
	/// Actions
	/// </summary>
	[DataMember(Name = "actions", EmitDefaultValue = false)]
	public List<Core.Action>? Actions { get; set; }

	/// <summary>
	/// Attachments
	/// </summary>
	[DataMember(Name = "attachments", EmitDefaultValue = false)]
	public List<Attachment>? Attachments { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string? GalleryImage { get; set; }

	/// <summary>
	/// LocationInformation
	/// </summary>
	[DataMember(Name = "locationInformation", EmitDefaultValue = false)]
	public Location? LocationInformation { get; set; }

	/// <summary>
	/// Sections
	/// </summary>
	[DataMember(Name = "sections", EmitDefaultValue = false)]
	public List<Section>? Sections { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string? Title { get; set; }
}
