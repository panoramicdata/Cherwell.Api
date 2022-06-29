using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsRow
/// </summary>
[DataContract]
public partial class SearchResultsRow
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
