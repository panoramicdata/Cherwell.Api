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
    /// BusinessObjectTemplateRequest
    /// </summary>
    [DataContract]
    public partial class TemplateRequest : IEquatable<TemplateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRequest" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="FieldNames">FieldNames.</param>
        /// <param name="FieldIds">FieldIds.</param>
        /// <param name="IncludeAll">IncludeAll.</param>
        /// <param name="IncludeRequired">IncludeRequired.</param>
        public TemplateRequest(string BusObId, List<string> FieldNames, List<string> FieldIds, bool? IncludeAll, bool? IncludeRequired)
        {
            this.BusObId = BusObId;
            this.FieldNames = FieldNames;
            this.FieldIds = FieldIds;
            this.IncludeAll = IncludeAll;
            this.IncludeRequired = IncludeRequired;
        }

        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets FieldNames
        /// </summary>
        [DataMember(Name = "fieldNames", EmitDefaultValue = false)]
        public List<string> FieldNames { get; set; }
        /// <summary>
        /// Gets or Sets FieldIds
        /// </summary>
        [DataMember(Name = "fieldIds", EmitDefaultValue = false)]
        public List<string> FieldIds { get; set; }
        /// <summary>
        /// Gets or Sets IncludeAll
        /// </summary>
        [DataMember(Name = "includeAll", EmitDefaultValue = false)]
        public bool? IncludeAll { get; set; }
        /// <summary>
        /// Gets or Sets IncludeRequired
        /// </summary>
        [DataMember(Name = "includeRequired", EmitDefaultValue = false)]
        public bool? IncludeRequired { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectTemplateRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  FieldNames: ").Append(FieldNames).Append('\n');
            sb.Append("  FieldIds: ").Append(FieldIds).Append('\n');
            sb.Append("  IncludeAll: ").Append(IncludeAll).Append('\n');
            sb.Append("  IncludeRequired: ").Append(IncludeRequired).Append('\n');
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
            return this.Equals(obj as TemplateRequest);
        }

        /// <summary>
        /// Returns true if BusinessObjectTemplateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectTemplateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.FieldNames == other.FieldNames ||
                    this.FieldNames != null &&
                    this.FieldNames.SequenceEqual(other.FieldNames)
                ) &&
                (
                    this.FieldIds == other.FieldIds ||
                    this.FieldIds != null &&
                    this.FieldIds.SequenceEqual(other.FieldIds)
                ) &&
                (
                    this.IncludeAll == other.IncludeAll ||
                    this.IncludeAll != null &&
                    this.IncludeAll.Equals(other.IncludeAll)
                ) &&
                (
                    this.IncludeRequired == other.IncludeRequired ||
                    this.IncludeRequired != null &&
                    this.IncludeRequired.Equals(other.IncludeRequired)
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
			{
				hash = hash * 59 + this.BusObId.GetHashCode();
			}

			if (this.FieldNames != null)
			{
				hash = hash * 59 + this.FieldNames.GetHashCode();
			}

			if (this.FieldIds != null)
			{
				hash = hash * 59 + this.FieldIds.GetHashCode();
			}

			if (this.IncludeAll != null)
			{
				hash = hash * 59 + this.IncludeAll.GetHashCode();
			}

			if (this.IncludeRequired != null)
			{
				hash = hash * 59 + this.IncludeRequired.GetHashCode();
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