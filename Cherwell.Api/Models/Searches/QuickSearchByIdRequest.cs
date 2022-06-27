using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchByIdRequest
/// </summary>
[DataContract]
public partial class QuickSearchByIdRequest : IEquatable<QuickSearchByIdRequest>, IValidatableObject
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesQuickSearchByIdRequest {\n");
		sb.Append("  BusObIds: ").Append(BusObIds).Append('\n');
		sb.Append("  IsGeneral: ").Append(IsGeneral).Append('\n');
		sb.Append("  SearchText: ").Append(SearchText).Append('\n');
		sb.Append("  StandIn: ").Append(StandIn).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as QuickSearchByIdRequest);
	}

	/// <summary>
	/// Returns true if SearchesQuickSearchByIdRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesQuickSearchByIdRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(QuickSearchByIdRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObIds == other.BusObIds ||
					BusObIds != null &&
					BusObIds.SequenceEqual(other.BusObIds)
				) &&
				(
					IsGeneral == other.IsGeneral ||
					IsGeneral != null &&
					IsGeneral.Equals(other.IsGeneral)
				) &&
				(
					SearchText == other.SearchText ||
					SearchText != null &&
					SearchText.Equals(other.SearchText, StringComparison.Ordinal)
				) &&
				(
					StandIn == other.StandIn ||
					StandIn != null &&
					StandIn.Equals(other.StandIn, StringComparison.Ordinal)
				);
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
			if (BusObIds != null)
			{
				hash = hash * 59 + BusObIds.GetHashCode();
			}

			if (IsGeneral != null)
			{
				hash = hash * 59 + IsGeneral.GetHashCode();
			}

			if (SearchText != null)
			{
				hash = hash * 59 + SearchText.GetHashCode();
			}

			if (StandIn != null)
			{
				hash = hash * 59 + StandIn.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
