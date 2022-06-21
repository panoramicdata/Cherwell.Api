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
    /// SecurityClientSecuritySettingsResponse
    /// </summary>
    [DataContract]
    public partial class SecurityClientSecuritySettingsResponse : IEquatable<SecurityClientSecuritySettingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityClientSecuritySettingsResponse" /> class.
        /// </summary>
        /// <param name="InternalLoginAllowed">InternalLoginAllowed.</param>
        /// <param name="LdapLoginAllowed">LdapLoginAllowed.</param>
        /// <param name="SamlLoginAllowed">SamlLoginAllowed.</param>
        /// <param name="WindowsLoginAllowed">WindowsLoginAllowed.</param>
        public SecurityClientSecuritySettingsResponse(bool? InternalLoginAllowed = default(bool?), bool? LdapLoginAllowed = default(bool?), bool? SamlLoginAllowed = default(bool?), bool? WindowsLoginAllowed = default(bool?))
        {
            this.InternalLoginAllowed = InternalLoginAllowed;
            this.LdapLoginAllowed = LdapLoginAllowed;
            this.SamlLoginAllowed = SamlLoginAllowed;
            this.WindowsLoginAllowed = WindowsLoginAllowed;
        }

        /// <summary>
        /// Gets or Sets InternalLoginAllowed
        /// </summary>
        [DataMember(Name = "internalLoginAllowed", EmitDefaultValue = false)]
        public bool? InternalLoginAllowed { get; set; }
        /// <summary>
        /// Gets or Sets LdapLoginAllowed
        /// </summary>
        [DataMember(Name = "ldapLoginAllowed", EmitDefaultValue = false)]
        public bool? LdapLoginAllowed { get; set; }
        /// <summary>
        /// Gets or Sets SamlLoginAllowed
        /// </summary>
        [DataMember(Name = "samlLoginAllowed", EmitDefaultValue = false)]
        public bool? SamlLoginAllowed { get; set; }
        /// <summary>
        /// Gets or Sets WindowsLoginAllowed
        /// </summary>
        [DataMember(Name = "windowsLoginAllowed", EmitDefaultValue = false)]
        public bool? WindowsLoginAllowed { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityClientSecuritySettingsResponse {\n");
            sb.Append("  InternalLoginAllowed: ").Append(InternalLoginAllowed).Append("\n");
            sb.Append("  LdapLoginAllowed: ").Append(LdapLoginAllowed).Append("\n");
            sb.Append("  SamlLoginAllowed: ").Append(SamlLoginAllowed).Append("\n");
            sb.Append("  WindowsLoginAllowed: ").Append(WindowsLoginAllowed).Append("\n");
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
            return this.Equals(obj as SecurityClientSecuritySettingsResponse);
        }

        /// <summary>
        /// Returns true if SecurityClientSecuritySettingsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityClientSecuritySettingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityClientSecuritySettingsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.InternalLoginAllowed == other.InternalLoginAllowed ||
                    this.InternalLoginAllowed != null &&
                    this.InternalLoginAllowed.Equals(other.InternalLoginAllowed)
                ) &&
                (
                    this.LdapLoginAllowed == other.LdapLoginAllowed ||
                    this.LdapLoginAllowed != null &&
                    this.LdapLoginAllowed.Equals(other.LdapLoginAllowed)
                ) &&
                (
                    this.SamlLoginAllowed == other.SamlLoginAllowed ||
                    this.SamlLoginAllowed != null &&
                    this.SamlLoginAllowed.Equals(other.SamlLoginAllowed)
                ) &&
                (
                    this.WindowsLoginAllowed == other.WindowsLoginAllowed ||
                    this.WindowsLoginAllowed != null &&
                    this.WindowsLoginAllowed.Equals(other.WindowsLoginAllowed)
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
                if (this.InternalLoginAllowed != null)
                    hash = hash * 59 + this.InternalLoginAllowed.GetHashCode();
                if (this.LdapLoginAllowed != null)
                    hash = hash * 59 + this.LdapLoginAllowed.GetHashCode();
                if (this.SamlLoginAllowed != null)
                    hash = hash * 59 + this.SamlLoginAllowed.GetHashCode();
                if (this.WindowsLoginAllowed != null)
                    hash = hash * 59 + this.WindowsLoginAllowed.GetHashCode();
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