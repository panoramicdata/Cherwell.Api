using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Teams;

/// <summary>
/// TeamResponse
/// </summary>
[DataContract]
public class TeamResponse : Response
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
	public EnumTeamType TeamType { get; set; }
	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; } = null!;

	/// <summary>
	/// EmailAlias
	/// </summary>
	[DataMember(Name = "emailAlias", EmitDefaultValue = false)]
	public string EmailAlias { get; set; } = null!;

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; } = null!;

	/// <summary>
	/// Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string Image { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// TeamId
	/// </summary>
	[DataMember(Name = "teamId", EmitDefaultValue = false)]
	public string TeamId { get; set; } = null!;
}

