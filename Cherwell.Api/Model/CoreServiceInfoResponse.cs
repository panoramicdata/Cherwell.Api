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
    /// CoreServiceInfoResponse
    /// </summary>
    [DataContract]
    public partial class CoreServiceInfoResponse :  IEquatable<CoreServiceInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreServiceInfoResponse" /> class.
        /// </summary>
        /// <param name="ApiVersion">ApiVersion.</param>
        /// <param name="CsmCulture">CsmCulture.</param>
        /// <param name="CsmVersion">CsmVersion.</param>
        /// <param name="SystemDateTime">SystemDateTime.</param>
        /// <param name="TimeZone">TimeZone.</param>
        /// <param name="SystemUtcOffset">SystemUtcOffset.</param>
        public CoreServiceInfoResponse(string ApiVersion = default(string), string CsmCulture = default(string), string CsmVersion = default(string), DateTime? SystemDateTime = default(DateTime?), Object TimeZone = default(Object), string SystemUtcOffset = default(string))
        {
            this.ApiVersion = ApiVersion;
            this.CsmCulture = CsmCulture;
            this.CsmVersion = CsmVersion;
            this.SystemDateTime = SystemDateTime;
            this.TimeZone = TimeZone;
            this.SystemUtcOffset = SystemUtcOffset;
        }
        
        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// Gets or Sets CsmCulture
        /// </summary>
        [DataMember(Name="csmCulture", EmitDefaultValue=false)]
        public string CsmCulture { get; set; }
        /// <summary>
        /// Gets or Sets CsmVersion
        /// </summary>
        [DataMember(Name="csmVersion", EmitDefaultValue=false)]
        public string CsmVersion { get; set; }
        /// <summary>
        /// Gets or Sets SystemDateTime
        /// </summary>
        [DataMember(Name="systemDateTime", EmitDefaultValue=false)]
        public DateTime? SystemDateTime { get; set; }
        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public Object TimeZone { get; set; }
        /// <summary>
        /// Gets or Sets SystemUtcOffset
        /// </summary>
        [DataMember(Name="systemUtcOffset", EmitDefaultValue=false)]
        public string SystemUtcOffset { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreServiceInfoResponse {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  CsmCulture: ").Append(CsmCulture).Append("\n");
            sb.Append("  CsmVersion: ").Append(CsmVersion).Append("\n");
            sb.Append("  SystemDateTime: ").Append(SystemDateTime).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  SystemUtcOffset: ").Append(SystemUtcOffset).Append("\n");
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
            return this.Equals(obj as CoreServiceInfoResponse);
        }

        /// <summary>
        /// Returns true if CoreServiceInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreServiceInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreServiceInfoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) && 
                (
                    this.CsmCulture == other.CsmCulture ||
                    this.CsmCulture != null &&
                    this.CsmCulture.Equals(other.CsmCulture)
                ) && 
                (
                    this.CsmVersion == other.CsmVersion ||
                    this.CsmVersion != null &&
                    this.CsmVersion.Equals(other.CsmVersion)
                ) && 
                (
                    this.SystemDateTime == other.SystemDateTime ||
                    this.SystemDateTime != null &&
                    this.SystemDateTime.Equals(other.SystemDateTime)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.SystemUtcOffset == other.SystemUtcOffset ||
                    this.SystemUtcOffset != null &&
                    this.SystemUtcOffset.Equals(other.SystemUtcOffset)
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
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.CsmCulture != null)
                    hash = hash * 59 + this.CsmCulture.GetHashCode();
                if (this.CsmVersion != null)
                    hash = hash * 59 + this.CsmVersion.GetHashCode();
                if (this.SystemDateTime != null)
                    hash = hash * 59 + this.SystemDateTime.GetHashCode();
                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                if (this.SystemUtcOffset != null)
                    hash = hash * 59 + this.SystemUtcOffset.GetHashCode();
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
