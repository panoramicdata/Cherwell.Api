using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityRightsResponse
/// </summary>
[DataContract]
public partial class SecurityRightsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecurityRightsResponse" /> class.
	/// </summary>
	/// <param name="Rights">Rights.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SecurityRightsResponse(List<Right> Rights, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Rights = Rights;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Rights
	/// </summary>
	[DataMember(Name = "rights", EmitDefaultValue = false)]
	public List<Right> Rights { get; set; }











	
}

