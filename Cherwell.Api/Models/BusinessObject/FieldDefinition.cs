using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// FieldDefinition
/// </summary>
[DataContract]
public partial class FieldDefinition
{
	/// <summary>
	/// AutoFill
	/// </summary>
	[DataMember(Name = "autoFill", EmitDefaultValue = false)]
	public bool AutoFill { get; set; }

	/// <summary>
	/// Calculated
	/// </summary>
	[DataMember(Name = "calculated", EmitDefaultValue = false)]
	public bool Calculated { get; set; }

	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string Category { get; set; } = null!;

	/// <summary>
	/// DecimalDigits
	/// </summary>
	[DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
	public int DecimalDigits { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; } = null!;

	/// <summary>
	/// Details
	/// </summary>
	[DataMember(Name = "details", EmitDefaultValue = false)]
	public string Details { get; set; } = null!;

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; } = null!;

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled", EmitDefaultValue = false)]
	public bool Enabled { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// HasDate
	/// </summary>
	[DataMember(Name = "hasDate", EmitDefaultValue = false)]
	public bool HasDate { get; set; }

	/// <summary>
	/// HasTime
	/// </summary>
	[DataMember(Name = "hasTime", EmitDefaultValue = false)]
	public bool HasTime { get; set; }

	/// <summary>
	/// IsFullTextSearchable
	/// </summary>
	[DataMember(Name = "isFullTextSearchable", EmitDefaultValue = false)]
	public bool IsFullTextSearchable { get; set; }

	/// <summary>
	/// MaximumSize
	/// </summary>
	[DataMember(Name = "maximumSize", EmitDefaultValue = false)]
	public string MaximumSize { get; set; } = null!;

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// _ReadOnly
	/// </summary>
	[DataMember(Name = "readOnly", EmitDefaultValue = false)]
	public bool ReadOnly { get; set; }

	/// <summary>
	/// Required
	/// </summary>
	[DataMember(Name = "required", EmitDefaultValue = false)]
	public bool Required { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string Type { get; set; } = null!;

	/// <summary>
	/// TypeLocalized
	/// </summary>
	[DataMember(Name = "typeLocalized", EmitDefaultValue = false)]
	public string TypeLocalized { get; set; } = null!;

	/// <summary>
	/// Validated
	/// </summary>
	[DataMember(Name = "validated", EmitDefaultValue = false)]
	public bool Validated { get; set; }

	/// <summary>
	/// WholeDigits
	/// </summary>
	[DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
	public int WholeDigits { get; set; }
}