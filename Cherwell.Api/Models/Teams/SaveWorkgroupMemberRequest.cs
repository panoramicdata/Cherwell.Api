using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// SaveWorkgroupMemberRequest
/// </summary>
[DataContract]
public class SaveWorkgroupMemberRequest
{
	/// <summary>
	/// CustomerRecordId
	/// </summary>
	[DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
	public string CustomerRecordId { get; set; } = null!;

	/// <summary>
	/// WorkgroupId
	/// </summary>
	[DataMember(Name = "workgroupId", EmitDefaultValue = false)]
	public string WorkgroupId { get; set; } = null!;

	/// <summary>
	/// CustomerIsWorkgroupManager
	/// </summary>
	[DataMember(Name = "customerIsWorkgroupManager", EmitDefaultValue = false)]
	public bool CustomerIsWorkgroupManager { get; set; }
}

