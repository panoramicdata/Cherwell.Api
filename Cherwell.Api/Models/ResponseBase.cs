using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models;

/// <summary>
/// ResponseBase
/// </summary>
[DataContract]
public partial class ResponseBase : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ResponseBase" /> class.
	/// </summary>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="httpStatusCode">httpStatusCode.</param>
	public ResponseBase(string errorCode, string errorMessage, bool hasError, EnumHttpStatusCode httpStatusCode)
	{
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = httpStatusCode;
	}
}