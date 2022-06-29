using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// MobileCredentialsModeResponse
/// </summary>
[DataContract]
public partial class MobileCredentialsModeResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MobileCredentialsModeResponse" /> class.
	/// </summary>
	/// <param name="CredentialsMode">CredentialsMode.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public MobileCredentialsModeResponse(int? CredentialsMode, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.CredentialsMode = CredentialsMode;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// CredentialsMode
	/// </summary>
	[DataMember(Name = "credentialsMode", EmitDefaultValue = false)]
	public int? CredentialsMode { get; set; }











	
}
