using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchResponse
/// </summary>
[DataContract]
public partial class QuickSearchResponse : Response
{
	/// <summary>
	/// SearchResultsTable
	/// </summary>
	[DataMember(Name = "searchResultsTable", EmitDefaultValue = false)]
	public SearchResultsTableResponse SearchResultsTable { get; set; } = null!;

	/// <summary>
	/// SimpleResultsList
	/// </summary>
	[DataMember(Name = "simpleResultsList", EmitDefaultValue = false)]
	public SimpleResultsList SimpleResultsList { get; set; } = null!;
}
