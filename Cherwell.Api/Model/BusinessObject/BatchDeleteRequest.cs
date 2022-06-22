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
    /// BusinessObjectBatchDeleteRequest
    /// </summary>
    [DataContract]
    public partial class BatchDeleteRequest : IEquatable<BatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="DeleteRequests">DeleteRequests.</param>
        /// <param name="StopOnError">StopOnError.</param>
        public BatchDeleteRequest(List<DeleteRequest> DeleteRequests = default, bool? StopOnError = default)
        {
            this.DeleteRequests = DeleteRequests;
            this.StopOnError = StopOnError;
        }

        /// <summary>
        /// Gets or Sets DeleteRequests
        /// </summary>
        [DataMember(Name = "deleteRequests", EmitDefaultValue = false)]
        public List<DeleteRequest> DeleteRequests { get; set; }
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
            sb.Append("class BusinessObjectBatchDeleteRequest {\n");
            sb.Append("  DeleteRequests: ").Append(DeleteRequests).Append('\n');
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
        public override bool Equals(object? obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BatchDeleteRequest);
        }

        /// <summary>
        /// Returns true if BusinessObjectBatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectBatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchDeleteRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.DeleteRequests == other.DeleteRequests ||
                    this.DeleteRequests != null &&
                    this.DeleteRequests.SequenceEqual(other.DeleteRequests)
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
                if (this.DeleteRequests != null)
                    hash = hash * 59 + this.DeleteRequests.GetHashCode();
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