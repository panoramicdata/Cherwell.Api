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
    /// BusinessObjectBatchReadResponse
    /// </summary>
    [DataContract]
    public partial class BusinessObjectBatchReadResponse : IEquatable<BusinessObjectBatchReadResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectBatchReadResponse" /> class.
        /// </summary>
        /// <param name="Responses">Responses.</param>
        public BusinessObjectBatchReadResponse(List<BusinessObjectReadResponse> Responses = default(List<BusinessObjectReadResponse>))
        {
            this.Responses = Responses;
        }

        /// <summary>
        /// Gets or Sets Responses
        /// </summary>
        [DataMember(Name = "responses", EmitDefaultValue = false)]
        public List<BusinessObjectReadResponse> Responses { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectBatchReadResponse {\n");
            sb.Append("  Responses: ").Append(Responses).Append('\n');
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
            return this.Equals(obj as BusinessObjectBatchReadResponse);
        }

        /// <summary>
        /// Returns true if BusinessObjectBatchReadResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectBatchReadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectBatchReadResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Responses == other.Responses ||
                    this.Responses != null &&
                    this.Responses.SequenceEqual(other.Responses)
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
                if (this.Responses != null)
                    hash = hash * 59 + this.Responses.GetHashCode();
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