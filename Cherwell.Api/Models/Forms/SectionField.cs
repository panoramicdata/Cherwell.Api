using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsSectionField
/// </summary>
[DataContract]
public partial class SectionField
{
	/// <summary>
	/// Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	public List<object> Attributes { get; set; } = null!;
	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;
	/// <summary>
	/// FieldType
	/// </summary>
	[DataMember(Name = "fieldType", EmitDefaultValue = false)]
	public string FieldType { get; set; } = null!;
	/// <summary>
	/// Label
	/// </summary>
	[DataMember(Name = "label", EmitDefaultValue = false)]
	public string Label { get; set; } = null!;
	/// <summary>
	/// Multiline
	/// </summary>
	[DataMember(Name = "multiline", EmitDefaultValue = false)]
	public bool Multiline { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; } = null!;
}
