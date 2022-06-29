using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Forms;

/// <summary>
/// FormsSectionField
/// </summary>
[DataContract]
public partial class SectionField
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SectionField" /> class.
	/// </summary>
	/// <param name="attributes">Attributes.</param>
	/// <param name="fieldId">FieldId.</param>
	/// <param name="fieldType">FieldType.</param>
	/// <param name="label">Label.</param>
	/// <param name="multiline">Multiline.</param>
	/// <param name="value">Value.</param>
	public SectionField(
		List<object> attributes,
		string fieldId,
		string fieldType,
		string label,
		bool? multiline,
		string value)
	{
		Attributes = attributes;
		FieldId = fieldId;
		FieldType = fieldType;
		Label = label;
		Multiline = multiline;
		Value = value;
	}

	/// <summary>
	/// Attributes
	/// </summary>
	[DataMember(Name = "attributes", EmitDefaultValue = false)]
	public List<object> Attributes { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// FieldType
	/// </summary>
	[DataMember(Name = "fieldType", EmitDefaultValue = false)]
	public string FieldType { get; set; }

	/// <summary>
	/// Label
	/// </summary>
	[DataMember(Name = "label", EmitDefaultValue = false)]
	public string Label { get; set; }

	/// <summary>
	/// Multiline
	/// </summary>
	[DataMember(Name = "multiline", EmitDefaultValue = false)]
	public bool? Multiline { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public string Value { get; set; }










	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)



		}
	}

	
}
