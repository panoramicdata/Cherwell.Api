using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// RightCategory
/// </summary>
[DataContract]
public partial class RightCategory
{
	/// <summary>
	/// CategoryDescription
	/// </summary>
	[DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
	public string CategoryDescription { get; set; } = null!;

	/// <summary>
	/// CategoryId
	/// </summary>
	[DataMember(Name = "categoryId", EmitDefaultValue = false)]
	public string CategoryId { get; set; } = null!;

	/// <summary>
	/// CategoryName
	/// </summary>
	[DataMember(Name = "categoryName", EmitDefaultValue = false)]
	public string CategoryName { get; set; } = null!;
}

