using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// RoleReadV2Response
/// </summary>
[DataContract]
public partial class RoleReadV2Response : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RoleReadV2Response" /> class.
	/// </summary>
	/// <param name="Roles">Roles.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public RoleReadV2Response(List<Role> Roles, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Roles = Roles;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Roles
	/// </summary>
	[DataMember(Name = "roles", EmitDefaultValue = false)]
	public List<Role> Roles { get; set; }











	
}

