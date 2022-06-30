using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models;

/// <summary>
/// TrebuchetNameValuePair
/// </summary>
[DataContract]
public partial class TrebuchetNameValuePair
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TrebuchetNameValuePair" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="ValueObject">ValueObject.</param>
	/// <param name="ValueString">ValueString.</param>
	/// <param name="Category">Category.</param>
	/// <param name="Description">Description.</param>
	/// <param name="DisplayShowsValue">DisplayShowsValue.</param>
	/// <param name="SpecialUseFlag">SpecialUseFlag.</param>
	/// <param name="DisplayString">DisplayString.</param>
	public TrebuchetNameValuePair(string Name, Object ValueObject, string ValueString, string Category, string Description, bool? DisplayShowsValue, bool? SpecialUseFlag, string DisplayString)
	{
		this.Name = Name;
		this.ValueObject = ValueObject;
		this.ValueString = ValueString;
		this.Category = Category;
		this.Description = Description;
		this.DisplayShowsValue = DisplayShowsValue;
		this.SpecialUseFlag = SpecialUseFlag;
		this.DisplayString = DisplayString;
	}

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// ValueObject
	/// </summary>
	[DataMember(Name = "valueObject", EmitDefaultValue = false)]
	public Object ValueObject { get; set; }

	/// <summary>
	/// ValueString
	/// </summary>
	[DataMember(Name = "valueString", EmitDefaultValue = false)]
	public string ValueString { get; set; }

	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string Category { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// DisplayShowsValue
	/// </summary>
	[DataMember(Name = "displayShowsValue", EmitDefaultValue = false)]
	public bool? DisplayShowsValue { get; set; }

	/// <summary>
	/// SpecialUseFlag
	/// </summary>
	[DataMember(Name = "specialUseFlag", EmitDefaultValue = false)]
	public bool? SpecialUseFlag { get; set; }

	/// <summary>
	/// DisplayString
	/// </summary>
	[DataMember(Name = "displayString", EmitDefaultValue = false)]
	public string DisplayString { get; set; }
}