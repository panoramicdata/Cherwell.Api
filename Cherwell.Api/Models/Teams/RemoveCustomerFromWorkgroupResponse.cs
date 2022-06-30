using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// RemoveCustomerFromWorkgroupResponse
/// </summary>
[DataContract]
public partial class RemoveCustomerFromWorkgroupResponse : Response
{
	/// <summary>
	/// WorkgroupId
	/// </summary>
	[DataMember(Name = "workgroupId", EmitDefaultValue = false)]
	public string WorkgroupId { get; set; } = null!;
	/// <summary>
	/// CustomerRecordId
	/// </summary>
	[DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
	public string CustomerRecordId { get; set; } = null!;
}

