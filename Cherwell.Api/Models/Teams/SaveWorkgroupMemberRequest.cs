using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// SaveWorkgroupMemberRequest
/// </summary>
[DataContract]
public partial class SaveWorkgroupMemberRequest : IEquatable<SaveWorkgroupMemberRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveWorkgroupMemberRequest" /> class.
	/// </summary>
	/// <param name="CustomerRecordId">CustomerRecordId.</param>
	/// <param name="WorkgroupId">WorkgroupId.</param>
	/// <param name="CustomerIsWorkgroupManager">CustomerIsWorkgroupManager.</param>
	public SaveWorkgroupMemberRequest(string CustomerRecordId, string WorkgroupId, bool? CustomerIsWorkgroupManager)
	{
		this.CustomerRecordId = CustomerRecordId;
		this.WorkgroupId = WorkgroupId;
		this.CustomerIsWorkgroupManager = CustomerIsWorkgroupManager;
	}

	/// <summary>
	/// Gets or Sets CustomerRecordId
	/// </summary>
	[DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
	public string CustomerRecordId { get; set; }
	/// <summary>
	/// Gets or Sets WorkgroupId
	/// </summary>
	[DataMember(Name = "workgroupId", EmitDefaultValue = false)]
	public string WorkgroupId { get; set; }
	/// <summary>
	/// Gets or Sets CustomerIsWorkgroupManager
	/// </summary>
	[DataMember(Name = "customerIsWorkgroupManager", EmitDefaultValue = false)]
	public bool? CustomerIsWorkgroupManager { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsSaveWorkgroupMemberRequest {\n");
		sb.Append("  CustomerRecordId: ").Append(CustomerRecordId).Append('\n');
		sb.Append("  WorkgroupId: ").Append(WorkgroupId).Append('\n');
		sb.Append("  CustomerIsWorkgroupManager: ").Append(CustomerIsWorkgroupManager).Append('\n');
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
		return Equals(obj as SaveWorkgroupMemberRequest);
	}

	/// <summary>
	/// Returns true if SaveWorkgroupMemberRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SaveWorkgroupMemberRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveWorkgroupMemberRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					CustomerRecordId == other.CustomerRecordId ||
					CustomerRecordId != null &&
					CustomerRecordId.Equals(other.CustomerRecordId, StringComparison.Ordinal)
				) &&
				(
					WorkgroupId == other.WorkgroupId ||
					WorkgroupId != null &&
					WorkgroupId.Equals(other.WorkgroupId, StringComparison.Ordinal)
				) &&
				(
					CustomerIsWorkgroupManager == other.CustomerIsWorkgroupManager ||
					CustomerIsWorkgroupManager != null &&
					CustomerIsWorkgroupManager.Equals(other.CustomerIsWorkgroupManager)
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
			if (CustomerRecordId != null)
			{
				hash = hash * 59 + CustomerRecordId.GetHashCode();
			}

			if (WorkgroupId != null)
			{
				hash = hash * 59 + WorkgroupId.GetHashCode();
			}

			if (CustomerIsWorkgroupManager != null)
			{
				hash = hash * 59 + CustomerIsWorkgroupManager.GetHashCode();
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

