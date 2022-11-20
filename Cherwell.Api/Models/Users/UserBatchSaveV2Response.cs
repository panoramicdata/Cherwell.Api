using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveV2Response
/// </summary>
[DataContract]
public class UserBatchSaveV2Response : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserSaveV2Response> Responses { get; set; } = null!;
}

