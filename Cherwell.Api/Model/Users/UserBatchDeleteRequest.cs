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
    /// UserBatchDeleteRequest
    /// </summary>
    [DataContract]
    public partial class UserBatchDeleteRequest : IEquatable<UserBatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="StopOnError">StopOnError.</param>
        /// <param name="UserRecordIds">UserRecordIds.</param>
        public UserBatchDeleteRequest(bool? StopOnError, List<string> UserRecordIds)
        {
            this.StopOnError = StopOnError;
            this.UserRecordIds = UserRecordIds;
        }

        /// <summary>
        /// Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
        public bool? StopOnError { get; set; }
        /// <summary>
        /// Gets or Sets UserRecordIds
        /// </summary>
        [DataMember(Name = "userRecordIds", EmitDefaultValue = false)]
        public List<string> UserRecordIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBatchDeleteRequest {\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append('\n');
            sb.Append("  UserRecordIds: ").Append(UserRecordIds).Append('\n');
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
            return Equals(obj as UserBatchDeleteRequest);
        }

        /// <summary>
        /// Returns true if UserBatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UserBatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBatchDeleteRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    StopOnError == other.StopOnError ||
                    StopOnError != null &&
                    StopOnError.Equals(other.StopOnError)
                ) &&
                (
                    UserRecordIds == other.UserRecordIds ||
                    UserRecordIds != null &&
                    UserRecordIds.SequenceEqual(other.UserRecordIds)
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
                if (StopOnError != null)
                    hash = hash * 59 + StopOnError.GetHashCode();
                if (UserRecordIds != null)
                    hash = hash * 59 + UserRecordIds.GetHashCode();
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
