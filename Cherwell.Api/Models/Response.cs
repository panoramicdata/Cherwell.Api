using System.Runtime.Serialization;

namespace Cherwell.Api.Models;

public class Response
{
	/// <summary>
	/// HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode HttpStatusCode { get; set; }
	/// <summary>
	/// ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; } = null!;

	/// <summary>
	/// ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; } = null!;

	/// <summary>
	/// HasError 
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool HasError { get; set; }
}