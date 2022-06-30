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
	public List<EnumAttachmentTypes> AttachmentTypes { get; set; }

	/// <summary>
	/// Types
	/// </summary>
	[DataMember(Name = "types", EmitDefaultValue = false)]
	public List<EnumTypes> Types { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="AttachmentsRequest" /> class.
	/// </summary>
	/// <param name="AttachmentId">AttachmentId.</param>
	/// <param name="AttachmentTypes">AttachmentTypes.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObName">BusObName.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="IncludeLinks">IncludeLinks.</param>
	/// <param name="Types">Types.</param>
	public AttachmentsRequest(string AttachmentId, List<EnumAttachmentTypes> AttachmentTypes, string BusObId, string BusObName, string BusObPublicId, string BusObRecId, bool? IncludeLinks, List<EnumTypes> Types)
	{
		this.AttachmentId = AttachmentId;
		this.AttachmentTypes = AttachmentTypes;
		this.BusObId = BusObId;
		this.BusObName = BusObName;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.IncludeLinks = IncludeLinks;
		this.Types = Types;
	}

	/// <summary>
	/// AttachmentId
	/// </summary>
	[DataMember(Name = "attachmentId", EmitDefaultValue = false)]
	public string AttachmentId { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool? IncludeLinks { get; set; }

}