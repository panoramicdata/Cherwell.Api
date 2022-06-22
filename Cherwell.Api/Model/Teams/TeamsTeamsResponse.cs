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
    /// TeamsTeamsResponse
    /// </summary>
    [DataContract]
    public partial class TeamsTeamsResponse :  IEquatable<TeamsTeamsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeamsResponse" /> class.
        /// </summary>
        /// <param name="Error">Error.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="HasError">HasError.</param>
        /// <param name="Teams">Teams.</param>
        public TeamsTeamsResponse(string Error = default, string ErrorCode = default, bool? HasError = default(bool?), List<TeamsTeam> Teams = default(List<TeamsTeam>))
        {
            this.Error = Error;
            this.ErrorCode = ErrorCode;
            this.HasError = HasError;
            this.Teams = Teams;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }
        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<TeamsTeam> Teams { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsTeamsResponse {\n");
            sb.Append("  Error: ").Append(Error).Append('\n');
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
            sb.Append("  HasError: ").Append(HasError).Append('\n');
            sb.Append("  Teams: ").Append(Teams).Append('\n');
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
            return this.Equals(obj as TeamsTeamsResponse);
        }

        /// <summary>
        /// Returns true if TeamsTeamsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamsTeamsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsTeamsResponse? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error, StringComparison.Ordinal)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
                ) && 
                (
                    this.HasError == other.HasError ||
                    this.HasError != null &&
                    this.HasError.Equals(other.HasError)
                ) && 
                (
                    this.Teams == other.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(other.Teams)
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
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.HasError != null)
                    hash = hash * 59 + this.HasError.GetHashCode();
                if (this.Teams != null)
                    hash = hash * 59 + this.Teams.GetHashCode();
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
