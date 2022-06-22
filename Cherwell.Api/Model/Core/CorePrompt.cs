using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Cherwell.Api.Model.Core
{
    /// <summary>
    /// CorePrompt
    /// </summary>
    [DataContract]
    public partial class CorePrompt : IEquatable<CorePrompt>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ListDisplayOption
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
        /// Gets or Sets PromptType
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
        /// Gets or Sets ListDisplayOption
        /// </summary>
        [DataMember(Name = "listDisplayOption", EmitDefaultValue = false)]
        public EnumListDisplayOption? ListDisplayOption { get; set; }
        /// <summary>
        /// Gets or Sets PromptType
        /// </summary>
        [DataMember(Name = "promptType", EmitDefaultValue = false)]
        public EnumPromptType? PromptType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CorePrompt" /> class.
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
        public CorePrompt(bool? AllowValuesOnly = default(bool?), string BusObId = default(string), string CollectionStoreEntireRow = default(string), string CollectionValueField = default(string), string ConstraintXml = default(string), string Contents = default(string), string Default = default(string), string FieldId = default(string), bool? IsDateRange = default(bool?), EnumListDisplayOption? ListDisplayOption = default(EnumListDisplayOption?), string ListReturnFieldId = default(string), bool? MultiLine = default(bool?), string PromptId = default(string), EnumPromptType? PromptType = default(EnumPromptType?), string PromptTypeName = default(string), bool? Required = default(bool?), string Text = default(string), Object Value = default(Object), List<string> Values = default(List<string>))
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
        /// Gets or Sets AllowValuesOnly
        /// </summary>
        [DataMember(Name = "allowValuesOnly", EmitDefaultValue = false)]
        public bool? AllowValuesOnly { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets CollectionStoreEntireRow
        /// </summary>
        [DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
        public string CollectionStoreEntireRow { get; set; }
        /// <summary>
        /// Gets or Sets CollectionValueField
        /// </summary>
        [DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
        public string CollectionValueField { get; set; }
        /// <summary>
        /// Gets or Sets ConstraintXml
        /// </summary>
        [DataMember(Name = "constraintXml", EmitDefaultValue = false)]
        public string ConstraintXml { get; set; }
        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name = "contents", EmitDefaultValue = false)]
        public string Contents { get; set; }
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public string Default { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets IsDateRange
        /// </summary>
        [DataMember(Name = "isDateRange", EmitDefaultValue = false)]
        public bool? IsDateRange { get; set; }
        /// <summary>
        /// Gets or Sets ListReturnFieldId
        /// </summary>
        [DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
        public string ListReturnFieldId { get; set; }
        /// <summary>
        /// Gets or Sets MultiLine
        /// </summary>
        [DataMember(Name = "multiLine", EmitDefaultValue = false)]
        public bool? MultiLine { get; set; }
        /// <summary>
        /// Gets or Sets PromptId
        /// </summary>
        [DataMember(Name = "promptId", EmitDefaultValue = false)]
        public string PromptId { get; set; }
        /// <summary>
        /// Gets or Sets PromptTypeName
        /// </summary>
        [DataMember(Name = "promptTypeName", EmitDefaultValue = false)]
        public string PromptTypeName { get; set; }
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        public bool? Required { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }
        /// <summary>
        /// Gets or Sets Values
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CorePrompt);
        }

        /// <summary>
        /// Returns true if CorePrompt instances are equal
        /// </summary>
        /// <param name="other">Instance of CorePrompt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorePrompt? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AllowValuesOnly == other.AllowValuesOnly ||
                    this.AllowValuesOnly != null &&
                    this.AllowValuesOnly.Equals(other.AllowValuesOnly)
                ) &&
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.CollectionStoreEntireRow == other.CollectionStoreEntireRow ||
                    this.CollectionStoreEntireRow != null &&
                    this.CollectionStoreEntireRow.Equals(other.CollectionStoreEntireRow, StringComparison.Ordinal)
                ) &&
                (
                    this.CollectionValueField == other.CollectionValueField ||
                    this.CollectionValueField != null &&
                    this.CollectionValueField.Equals(other.CollectionValueField, StringComparison.Ordinal)
                ) &&
                (
                    this.ConstraintXml == other.ConstraintXml ||
                    this.ConstraintXml != null &&
                    this.ConstraintXml.Equals(other.ConstraintXml, StringComparison.Ordinal)
                ) &&
                (
                    this.Contents == other.Contents ||
                    this.Contents != null &&
                    this.Contents.Equals(other.Contents, StringComparison.Ordinal)
                ) &&
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default, StringComparison.Ordinal)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.IsDateRange == other.IsDateRange ||
                    this.IsDateRange != null &&
                    this.IsDateRange.Equals(other.IsDateRange)
                ) &&
                (
                    this.ListDisplayOption == other.ListDisplayOption ||
                    this.ListDisplayOption != null &&
                    this.ListDisplayOption.Equals(other.ListDisplayOption)
                ) &&
                (
                    this.ListReturnFieldId == other.ListReturnFieldId ||
                    this.ListReturnFieldId != null &&
                    this.ListReturnFieldId.Equals(other.ListReturnFieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.MultiLine == other.MultiLine ||
                    this.MultiLine != null &&
                    this.MultiLine.Equals(other.MultiLine)
                ) &&
                (
                    this.PromptId == other.PromptId ||
                    this.PromptId != null &&
                    this.PromptId.Equals(other.PromptId, StringComparison.Ordinal)
                ) &&
                (
                    this.PromptType == other.PromptType ||
                    this.PromptType != null &&
                    this.PromptType.Equals(other.PromptType)
                ) &&
                (
                    this.PromptTypeName == other.PromptTypeName ||
                    this.PromptTypeName != null &&
                    this.PromptTypeName.Equals(other.PromptTypeName, StringComparison.Ordinal)
                ) &&
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text, StringComparison.Ordinal)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                );
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
                if (this.AllowValuesOnly != null)
                    hash = hash * 59 + this.AllowValuesOnly.GetHashCode();
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.CollectionStoreEntireRow != null)
                    hash = hash * 59 + this.CollectionStoreEntireRow.GetHashCode();
                if (this.CollectionValueField != null)
                    hash = hash * 59 + this.CollectionValueField.GetHashCode();
                if (this.ConstraintXml != null)
                    hash = hash * 59 + this.ConstraintXml.GetHashCode();
                if (this.Contents != null)
                    hash = hash * 59 + this.Contents.GetHashCode();
                if (this.Default != null)
                    hash = hash * 59 + this.Default.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.IsDateRange != null)
                    hash = hash * 59 + this.IsDateRange.GetHashCode();
                if (this.ListDisplayOption != null)
                    hash = hash * 59 + this.ListDisplayOption.GetHashCode();
                if (this.ListReturnFieldId != null)
                    hash = hash * 59 + this.ListReturnFieldId.GetHashCode();
                if (this.MultiLine != null)
                    hash = hash * 59 + this.MultiLine.GetHashCode();
                if (this.PromptId != null)
                    hash = hash * 59 + this.PromptId.GetHashCode();
                if (this.PromptType != null)
                    hash = hash * 59 + this.PromptType.GetHashCode();
                if (this.PromptTypeName != null)
                    hash = hash * 59 + this.PromptTypeName.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
