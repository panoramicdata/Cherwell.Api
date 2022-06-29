using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;


/// <summary>
/// CoreViewsResponse
/// </summary>
[DataContract]
public partial class ViewsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ViewsResponse" /> class.
	/// </summary>
	/// <param name="Views">Views.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public ViewsResponse(List<View> Views, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Views = Views;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Views
	/// </summary>
	[DataMember(Name = "views", EmitDefaultValue = false)]
	public List<View> Views { get; set; }











	
}
