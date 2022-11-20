using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models;

/// <summary>
/// TrebuchetNameValuePair
/// </summary>
[DataContract]
public class TrebuchetNameValuePair
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; } = null!;

	/// <summary>
	/// ValueObject
	/// </summary>
	[DataMember(Name = "valueObject", EmitDefaultValue = false)]
	public Object ValueObject { get; set; } = null!;

	/// <summary>
	/// ValueString
	/// </summary>
	[DataMember(Name = "valueString", EmitDefaultValue = false)]
	public string ValueString { get; set; } = null!;

	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string Category { get; set; } = null!;

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; } = null!;

	/// <summary>
	/// DisplayShowsValue
	/// </summary>
	[DataMember(Name = "displayShowsValue", EmitDefaultValue = false)]
	public bool DisplayShowsValue { get; set; }

	/// <summary>
	/// SpecialUseFlag
	/// </summary>
	[DataMember(Name = "specialUseFlag", EmitDefaultValue = false)]
	public bool SpecialUseFlag { get; set; }

	/// <summary>
	/// DisplayString
	/// </summary>
	[DataMember(Name = "displayString", EmitDefaultValue = false)]
	public string DisplayString { get; set; } = null!;
}