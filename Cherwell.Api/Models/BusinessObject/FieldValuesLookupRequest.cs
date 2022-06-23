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

namespace Cherwell.Api.Models.BusinessObject;

    /// <summary>
    /// BusinessObjectFieldValuesLookupRequest
    /// </summary>
    [DataContract]
    public partial class FieldValuesLookupRequest : IEquatable<FieldValuesLookupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValuesLookupRequest" /> class.
        /// </summary>
        /// <param name="BusbPublicId">BusbPublicId.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="Fields">Fields.</param>
        public FieldValuesLookupRequest(string BusbPublicId, string BusObId, string BusObRecId, string FieldId, string FieldName, List<FieldTemplateItem> Fields)
        {
            this.BusbPublicId = BusbPublicId;
            this.BusObId = BusObId;
            this.BusObRecId = BusObRecId;
            this.FieldId = FieldId;
            this.FieldName = FieldName;
            this.Fields = Fields;
        }

        /// <summary>
        /// Gets or Sets BusbPublicId
        /// </summary>
        [DataMember(Name = "busbPublicId", EmitDefaultValue = false)]
        public string BusbPublicId { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> Fields { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectFieldValuesLookupRequest {\n");
            sb.Append("  BusbPublicId: ").Append(BusbPublicId).Append('\n');
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
            sb.Append("  FieldId: ").Append(FieldId).Append('\n');
            sb.Append("  FieldName: ").Append(FieldName).Append('\n');
            sb.Append("  Fields: ").Append(Fields).Append('\n');
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
            return this.Equals(obj as FieldValuesLookupRequest);
        }

        /// <summary>
        /// Returns true if BusinessObjectFieldValuesLookupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectFieldValuesLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValuesLookupRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return
                (
                    this.BusbPublicId == other.BusbPublicId ||
                    this.BusbPublicId != null &&
                    this.BusbPublicId.Equals(other.BusbPublicId, StringComparison.Ordinal)
                ) &&
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId, StringComparison.Ordinal)
                ) &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName, StringComparison.Ordinal)
                ) &&
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
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
                if (this.BusbPublicId != null)
			{
				hash = hash * 59 + this.BusbPublicId.GetHashCode();
			}

			if (this.BusObId != null)
			{
				hash = hash * 59 + this.BusObId.GetHashCode();
			}

			if (this.BusObRecId != null)
			{
				hash = hash * 59 + this.BusObRecId.GetHashCode();
			}

			if (this.FieldId != null)
			{
				hash = hash * 59 + this.FieldId.GetHashCode();
			}

			if (this.FieldName != null)
			{
				hash = hash * 59 + this.FieldName.GetHashCode();
			}

			if (this.Fields != null)
			{
				hash = hash * 59 + this.Fields.GetHashCode();
			}

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