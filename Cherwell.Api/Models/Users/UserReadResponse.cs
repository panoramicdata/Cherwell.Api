using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserReadResponse
/// </summary>
[DataContract]
public class UserReadResponse : Response
{
	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; } = null!;

	/// <summary>
	/// Users
	/// </summary>
	[DataMember(Name = "users", EmitDefaultValue = false)]
	public List<User> Users { get; set; } = null!;
}

