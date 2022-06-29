using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CorePrompt
/// </summary>
[DataContract]
public partial class Prompt
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
	public EnumListDisplayOption? ListDisplayOption { get; set; }

	/// <summary>
	/// PromptType
	/// </summary>
	[DataMember(Name = "promptType", EmitDefaultValue = false)]
	public EnumPromptType? PromptType { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Prompt" /> class.
	/// </summary>
	/// <param name="AllowValuesOnly">AllowValuesOnly.</param>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="CollectionStoreEntireRow">CollectionStoreEntireRow.</param>
	/// <param name="CollectionValueField">CollectionValueField.</param>
	/// <param name="ConstraintXml">ConstraintXml.</param>
	/// <param name="Contents">Contents.</param>
	/// <param name="Default">_Default.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="IsDateRange">IsDateRange.</param>
	/// <param name="ListDisplayOption">ListDisplayOption.</param>
	/// <param name="ListReturnFieldId">ListReturnFieldId.</param>
	/// <param name="MultiLine">MultiLine.</param>
	/// <param name="PromptId">PromptId.</param>
	/// <param name="PromptType">PromptType.</param>
	/// <param name="PromptTypeName">PromptTypeName.</param>
	/// <param name="Required">Required.</param>
	/// <param name="Text">Text.</param>
	/// <param name="Value">Value.</param>
	/// <param name="Values">Values.</param>
	public Prompt(bool? AllowValuesOnly, string BusObId, string CollectionStoreEntireRow, string CollectionValueField, string ConstraintXml, string Contents, string Default, string FieldId, bool? IsDateRange, EnumListDisplayOption? ListDisplayOption, string ListReturnFieldId, bool? MultiLine, string PromptId, EnumPromptType? PromptType, string PromptTypeName, bool? Required, string Text, Object Value, List<string> Values)
	{
		this.AllowValuesOnly = AllowValuesOnly;
		this.BusObId = BusObId;
		this.CollectionStoreEntireRow = CollectionStoreEntireRow;
		this.CollectionValueField = CollectionValueField;
		this.ConstraintXml = ConstraintXml;
		this.Contents = Contents;
		this.Default = Default;
		this.FieldId = FieldId;
		this.IsDateRange = IsDateRange;
		this.ListDisplayOption = ListDisplayOption;
		this.ListReturnFieldId = ListReturnFieldId;
		this.MultiLine = MultiLine;
		this.PromptId = PromptId;
		this.PromptType = PromptType;
		this.PromptTypeName = PromptTypeName;
		this.Required = Required;
		this.Text = Text;
		this.Value = Value;
		this.Values = Values;
	}

	/// <summary>
	/// AllowValuesOnly
	/// </summary>
	[DataMember(Name = "allowValuesOnly", EmitDefaultValue = false)]
	public bool? AllowValuesOnly { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// CollectionStoreEntireRow
	/// </summary>
	[DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
	public string CollectionStoreEntireRow { get; set; }

	/// <summary>
	/// CollectionValueField
	/// </summary>
	[DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
	public string CollectionValueField { get; set; }

	/// <summary>
	/// ConstraintXml
	/// </summary>
	[DataMember(Name = "constraintXml", EmitDefaultValue = false)]
	public string ConstraintXml { get; set; }

	/// <summary>
	/// Contents
	/// </summary>
	[DataMember(Name = "contents", EmitDefaultValue = false)]
	public string Contents { get; set; }

	/// <summary>
	/// _Default
	/// </summary>
	[DataMember(Name = "default", EmitDefaultValue = false)]
	public string Default { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// IsDateRange
	/// </summary>
	[DataMember(Name = "isDateRange", EmitDefaultValue = false)]
	public bool? IsDateRange { get; set; }

	/// <summary>
	/// ListReturnFieldId
	/// </summary>
	[DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
	public string ListReturnFieldId { get; set; }

	/// <summary>
	/// MultiLine
	/// </summary>
	[DataMember(Name = "multiLine", EmitDefaultValue = false)]
	public bool? MultiLine { get; set; }

	/// <summary>
	/// PromptId
	/// </summary>
	[DataMember(Name = "promptId", EmitDefaultValue = false)]
	public string PromptId { get; set; }

	/// <summary>
	/// PromptTypeName
	/// </summary>
	[DataMember(Name = "promptTypeName", EmitDefaultValue = false)]
	public string PromptTypeName { get; set; }

	/// <summary>
	/// Required
	/// </summary>
	[DataMember(Name = "required", EmitDefaultValue = false)]
	public bool? Required { get; set; }

	/// <summary>
	/// Text
	/// </summary>
	[DataMember(Name = "text", EmitDefaultValue = false)]
	public string Text { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public Object Value { get; set; }

	/// <summary>
	/// Values
	/// </summary>
	[DataMember(Name = "values", EmitDefaultValue = false)]
	public List<string> Values { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CorePrompt {\n");
		sb.Append("  AllowValuesOnly: ").Append(AllowValuesOnly).Append('\n');
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  CollectionStoreEntireRow: ").Append(CollectionStoreEntireRow).Append('\n');
		sb.Append("  CollectionValueField: ").Append(CollectionValueField).Append('\n');
		sb.Append("  ConstraintXml: ").Append(ConstraintXml).Append('\n');
		sb.Append("  Contents: ").Append(Contents).Append('\n');
		sb.Append("  _Default: ").Append(Default).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  IsDateRange: ").Append(IsDateRange).Append('\n');
		sb.Append("  ListDisplayOption: ").Append(ListDisplayOption).Append('\n');
		sb.Append("  ListReturnFieldId: ").Append(ListReturnFieldId).Append('\n');
		sb.Append("  MultiLine: ").Append(MultiLine).Append('\n');
		sb.Append("  PromptId: ").Append(PromptId).Append('\n');
		sb.Append("  PromptType: ").Append(PromptType).Append('\n');
		sb.Append("  PromptTypeName: ").Append(PromptTypeName).Append('\n');
		sb.Append("  Required: ").Append(Required).Append('\n');
		sb.Append("  Text: ").Append(Text).Append('\n');
		sb.Append("  Value: ").Append(Value).Append('\n');
		sb.Append("  Values: ").Append(Values).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

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
			if (AllowValuesOnly != null)
			{
				hash = hash * 59 + AllowValuesOnly.GetHashCode();
			}

			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (CollectionStoreEntireRow != null)
			{
				hash = hash * 59 + CollectionStoreEntireRow.GetHashCode();
			}

			if (CollectionValueField != null)
			{
				hash = hash * 59 + CollectionValueField.GetHashCode();
			}

			if (ConstraintXml != null)
			{
				hash = hash * 59 + ConstraintXml.GetHashCode();
			}

			if (Contents != null)
			{
				hash = hash * 59 + Contents.GetHashCode();
			}

			if (Default != null)
			{
				hash = hash * 59 + Default.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (IsDateRange != null)
			{
				hash = hash * 59 + IsDateRange.GetHashCode();
			}

			if (ListDisplayOption != null)
			{
				hash = hash * 59 + ListDisplayOption.GetHashCode();
			}

			if (ListReturnFieldId != null)
			{
				hash = hash * 59 + ListReturnFieldId.GetHashCode();
			}

			if (MultiLine != null)
			{
				hash = hash * 59 + MultiLine.GetHashCode();
			}

			if (PromptId != null)
			{
				hash = hash * 59 + PromptId.GetHashCode();
			}

			if (PromptType != null)
			{
				hash = hash * 59 + PromptType.GetHashCode();
			}

			if (PromptTypeName != null)
			{
				hash = hash * 59 + PromptTypeName.GetHashCode();
			}

			if (Required != null)
			{
				hash = hash * 59 + Required.GetHashCode();
			}

			if (Text != null)
			{
				hash = hash * 59 + Text.GetHashCode();
			}

			if (Value != null)
			{
				hash = hash * 59 + Value.GetHashCode();
			}

			if (Values != null)
			{
				hash = hash * 59 + Values.GetHashCode();
			}

			return hash;
		}
	}

	
}
