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

namespace Cherwell.Api.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectBatchSaveRequest
    /// </summary>
    [DataContract]
    public partial class BusinessObjectBatchSaveRequest : IEquatable<BusinessObjectBatchSaveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectBatchSaveRequest" /> class.
        /// </summary>
        /// <param name="SaveRequests">SaveRequests.</param>
        /// <param name="StopOnError">StopOnError.</param>
        public BusinessObjectBatchSaveRequest(List<BusinessObjectSaveRequest> SaveRequests = default(List<BusinessObjectSaveRequest>), bool? StopOnError = default(bool?))
        {
            this.SaveRequests = SaveRequests;
            this.StopOnError = StopOnError;
        }

        /// <summary>
        /// Gets or Sets SaveRequests
        /// </summary>
        [DataMember(Name = "saveRequests", EmitDefaultValue = false)]
        public List<BusinessObjectSaveRequest> SaveRequests { get; set; }
        /// <summary>
        /// Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
        public bool? StopOnError { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectBatchSaveRequest {\n");
            sb.Append("  SaveRequests: ").Append(SaveRequests).Append('\n');
            sb.Append("  StopOnError: ").Append(StopOnError).Append('\n');
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
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BusinessObjectBatchSaveRequest);
        }

        /// <summary>
        /// Returns true if BusinessObjectBatchSaveRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectBatchSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectBatchSaveRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.SaveRequests == other.SaveRequests ||
                    this.SaveRequests != null &&
                    this.SaveRequests.SequenceEqual(other.SaveRequests)
                ) &&
                (
                    this.StopOnError == other.StopOnError ||
                    this.StopOnError != null &&
                    this.StopOnError.Equals(other.StopOnError)
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
                if (this.SaveRequests != null)
                    hash = hash * 59 + this.SaveRequests.GetHashCode();
                if (this.StopOnError != null)
                    hash = hash * 59 + this.StopOnError.GetHashCode();
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