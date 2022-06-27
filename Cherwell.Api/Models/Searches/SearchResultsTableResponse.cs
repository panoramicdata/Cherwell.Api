using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsTableResponse
/// </summary>
[DataContract]
public partial class SearchResultsTableResponse : Response, IEquatable<SearchResultsTableResponse>, IValidatableObject
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSearchResultsTableResponse {\n");
		sb.Append("  Columns: ").Append(Columns).Append('\n');
		sb.Append("  Rows: ").Append(Rows).Append('\n');
		sb.Append("  Sorting: ").Append(Sorting).Append('\n');
		sb.Append("  TotalRows: ").Append(TotalRows).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as SearchResultsTableResponse);
	}

	/// <summary>
	/// Returns true if SearchesSearchResultsTableResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSearchResultsTableResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SearchResultsTableResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Columns == other.Columns ||
					Columns != null &&
					Columns.SequenceEqual(other.Columns)
				) &&
				(
					Rows == other.Rows ||
					Rows != null &&
					Rows.SequenceEqual(other.Rows)
				) &&
				(
					Sorting == other.Sorting ||
					Sorting != null &&
					Sorting.SequenceEqual(other.Sorting)
				) &&
				(
					TotalRows == other.TotalRows ||
					TotalRows != null &&
					TotalRows.Equals(other.TotalRows)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
				);
	}

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
			if (Columns != null)
			{
				hash = hash * 59 + Columns.GetHashCode();
			}

			if (Rows != null)
			{
				hash = hash * 59 + Rows.GetHashCode();
			}

			if (Sorting != null)
			{
				hash = hash * 59 + Sorting.GetHashCode();
			}

			if (TotalRows != null)
			{
				hash = hash * 59 + TotalRows.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
