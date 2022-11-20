using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserListResponse
/// </summary>
[DataContract]
public class UserListResponse : Response
{
	/// <summary>
	/// Users
	/// </summary>
	[DataMember(Name = "users", EmitDefaultValue = false)]
	public List<UserV2> Users { get; set; } = null!;
}

