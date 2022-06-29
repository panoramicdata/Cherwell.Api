using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSimpleResultsList
/// </summary>
[DataContract]
public partial class SimpleResultsList : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SimpleResultsList" /> class.
	/// </summary>
	/// <param name="Groups">Groups.</param>
	/// <param name="Title">Title.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SimpleResultsList(List<SimpleResultsListGroup> Groups, string Title, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Groups = Groups;
		this.Title = Title;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Groups
	/// </summary>
	[DataMember(Name = "groups", EmitDefaultValue = false)]
	public List<SimpleResultsListGroup> Groups { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string Title { get; set; }












	
}
