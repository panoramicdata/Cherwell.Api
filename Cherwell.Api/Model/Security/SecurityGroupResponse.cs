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

namespace Cherwell.Api.Model.Security
{
    /// <summary>
    /// SecurityGroupResponse
    /// </summary>
    [DataContract]
    public partial class SecurityGroupResponse :  IEquatable<SecurityGroupResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityGroupResponse" /> class.
        /// </summary>
        /// <param name="SecurityGroups">SecurityGroups.</param>
        public SecurityGroupResponse(List<SecurityGroup> SecurityGroups = default(List<SecurityGroup>))
        {
            this.SecurityGroups = SecurityGroups;
        }
        
        /// <summary>
        /// Gets or Sets SecurityGroups
        /// </summary>
        [DataMember(Name="securityGroups", EmitDefaultValue=false)]
        public List<SecurityGroup> SecurityGroups { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySecurityGroupResponse {\n");
            sb.Append("  SecurityGroups: ").Append(SecurityGroups).Append('\n');
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
            return this.Equals(obj as SecurityGroupResponse);
        }

        /// <summary>
        /// Returns true if SecurityGroupResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityGroupResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityGroupResponse? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SecurityGroups == other.SecurityGroups ||
                    this.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(other.SecurityGroups)
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
                if (this.SecurityGroups != null)
                    hash = hash * 59 + this.SecurityGroups.GetHashCode();
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