using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// Attachment
/// </summary>
[DataContract]
public class Attachment
{
	/// <summary>
	/// AttachmentType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumAttachmentType
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
	/// Scope
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttachmentScope
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

		/// <summary>
		/// Enum Global for "Global"
		/// </summary>
		[EnumMember(Value = "Global")]
		Global,

		/// <summary>
		/// Enum Team for "Team"
		/// </summary>
		[EnumMember(Value = "Team")]
		Team,

		/// <summary>
		/// Enum Persona for "Persona"
		/// </summary>
		[EnumMember(Value = "Persona")]
		Persona,

		/// <summary>
		/// Enum SecurityGroup for "SecurityGroup"
		/// </summary>
		[EnumMember(Value = "SecurityGroup")]
		SecurityGroup,

		/// <summary>
		/// Enum User for "User"
		/// </summary>
		[EnumMember(Value = "User")]
		User,

		/// <summary>
		/// Enum UserInPersona for "UserInPersona"
		/// </summary>
		[EnumMember(Value = "UserInPersona")]
		UserInPersona,

		/// <summary>
		/// Enum OtherUsers for "OtherUsers"
		/// </summary>
		[EnumMember(Value = "OtherUsers")]
		OtherUsers,

		/// <summary>
		/// Enum Core for "Core"
		/// </summary>
		[EnumMember(Value = "Core")]
		Core,

		/// <summary>
		/// Enum BusIntel for "BusIntel"
		/// </summary>
		[EnumMember(Value = "BusIntel")]
		BusIntel,

		/// <summary>
		/// Enum FromResource for "FromResource"
		/// </summary>
		[EnumMember(Value = "FromResource")]
		FromResource,

		/// <summary>
		/// Enum Site for "Site"
		/// </summary>
		[EnumMember(Value = "Site")]
		Site,

		/// <summary>
		/// Enum Custom for "Custom"
		/// </summary>
		[EnumMember(Value = "Custom")]
		Custom,

		/// <summary>
		/// Enum BusObRecord for "BusObRecord"
		/// </summary>
		[EnumMember(Value = "BusObRecord")]
		BusObRecord
	}

	/// <summary>
	/// Type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ObjectType
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
	/// AttachmentType
	/// </summary>
	[DataMember(Name = "attachmentType", EmitDefaultValue = false)]
	public EnumAttachmentType AttachmentType { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public AttachmentScope Scope { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public ObjectType Type { get; set; }

	/// <summary>
	/// AttachedBusObId
	/// </summary>
	[DataMember(Name = "attachedBusObId", EmitDefaultValue = false)]
	public string AttachedBusObId { get; set; } = null!;

	/// <summary>
	/// AttachedBusObRecId
	/// </summary>
	[DataMember(Name = "attachedBusObRecId", EmitDefaultValue = false)]
	public string AttachedBusObRecId { get; set; } = null!;

	/// <summary>
	/// AttachmentFileId
	/// </summary>
	[DataMember(Name = "attachmentFileId", EmitDefaultValue = false)]
	public string AttachmentFileId { get; set; } = null!;

	/// <summary>
	/// AttachmentFileName
	/// </summary>
	[DataMember(Name = "attachmentFileName", EmitDefaultValue = false)]
	public string AttachmentFileName { get; set; } = null!;

	/// <summary>
	/// AttachmentFileType
	/// </summary>
	[DataMember(Name = "attachmentFileType", EmitDefaultValue = false)]
	public string AttachmentFileType { get; set; } = null!;

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
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// Comment
	/// </summary>
	[DataMember(Name = "comment", EmitDefaultValue = false)]
	public string Comment { get; set; } = null!;

	/// <summary>
	/// Created
	/// </summary>
	[DataMember(Name = "created", EmitDefaultValue = false)]
	public DateTime Created { get; set; }

	/// <summary>
	/// DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; } = null!;

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; } = null!;

	/// <summary>
	/// Owner
	/// </summary>
	[DataMember(Name = "owner", EmitDefaultValue = false)]
	public string Owner { get; set; } = null!;

	/// <summary>
	/// ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; } = null!;
}