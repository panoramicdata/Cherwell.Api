/* 
 * Cherwell Rest API
 *
 * <a href=\"https://xantes.sharepoint.com/sites/supporthelp\">Cherwell Rest API Documentation</a><br>Select version options from the header drop-down list (to the left of the Client Key box). Then, click Explore to view different versions of operations.
 *
 * OpenAPI spec version: 10.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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

namespace IO.Swagger.Model
{
    /// <summary>
    /// TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger :  IEquatable<TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger" /> class.
        /// </summary>
        /// <param name="SourceType">SourceType.</param>
        /// <param name="SourceId">SourceId.</param>
        /// <param name="SourceChange">SourceChange.</param>
        /// <param name="Key">Key.</param>
        public TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger(string SourceType = default(string), string SourceId = default(string), string SourceChange = default(string), string Key = default(string))
        {
            this.SourceType = SourceType;
            this.SourceId = SourceId;
            this.SourceChange = SourceChange;
            this.Key = Key;
        }
        
        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public string SourceType { get; set; }
        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name="sourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }
        /// <summary>
        /// Gets or Sets SourceChange
        /// </summary>
        [DataMember(Name="sourceChange", EmitDefaultValue=false)]
        public string SourceChange { get; set; }
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger {\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceChange: ").Append(SourceChange).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(obj as TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsBusinessObjectNotificationTrigger other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) && 
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.SourceChange == other.SourceChange ||
                    this.SourceChange != null &&
                    this.SourceChange.Equals(other.SourceChange)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
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
                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                if (this.SourceChange != null)
                    hash = hash * 59 + this.SourceChange.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
