using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsMobileFormResponse
/// </summary>
[DataContract]
public partial class MobileFormResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MobileFormResponse" /> class.
	/// </summary>
	/// <param name="Actions">Actions.</param>
	/// <param name="Attachments">Attachments.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="LocationInformation">LocationInformation.</param>
	/// <param name="Sections">Sections.</param>
	/// <param name="Title">Title.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public MobileFormResponse(List<Core.Action> Actions, List<Attachment> Attachments, string GalleryImage, Location LocationInformation, List<Section> Sections, string Title, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Actions = Actions;
		this.Attachments = Attachments;
		this.GalleryImage = GalleryImage;
		this.LocationInformation = LocationInformation;
		this.Sections = Sections;
		this.Title = Title;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Actions
	/// </summary>
	[DataMember(Name = "actions", EmitDefaultValue = false)]
	public List<Core.Action> Actions { get; set; }

	/// <summary>
	/// Attachments
	/// </summary>
	[DataMember(Name = "attachments", EmitDefaultValue = false)]
	public List<Attachment> Attachments { get; set; }

	/// <summary>
	/// GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// LocationInformation
	/// </summary>
	[DataMember(Name = "locationInformation", EmitDefaultValue = false)]
	public Location LocationInformation { get; set; }

	/// <summary>
	/// Sections
	/// </summary>
	[DataMember(Name = "sections", EmitDefaultValue = false)]
	public List<Section> Sections { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }














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
