using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSimpleResultsList
/// </summary>
[DataContract]
public partial class SimpleResultsList : Response
{
	/// <summary>
	/// Groups
	/// </summary>
	[DataMember(Name = "groups", EmitDefaultValue = false)]
	public List<SimpleResultsListGroup>? Groups { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string? Title { get; set; }
}
