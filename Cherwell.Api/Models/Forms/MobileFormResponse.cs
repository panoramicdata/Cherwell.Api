using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsMobileFormResponse
/// </summary>
[DataContract]
public partial class MobileFormResponse : IEquatable<MobileFormResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MobileFormResponse" /> class.
	/// </summary>
	/// <param name="Actions">Actions.</param>
	/// <param name="Attachments">Attachments.</param>
	/// <param name="GalleryImage">GalleryImage.</param>
	/// <param name="LocationInformation">LocationInformation.</param>
	/// <param name="Sections">Sections.</param>
	/// <param name="Title">Title.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public MobileFormResponse(List<Core.Action> Actions, List<ObjectAttachment> Attachments, string GalleryImage, Location LocationInformation, List<Section> Sections, string Title, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.Actions = Actions;
		this.Attachments = Attachments;
		this.GalleryImage = GalleryImage;
		this.LocationInformation = LocationInformation;
		this.Sections = Sections;
		this.Title = Title;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets Actions
	/// </summary>
	[DataMember(Name = "actions", EmitDefaultValue = false)]
	public List<Core.Action> Actions { get; set; }

	/// <summary>
	/// Gets or Sets Attachments
	/// </summary>
	[DataMember(Name = "attachments", EmitDefaultValue = false)]
	public List<ObjectAttachment> Attachments { get; set; }

	/// <summary>
	/// Gets or Sets GalleryImage
	/// </summary>
	[DataMember(Name = "galleryImage", EmitDefaultValue = false)]
	public string GalleryImage { get; set; }

	/// <summary>
	/// Gets or Sets LocationInformation
	/// </summary>
	[DataMember(Name = "locationInformation", EmitDefaultValue = false)]
	public Location LocationInformation { get; set; }

	/// <summary>
	/// Gets or Sets Sections
	/// </summary>
	[DataMember(Name = "sections", EmitDefaultValue = false)]
	public List<Section> Sections { get; set; }

	/// <summary>
	/// Gets or Sets Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class FormsMobileFormResponse {\n");
		sb.Append("  Actions: ").Append(Actions).Append('\n');
		sb.Append("  Attachments: ").Append(Attachments).Append('\n');
		sb.Append("  GalleryImage: ").Append(GalleryImage).Append('\n');
		sb.Append("  LocationInformation: ").Append(LocationInformation).Append('\n');
		sb.Append("  Sections: ").Append(Sections).Append('\n');
		sb.Append("  Title: ").Append(Title).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as MobileFormResponse);
	}

	/// <summary>
	/// Returns true if FormsMobileFormResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of FormsMobileFormResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(MobileFormResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Actions == other.Actions ||
					Actions != null &&
					Actions.SequenceEqual(other.Actions)
				) &&
				(
					Attachments == other.Attachments ||
					Attachments != null &&
					Attachments.SequenceEqual(other.Attachments)
				) &&
				(
					GalleryImage == other.GalleryImage ||
					GalleryImage != null &&
					GalleryImage.Equals(other.GalleryImage, StringComparison.Ordinal)
				) &&
				(
					LocationInformation == other.LocationInformation ||
					LocationInformation != null &&
					LocationInformation.Equals(other.LocationInformation)
				) &&
				(
					Sections == other.Sections ||
					Sections != null &&
					Sections.SequenceEqual(other.Sections)
				) &&
				(
					Title == other.Title ||
					Title != null &&
					Title.Equals(other.Title, StringComparison.Ordinal)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
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
			if (Actions != null)
			{
				hash = hash * 59 + Actions.GetHashCode();
			}

			if (Attachments != null)
			{
				hash = hash * 59 + Attachments.GetHashCode();
			}

			if (GalleryImage != null)
			{
				hash = hash * 59 + GalleryImage.GetHashCode();
			}

			if (LocationInformation != null)
			{
				hash = hash * 59 + LocationInformation.GetHashCode();
			}

			if (Sections != null)
			{
				hash = hash * 59 + Sections.GetHashCode();
			}

			if (Title != null)
			{
				hash = hash * 59 + Title.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
