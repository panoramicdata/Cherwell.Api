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

namespace Cherwell.Api.Model.Users
{
    /// <summary>
    /// UserBatchSaveV2Request
    /// </summary>
    [DataContract]
    public partial class UserBatchSaveV2Request : IEquatable<UserBatchSaveV2Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBatchSaveV2Request" /> class.
        /// </summary>
        /// <param name="SaveRequests">SaveRequests.</param>
        /// <param name="StopOnError">StopOnError.</param>
        public UserBatchSaveV2Request(List<UserSaveV2Request> SaveRequests = default, bool? StopOnError = default)
        {
            this.SaveRequests = SaveRequests;
            this.StopOnError = StopOnError;
        }

        /// <summary>
        /// Gets or Sets SaveRequests
        /// </summary>
        [DataMember(Name = "saveRequests", EmitDefaultValue = false)]
        public List<UserSaveV2Request> SaveRequests { get; set; }
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
            sb.Append("class UserBatchSaveV2Request {\n");
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
        public override bool Equals(object? obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as UserBatchSaveV2Request);
        }

        /// <summary>
        /// Returns true if UserBatchSaveV2Request instances are equal
        /// </summary>
        /// <param name="other">Instance of UserBatchSaveV2Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBatchSaveV2Request? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    SaveRequests == other.SaveRequests ||
                    SaveRequests != null &&
                    SaveRequests.SequenceEqual(other.SaveRequests)
                ) &&
                (
                    StopOnError == other.StopOnError ||
                    StopOnError != null &&
                    StopOnError.Equals(other.StopOnError)
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
                if (SaveRequests != null)
                    hash = hash * 59 + SaveRequests.GetHashCode();
                if (StopOnError != null)
                    hash = hash * 59 + StopOnError.GetHashCode();
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
