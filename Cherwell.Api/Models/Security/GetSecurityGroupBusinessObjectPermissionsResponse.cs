using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetSecurityGroupBusinessObjectPermissionsResponse
/// </summary>
[DataContract]
public class GetSecurityGroupBusinessObjectPermissionsResponse : Response
{
	/// <summary>
	/// BusinessObjectPermissions
	/// </summary>
	[DataMember(Name = "businessObjectPermissions", EmitDefaultValue = false)]
	public List<BusinessObjectPermission> BusinessObjectPermissions { get; set; } = null!;
}
