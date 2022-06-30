using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserDeleteV2Response
/// </summary>
[DataContract]
public partial class UserDeleteV2Response : Response
{
	/// <summary>
	/// UserRecordId
	/// </summary>
	[DataMember(Name = "userRecordId", EmitDefaultValue = false)]
	public string? UserRecordId { get; set; }
}

