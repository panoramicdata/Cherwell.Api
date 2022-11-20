using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesFilterInfo
/// </summary>
[DataContract]
public class FilterInfo
{
	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// _Operator
	/// </summary>
	[DataMember(Name = "operator", EmitDefaultValue = false)]
	public string Operator { get; set; } = null!;

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; } = null!;
}
