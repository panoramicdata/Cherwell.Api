using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsRow
/// </summary>
[DataContract]
public partial class SearchResultsRow
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;
	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;
	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; } = null!;

	/// <summary>
	/// PublicId
	/// </summary>
	[DataMember(Name = "publicId", EmitDefaultValue = false)]
	public string PublicId { get; set; } = null!;
	/// <summary>
	/// RowColor
	/// </summary>
	[DataMember(Name = "rowColor", EmitDefaultValue = false)]
	public string RowColor { get; set; } = null!;
	/// <summary>
	/// SearchResultsFieldValues
	/// </summary>
	[DataMember(Name = "searchResultsFieldValues", EmitDefaultValue = false)]
	public List<FieldTemplateItem> SearchResultsFieldValues { get; set; } = null!;
}
