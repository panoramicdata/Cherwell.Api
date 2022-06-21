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

namespace Cherwell.Model.Security
{
    /// <summary>
    /// SecurityCloneSecurityGroupRequest
    /// </summary>
    [DataContract]
    public partial class SecurityCloneSecurityGroupRequest : IEquatable<SecurityCloneSecurityGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityCloneSecurityGroupRequest" /> class.
        /// </summary>
        /// <param name="SecurityGroupName">SecurityGroupName.</param>
        /// <param name="SourceSecurityGroupNameOrId">SourceSecurityGroupNameOrId.</param>
        public SecurityCloneSecurityGroupRequest(string SecurityGroupName = default(string), string SourceSecurityGroupNameOrId = default(string))
        {
            this.SecurityGroupName = SecurityGroupName;
            this.SourceSecurityGroupNameOrId = SourceSecurityGroupNameOrId;
        }

        /// <summary>
        /// Gets or Sets SecurityGroupName
        /// </summary>
        [DataMember(Name = "securityGroupName", EmitDefaultValue = false)]
        public string SecurityGroupName { get; set; }
        /// <summary>
        /// Gets or Sets SourceSecurityGroupNameOrId
        /// </summary>
        [DataMember(Name = "sourceSecurityGroupNameOrId", EmitDefaultValue = false)]
        public string SourceSecurityGroupNameOrId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityCloneSecurityGroupRequest {\n");
            sb.Append("  SecurityGroupName: ").Append(SecurityGroupName).Append("\n");
            sb.Append("  SourceSecurityGroupNameOrId: ").Append(SourceSecurityGroupNameOrId).Append("\n");
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
            return this.Equals(obj as SecurityCloneSecurityGroupRequest);
        }

        /// <summary>
        /// Returns true if SecurityCloneSecurityGroupRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityCloneSecurityGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityCloneSecurityGroupRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.SecurityGroupName == other.SecurityGroupName ||
                    this.SecurityGroupName != null &&
                    this.SecurityGroupName.Equals(other.SecurityGroupName)
                ) &&
                (
                    this.SourceSecurityGroupNameOrId == other.SourceSecurityGroupNameOrId ||
                    this.SourceSecurityGroupNameOrId != null &&
                    this.SourceSecurityGroupNameOrId.Equals(other.SourceSecurityGroupNameOrId)
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
                if (this.SecurityGroupName != null)
                    hash = hash * 59 + this.SecurityGroupName.GetHashCode();
                if (this.SourceSecurityGroupNameOrId != null)
                    hash = hash * 59 + this.SourceSecurityGroupNameOrId.GetHashCode();
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
