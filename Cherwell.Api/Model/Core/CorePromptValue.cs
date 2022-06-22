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
    /// CorePromptValue
    /// </summary>
    [DataContract]
    public partial class CorePromptValue : IEquatable<CorePromptValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorePromptValue" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="CollectionStoreEntireRow">CollectionStoreEntireRow.</param>
        /// <param name="CollectionValueField">CollectionValueField.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="ListReturnFieldId">ListReturnFieldId.</param>
        /// <param name="PromptId">PromptId.</param>
        /// <param name="Value">Value.</param>
        /// <param name="ValueIsRecId">ValueIsRecId.</param>
        public CorePromptValue(string BusObId = default(string), string CollectionStoreEntireRow = default(string), string CollectionValueField = default(string), string FieldId = default(string), string ListReturnFieldId = default(string), string PromptId = default(string), Object Value = default(Object), bool? ValueIsRecId = default(bool?))
        {
            this.BusObId = BusObId;
            this.CollectionStoreEntireRow = CollectionStoreEntireRow;
            this.CollectionValueField = CollectionValueField;
            this.FieldId = FieldId;
            this.ListReturnFieldId = ListReturnFieldId;
            this.PromptId = PromptId;
            this.Value = Value;
            this.ValueIsRecId = ValueIsRecId;
        }

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
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets ListReturnFieldId
        /// </summary>
        [DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
        public string ListReturnFieldId { get; set; }
        /// <summary>
        /// Gets or Sets PromptId
        /// </summary>
        [DataMember(Name = "promptId", EmitDefaultValue = false)]
        public string PromptId { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public Object Value { get; set; }
        /// <summary>
        /// Gets or Sets ValueIsRecId
        /// </summary>
        [DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
        public bool? ValueIsRecId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorePromptValue {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  CollectionStoreEntireRow: ").Append(CollectionStoreEntireRow).Append('\n');
            sb.Append("  CollectionValueField: ").Append(CollectionValueField).Append('\n');
            sb.Append("  FieldId: ").Append(FieldId).Append('\n');
            sb.Append("  ListReturnFieldId: ").Append(ListReturnFieldId).Append('\n');
            sb.Append("  PromptId: ").Append(PromptId).Append('\n');
            sb.Append("  Value: ").Append(Value).Append('\n');
            sb.Append("  ValueIsRecId: ").Append(ValueIsRecId).Append('\n');
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
            return this.Equals(obj as CorePromptValue);
        }

        /// <summary>
        /// Returns true if CorePromptValue instances are equal
        /// </summary>
        /// <param name="other">Instance of CorePromptValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorePromptValue? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
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
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.ListReturnFieldId == other.ListReturnFieldId ||
                    this.ListReturnFieldId != null &&
                    this.ListReturnFieldId.Equals(other.ListReturnFieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.PromptId == other.PromptId ||
                    this.PromptId != null &&
                    this.PromptId.Equals(other.PromptId, StringComparison.Ordinal)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.ValueIsRecId == other.ValueIsRecId ||
                    this.ValueIsRecId != null &&
                    this.ValueIsRecId.Equals(other.ValueIsRecId)
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
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.CollectionStoreEntireRow != null)
                    hash = hash * 59 + this.CollectionStoreEntireRow.GetHashCode();
                if (this.CollectionValueField != null)
                    hash = hash * 59 + this.CollectionValueField.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.ListReturnFieldId != null)
                    hash = hash * 59 + this.ListReturnFieldId.GetHashCode();
                if (this.PromptId != null)
                    hash = hash * 59 + this.PromptId.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.ValueIsRecId != null)
                    hash = hash * 59 + this.ValueIsRecId.GetHashCode();
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
