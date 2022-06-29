using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveLinkAttachmentRequest
/// </summary>
[DataContract]
public partial class SaveLinkAttachmentRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveLinkAttachmentRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObName">BusObName.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Comment">Comment.</param>
	/// <param name="DisplayText">DisplayText.</param>
	/// <param name="IncludeLinks">IncludeLinks.</param>
	/// <param name="UncFilePath">UncFilePath.</param>
	public SaveLinkAttachmentRequest(string BusObId, string BusObName, string BusObPublicId, string BusObRecId, string Comment, string DisplayText, bool? IncludeLinks, string UncFilePath)
	{
		this.BusObId = BusObId;
		this.BusObName = BusObName;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.Comment = Comment;
		this.DisplayText = DisplayText;
		this.IncludeLinks = IncludeLinks;
		this.UncFilePath = UncFilePath;
	}

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
	/// Comment
	/// </summary>
	[DataMember(Name = "comment", EmitDefaultValue = false)]
	public string Comment { get; set; }

	/// <summary>
	/// DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; }

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool? IncludeLinks { get; set; }

	/// <summary>
	/// UncFilePath
	/// </summary>
	[DataMember(Name = "uncFilePath", EmitDefaultValue = false)]
	public string UncFilePath { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectSaveLinkAttachmentRequest {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObName: ").Append(BusObName).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Comment: ").Append(Comment).Append('\n');
		sb.Append("  DisplayText: ").Append(DisplayText).Append('\n');
		sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append('\n');
		sb.Append("  UncFilePath: ").Append(UncFilePath).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
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

			if (Comment != null)
			{
				hash = hash * 59 + Comment.GetHashCode();
			}

			if (DisplayText != null)
			{
				hash = hash * 59 + DisplayText.GetHashCode();
			}

			if (IncludeLinks != null)
			{
				hash = hash * 59 + IncludeLinks.GetHashCode();
			}

			if (UncFilePath != null)
			{
				hash = hash * 59 + UncFilePath.GetHashCode();
			}

			return hash;
		}
	}

	
}