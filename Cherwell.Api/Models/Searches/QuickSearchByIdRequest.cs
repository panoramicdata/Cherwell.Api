using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchByIdRequest
/// </summary>
[DataContract]
public partial class QuickSearchByIdRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchByIdRequest" /> class.
	/// </summary>
	/// <param name="BusObIds">BusObIds.</param>
	/// <param name="IsGeneral">IsGeneral.</param>
	/// <param name="SearchText">SearchText.</param>
	/// <param name="StandIn">StandIn.</param>
	public QuickSearchByIdRequest(List<string> BusObIds, bool? IsGeneral, string SearchText, string StandIn)
	{
		this.BusObIds = BusObIds;
		this.IsGeneral = IsGeneral;
		this.SearchText = SearchText;
		this.StandIn = StandIn;
	}

	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; }

	/// <summary>
	/// IsGeneral
	/// </summary>
	[DataMember(Name = "isGeneral", EmitDefaultValue = false)]
	public bool? IsGeneral { get; set; }

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; }

	/// <summary>
	/// StandIn
	/// </summary>
	[DataMember(Name = "standIn", EmitDefaultValue = false)]
	public string StandIn { get; set; }








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
