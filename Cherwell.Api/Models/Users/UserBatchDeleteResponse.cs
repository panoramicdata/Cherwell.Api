using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchDeleteResponse
/// </summary>
[DataContract]
public partial class UserBatchDeleteResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserDeleteResponse> Responses { get; set; } = null!;
}

