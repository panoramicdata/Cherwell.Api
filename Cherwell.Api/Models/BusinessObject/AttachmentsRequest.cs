using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectAttachmentsRequest
/// </summary>
[DataContract]
public partial class AttachmentsRequest : IEquatable<AttachmentsRequest>, IValidatableObject
{

	/// <summary>
	/// Gets or Sets AttachmentTypes
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
	/// Gets or Sets Types
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
	/// Gets or Sets AttachmentTypes
	/// </summary>
	[DataMember(Name = "attachmentTypes", EmitDefaultValue = false)]
	public List<EnumAttachmentTypes> AttachmentTypes { get; set; }

	/// <summary>
	/// Gets or Sets Types
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
	/// Gets or Sets BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; }

	/// <summary>
	/// Gets or Sets BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// Gets or Sets BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// Gets or Sets IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool? IncludeLinks { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectAttachmentsRequest {\n");
		sb.Append("  AttachmentId: ").Append(AttachmentId).Append('\n');
		sb.Append("  AttachmentTypes: ").Append(AttachmentTypes).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObName: ").Append(BusObName).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append('\n');
		sb.Append("  Types: ").Append(Types).Append('\n');
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
		return Equals(obj as AttachmentsRequest);
	}

	/// <summary>
	/// Returns true if BusinessObjectAttachmentsRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectAttachmentsRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(AttachmentsRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AttachmentId == other.AttachmentId ||
					AttachmentId != null &&
					AttachmentId.Equals(other.AttachmentId, StringComparison.Ordinal)
				) &&
				(
					AttachmentTypes == other.AttachmentTypes ||
					AttachmentTypes != null &&
					AttachmentTypes.SequenceEqual(other.AttachmentTypes)
				) &&
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObName == other.BusObName ||
					BusObName != null &&
					BusObName.Equals(other.BusObName, StringComparison.Ordinal)
				) &&
				(
					BusObPublicId == other.BusObPublicId ||
					BusObPublicId != null &&
					BusObPublicId.Equals(other.BusObPublicId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					IncludeLinks == other.IncludeLinks ||
					IncludeLinks != null &&
					IncludeLinks.Equals(other.IncludeLinks)
				) &&
				(
					Types == other.Types ||
					Types != null &&
					Types.SequenceEqual(other.Types)
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
			if (AttachmentId != null)
			{
				hash = hash * 59 + AttachmentId.GetHashCode();
			}

			if (AttachmentTypes != null)
			{
				hash = hash * 59 + AttachmentTypes.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObName != null)
			{
				hash = hash * 59 + BusObName.GetHashCode();
			}

			if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (IncludeLinks != null)
			{
				hash = hash * 59 + IncludeLinks.GetHashCode();
			}

			if (Types != null)
			{
				hash = hash * 59 + Types.GetHashCode();
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