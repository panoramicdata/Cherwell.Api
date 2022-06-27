using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreSaveGalleryImageRequest
/// </summary>
[DataContract]
public partial class SaveGalleryImageRequest : IEquatable<SaveGalleryImageRequest>, IValidatableObject
{
	/// <summary>
	/// ImageType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumImageType
	{

		/// <summary>
		/// Enum Imported for "Imported"
		/// </summary>
		[EnumMember(Value = "Imported")]
		Imported,

		/// <summary>
		/// Enum File for "File"
		/// </summary>
		[EnumMember(Value = "File")]
		File,

		/// <summary>
		/// Enum Url for "Url"
		/// </summary>
		[EnumMember(Value = "Url")]
		Url
	}

	/// <summary>
	/// ImageType
	/// </summary>
	[DataMember(Name = "imageType", EmitDefaultValue = false)]
	public EnumImageType? ImageType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SaveGalleryImageRequest" /> class.
	/// </summary>
	/// <param name="Base64EncodedImageData">Base64EncodedImageData.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Folder">Folder.</param>
	/// <param name="ImageType">ImageType.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="StandInKey">StandInKey.</param>
	public SaveGalleryImageRequest(string Base64EncodedImageData, string Description, string Folder, EnumImageType? ImageType, string Name, string Scope, string ScopeOwner, string StandInKey)
	{
		this.Base64EncodedImageData = Base64EncodedImageData;
		this.Description = Description;
		this.Folder = Folder;
		this.ImageType = ImageType;
		this.Name = Name;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.StandInKey = StandInKey;
	}

	/// <summary>
	/// Base64EncodedImageData
	/// </summary>
	[DataMember(Name = "base64EncodedImageData", EmitDefaultValue = false)]
	public string Base64EncodedImageData { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Folder
	/// </summary>
	[DataMember(Name = "folder", EmitDefaultValue = false)]
	public string Folder { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

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
		sb.Append("class CoreSaveGalleryImageRequest {\n");
		sb.Append("  Base64EncodedImageData: ").Append(Base64EncodedImageData).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  Folder: ").Append(Folder).Append('\n');
		sb.Append("  ImageType: ").Append(ImageType).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as SaveGalleryImageRequest);
	}

	/// <summary>
	/// Returns true if CoreSaveGalleryImageRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreSaveGalleryImageRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveGalleryImageRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Base64EncodedImageData == other.Base64EncodedImageData ||
					Base64EncodedImageData != null &&
					Base64EncodedImageData.Equals(other.Base64EncodedImageData, StringComparison.Ordinal)
				) &&
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					Folder == other.Folder ||
					Folder != null &&
					Folder.Equals(other.Folder, StringComparison.Ordinal)
				) &&
				(
					ImageType == other.ImageType ||
					ImageType != null &&
					ImageType.Equals(other.ImageType)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
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
			if (Base64EncodedImageData != null)
			{
				hash = hash * 59 + Base64EncodedImageData.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (Folder != null)
			{
				hash = hash * 59 + Folder.GetHashCode();
			}

			if (ImageType != null)
			{
				hash = hash * 59 + ImageType.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
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
