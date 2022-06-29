using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldDefinition
/// </summary>
[DataContract]
public partial class FieldDefinition
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldDefinition" /> class.
	/// </summary>
	/// <param name="AutoFill">AutoFill.</param>
	/// <param name="Calculated">Calculated.</param>
	/// <param name="Category">Category.</param>
	/// <param name="DecimalDigits">DecimalDigits.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Details">Details.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="Enabled">Enabled.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="HasDate">HasDate.</param>
	/// <param name="HasTime">HasTime.</param>
	/// <param name="IsFullTextSearchable">IsFullTextSearchable.</param>
	/// <param name="MaximumSize">MaximumSize.</param>
	/// <param name="Name">Name.</param>
	/// <param name="ReadOnly">_ReadOnly.</param>
	/// <param name="Required">Required.</param>
	/// <param name="Type">Type.</param>
	/// <param name="TypeLocalized">TypeLocalized.</param>
	/// <param name="Validated">Validated.</param>
	/// <param name="WholeDigits">WholeDigits.</param>
	public FieldDefinition(bool? AutoFill, bool? Calculated, string Category, int? DecimalDigits, string Description, string Details, string DisplayName, bool? Enabled, string FieldId, bool? HasDate, bool? HasTime, bool? IsFullTextSearchable, string MaximumSize, string Name, bool? ReadOnly, bool? Required, string Type, string TypeLocalized, bool? Validated, int? WholeDigits)
	{
		this.AutoFill = AutoFill;
		this.Calculated = Calculated;
		this.Category = Category;
		this.DecimalDigits = DecimalDigits;
		this.Description = Description;
		this.Details = Details;
		this.DisplayName = DisplayName;
		this.Enabled = Enabled;
		this.FieldId = FieldId;
		this.HasDate = HasDate;
		this.HasTime = HasTime;
		this.IsFullTextSearchable = IsFullTextSearchable;
		this.MaximumSize = MaximumSize;
		this.Name = Name;
		this.ReadOnly = ReadOnly;
		this.Required = Required;
		this.Type = Type;
		this.TypeLocalized = TypeLocalized;
		this.Validated = Validated;
		this.WholeDigits = WholeDigits;
	}

	/// <summary>
	/// AutoFill
	/// </summary>
	[DataMember(Name = "autoFill", EmitDefaultValue = false)]
	public bool? AutoFill { get; set; }

	/// <summary>
	/// Calculated
	/// </summary>
	[DataMember(Name = "calculated", EmitDefaultValue = false)]
	public bool? Calculated { get; set; }

	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string Category { get; set; }

	/// <summary>
	/// DecimalDigits
	/// </summary>
	[DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
	public int? DecimalDigits { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Details
	/// </summary>
	[DataMember(Name = "details", EmitDefaultValue = false)]
	public string Details { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled", EmitDefaultValue = false)]
	public bool? Enabled { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// HasDate
	/// </summary>
	[DataMember(Name = "hasDate", EmitDefaultValue = false)]
	public bool? HasDate { get; set; }

	/// <summary>
	/// HasTime
	/// </summary>
	[DataMember(Name = "hasTime", EmitDefaultValue = false)]
	public bool? HasTime { get; set; }

	/// <summary>
	/// IsFullTextSearchable
	/// </summary>
	[DataMember(Name = "isFullTextSearchable", EmitDefaultValue = false)]
	public bool? IsFullTextSearchable { get; set; }

	/// <summary>
	/// MaximumSize
	/// </summary>
	[DataMember(Name = "maximumSize", EmitDefaultValue = false)]
	public string MaximumSize { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// _ReadOnly
	/// </summary>
	[DataMember(Name = "readOnly", EmitDefaultValue = false)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// Required
	/// </summary>
	[DataMember(Name = "required", EmitDefaultValue = false)]
	public bool? Required { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string Type { get; set; }

	/// <summary>
	/// TypeLocalized
	/// </summary>
	[DataMember(Name = "typeLocalized", EmitDefaultValue = false)]
	public string TypeLocalized { get; set; }

	/// <summary>
	/// Validated
	/// </summary>
	[DataMember(Name = "validated", EmitDefaultValue = false)]
	public bool? Validated { get; set; }

	/// <summary>
	/// WholeDigits
	/// </summary>
	[DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
	public int? WholeDigits { get; set; }
























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