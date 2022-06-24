using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsResponse
/// </summary>
[DataContract]
public partial class SearchResultsResponse : IEquatable<SearchResultsResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="SearchResultsResponse" /> class.
	/// </summary>
	/// <param name="BusinessObjects">BusinessObjects.</param>
	/// <param name="HasPrompts">HasPrompts.</param>
	/// <param name="Links">Links.</param>
	/// <param name="Prompts">Prompts.</param>
	/// <param name="SearchResultsFields">SearchResultsFields.</param>
	/// <param name="SimpleResults">SimpleResults.</param>
	/// <param name="TotalRows">TotalRows.</param>
	/// <param name="HasMoreRecords">HasMoreRecords.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SearchResultsResponse(List<ReadResponse> BusinessObjects, bool? HasPrompts, List<Link> Links, List<Prompt> Prompts, List<Field> SearchResultsFields, SimpleResultsList SimpleResults, long? TotalRows, bool? HasMoreRecords, string ErrorCode, string ErrorMessage, bool? HasError, EnumHttpStatusCode? HttpStatusCode)
	{
		this.BusinessObjects = BusinessObjects;
		this.HasPrompts = HasPrompts;
		this.Links = Links;
		this.Prompts = Prompts;
		this.SearchResultsFields = SearchResultsFields;
		this.SimpleResults = SimpleResults;
		this.TotalRows = TotalRows;
		this.HasMoreRecords = HasMoreRecords;
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Gets or Sets BusinessObjects
	/// </summary>
	[DataMember(Name = "businessObjects", EmitDefaultValue = false)]
	public List<ReadResponse> BusinessObjects { get; set; }

	/// <summary>
	/// Gets or Sets HasPrompts
	/// </summary>
	[DataMember(Name = "hasPrompts", EmitDefaultValue = false)]
	public bool? HasPrompts { get; set; }

	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }

	/// <summary>
	/// Gets or Sets Prompts
	/// </summary>
	[DataMember(Name = "prompts", EmitDefaultValue = false)]
	public List<Prompt> Prompts { get; set; }

	/// <summary>
	/// Gets or Sets SearchResultsFields
	/// </summary>
	[DataMember(Name = "searchResultsFields", EmitDefaultValue = false)]
	public List<Field> SearchResultsFields { get; set; }

	/// <summary>
	/// Gets or Sets SimpleResults
	/// </summary>
	[DataMember(Name = "simpleResults", EmitDefaultValue = false)]
	public SimpleResultsList SimpleResults { get; set; }

	/// <summary>
	/// Gets or Sets TotalRows
	/// </summary>
	[DataMember(Name = "totalRows", EmitDefaultValue = false)]
	public long? TotalRows { get; set; }

	/// <summary>
	/// Gets or Sets HasMoreRecords
	/// </summary>
	[DataMember(Name = "hasMoreRecords", EmitDefaultValue = false)]
	public bool? HasMoreRecords { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSearchResultsResponse {\n");
		sb.Append("  BusinessObjects: ").Append(BusinessObjects).Append('\n');
		sb.Append("  HasPrompts: ").Append(HasPrompts).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  Prompts: ").Append(Prompts).Append('\n');
		sb.Append("  SearchResultsFields: ").Append(SearchResultsFields).Append('\n');
		sb.Append("  SimpleResults: ").Append(SimpleResults).Append('\n');
		sb.Append("  TotalRows: ").Append(TotalRows).Append('\n');
		sb.Append("  HasMoreRecords: ").Append(HasMoreRecords).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as SearchResultsResponse);
	}

	/// <summary>
	/// Returns true if SearchesSearchResultsResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSearchResultsResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SearchResultsResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusinessObjects == other.BusinessObjects ||
					BusinessObjects != null &&
					BusinessObjects.SequenceEqual(other.BusinessObjects)
				) &&
				(
					HasPrompts == other.HasPrompts ||
					HasPrompts != null &&
					HasPrompts.Equals(other.HasPrompts)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
				) &&
				(
					Prompts == other.Prompts ||
					Prompts != null &&
					Prompts.SequenceEqual(other.Prompts)
				) &&
				(
					SearchResultsFields == other.SearchResultsFields ||
					SearchResultsFields != null &&
					SearchResultsFields.SequenceEqual(other.SearchResultsFields)
				) &&
				(
					SimpleResults == other.SimpleResults ||
					SimpleResults != null &&
					SimpleResults.Equals(other.SimpleResults)
				) &&
				(
					TotalRows == other.TotalRows ||
					TotalRows != null &&
					TotalRows.Equals(other.TotalRows)
				) &&
				(
					HasMoreRecords == other.HasMoreRecords ||
					HasMoreRecords != null &&
					HasMoreRecords.Equals(other.HasMoreRecords)
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
			if (BusinessObjects != null)
			{
				hash = hash * 59 + BusinessObjects.GetHashCode();
			}

			if (HasPrompts != null)
			{
				hash = hash * 59 + HasPrompts.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (Prompts != null)
			{
				hash = hash * 59 + Prompts.GetHashCode();
			}

			if (SearchResultsFields != null)
			{
				hash = hash * 59 + SearchResultsFields.GetHashCode();
			}

			if (SimpleResults != null)
			{
				hash = hash * 59 + SimpleResults.GetHashCode();
			}

			if (TotalRows != null)
			{
				hash = hash * 59 + TotalRows.GetHashCode();
			}

			if (HasMoreRecords != null)
			{
				hash = hash * 59 + HasMoreRecords.GetHashCode();
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
