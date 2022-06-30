using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesColumnSchema
/// </summary>
[DataContract]
public partial class ColumnSchema
{
	/// <summary>
	/// Type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumType
	{

		/// <summary>
		/// Enum Text for "Text"
		/// </summary>
		[EnumMember(Value = "Text")]
		Text,

		/// <summary>
		/// Enum Number for "Number"
		/// </summary>
		[EnumMember(Value = "Number")]
		Number,

		/// <summary>
		/// Enum Currency for "Currency"
		/// </summary>
		[EnumMember(Value = "Currency")]
		Currency,

		/// <summary>
		/// Enum Integer for "Integer"
		/// </summary>
		[EnumMember(Value = "Integer")]
		EnumInteger,

		/// <summary>
		/// Enum Datetime for "Datetime"
		/// </summary>
		[EnumMember(Value = "Datetime")]
		Datetime,

		/// <summary>
		/// Enum Date for "Date"
		/// </summary>
		[EnumMember(Value = "Date")]
		Date,

		/// <summary>
		/// Enum Time for "Time"
		/// </summary>
		[EnumMember(Value = "Time")]
		Time,

		/// <summary>
		/// Enum Logical for "Logical"
		/// </summary>
		[EnumMember(Value = "Logical")]
		Logical
	}

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public EnumType? Type { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string? Name { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string? FieldId { get; set; }
}
