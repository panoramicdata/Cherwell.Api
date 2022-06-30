using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserDeleteResponse
/// </summary>
[DataContract]
public partial class UserDeleteResponse : Response
{
	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string? Error { get; set; }

	/// <summary>
	/// Users
	/// </summary>
	[DataMember(Name = "users", EmitDefaultValue = false)]
	public List<User>? Users { get; set; }
}

