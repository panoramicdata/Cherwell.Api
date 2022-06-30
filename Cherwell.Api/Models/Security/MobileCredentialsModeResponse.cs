using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// MobileCredentialsModeResponse
/// </summary>
[DataContract]
public partial class MobileCredentialsModeResponse : Response
{
	/// <summary>
	/// CredentialsMode
	/// </summary>
	[DataMember(Name = "credentialsMode", EmitDefaultValue = false)]
	public int CredentialsMode { get; set; }
}
