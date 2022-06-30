using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// SaveWorkgroupMemberRequest
/// </summary>
[DataContract]
public partial class SaveWorkgroupMemberRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveWorkgroupMemberRequest" /> class.
	/// </summary>
	/// <param name="CustomerRecordId">CustomerRecordId.</param>
	/// <param name="WorkgroupId">WorkgroupId.</param>
	/// <param name="CustomerIsWorkgroupManager">CustomerIsWorkgroupManager.</param>
	public SaveWorkgroupMemberRequest(string CustomerRecordId, string WorkgroupId, bool? CustomerIsWorkgroupManager)
	{
		this.CustomerRecordId = CustomerRecordId;
		this.WorkgroupId = WorkgroupId;
		this.CustomerIsWorkgroupManager = CustomerIsWorkgroupManager;
	}

	/// <summary>
	/// CustomerRecordId
	/// </summary>
	[DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
	public string CustomerRecordId { get; set; }

	/// <summary>
	/// WorkgroupId
	/// </summary>
	[DataMember(Name = "workgroupId", EmitDefaultValue = false)]
	public string WorkgroupId { get; set; }

	/// <summary>
	/// CustomerIsWorkgroupManager
	/// </summary>
	[DataMember(Name = "customerIsWorkgroupManager", EmitDefaultValue = false)]
	public bool? CustomerIsWorkgroupManager { get; set; }
}

