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