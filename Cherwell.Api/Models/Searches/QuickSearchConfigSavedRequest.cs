using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesQuickSearchConfigSavedRequest
/// </summary>
[DataContract]
public partial class QuickSearchConfigSavedRequest : IEquatable<QuickSearchConfigSavedRequest>, IValidatableObject
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
	/// Gets or Sets StandIn
	/// </summary>
	[DataMember(Name = "standIn", EmitDefaultValue = false)]
	public string StandIn { get; set; }
	/// <summary>
	/// Gets or Sets BusObIds
	/// </summary>
	[DataMember(Name = "busObIds", EmitDefaultValue = false)]
	public List<string> BusObIds { get; set; }
	/// <summary>
	/// Gets or Sets IsGeneral
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
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as QuickSearchConfigSavedRequest);
	}

	/// <summary>
	/// Returns true if SearchesQuickSearchConfigSavedRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesQuickSearchConfigSavedRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(QuickSearchConfigSavedRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					StandIn == other.StandIn ||
					StandIn != null &&
					StandIn.Equals(other.StandIn, StringComparison.Ordinal)
				) &&
				(
					BusObIds == other.BusObIds ||
					BusObIds != null &&
					BusObIds.SequenceEqual(other.BusObIds)
				) &&
				(
					IsGeneral == other.IsGeneral ||
					IsGeneral != null &&
					IsGeneral.Equals(other.IsGeneral)
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
