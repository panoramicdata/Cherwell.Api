using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectTemplateRequest
/// </summary>
[DataContract]
public partial class TemplateRequest : IEquatable<TemplateRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TemplateRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="FieldNames">FieldNames.</param>
	/// <param name="FieldIds">FieldIds.</param>
	/// <param name="IncludeAll">IncludeAll.</param>
	/// <param name="IncludeRequired">IncludeRequired.</param>
	public TemplateRequest(string BusObId, List<string> FieldNames, List<string> FieldIds, bool? IncludeAll, bool? IncludeRequired)
	{
		this.BusObId = BusObId;
		this.FieldNames = FieldNames;
		this.FieldIds = FieldIds;
		this.IncludeAll = IncludeAll;
		this.IncludeRequired = IncludeRequired;
	}

	/// <summary>
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// Gets or Sets FieldNames
	/// </summary>
	[DataMember(Name = "fieldNames", EmitDefaultValue = false)]
	public List<string> FieldNames { get; set; }

	/// <summary>
	/// Gets or Sets FieldIds
	/// </summary>
	[DataMember(Name = "fieldIds", EmitDefaultValue = false)]
	public List<string> FieldIds { get; set; }

	/// <summary>
	/// Gets or Sets IncludeAll
	/// </summary>
	[DataMember(Name = "includeAll", EmitDefaultValue = false)]
	public bool? IncludeAll { get; set; }

	/// <summary>
	/// Gets or Sets IncludeRequired
	/// </summary>
	[DataMember(Name = "includeRequired", EmitDefaultValue = false)]
	public bool? IncludeRequired { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectTemplateRequest {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  FieldNames: ").Append(FieldNames).Append('\n');
		sb.Append("  FieldIds: ").Append(FieldIds).Append('\n');
		sb.Append("  IncludeAll: ").Append(IncludeAll).Append('\n');
		sb.Append("  IncludeRequired: ").Append(IncludeRequired).Append('\n');
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
		return Equals(obj as TemplateRequest);
	}

	/// <summary>
	/// Returns true if BusinessObjectTemplateRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectTemplateRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TemplateRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					FieldNames == other.FieldNames ||
					FieldNames != null &&
					FieldNames.SequenceEqual(other.FieldNames)
				) &&
				(
					FieldIds == other.FieldIds ||
					FieldIds != null &&
					FieldIds.SequenceEqual(other.FieldIds)
				) &&
				(
					IncludeAll == other.IncludeAll ||
					IncludeAll != null &&
					IncludeAll.Equals(other.IncludeAll)
				) &&
				(
					IncludeRequired == other.IncludeRequired ||
					IncludeRequired != null &&
					IncludeRequired.Equals(other.IncludeRequired)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (FieldNames != null)
			{
				hash = hash * 59 + FieldNames.GetHashCode();
			}

			if (FieldIds != null)
			{
				hash = hash * 59 + FieldIds.GetHashCode();
			}

			if (IncludeAll != null)
			{
				hash = hash * 59 + IncludeAll.GetHashCode();
			}

			if (IncludeRequired != null)
			{
				hash = hash * 59 + IncludeRequired.GetHashCode();
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