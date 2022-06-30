using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSimpleResultsListGroup
/// </summary>
[DataContract]
public partial class SimpleResultsListGroup : Response
{
	/// <summary>
	/// IsBusObTarget
	/// </summary>
	[DataMember(Name = "isBusObTarget", EmitDefaultValue = false)]
	public bool? IsBusObTarget { get; set; }

	/// <summary>
	/// SimpleResultsListItems
	/// </summary>
	[DataMember(Name = "simpleResultsListItems", EmitDefaultValue = false)]
	public List<SimpleResultsListItem>? SimpleResultsListItems { get; set; }

	/// <summary>
	/// SubTitle
	/// </summary>
	[DataMember(Name = "subTitle", EmitDefaultValue = false)]
	public string? SubTitle { get; set; }

	/// <summary>
	/// TargetId
	/// </summary>
	[DataMember(Name = "targetId", EmitDefaultValue = false)]
	public string? TargetId { get; set; }

	/// <summary>
	/// Title
	/// </summary>
	[DataMember(Name = "title", EmitDefaultValue = false)]
	public string? Title { get; set; }
}
