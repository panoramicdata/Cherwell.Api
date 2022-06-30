using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusObsForViewResponse
/// </summary>
[DataContract]
public partial class BusObsForViewResponse : Response
{
	/// <summary>
	/// Summaries
	/// </summary>
	[DataMember(Name = "summaries", EmitDefaultValue = false)]
	public List<ViewSummary>? Summaries { get; set; }
}