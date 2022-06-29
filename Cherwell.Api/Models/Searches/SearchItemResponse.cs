using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchItemResponse
/// </summary>
[DataContract]
public partial class SearchItemResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SearchItemResponse" /> class.
	/// </summary>
	/// <param name="Root">Root.</param>
	/// <param name="SupportedAssociations">SupportedAssociations.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SearchItemResponse(SearchFolder Root, List<Association> SupportedAssociations, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Root = Root;
		this.SupportedAssociations = SupportedAssociations;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Root
	/// </summary>
	[DataMember(Name = "root", EmitDefaultValue = false)]
	public SearchFolder Root { get; set; }

	/// <summary>
	/// SupportedAssociations
	/// </summary>
	[DataMember(Name = "supportedAssociations", EmitDefaultValue = false)]
	public List<Association> SupportedAssociations { get; set; }












	
}
