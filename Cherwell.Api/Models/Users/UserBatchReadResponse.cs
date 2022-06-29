using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchReadResponse
/// </summary>
[DataContract]
public partial class UserBatchReadResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchReadResponse" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public UserBatchReadResponse(List<UserReadV2Response> Responses, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Responses = Responses;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserReadV2Response> Responses { get; set; }











	
}

