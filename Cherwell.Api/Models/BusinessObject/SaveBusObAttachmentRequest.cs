using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// SaveBusObAttachmentRequest
/// </summary>
[DataContract]
public partial class SaveBusObAttachmentRequest
{
	/// <summary>
	/// AttachBusObId
	/// </summary>
	[DataMember(Name = "attachBusObId", EmitDefaultValue = false)]
	public string? AttachBusObId { get; set; }

	/// <summary>
	/// AttachBusObName
	/// </summary>
	[DataMember(Name = "attachBusObName", EmitDefaultValue = false)]
	public string? AttachBusObName { get; set; }

	/// <summary>
	/// AttachBusObPublicId
	/// </summary>
	[DataMember(Name = "attachBusObPublicId", EmitDefaultValue = false)]
	public string? AttachBusObPublicId { get; set; }

	/// <summary>
	/// AttachBusObRecId
	/// </summary>
	[DataMember(Name = "attachBusObRecId", EmitDefaultValue = false)]
	public string? AttachBusObRecId { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string? BusObName { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string? BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string? BusObRecId { get; set; }

	/// <summary>
	/// Comment
	/// </summary>
	[DataMember(Name = "comment", EmitDefaultValue = false)]
	public string? Comment { get; set; }

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool? IncludeLinks { get; set; }
}