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
public partial class TeamSaveRequest
{
	/// <summary>
	/// TeamType
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
	/// TeamType
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
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// EmailAlias
	/// </summary>
	[DataMember(Name = "emailAlias", EmitDefaultValue = false)]
	public string EmailAlias { get; set; }

	/// <summary>
	/// Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string Image { get; set; }

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; }

	/// <summary>
	/// TeamName
	/// </summary>
	[DataMember(Name = "teamName", EmitDefaultValue = false)]
	public string TeamName { get; set; }
}

