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
    /// SecurityRole
    /// </summary>
    [DataContract]
    public partial class SecurityRole :  IEquatable<SecurityRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityRole" /> class.
        /// </summary>
        /// <param name="BrowserClientCustomViewId">BrowserClientCustomViewId.</param>
        /// <param name="BusinessObjectExcludeList">BusinessObjectExcludeList.</param>
        /// <param name="Culture">Culture.</param>
        /// <param name="Description">Description.</param>
        /// <param name="MobileClientCustomViewId">MobileClientCustomViewId.</param>
        /// <param name="PrimaryBusObId">PrimaryBusObId.</param>
        /// <param name="RoleId">RoleId.</param>
        /// <param name="RoleName">RoleName.</param>
        /// <param name="SmartClientCustomViewId">SmartClientCustomViewId.</param>
        public SecurityRole(string BrowserClientCustomViewId = default(string), List<string> BusinessObjectExcludeList = default(List<string>), string Culture = default(string), string Description = default(string), string MobileClientCustomViewId = default(string), string PrimaryBusObId = default(string), string RoleId = default(string), string RoleName = default(string), string SmartClientCustomViewId = default(string))
        {
            this.BrowserClientCustomViewId = BrowserClientCustomViewId;
            this.BusinessObjectExcludeList = BusinessObjectExcludeList;
            this.Culture = Culture;
            this.Description = Description;
            this.MobileClientCustomViewId = MobileClientCustomViewId;
            this.PrimaryBusObId = PrimaryBusObId;
            this.RoleId = RoleId;
            this.RoleName = RoleName;
            this.SmartClientCustomViewId = SmartClientCustomViewId;
        }
        
        /// <summary>
        /// Gets or Sets BrowserClientCustomViewId
        /// </summary>
        [DataMember(Name="browserClientCustomViewId", EmitDefaultValue=false)]
        public string BrowserClientCustomViewId { get; set; }
        /// <summary>
        /// Gets or Sets BusinessObjectExcludeList
        /// </summary>
        [DataMember(Name="businessObjectExcludeList", EmitDefaultValue=false)]
        public List<string> BusinessObjectExcludeList { get; set; }
        /// <summary>
        /// Gets or Sets Culture
        /// </summary>
        [DataMember(Name="culture", EmitDefaultValue=false)]
        public string Culture { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets MobileClientCustomViewId
        /// </summary>
        [DataMember(Name="mobileClientCustomViewId", EmitDefaultValue=false)]
        public string MobileClientCustomViewId { get; set; }
        /// <summary>
        /// Gets or Sets PrimaryBusObId
        /// </summary>
        [DataMember(Name="primaryBusObId", EmitDefaultValue=false)]
        public string PrimaryBusObId { get; set; }
        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public string RoleId { get; set; }
        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name="roleName", EmitDefaultValue=false)]
        public string RoleName { get; set; }
        /// <summary>
        /// Gets or Sets SmartClientCustomViewId
        /// </summary>
        [DataMember(Name="smartClientCustomViewId", EmitDefaultValue=false)]
        public string SmartClientCustomViewId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityRole {\n");
            sb.Append("  BrowserClientCustomViewId: ").Append(BrowserClientCustomViewId).Append("\n");
            sb.Append("  BusinessObjectExcludeList: ").Append(BusinessObjectExcludeList).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MobileClientCustomViewId: ").Append(MobileClientCustomViewId).Append("\n");
            sb.Append("  PrimaryBusObId: ").Append(PrimaryBusObId).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  SmartClientCustomViewId: ").Append(SmartClientCustomViewId).Append("\n");
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
            return this.Equals(obj as SecurityRole);
        }

        /// <summary>
        /// Returns true if SecurityRole instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityRole other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BrowserClientCustomViewId == other.BrowserClientCustomViewId ||
                    this.BrowserClientCustomViewId != null &&
                    this.BrowserClientCustomViewId.Equals(other.BrowserClientCustomViewId)
                ) && 
                (
                    this.BusinessObjectExcludeList == other.BusinessObjectExcludeList ||
                    this.BusinessObjectExcludeList != null &&
                    this.BusinessObjectExcludeList.SequenceEqual(other.BusinessObjectExcludeList)
                ) && 
                (
                    this.Culture == other.Culture ||
                    this.Culture != null &&
                    this.Culture.Equals(other.Culture)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.MobileClientCustomViewId == other.MobileClientCustomViewId ||
                    this.MobileClientCustomViewId != null &&
                    this.MobileClientCustomViewId.Equals(other.MobileClientCustomViewId)
                ) && 
                (
                    this.PrimaryBusObId == other.PrimaryBusObId ||
                    this.PrimaryBusObId != null &&
                    this.PrimaryBusObId.Equals(other.PrimaryBusObId)
                ) && 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.RoleName == other.RoleName ||
                    this.RoleName != null &&
                    this.RoleName.Equals(other.RoleName)
                ) && 
                (
                    this.SmartClientCustomViewId == other.SmartClientCustomViewId ||
                    this.SmartClientCustomViewId != null &&
                    this.SmartClientCustomViewId.Equals(other.SmartClientCustomViewId)
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
                if (this.BrowserClientCustomViewId != null)
                    hash = hash * 59 + this.BrowserClientCustomViewId.GetHashCode();
                if (this.BusinessObjectExcludeList != null)
                    hash = hash * 59 + this.BusinessObjectExcludeList.GetHashCode();
                if (this.Culture != null)
                    hash = hash * 59 + this.Culture.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.MobileClientCustomViewId != null)
                    hash = hash * 59 + this.MobileClientCustomViewId.GetHashCode();
                if (this.PrimaryBusObId != null)
                    hash = hash * 59 + this.PrimaryBusObId.GetHashCode();
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null)
                    hash = hash * 59 + this.RoleName.GetHashCode();
                if (this.SmartClientCustomViewId != null)
                    hash = hash * 59 + this.SmartClientCustomViewId.GetHashCode();
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
