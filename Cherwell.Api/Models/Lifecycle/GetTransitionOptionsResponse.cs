using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Lifecycle;

/// <summary>
/// LifecycleGetTransitionOptionsResponse
/// </summary>
[DataContract]
public partial class GetTransitionOptionsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetTransitionOptionsResponse" /> class.
	/// </summary>
	/// <param name="Transitions">Transitions.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public GetTransitionOptionsResponse(List<GetTransitionOptionsResponseTransition> Transitions, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Transitions = Transitions;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Transitions
	/// </summary>
	[DataMember(Name = "transitions", EmitDefaultValue = false)]
	public List<GetTransitionOptionsResponseTransition> Transitions { get; set; }











	
}
