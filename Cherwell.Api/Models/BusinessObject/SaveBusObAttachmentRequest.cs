using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// SaveBusObAttachmentRequest
/// </summary>
[DataContract]
public class SaveBusObAttachmentRequest
{
	/// <summary>
	/// AttachBusObId
	/// </summary>
	[DataMember(Name = "attachBusObId", EmitDefaultValue = false)]
	public string AttachBusObId { get; set; } = null!;

	/// <summary>
	/// AttachBusObName
	/// </summary>
	[DataMember(Name = "attachBusObName", EmitDefaultValue = false)]
	public string AttachBusObName { get; set; } = null!;

	/// <summary>
	/// AttachBusObPublicId
	/// </summary>
	[DataMember(Name = "attachBusObPublicId", EmitDefaultValue = false)]
	public string AttachBusObPublicId { get; set; } = null!;

	/// <summary>
	/// AttachBusObRecId
	/// </summary>
	[DataMember(Name = "attachBusObRecId", EmitDefaultValue = false)]
	public string AttachBusObRecId { get; set; } = null!;

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
	/// Comment
	/// </summary>
	[DataMember(Name = "comment", EmitDefaultValue = false)]
	public string Comment { get; set; } = null!;

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool IncludeLinks { get; set; }
}