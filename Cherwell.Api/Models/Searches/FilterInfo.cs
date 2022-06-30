using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesFilterInfo
/// </summary>
[DataContract]
public partial class FilterInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FilterInfo" /> class.
	/// </summary>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="Operator">_Operator.</param>
	/// <param name="Value">Value.</param>
	public FilterInfo(string FieldId, string Operator, string Value)
	{
		this.FieldId = FieldId;
		this.Operator = Operator;
		this.Value = Value;
	}

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
