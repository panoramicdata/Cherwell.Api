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

namespace Cherwell.Api.Model
{
    /// <summary>
    /// SecuritySaveApiClientSettingRequest
    /// </summary>
    [DataContract]
    public partial class SecuritySaveApiClientSettingRequest :  IEquatable<SecuritySaveApiClientSettingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySaveApiClientSettingRequest" /> class.
        /// </summary>
        /// <param name="AllowAnonymousAccess">AllowAnonymousAccess.</param>
        /// <param name="ApiAccessIsEnabled">ApiAccessIsEnabled.</param>
        /// <param name="CreateNewClientKey">CreateNewClientKey.</param>
        /// <param name="Culture">Culture.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RefreshTokenLifespanMinutes">RefreshTokenLifespanMinutes.</param>
        /// <param name="StandInKey">StandInKey.</param>
        /// <param name="TokenLifespanMinutes">TokenLifespanMinutes.</param>
        public SecuritySaveApiClientSettingRequest(bool? AllowAnonymousAccess = default(bool?), bool? ApiAccessIsEnabled = default(bool?), bool? CreateNewClientKey = default(bool?), string Culture = default(string), string Description = default(string), string Name = default(string), int? RefreshTokenLifespanMinutes = default(int?), string StandInKey = default(string), int? TokenLifespanMinutes = default(int?))
        {
            this.AllowAnonymousAccess = AllowAnonymousAccess;
            this.ApiAccessIsEnabled = ApiAccessIsEnabled;
            this.CreateNewClientKey = CreateNewClientKey;
            this.Culture = Culture;
            this.Description = Description;
            this.Name = Name;
            this.RefreshTokenLifespanMinutes = RefreshTokenLifespanMinutes;
            this.StandInKey = StandInKey;
            this.TokenLifespanMinutes = TokenLifespanMinutes;
        }
        
        /// <summary>
        /// Gets or Sets AllowAnonymousAccess
        /// </summary>
        [DataMember(Name="allowAnonymousAccess", EmitDefaultValue=false)]
        public bool? AllowAnonymousAccess { get; set; }
        /// <summary>
        /// Gets or Sets ApiAccessIsEnabled
        /// </summary>
        [DataMember(Name="apiAccessIsEnabled", EmitDefaultValue=false)]
        public bool? ApiAccessIsEnabled { get; set; }
        /// <summary>
        /// Gets or Sets CreateNewClientKey
        /// </summary>
        [DataMember(Name="createNewClientKey", EmitDefaultValue=false)]
        public bool? CreateNewClientKey { get; set; }
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets RefreshTokenLifespanMinutes
        /// </summary>
        [DataMember(Name="refreshTokenLifespanMinutes", EmitDefaultValue=false)]
        public int? RefreshTokenLifespanMinutes { get; set; }
        /// <summary>
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name="standInKey", EmitDefaultValue=false)]
        public string StandInKey { get; set; }
        /// <summary>
        /// Gets or Sets TokenLifespanMinutes
        /// </summary>
        [DataMember(Name="tokenLifespanMinutes", EmitDefaultValue=false)]
        public int? TokenLifespanMinutes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySaveApiClientSettingRequest {\n");
            sb.Append("  AllowAnonymousAccess: ").Append(AllowAnonymousAccess).Append("\n");
            sb.Append("  ApiAccessIsEnabled: ").Append(ApiAccessIsEnabled).Append("\n");
            sb.Append("  CreateNewClientKey: ").Append(CreateNewClientKey).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RefreshTokenLifespanMinutes: ").Append(RefreshTokenLifespanMinutes).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
            sb.Append("  TokenLifespanMinutes: ").Append(TokenLifespanMinutes).Append("\n");
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
            return this.Equals(obj as SecuritySaveApiClientSettingRequest);
        }

        /// <summary>
        /// Returns true if SecuritySaveApiClientSettingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SecuritySaveApiClientSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecuritySaveApiClientSettingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowAnonymousAccess == other.AllowAnonymousAccess ||
                    this.AllowAnonymousAccess != null &&
                    this.AllowAnonymousAccess.Equals(other.AllowAnonymousAccess)
                ) && 
                (
                    this.ApiAccessIsEnabled == other.ApiAccessIsEnabled ||
                    this.ApiAccessIsEnabled != null &&
                    this.ApiAccessIsEnabled.Equals(other.ApiAccessIsEnabled)
                ) && 
                (
                    this.CreateNewClientKey == other.CreateNewClientKey ||
                    this.CreateNewClientKey != null &&
                    this.CreateNewClientKey.Equals(other.CreateNewClientKey)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RefreshTokenLifespanMinutes == other.RefreshTokenLifespanMinutes ||
                    this.RefreshTokenLifespanMinutes != null &&
                    this.RefreshTokenLifespanMinutes.Equals(other.RefreshTokenLifespanMinutes)
                ) && 
                (
                    this.StandInKey == other.StandInKey ||
                    this.StandInKey != null &&
                    this.StandInKey.Equals(other.StandInKey)
                ) && 
                (
                    this.TokenLifespanMinutes == other.TokenLifespanMinutes ||
                    this.TokenLifespanMinutes != null &&
                    this.TokenLifespanMinutes.Equals(other.TokenLifespanMinutes)
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
                if (this.AllowAnonymousAccess != null)
                    hash = hash * 59 + this.AllowAnonymousAccess.GetHashCode();
                if (this.ApiAccessIsEnabled != null)
                    hash = hash * 59 + this.ApiAccessIsEnabled.GetHashCode();
                if (this.CreateNewClientKey != null)
                    hash = hash * 59 + this.CreateNewClientKey.GetHashCode();
                if (this.Culture != null)
                    hash = hash * 59 + this.Culture.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RefreshTokenLifespanMinutes != null)
                    hash = hash * 59 + this.RefreshTokenLifespanMinutes.GetHashCode();
                if (this.StandInKey != null)
                    hash = hash * 59 + this.StandInKey.GetHashCode();
                if (this.TokenLifespanMinutes != null)
                    hash = hash * 59 + this.TokenLifespanMinutes.GetHashCode();
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
