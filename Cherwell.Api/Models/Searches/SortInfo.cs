using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSortInfo
/// </summary>
[DataContract]
public partial class SortInfo
{
	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;
	/// <summary>
	/// SortDirection
	/// </summary>
	[DataMember(Name = "sortDirection", EmitDefaultValue = false)]
	public int SortDirection { get; set; }
}
