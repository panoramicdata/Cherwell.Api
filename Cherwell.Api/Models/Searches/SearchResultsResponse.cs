using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchResultsResponse
/// </summary>
[DataContract]
public partial class SearchResultsResponse : Response
{
	/// <summary>
	/// BusinessObjects
	/// </summary>
	[DataMember(Name = "businessObjects", EmitDefaultValue = false)]
	public List<ReadResponse> BusinessObjects { get; set; } = null!;
	/// <summary>
	/// HasPrompts
	/// </summary>
	[DataMember(Name = "hasPrompts", EmitDefaultValue = false)]
	public bool HasPrompts { get; set; }

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; } = null!;

	/// <summary>
	/// Prompts
	/// </summary>
	[DataMember(Name = "prompts", EmitDefaultValue = false)]
	public List<Prompt> Prompts { get; set; } = null!;
	/// <summary>
	/// SearchResultsFields
	/// </summary>
	[DataMember(Name = "searchResultsFields", EmitDefaultValue = false)]
	public List<Field> SearchResultsFields { get; set; } = null!;
	/// <summary>
	/// SimpleResults
	/// </summary>
	[DataMember(Name = "simpleResults", EmitDefaultValue = false)]
	public SimpleResultsList SimpleResults { get; set; } = null!;
	/// <summary>
	/// TotalRows
	/// </summary>
	[DataMember(Name = "totalRows", EmitDefaultValue = false)]
	public long TotalRows { get; set; }
	/// <summary>
	/// HasMoreRecords
	/// </summary>
	[DataMember(Name = "hasMoreRecords", EmitDefaultValue = false)]
	public bool HasMoreRecords { get; set; }
}
