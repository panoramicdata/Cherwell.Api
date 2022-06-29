using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBusObsForViewResponse
/// </summary>
[DataContract]
public partial class BusObsForViewResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BusObsForViewResponse" /> class.
	/// </summary>
	/// <param name="Summaries">Summaries.</param>
	public BusObsForViewResponse(List<ViewSummary> Summaries)
	{
		this.Summaries = Summaries;
	}

	/// <summary>
	/// Summaries
	/// </summary>
	[DataMember(Name = "summaries", EmitDefaultValue = false)]
	public List<ViewSummary> Summaries { get; set; }







	
}