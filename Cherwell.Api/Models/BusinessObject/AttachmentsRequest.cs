using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// AttachmentsRequest
/// </summary>
[DataContract]
public partial class AttachmentsRequest
{

	/// <summary>
	/// AttachmentTypes
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumAttachmentTypes
	{

		/// <summary>
		/// Enum Imported for "Imported"
		/// </summary>
		[EnumMember(Value = "Imported")]
		Imported,

		/// <summary>
		/// Enum Linked for "Linked"
		/// </summary>
		[EnumMember(Value = "Linked")]
		Linked,

		/// <summary>
		/// Enum URL for "URL"
		/// </summary>
		[EnumMember(Value = "URL")]
		URL
	}


	/// <summary>
	/// Types
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumTypes
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum File for "File"
		/// </summary>
		[EnumMember(Value = "File")]
		File,

		/// <summary>
		/// Enum FileManagerFile for "FileManagerFile"
		/// </summary>
		[EnumMember(Value = "FileManagerFile")]
		FileManagerFile,

		/// <summary>
		/// Enum BusOb for "BusOb"
		/// </summary>
		[EnumMember(Value = "BusOb")]
		BusOb,

		/// <summary>
		/// Enum History for "History"
		/// </summary>
		[EnumMember(Value = "History")]
		History,

		/// <summary>
		/// Enum Other for "Other"
		/// </summary>
		[EnumMember(Value = "Other")]
		Other,

		/// <summary>
		/// Enum Solution for "Solution"
		/// </summary>
		[EnumMember(Value = "Solution")]
		Solution,

		/// <summary>
		/// Enum UsedAsSolution for "UsedAsSolution"
		/// </summary>
		[EnumMember(Value = "UsedAsSolution")]
		UsedAsSolution,

		/// <summary>
		/// Enum ExternalSolution for "ExternalSolution"
		/// </summary>
		[EnumMember(Value = "ExternalSolution")]
		ExternalSolution
	}

	/// <summary>
	/// AttachmentTypes
	/// </summary>
	[DataMember(Name = "attachmentTypes", EmitDefaultValue = false)]
	public List<EnumAttachmentTypes> AttachmentTypes { get; set; } = null!;

	/// <summary>
	/// AttachmentId
	/// </summary>
	[DataMember(Name = "attachmentId", EmitDefaultValue = false)]
	public string AttachmentId { get; set; } = null!;

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; } = null!;

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; } = null!;

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool IncludeLinks { get; set; }

}