using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveV2Response
/// </summary>
[DataContract]
public partial class UserBatchSaveV2Response : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchSaveV2Response" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public UserBatchSaveV2Response(List<UserSaveV2Response> Responses, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
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
	public List<UserSaveV2Response> Responses { get; set; }











	
}

