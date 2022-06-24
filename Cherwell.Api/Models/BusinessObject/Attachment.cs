using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectAttachment
/// </summary>
[DataContract]
public partial class ObjectAttachment : IEquatable<ObjectAttachment>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets AttachmentType
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
	/// Gets or Sets Scope
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumScope
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
	/// Gets or Sets Type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumType
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
	/// Gets or Sets AttachmentType
	/// </summary>
	[DataMember(Name = "attachmentType", EmitDefaultValue = false)]
	public EnumAttachmentType? AttachmentType { get; set; }
	/// <summary>
	/// Gets or Sets Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public EnumScope? Scope { get; set; }
	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public EnumType? Type { get; set; }
	/// <summary>
	/// Initializes a new instance of the <see cref="ObjectAttachment" /> class.
	/// </summary>
	/// <param name="AttachedBusObId">AttachedBusObId.</param>
	/// <param name="AttachedBusObRecId">AttachedBusObRecId.</param>
	/// <param name="AttachmentFileId">AttachmentFileId.</param>
	/// <param name="AttachmentFileName">AttachmentFileName.</param>
	/// <param name="AttachmentFileType">AttachmentFileType.</param>
	/// <param name="AttachmentId">AttachmentId.</param>
	/// <param name="AttachmentType">AttachmentType.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Comment">Comment.</param>
	/// <param name="Created">Created.</param>
	/// <param name="DisplayText">DisplayText.</param>
	/// <param name="Links">Links.</param>
	/// <param name="Owner">Owner.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwner">ScopeOwner.</param>
	/// <param name="Type">Type.</param>
	public ObjectAttachment(string AttachedBusObId, string AttachedBusObRecId, string AttachmentFileId, string AttachmentFileName, string AttachmentFileType, string AttachmentId, EnumAttachmentType? AttachmentType, string BusObId, string BusObRecId, string Comment, DateTime? Created, string DisplayText, List<Link> Links, string Owner, EnumScope? Scope, string ScopeOwner, EnumType? Type)
	{
		this.AttachedBusObId = AttachedBusObId;
		this.AttachedBusObRecId = AttachedBusObRecId;
		this.AttachmentFileId = AttachmentFileId;
		this.AttachmentFileName = AttachmentFileName;
		this.AttachmentFileType = AttachmentFileType;
		this.AttachmentId = AttachmentId;
		this.AttachmentType = AttachmentType;
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.Comment = Comment;
		this.Created = Created;
		this.DisplayText = DisplayText;
		this.Links = Links;
		this.Owner = Owner;
		this.Scope = Scope;
		this.ScopeOwner = ScopeOwner;
		this.Type = Type;
	}

	/// <summary>
	/// Gets or Sets AttachedBusObId
	/// </summary>
	[DataMember(Name = "attachedBusObId", EmitDefaultValue = false)]
	public string AttachedBusObId { get; set; }
	/// <summary>
	/// Gets or Sets AttachedBusObRecId
	/// </summary>
	[DataMember(Name = "attachedBusObRecId", EmitDefaultValue = false)]
	public string AttachedBusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets AttachmentFileId
	/// </summary>
	[DataMember(Name = "attachmentFileId", EmitDefaultValue = false)]
	public string AttachmentFileId { get; set; }
	/// <summary>
	/// Gets or Sets AttachmentFileName
	/// </summary>
	[DataMember(Name = "attachmentFileName", EmitDefaultValue = false)]
	public string AttachmentFileName { get; set; }
	/// <summary>
	/// Gets or Sets AttachmentFileType
	/// </summary>
	[DataMember(Name = "attachmentFileType", EmitDefaultValue = false)]
	public string AttachmentFileType { get; set; }
	/// <summary>
	/// Gets or Sets AttachmentId
	/// </summary>
	[DataMember(Name = "attachmentId", EmitDefaultValue = false)]
	public string AttachmentId { get; set; }
	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets Comment
	/// </summary>
	[DataMember(Name = "comment", EmitDefaultValue = false)]
	public string Comment { get; set; }
	/// <summary>
	/// Gets or Sets Created
	/// </summary>
	[DataMember(Name = "created", EmitDefaultValue = false)]
	public DateTime? Created { get; set; }
	/// <summary>
	/// Gets or Sets DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; }
	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }
	/// <summary>
	/// Gets or Sets Owner
	/// </summary>
	[DataMember(Name = "owner", EmitDefaultValue = false)]
	public string Owner { get; set; }
	/// <summary>
	/// Gets or Sets ScopeOwner
	/// </summary>
	[DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
	public string ScopeOwner { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectAttachment {\n");
		sb.Append("  AttachedBusObId: ").Append(AttachedBusObId).Append('\n');
		sb.Append("  AttachedBusObRecId: ").Append(AttachedBusObRecId).Append('\n');
		sb.Append("  AttachmentFileId: ").Append(AttachmentFileId).Append('\n');
		sb.Append("  AttachmentFileName: ").Append(AttachmentFileName).Append('\n');
		sb.Append("  AttachmentFileType: ").Append(AttachmentFileType).Append('\n');
		sb.Append("  AttachmentId: ").Append(AttachmentId).Append('\n');
		sb.Append("  AttachmentType: ").Append(AttachmentType).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Comment: ").Append(Comment).Append('\n');
		sb.Append("  Created: ").Append(Created).Append('\n');
		sb.Append("  DisplayText: ").Append(DisplayText).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  Owner: ").Append(Owner).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append('\n');
		sb.Append("  Type: ").Append(Type).Append('\n');
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
		return Equals(obj as ObjectAttachment);
	}

	/// <summary>
	/// Returns true if BusinessObjectAttachment instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectAttachment to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ObjectAttachment? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AttachedBusObId == other.AttachedBusObId ||
					AttachedBusObId != null &&
					AttachedBusObId.Equals(other.AttachedBusObId, StringComparison.Ordinal)
				) &&
				(
					AttachedBusObRecId == other.AttachedBusObRecId ||
					AttachedBusObRecId != null &&
					AttachedBusObRecId.Equals(other.AttachedBusObRecId, StringComparison.Ordinal)
				) &&
				(
					AttachmentFileId == other.AttachmentFileId ||
					AttachmentFileId != null &&
					AttachmentFileId.Equals(other.AttachmentFileId, StringComparison.Ordinal)
				) &&
				(
					AttachmentFileName == other.AttachmentFileName ||
					AttachmentFileName != null &&
					AttachmentFileName.Equals(other.AttachmentFileName, StringComparison.Ordinal)
				) &&
				(
					AttachmentFileType == other.AttachmentFileType ||
					AttachmentFileType != null &&
					AttachmentFileType.Equals(other.AttachmentFileType, StringComparison.Ordinal)
				) &&
				(
					AttachmentId == other.AttachmentId ||
					AttachmentId != null &&
					AttachmentId.Equals(other.AttachmentId, StringComparison.Ordinal)
				) &&
				(
					AttachmentType == other.AttachmentType ||
					AttachmentType != null &&
					AttachmentType.Equals(other.AttachmentType)
				) &&
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					Comment == other.Comment ||
					Comment != null &&
					Comment.Equals(other.Comment, StringComparison.Ordinal)
				) &&
				(
					Created == other.Created ||
					Created != null &&
					Created.Equals(other.Created)
				) &&
				(
					DisplayText == other.DisplayText ||
					DisplayText != null &&
					DisplayText.Equals(other.DisplayText, StringComparison.Ordinal)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
				) &&
				(
					Owner == other.Owner ||
					Owner != null &&
					Owner.Equals(other.Owner, StringComparison.Ordinal)
				) &&
				(
					Scope == other.Scope ||
					Scope != null &&
					Scope.Equals(other.Scope)
				) &&
				(
					ScopeOwner == other.ScopeOwner ||
					ScopeOwner != null &&
					ScopeOwner.Equals(other.ScopeOwner, StringComparison.Ordinal)
				) &&
				(
					Type == other.Type ||
					Type != null &&
					Type.Equals(other.Type)
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
			if (AttachedBusObId != null)
			{
				hash = hash * 59 + AttachedBusObId.GetHashCode();
			}

			if (AttachedBusObRecId != null)
			{
				hash = hash * 59 + AttachedBusObRecId.GetHashCode();
			}

			if (AttachmentFileId != null)
			{
				hash = hash * 59 + AttachmentFileId.GetHashCode();
			}

			if (AttachmentFileName != null)
			{
				hash = hash * 59 + AttachmentFileName.GetHashCode();
			}

			if (AttachmentFileType != null)
			{
				hash = hash * 59 + AttachmentFileType.GetHashCode();
			}

			if (AttachmentId != null)
			{
				hash = hash * 59 + AttachmentId.GetHashCode();
			}

			if (AttachmentType != null)
			{
				hash = hash * 59 + AttachmentType.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (Comment != null)
			{
				hash = hash * 59 + Comment.GetHashCode();
			}

			if (Created != null)
			{
				hash = hash * 59 + Created.GetHashCode();
			}

			if (DisplayText != null)
			{
				hash = hash * 59 + DisplayText.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (Owner != null)
			{
				hash = hash * 59 + Owner.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwner != null)
			{
				hash = hash * 59 + ScopeOwner.GetHashCode();
			}

			if (Type != null)
			{
				hash = hash * 59 + Type.GetHashCode();
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