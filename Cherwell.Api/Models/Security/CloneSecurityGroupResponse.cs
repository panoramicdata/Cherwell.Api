using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// CloneSecurityGroupResponse
/// </summary>
[DataContract]
public partial class CloneSecurityGroupResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CloneSecurityGroupResponse" /> class.
	/// </summary>
	/// <param name="SecurityGroupId">SecurityGroupId.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public CloneSecurityGroupResponse(string SecurityGroupId, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.SecurityGroupId = SecurityGroupId;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// SecurityGroupId
	/// </summary>
	[DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
	public string SecurityGroupId { get; set; }











	
}
