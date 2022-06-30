using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveResponse
/// </summary>
[DataContract]
public partial class UserBatchSaveResponse : Response
{
	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserSaveResponse> Responses { get; set; } = null!;
}

