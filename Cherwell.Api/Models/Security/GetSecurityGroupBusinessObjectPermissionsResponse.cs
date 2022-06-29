using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetSecurityGroupBusinessObjectPermissionsResponse
/// </summary>
[DataContract]
public partial class GetSecurityGroupBusinessObjectPermissionsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetSecurityGroupBusinessObjectPermissionsResponse" /> class.
	/// </summary>
	/// <param name="BusinessObjectPermissions">BusinessObjectPermissions.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public GetSecurityGroupBusinessObjectPermissionsResponse(List<BusinessObjectPermission> BusinessObjectPermissions, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.BusinessObjectPermissions = BusinessObjectPermissions;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// BusinessObjectPermissions
	/// </summary>
	[DataMember(Name = "businessObjectPermissions", EmitDefaultValue = false)]
	public List<BusinessObjectPermission> BusinessObjectPermissions { get; set; }











	
}
