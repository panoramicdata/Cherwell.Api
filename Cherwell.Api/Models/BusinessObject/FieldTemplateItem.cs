using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// FieldTemplateItem
/// </summary>
[DataContract]
public partial class FieldTemplateItem
{
	/// <summary>
	/// Dirty
	/// </summary>
	[DataMember(Name = "dirty", EmitDefaultValue = false)]
	public bool? Dirty { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string? DisplayName { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string? FieldId { get; set; }

	/// <summary>
	/// FullFieldId
	/// </summary>
	[DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
	public string? FullFieldId { get; set; }

	/// <summary>
	/// Html
	/// </summary>
	[DataMember(Name = "html", EmitDefaultValue = false)]
	public string? Html { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string? Value { get; set; }
}