using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// SaveLinkAttachmentRequest
/// </summary>
[DataContract]
public class SaveLinkAttachmentRequest
{
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
	/// DisplayText
	/// </summary>
	[DataMember(Name = "displayText", EmitDefaultValue = false)]
	public string DisplayText { get; set; } = null!;

	/// <summary>
	/// IncludeLinks
	/// </summary>
	[DataMember(Name = "includeLinks", EmitDefaultValue = false)]
	public bool IncludeLinks { get; set; }

	/// <summary>
	/// UncFilePath
	/// </summary>
	[DataMember(Name = "uncFilePath", EmitDefaultValue = false)]
	public string UncFilePath { get; set; } = null!;
}