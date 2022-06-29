using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityRightCategoriesResponse
/// </summary>
[DataContract]
public partial class SecurityRightCategoriesResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecurityRightCategoriesResponse" /> class.
	/// </summary>
	/// <param name="RightCategories">RightCategories.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SecurityRightCategoriesResponse(List<RightCategory> RightCategories, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.RightCategories = RightCategories;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// RightCategories
	/// </summary>
	[DataMember(Name = "rightCategories", EmitDefaultValue = false)]
	public List<RightCategory> RightCategories { get; set; }











	
}

