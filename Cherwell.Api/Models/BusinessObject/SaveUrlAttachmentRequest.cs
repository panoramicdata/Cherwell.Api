using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveUrlAttachmentRequest
/// </summary>
[DataContract]
public partial class SaveUrlAttachmentRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveUrlAttachmentRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObName">BusObName.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Comment">Comment.</param>
	/// <param name="DisplayText">DisplayText.</param>
	/// <param name="IncludeLinks">IncludeLinks.</param>
	/// <param name="Url">Url.</param>
	public SaveUrlAttachmentRequest(string BusObId, string BusObName, string BusObPublicId, string BusObRecId, string Comment, string DisplayText, bool? IncludeLinks, string Url)
	{
		this.BusObId = BusObId;
		this.BusObName = BusObName;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.Comment = Comment;
		this.DisplayText = DisplayText;
		this.IncludeLinks = IncludeLinks;
		this.Url = Url;
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
	/// Url
	/// </summary>
	[DataMember(Name = "url", EmitDefaultValue = false)]
	public string Url { get; set; }












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