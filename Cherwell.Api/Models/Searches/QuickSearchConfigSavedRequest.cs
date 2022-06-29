using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigSavedRequest
/// </summary>
[DataContract]
public partial class QuickSearchConfigSavedRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="QuickSearchConfigSavedRequest" /> class.
	/// </summary>
	/// <param name="StandIn">StandIn.</param>
	/// <param name="BusObIds">BusObIds.</param>
	/// <param name="IsGeneral">IsGeneral.</param>
	public QuickSearchConfigSavedRequest(string StandIn, List<string> BusObIds, bool? IsGeneral)
	{
		this.StandIn = StandIn;
		this.BusObIds = BusObIds;
		this.IsGeneral = IsGeneral;
	}

	/// <summary>
	/// StandIn
	/// </summary>
	[DataMember(Name = "standIn", EmitDefaultValue = false)]
	public string StandIn { get; set; }

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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesQuickSearchConfigSavedRequest {\n");
		sb.Append("  StandIn: ").Append(StandIn).Append('\n');
		sb.Append("  BusObIds: ").Append(BusObIds).Append('\n');
		sb.Append("  IsGeneral: ").Append(IsGeneral).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

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
			if (StandIn != null)
			{
				hash = hash * 59 + StandIn.GetHashCode();
			}

			if (BusObIds != null)
			{
				hash = hash * 59 + BusObIds.GetHashCode();
			}

			if (IsGeneral != null)
			{
				hash = hash * 59 + IsGeneral.GetHashCode();
			}

			return hash;
		}
	}

	
}
