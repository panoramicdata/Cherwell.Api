using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SecurityRightCategoriesResponse
/// </summary>
[DataContract]
public partial class SecurityRightCategoriesResponse : Response
{
	/// <summary>
	/// RightCategories
	/// </summary>
	[DataMember(Name = "rightCategories", EmitDefaultValue = false)]
	public List<RightCategory> RightCategories { get; set; } = null!;
}

