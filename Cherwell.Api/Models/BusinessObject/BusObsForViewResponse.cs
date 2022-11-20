using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusObsForViewResponse
/// </summary>
[DataContract]
public class BusObsForViewResponse : Response
{
	/// <summary>
	/// Summaries
	/// </summary>
	[DataMember(Name = "summaries", EmitDefaultValue = false)]
	public List<ViewSummary> Summaries { get; set; } = null!;
}