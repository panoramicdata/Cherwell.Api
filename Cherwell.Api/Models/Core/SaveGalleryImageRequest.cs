using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// SaveGalleryImageRequest
/// </summary>
[DataContract]
public class SaveGalleryImageRequest
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
	public EnumImageType ImageType { get; set; }
	/// <summary>
	/// Base64EncodedImageData
	/// </summary>
	[DataMember(Name = "base64EncodedImageData", EmitDefaultValue = false)]
	public string Base64EncodedImageData { get; set; } = null!;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; } = null!;

	/// <summary>
	/// Folder
	/// </summary>
	[DataMember(Name = "folder", EmitDefaultValue = false)]
	public string Folder { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; } = null!;

	/// <summary>
	/// ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; } = null!;

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; } = null!;
}
