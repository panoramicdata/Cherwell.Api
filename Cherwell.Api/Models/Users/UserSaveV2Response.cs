using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserSaveV2Response
/// </summary>
[DataContract]
public partial class UserSaveV2Response : Response
{
	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string? BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string? BusObRecId { get; set; }
}