using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityGroup
/// </summary>
[DataContract]
public partial class SecurityGroup : IEquatable<SecurityGroup>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SecurityGroup" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="GroupId">GroupId.</param>
	/// <param name="GroupName">GroupName.</param>
	public SecurityGroup(string Description, string GroupId, string GroupName)
	{
		this.Description = Description;
		this.GroupId = GroupId;
		this.GroupName = GroupName;
	}

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// GroupId
	/// </summary>
	[DataMember(Name = "groupId", EmitDefaultValue = false)]
	public string GroupId { get; set; }

	/// <summary>
	/// GroupName
	/// </summary>
	[DataMember(Name = "groupName", EmitDefaultValue = false)]
	public string GroupName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecuritySecurityGroup {\n");
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  GroupId: ").Append(GroupId).Append('\n');
		sb.Append("  GroupName: ").Append(GroupName).Append('\n');
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
		return Equals(obj as SecurityGroup);
	}

	/// <summary>
	/// Returns true if SecurityGroup instances are equal
	/// </summary>
	/// <param name="other">Instance of SecurityGroup to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SecurityGroup? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					GroupId == other.GroupId ||
					GroupId != null &&
					GroupId.Equals(other.GroupId, StringComparison.Ordinal)
				) &&
				(
					GroupName == other.GroupName ||
					GroupName != null &&
					GroupName.Equals(other.GroupName, StringComparison.Ordinal)
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
			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (GroupId != null)
			{
				hash = hash * 59 + GroupId.GetHashCode();
			}

			if (GroupName != null)
			{
				hash = hash * 59 + GroupName.GetHashCode();
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

