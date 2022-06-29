using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// RemoveCustomerFromWorkgroupResponse
/// </summary>
[DataContract]
public partial class RemoveCustomerFromWorkgroupResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RemoveCustomerFromWorkgroupResponse" /> class.
	/// </summary>
	/// <param name="WorkgroupId">WorkgroupId.</param>
	/// <param name="CustomerRecordId">CustomerRecordId.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public RemoveCustomerFromWorkgroupResponse(string WorkgroupId, string CustomerRecordId, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.WorkgroupId = WorkgroupId;
		this.CustomerRecordId = CustomerRecordId;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// WorkgroupId
	/// </summary>
	[DataMember(Name = "workgroupId", EmitDefaultValue = false)]
	public string WorkgroupId { get; set; }

	/// <summary>
	/// CustomerRecordId
	/// </summary>
	[DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
	public string CustomerRecordId { get; set; }












	
}

