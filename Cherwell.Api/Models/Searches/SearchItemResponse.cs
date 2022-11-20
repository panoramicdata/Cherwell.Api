using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSearchItemResponse
/// </summary>
[DataContract]
public class SearchItemResponse : Response
{
	/// <summary>
	/// Root
	/// </summary>
	[DataMember(Name = "root", EmitDefaultValue = false)]
	public SearchFolder Root { get; set; } = null!;

	/// <summary>
	/// SupportedAssociations
	/// </summary>
	[DataMember(Name = "supportedAssociations", EmitDefaultValue = false)]
	public List<Association> SupportedAssociations { get; set; } = null!;
}
