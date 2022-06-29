using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsTableResponse
/// </summary>
[DataContract]
public partial class SearchResultsTableResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SearchResultsTableResponse" /> class.
	/// </summary>
	/// <param name="Columns">Columns.</param>
	/// <param name="Rows">Rows.</param>
	/// <param name="Sorting">Sorting.</param>
	/// <param name="TotalRows">TotalRows.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SearchResultsTableResponse(List<Field> Columns, List<SearchResultsRow> Rows, List<SortInfo> Sorting, long? TotalRows, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Columns = Columns;
		this.Rows = Rows;
		this.Sorting = Sorting;
		this.TotalRows = TotalRows;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Columns
	/// </summary>
	[DataMember(Name = "columns", EmitDefaultValue = false)]
	public List<Field> Columns { get; set; }

	/// <summary>
	/// Rows
	/// </summary>
	[DataMember(Name = "rows", EmitDefaultValue = false)]
	public List<SearchResultsRow> Rows { get; set; }

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; }

	/// <summary>
	/// TotalRows
	/// </summary>
	[DataMember(Name = "totalRows", EmitDefaultValue = false)]
	public long? TotalRows { get; set; }












	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)




		}
	}

	
}
