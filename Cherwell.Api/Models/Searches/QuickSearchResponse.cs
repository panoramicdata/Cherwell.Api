using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchResponse
/// </summary>
[DataContract]
public partial class QuickSearchResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchResponse" /> class.
	/// </summary>
	/// <param name="SearchResultsTable">SearchResultsTable.</param>
	/// <param name="SimpleResultsList">SimpleResultsList.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public QuickSearchResponse(SearchResultsTableResponse SearchResultsTable, SimpleResultsList SimpleResultsList, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.SearchResultsTable = SearchResultsTable;
		this.SimpleResultsList = SimpleResultsList;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// SearchResultsTable
	/// </summary>
	[DataMember(Name = "searchResultsTable", EmitDefaultValue = false)]
	public SearchResultsTableResponse SearchResultsTable { get; set; }

	/// <summary>
	/// SimpleResultsList
	/// </summary>
	[DataMember(Name = "simpleResultsList", EmitDefaultValue = false)]
	public SimpleResultsList SimpleResultsList { get; set; }












	
}
