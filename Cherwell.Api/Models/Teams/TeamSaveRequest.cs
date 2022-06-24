using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamSaveRequest
/// </summary>
[DataContract]
public partial class TeamSaveRequest : IEquatable<TeamSaveRequest>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets TeamType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumTeamType
	{

		/// <summary>
		/// Enum User for "User"
		/// </summary>
		[EnumMember(Value = "User")]
		User,

		/// <summary>
		/// Enum CustomerWorkgroup for "CustomerWorkgroup"
		/// </summary>
		[EnumMember(Value = "CustomerWorkgroup")]
		CustomerWorkgroup
	}

	/// <summary>
	/// Gets or Sets TeamType
	/// </summary>
	[DataMember(Name = "teamType", EmitDefaultValue = false)]
	public EnumTeamType? TeamType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="TeamSaveRequest" /> class.
	/// </summary>
	/// <param name="Description">Description.</param>
	/// <param name="EmailAlias">EmailAlias.</param>
	/// <param name="Image">Image.</param>
	/// <param name="TeamId">TeamId.</param>
	/// <param name="TeamName">TeamName.</param>
	/// <param name="TeamType">TeamType.</param>
	public TeamSaveRequest(string Description, string EmailAlias, string Image, string TeamId, string TeamName, EnumTeamType? TeamType)
	{
		this.Description = Description;
		this.EmailAlias = EmailAlias;
		this.Image = Image;
		this.TeamId = TeamId;
		this.TeamName = TeamName;
		this.TeamType = TeamType;
	}

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Gets or Sets EmailAlias
	/// </summary>
	[DataMember(Name = "emailAlias", EmitDefaultValue = false)]
	public string EmailAlias { get; set; }

	/// <summary>
	/// Gets or Sets Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string Image { get; set; }

	/// <summary>
	/// Gets or Sets TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// Gets or Sets TeamName
	/// </summary>
	[DataMember(Name = "teamName", EmitDefaultValue = false)]
	public string TeamName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TeamsTeamSaveRequest {\n");
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  EmailAlias: ").Append(EmailAlias).Append('\n');
		sb.Append("  Image: ").Append(Image).Append('\n');
		sb.Append("  TeamId: ").Append(TeamId).Append('\n');
		sb.Append("  TeamName: ").Append(TeamName).Append('\n');
		sb.Append("  TeamType: ").Append(TeamType).Append('\n');
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
		return Equals(obj as TeamSaveRequest);
	}

	/// <summary>
	/// Returns true if TeamSaveRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of TeamSaveRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TeamSaveRequest? other)
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
					EmailAlias == other.EmailAlias ||
					EmailAlias != null &&
					EmailAlias.Equals(other.EmailAlias, StringComparison.Ordinal)
				) &&
				(
					Image == other.Image ||
					Image != null &&
					Image.Equals(other.Image, StringComparison.Ordinal)
				) &&
				(
					TeamId == other.TeamId ||
					TeamId != null &&
					TeamId.Equals(other.TeamId, StringComparison.Ordinal)
				) &&
				(
					TeamName == other.TeamName ||
					TeamName != null &&
					TeamName.Equals(other.TeamName, StringComparison.Ordinal)
				) &&
				(
					TeamType == other.TeamType ||
					TeamType != null &&
					TeamType.Equals(other.TeamType)
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

			if (EmailAlias != null)
			{
				hash = hash * 59 + EmailAlias.GetHashCode();
			}

			if (Image != null)
			{
				hash = hash * 59 + Image.GetHashCode();
			}

			if (TeamId != null)
			{
				hash = hash * 59 + TeamId.GetHashCode();
			}

			if (TeamName != null)
			{
				hash = hash * 59 + TeamName.GetHashCode();
			}

			if (TeamType != null)
			{
				hash = hash * 59 + TeamType.GetHashCode();
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

