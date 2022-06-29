using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldTemplateItem
/// </summary>
[DataContract]
public partial class FieldTemplateItem
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldTemplateItem" /> class.
	/// </summary>
	/// <param name="Dirty">Dirty.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="FullFieldId">FullFieldId.</param>
	/// <param name="Html">Html.</param>
	/// <param name="Name">Name.</param>
	/// <param name="Value">Value.</param>
	public FieldTemplateItem(bool? Dirty, string DisplayName, string FieldId, string FullFieldId, string Html, string Name, string Value)
	{
		this.Dirty = Dirty;
		this.DisplayName = DisplayName;
		this.FieldId = FieldId;
		this.FullFieldId = FullFieldId;
		this.Html = Html;
		this.Name = Name;
		this.Value = Value;
	}

	/// <summary>
	/// Dirty
	/// </summary>
	[DataMember(Name = "dirty", EmitDefaultValue = false)]
	public bool? Dirty { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// FullFieldId
	/// </summary>
	[DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
	public string FullFieldId { get; set; }

	/// <summary>
	/// Html
	/// </summary>
	[DataMember(Name = "html", EmitDefaultValue = false)]
	public string Html { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; }
}