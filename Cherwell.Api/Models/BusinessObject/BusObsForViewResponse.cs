using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectBusObsForViewResponse
/// </summary>
[DataContract]
public partial class BusObsForViewResponse : Response, IEquatable<BusObsForViewResponse>, IValidatableObject
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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectBusObsForViewResponse {\n");
		sb.Append("  Summaries: ").Append(Summaries).Append('\n');
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
		return Equals(obj as BusObsForViewResponse);
	}

	/// <summary>
	/// Returns true if BusinessObjectBusObsForViewResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectBusObsForViewResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(BusObsForViewResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Summaries == other.Summaries ||
					Summaries != null &&
					Summaries.SequenceEqual(other.Summaries)
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
			if (Summaries != null)
			{
				hash = hash * 59 + Summaries.GetHashCode();
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