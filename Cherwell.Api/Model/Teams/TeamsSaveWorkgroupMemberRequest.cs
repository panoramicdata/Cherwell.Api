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

namespace Cherwell.Api.Model.Teams
{
    /// <summary>
    /// TeamsSaveWorkgroupMemberRequest
    /// </summary>
    [DataContract]
    public partial class TeamsSaveWorkgroupMemberRequest :  IEquatable<TeamsSaveWorkgroupMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsSaveWorkgroupMemberRequest" /> class.
        /// </summary>
        /// <param name="CustomerRecordId">CustomerRecordId.</param>
        /// <param name="WorkgroupId">WorkgroupId.</param>
        /// <param name="CustomerIsWorkgroupManager">CustomerIsWorkgroupManager.</param>
        public TeamsSaveWorkgroupMemberRequest(string CustomerRecordId = default(string), string WorkgroupId = default(string), bool? CustomerIsWorkgroupManager = default(bool?))
        {
            this.CustomerRecordId = CustomerRecordId;
            this.WorkgroupId = WorkgroupId;
            this.CustomerIsWorkgroupManager = CustomerIsWorkgroupManager;
        }
        
        /// <summary>
        /// Gets or Sets CustomerRecordId
        /// </summary>
        [DataMember(Name="customerRecordId", EmitDefaultValue=false)]
        public string CustomerRecordId { get; set; }
        /// <summary>
        /// Gets or Sets WorkgroupId
        /// </summary>
        [DataMember(Name="workgroupId", EmitDefaultValue=false)]
        public string WorkgroupId { get; set; }
        /// <summary>
        /// Gets or Sets CustomerIsWorkgroupManager
        /// </summary>
        [DataMember(Name="customerIsWorkgroupManager", EmitDefaultValue=false)]
        public bool? CustomerIsWorkgroupManager { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsSaveWorkgroupMemberRequest {\n");
            sb.Append("  CustomerRecordId: ").Append(CustomerRecordId).Append('\n');
            sb.Append("  WorkgroupId: ").Append(WorkgroupId).Append('\n');
            sb.Append("  CustomerIsWorkgroupManager: ").Append(CustomerIsWorkgroupManager).Append('\n');
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
            return this.Equals(obj as TeamsSaveWorkgroupMemberRequest);
        }

        /// <summary>
        /// Returns true if TeamsSaveWorkgroupMemberRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamsSaveWorkgroupMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsSaveWorkgroupMemberRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerRecordId == other.CustomerRecordId ||
                    this.CustomerRecordId != null &&
                    this.CustomerRecordId.Equals(other.CustomerRecordId, StringComparison.Ordinal)
                ) && 
                (
                    this.WorkgroupId == other.WorkgroupId ||
                    this.WorkgroupId != null &&
                    this.WorkgroupId.Equals(other.WorkgroupId, StringComparison.Ordinal)
                ) && 
                (
                    this.CustomerIsWorkgroupManager == other.CustomerIsWorkgroupManager ||
                    this.CustomerIsWorkgroupManager != null &&
                    this.CustomerIsWorkgroupManager.Equals(other.CustomerIsWorkgroupManager)
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
                if (this.CustomerRecordId != null)
                    hash = hash * 59 + this.CustomerRecordId.GetHashCode();
                if (this.WorkgroupId != null)
                    hash = hash * 59 + this.WorkgroupId.GetHashCode();
                if (this.CustomerIsWorkgroupManager != null)
                    hash = hash * 59 + this.CustomerIsWorkgroupManager.GetHashCode();
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
