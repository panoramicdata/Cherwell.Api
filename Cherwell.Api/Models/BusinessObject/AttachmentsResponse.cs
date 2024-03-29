using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// Attachments Response
/// </summary>
[DataContract]
public class AttachmentsResponse : Response
{
	/// <summary>
	/// Attachments
	/// </summary>
	[DataMember(Name = "attachments", EmitDefaultValue = false)]
	public List<Attachment> Attachments { get; set; } = null!;
}