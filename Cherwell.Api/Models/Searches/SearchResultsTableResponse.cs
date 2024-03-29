using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsTableResponse
/// </summary>
[DataContract]
public class SearchResultsTableResponse : Response
{
	/// <summary>
	/// Columns
	/// </summary>
	[DataMember(Name = "columns", EmitDefaultValue = false)]
	public List<Field> Columns { get; set; } = null!;

	/// <summary>
	/// Rows
	/// </summary>
	[DataMember(Name = "rows", EmitDefaultValue = false)]
	public List<SearchResultsRow> Rows { get; set; } = null!;

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; } = null!;

	/// <summary>
	/// TotalRows
	/// </summary>
	[DataMember(Name = "totalRows", EmitDefaultValue = false)]
	public long TotalRows { get; set; }
}
