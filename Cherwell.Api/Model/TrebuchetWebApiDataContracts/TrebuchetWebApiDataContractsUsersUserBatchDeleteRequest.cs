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

namespace Cherwell.Model
{
    /// <summary>
    /// TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest :  IEquatable<TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest" /> class.
        /// </summary>
        /// <param name="StopOnError">StopOnError.</param>
        /// <param name="UserRecordIds">UserRecordIds.</param>
        public TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest(bool? StopOnError = default(bool?), List<string> UserRecordIds = default(List<string>))
        {
            this.StopOnError = StopOnError;
            this.UserRecordIds = UserRecordIds;
        }
        
        /// <summary>
        /// Gets or Sets StopOnError
        /// </summary>
        [DataMember(Name="stopOnError", EmitDefaultValue=false)]
        public bool? StopOnError { get; set; }
        /// <summary>
        /// Gets or Sets UserRecordIds
        /// </summary>
        [DataMember(Name="userRecordIds", EmitDefaultValue=false)]
        public List<string> UserRecordIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest {\n");
            sb.Append("  StopOnError: ").Append(StopOnError).Append("\n");
            sb.Append("  UserRecordIds: ").Append(UserRecordIds).Append("\n");
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
            return this.Equals(obj as TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsUsersUserBatchDeleteRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StopOnError == other.StopOnError ||
                    this.StopOnError != null &&
                    this.StopOnError.Equals(other.StopOnError)
                ) && 
                (
                    this.UserRecordIds == other.UserRecordIds ||
                    this.UserRecordIds != null &&
                    this.UserRecordIds.SequenceEqual(other.UserRecordIds)
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
                if (this.StopOnError != null)
                    hash = hash * 59 + this.StopOnError.GetHashCode();
                if (this.UserRecordIds != null)
                    hash = hash * 59 + this.UserRecordIds.GetHashCode();
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
