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
    /// TrebuchetWebApiDataContractsSecurityTokenResponse
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSecurityTokenResponse :  IEquatable<TrebuchetWebApiDataContractsSecurityTokenResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSecurityTokenResponse" /> class.
        /// </summary>
        /// <param name="AccessToken">AccessToken.</param>
        /// <param name="AsclientId">AsclientId.</param>
        /// <param name="Expires">Expires.</param>
        /// <param name="ExpiresIn">ExpiresIn.</param>
        /// <param name="Issued">Issued.</param>
        /// <param name="RefreshToken">RefreshToken.</param>
        /// <param name="TokenType">TokenType.</param>
        /// <param name="Username">Username.</param>
        public TrebuchetWebApiDataContractsSecurityTokenResponse(string AccessToken = default(string), string AsclientId = default(string), string Expires = default(string), int? ExpiresIn = default(int?), string Issued = default(string), string RefreshToken = default(string), string TokenType = default(string), string Username = default(string))
        {
            this.AccessToken = AccessToken;
            this.AsclientId = AsclientId;
            this.Expires = Expires;
            this.ExpiresIn = ExpiresIn;
            this.Issued = Issued;
            this.RefreshToken = RefreshToken;
            this.TokenType = TokenType;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or Sets AsclientId
        /// </summary>
        [DataMember(Name="as:client_id", EmitDefaultValue=false)]
        public string AsclientId { get; set; }
        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name=".expires", EmitDefaultValue=false)]
        public string Expires { get; set; }
        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }
        /// <summary>
        /// Gets or Sets Issued
        /// </summary>
        [DataMember(Name=".issued", EmitDefaultValue=false)]
        public string Issued { get; set; }
        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }
        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSecurityTokenResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AsclientId: ").Append(AsclientId).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Issued: ").Append(Issued).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(obj as TrebuchetWebApiDataContractsSecurityTokenResponse);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSecurityTokenResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsSecurityTokenResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSecurityTokenResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.AsclientId == other.AsclientId ||
                    this.AsclientId != null &&
                    this.AsclientId.Equals(other.AsclientId)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) && 
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    this.Issued == other.Issued ||
                    this.Issued != null &&
                    this.Issued.Equals(other.Issued)
                ) && 
                (
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
                ) && 
                (
                    this.TokenType == other.TokenType ||
                    this.TokenType != null &&
                    this.TokenType.Equals(other.TokenType)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.AsclientId != null)
                    hash = hash * 59 + this.AsclientId.GetHashCode();
                if (this.Expires != null)
                    hash = hash * 59 + this.Expires.GetHashCode();
                if (this.ExpiresIn != null)
                    hash = hash * 59 + this.ExpiresIn.GetHashCode();
                if (this.Issued != null)
                    hash = hash * 59 + this.Issued.GetHashCode();
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                if (this.TokenType != null)
                    hash = hash * 59 + this.TokenType.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
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
