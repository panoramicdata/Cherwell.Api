using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchRequest
/// </summary>
[DataContract]
public partial class QuickSearchRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchRequest" /> class.
	/// </summary>
	/// <param name="BusObIds">BusObIds.</param>
	/// <param name="SearchText">SearchText.</param>
	public QuickSearchRequest(List<string> BusObIds, string SearchText)
	{
		this.BusObIds = BusObIds;
		this.SearchText = SearchText;
	}

	/// <summary>
	/// BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; }

	/// <summary>
	/// SearchText
	/// </summary>
	[DataMember(Name = "searchText", EmitDefaultValue = false)]
	public string SearchText { get; set; }






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
