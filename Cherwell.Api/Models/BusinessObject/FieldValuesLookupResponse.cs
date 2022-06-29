using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldValuesLookupResponse
/// </summary>
[DataContract]
public partial class FieldValuesLookupResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldValuesLookupResponse" /> class.
	/// </summary>
	/// <param name="Values">Values.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public FieldValuesLookupResponse(List<string> Values, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Values = Values;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Values
	/// </summary>
	[DataMember(Name = "values", EmitDefaultValue = false)]
	public List<string> Values { get; set; }











	
}