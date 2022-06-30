using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchDeleteV2Response
/// </summary>
[DataContract]
public partial class UserBatchDeleteV2Response : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserDeleteV2Response>? Responses { get; set; }
}

