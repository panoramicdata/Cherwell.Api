using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchReadResponse
/// </summary>
[DataContract]
public class UserBatchReadResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserReadV2Response> Responses { get; set; } = null!;
}

