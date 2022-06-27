using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchResponse
/// </summary>
[DataContract]
public partial class QuickSearchResponse : Response, IEquatable<QuickSearchResponse>, IValidatableObject
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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesQuickSearchResponse {\n");
		sb.Append("  SearchResultsTable: ").Append(SearchResultsTable).Append('\n');
		sb.Append("  SimpleResultsList: ").Append(SimpleResultsList).Append('\n');
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
		return Equals(obj as QuickSearchResponse);
	}

	/// <summary>
	/// Returns true if SearchesQuickSearchResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesQuickSearchResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(QuickSearchResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					SearchResultsTable == other.SearchResultsTable ||
					SearchResultsTable != null &&
					SearchResultsTable.Equals(other.SearchResultsTable)
				) &&
				(
					SimpleResultsList == other.SimpleResultsList ||
					SimpleResultsList != null &&
					SimpleResultsList.Equals(other.SimpleResultsList)
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
			if (SearchResultsTable != null)
			{
				hash = hash * 59 + SearchResultsTable.GetHashCode();
			}

			if (SimpleResultsList != null)
			{
				hash = hash * 59 + SimpleResultsList.GetHashCode();
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
