using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// Prompt
/// </summary>
[DataContract]
public class Prompt
{
	/// <summary>
	/// ListDisplayOption
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumListDisplayOption
	{

		/// <summary>
		/// Enum Auto for "Auto"
		/// </summary>
		[EnumMember(Value = "Auto")]
		Auto,

		/// <summary>
		/// Enum Text for "Text"
		/// </summary>
		[EnumMember(Value = "Text")]
		Text,

		/// <summary>
		/// Enum Combo for "Combo"
		/// </summary>
		[EnumMember(Value = "Combo")]
		Combo,

		/// <summary>
		/// Enum GridList for "GridList"
		/// </summary>
		[EnumMember(Value = "GridList")]
		GridList,

		/// <summary>
		/// Enum SimpleList for "SimpleList"
		/// </summary>
		[EnumMember(Value = "SimpleList")]
		SimpleList,

		/// <summary>
		/// Enum PromptSimpleGrid for "PromptSimpleGrid"
		/// </summary>
		[EnumMember(Value = "PromptSimpleGrid")]
		PromptSimpleGrid
	}

	/// <summary>
	/// PromptType
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumPromptType
	{

		/// <summary>
		/// Enum None for "None"
		/// </summary>
		[EnumMember(Value = "None")]
		None,

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
		/// Enum DateTime for "DateTime"
		/// </summary>
		[EnumMember(Value = "DateTime")]
		DateTime,

		/// <summary>
		/// Enum Logical for "Logical"
		/// </summary>
		[EnumMember(Value = "Logical")]
		Logical,

		/// <summary>
		/// Enum Binary for "Binary"
		/// </summary>
		[EnumMember(Value = "Binary")]
		Binary,

		/// <summary>
		/// Enum DateOnly for "DateOnly"
		/// </summary>
		[EnumMember(Value = "DateOnly")]
		DateOnly,

		/// <summary>
		/// Enum TimeOnly for "TimeOnly"
		/// </summary>
		[EnumMember(Value = "TimeOnly")]
		TimeOnly,

		/// <summary>
		/// Enum Json for "Json"
		/// </summary>
		[EnumMember(Value = "Json")]
		Json,

		/// <summary>
		/// Enum JsonArray for "JsonArray"
		/// </summary>
		[EnumMember(Value = "JsonArray")]
		JsonArray,

		/// <summary>
		/// Enum Xml for "Xml"
		/// </summary>
		[EnumMember(Value = "Xml")]
		Xml,

		/// <summary>
		/// Enum XmlCollection for "XmlCollection"
		/// </summary>
		[EnumMember(Value = "XmlCollection")]
		XmlCollection,

		/// <summary>
		/// Enum TimeValue for "TimeValue"
		/// </summary>
		[EnumMember(Value = "TimeValue")]
		TimeValue
	}

	/// <summary>
	/// ListDisplayOption
	/// </summary>
	[DataMember(Name = "listDisplayOption", EmitDefaultValue = false)]
	public EnumListDisplayOption ListDisplayOption { get; set; }
	/// <summary>
	/// PromptType
	/// </summary>
	[DataMember(Name = "promptType", EmitDefaultValue = false)]
	public EnumPromptType PromptType { get; set; }
	/// <summary>
	/// AllowValuesOnly
	/// </summary>
	[DataMember(Name = "allowValuesOnly", EmitDefaultValue = false)]
	public bool AllowValuesOnly { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// CollectionStoreEntireRow
	/// </summary>
	[DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
	public string CollectionStoreEntireRow { get; set; } = null!;

	/// <summary>
	/// CollectionValueField
	/// </summary>
	[DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
	public string CollectionValueField { get; set; } = null!;

	/// <summary>
	/// ConstraintXml
	/// </summary>
	[DataMember(Name = "constraintXml", EmitDefaultValue = false)]
	public string ConstraintXml { get; set; } = null!;

	/// <summary>
	/// Contents
	/// </summary>
	[DataMember(Name = "contents", EmitDefaultValue = false)]
	public string Contents { get; set; } = null!;

	/// <summary>
	/// _Default
	/// </summary>
	[DataMember(Name = "default", EmitDefaultValue = false)]
	public string Default { get; set; } = null!;

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// IsDateRange
	/// </summary>
	[DataMember(Name = "isDateRange", EmitDefaultValue = false)]
	public bool IsDateRange { get; set; }

	/// <summary>
	/// ListReturnFieldId
	/// </summary>
	[DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
	public string ListReturnFieldId { get; set; } = null!;

	/// <summary>
	/// MultiLine
	/// </summary>
	[DataMember(Name = "multiLine", EmitDefaultValue = false)]
	public bool MultiLine { get; set; }

	/// <summary>
	/// PromptId
	/// </summary>
	[DataMember(Name = "promptId", EmitDefaultValue = false)]
	public string PromptId { get; set; } = null!;

	/// <summary>
	/// PromptTypeName
	/// </summary>
	[DataMember(Name = "promptTypeName", EmitDefaultValue = false)]
	public string PromptTypeName { get; set; } = null!;

	/// <summary>
	/// Required
	/// </summary>
	[DataMember(Name = "required", EmitDefaultValue = false)]
	public bool Required { get; set; }

	/// <summary>
	/// Text
	/// </summary>
	[DataMember(Name = "text", EmitDefaultValue = false)]
	public string Text { get; set; } = null!;

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public Object Value { get; set; } = null!;

	/// <summary>
	/// Values
	/// </summary>
	[DataMember(Name = "values", EmitDefaultValue = false)]
	public List<string> Values { get; set; } = null!;
}
