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
public partial class SaveGalleryImageRequest
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
