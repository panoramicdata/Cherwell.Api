using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveBusObAttachmentRequest
/// </summary>
[DataContract]
public partial class SaveBusObAttachmentRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveBusObAttachmentRequest" /> class.
	/// </summary>
	/// <param name="AttachBusObId">AttachBusObId.</param>
	/// <param name="AttachBusObName">AttachBusObName.</param>
	/// <param name="AttachBusObPublicId">AttachBusObPublicId.</param>
	/// <param name="AttachBusObRecId">AttachBusObRecId.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObName">BusObName.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Comment">Comment.</param>
	/// <param name="IncludeLinks">IncludeLinks.</param>
	public SaveBusObAttachmentRequest(string AttachBusObId, string AttachBusObName, string AttachBusObPublicId, string AttachBusObRecId, string BusObId, string BusObName, string BusObPublicId, string BusObRecId, string Comment, bool? IncludeLinks)
	{
		this.AttachBusObId = AttachBusObId;
		this.AttachBusObName = AttachBusObName;
		this.AttachBusObPublicId = AttachBusObPublicId;
		this.AttachBusObRecId = AttachBusObRecId;
		this.BusObId = BusObId;
		this.BusObName = BusObName;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.Comment = Comment;
		this.IncludeLinks = IncludeLinks;
	}

	/// <summary>
	/// AttachBusObId
	/// </summary>
	[DataMember(Name = "attachBusObId", EmitDefaultValue = false)]
	public string AttachBusObId { get; set; }

	/// <summary>
	/// AttachBusObName
	/// </summary>
	[DataMember(Name = "attachBusObName", EmitDefaultValue = false)]
	public string AttachBusObName { get; set; }

	/// <summary>
	/// AttachBusObPublicId
	/// </summary>
	[DataMember(Name = "attachBusObPublicId", EmitDefaultValue = false)]
	public string AttachBusObPublicId { get; set; }

	/// <summary>
	/// AttachBusObRecId
	/// </summary>
	[DataMember(Name = "attachBusObRecId", EmitDefaultValue = false)]
	public string AttachBusObRecId { get; set; }

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
	/// IncludeLinks
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
		sb.Append("class BusinessObjectSaveBusObAttachmentRequest {\n");
		sb.Append("  AttachBusObId: ").Append(AttachBusObId).Append('\n');
		sb.Append("  AttachBusObName: ").Append(AttachBusObName).Append('\n');
		sb.Append("  AttachBusObPublicId: ").Append(AttachBusObPublicId).Append('\n');
		sb.Append("  AttachBusObRecId: ").Append(AttachBusObRecId).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObName: ").Append(BusObName).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Comment: ").Append(Comment).Append('\n');
		sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append('\n');
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
			if (AttachBusObId != null)
			{
				hash = hash * 59 + AttachBusObId.GetHashCode();
			}

			if (AttachBusObName != null)
			{
				hash = hash * 59 + AttachBusObName.GetHashCode();
			}

			if (AttachBusObPublicId != null)
			{
				hash = hash * 59 + AttachBusObPublicId.GetHashCode();
			}

			if (AttachBusObRecId != null)
			{
				hash = hash * 59 + AttachBusObRecId.GetHashCode();
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

			if (Comment != null)
			{
				hash = hash * 59 + Comment.GetHashCode();
			}

			if (IncludeLinks != null)
			{
				hash = hash * 59 + IncludeLinks.GetHashCode();
			}

			return hash;
		}
	}

	
}