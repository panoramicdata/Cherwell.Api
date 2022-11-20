using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// ManagerData
/// </summary>
[DataContract]
public class ManagerData : Response
{
	/// <summary>
	/// Root
	/// </summary>
	[DataMember(Name = "root", EmitDefaultValue = false)]
	public ManagerFolder Root { get; set; } = null!;

	/// <summary>
	/// SupportedAssociations
	/// </summary>
	[DataMember(Name = "supportedAssociations", EmitDefaultValue = false)]
	public List<TrebuchetNameValuePair> SupportedAssociations { get; set; } = null!;
}
