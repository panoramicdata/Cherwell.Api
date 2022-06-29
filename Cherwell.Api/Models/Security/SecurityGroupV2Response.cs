using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroupV2Response
/// </summary>
[DataContract]
public partial class SecurityGroupV2Response : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecurityGroupV2Response" /> class.
	/// </summary>
	/// <param name="SecurityGroups">SecurityGroups.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SecurityGroupV2Response(List<SecurityGroup> SecurityGroups, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.SecurityGroups = SecurityGroups;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// SecurityGroups
	/// </summary>
	[DataMember(Name = "securityGroups", EmitDefaultValue = false)]
	public List<SecurityGroup> SecurityGroups { get; set; }











	
}

