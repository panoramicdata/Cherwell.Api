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

namespace Cherwell.Api.Models.Security;

    /// <summary>
    /// SecurityGroup
    /// </summary>
    [DataContract]
    public partial class SecurityGroup :  IEquatable<SecurityGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityGroup" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="GroupName">GroupName.</param>
        public SecurityGroup(string Description, string GroupId, string GroupName)
        {
            this.Description = Description;
            this.GroupId = GroupId;
            this.GroupName = GroupName;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        /// <summary>
        /// Gets or Sets GroupName
        /// </summary>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySecurityGroup {\n");
            sb.Append("  Description: ").Append(Description).Append('\n');
            sb.Append("  GroupId: ").Append(GroupId).Append('\n');
            sb.Append("  GroupName: ").Append(GroupName).Append('\n');
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
            return this.Equals(obj as SecurityGroup);
        }

        /// <summary>
        /// Returns true if SecurityGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityGroup? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description, StringComparison.Ordinal)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId, StringComparison.Ordinal)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName, StringComparison.Ordinal)
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
                if (this.Description != null)
			{
				hash = hash * 59 + this.Description.GetHashCode();
			}

			if (this.GroupId != null)
			{
				hash = hash * 59 + this.GroupId.GetHashCode();
			}

			if (this.GroupName != null)
			{
				hash = hash * 59 + this.GroupName.GetHashCode();
			}

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

