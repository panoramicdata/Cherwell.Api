using System.Diagnostics;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// FieldTemplateItem
/// </summary>
[DataContract]
[DebuggerDisplay("{Name} \"{DisplayName}\" ({FieldId}) = {Value}")]
public class FieldTemplateItem
{
	/// <summary>
	/// Dirty
	/// </summary>
	[DataMember(Name = "dirty", EmitDefaultValue = false)]
	public bool Dirty { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// FullFieldId
	/// </summary>
	[DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
	public string FullFieldId { get; set; } = null!;

	/// <summary>
	/// Html
	/// </summary>
	[DataMember(Name = "html", EmitDefaultValue = false)]
	public string Html { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; } = null!;
}