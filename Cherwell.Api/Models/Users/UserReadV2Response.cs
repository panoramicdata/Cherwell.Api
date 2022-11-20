using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserReadV2Response
/// </summary>
[DataContract]
public class UserReadV2Response : Response
{
	/// <summary>
	/// Users
	/// </summary>
	[DataMember(Name = "users", EmitDefaultValue = false)]
	public List<UserV2> Users { get; set; } = null!;
}

