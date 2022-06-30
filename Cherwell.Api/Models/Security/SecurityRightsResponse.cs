using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityRightsResponse
/// </summary>
[DataContract]
public partial class SecurityRightsResponse : Response
{
	/// <summary>
	/// Rights
	/// </summary>
	[DataMember(Name = "rights", EmitDefaultValue = false)]
	public List<Right> Rights { get; set; } = null!;
}

