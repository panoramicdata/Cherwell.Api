using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsRow
/// </summary>
[DataContract]
public partial class SearchResultsRow : IEquatable<SearchResultsRow>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SearchResultsRow" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Links">Links.</param>
	/// <param name="PublicId">PublicId.</param>
	/// <param name="RowColor">RowColor.</param>
	/// <param name="SearchResultsFieldValues">SearchResultsFieldValues.</param>
	public SearchResultsRow(string BusObId, string BusObRecId, List<Link> Links, string PublicId, string RowColor, List<FieldTemplateItem> SearchResultsFieldValues)
	{
		this.BusObId = BusObId;
		this.BusObRecId = BusObRecId;
		this.Links = Links;
		this.PublicId = PublicId;
		this.RowColor = RowColor;
		this.SearchResultsFieldValues = SearchResultsFieldValues;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }

	/// <summary>
	/// PublicId
	/// </summary>
	[DataMember(Name = "publicId", EmitDefaultValue = false)]
	public string PublicId { get; set; }

	/// <summary>
	/// RowColor
	/// </summary>
	[DataMember(Name = "rowColor", EmitDefaultValue = false)]
	public string RowColor { get; set; }

	/// <summary>
	/// SearchResultsFieldValues
	/// </summary>
	[DataMember(Name = "searchResultsFieldValues", EmitDefaultValue = false)]
	public List<FieldTemplateItem> SearchResultsFieldValues { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSearchResultsRow {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  PublicId: ").Append(PublicId).Append('\n');
		sb.Append("  RowColor: ").Append(RowColor).Append('\n');
		sb.Append("  SearchResultsFieldValues: ").Append(SearchResultsFieldValues).Append('\n');
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
		return Equals(obj as SearchResultsRow);
	}

	/// <summary>
	/// Returns true if SearchesSearchResultsRow instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesSearchResultsRow to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SearchResultsRow? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObRecId == other.BusObRecId ||
					BusObRecId != null &&
					BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
				) &&
				(
					PublicId == other.PublicId ||
					PublicId != null &&
					PublicId.Equals(other.PublicId, StringComparison.Ordinal)
				) &&
				(
					RowColor == other.RowColor ||
					RowColor != null &&
					RowColor.Equals(other.RowColor, StringComparison.Ordinal)
				) &&
				(
					SearchResultsFieldValues == other.SearchResultsFieldValues ||
					SearchResultsFieldValues != null &&
					SearchResultsFieldValues.SequenceEqual(other.SearchResultsFieldValues)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (PublicId != null)
			{
				hash = hash * 59 + PublicId.GetHashCode();
			}

			if (RowColor != null)
			{
				hash = hash * 59 + RowColor.GetHashCode();
			}

			if (SearchResultsFieldValues != null)
			{
				hash = hash * 59 + SearchResultsFieldValues.GetHashCode();
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
