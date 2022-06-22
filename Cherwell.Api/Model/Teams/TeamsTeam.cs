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
    /// TeamsTeam
    /// </summary>
    [DataContract]
    public partial class TeamsTeam :  IEquatable<TeamsTeam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsTeam" /> class.
        /// </summary>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="TeamName">TeamName.</param>
        public TeamsTeam(string TeamId = default(string), string TeamName = default(string))
        {
            this.TeamId = TeamId;
            this.TeamName = TeamName;
        }
        
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets TeamName
        /// </summary>
        [DataMember(Name="teamName", EmitDefaultValue=false)]
        public string TeamName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsTeam {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append('\n');
            sb.Append("  TeamName: ").Append(TeamName).Append('\n');
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
            return this.Equals(obj as TeamsTeam);
        }

        /// <summary>
        /// Returns true if TeamsTeam instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamsTeam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamsTeam other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.TeamName == other.TeamName ||
                    this.TeamName != null &&
                    this.TeamName.Equals(other.TeamName)
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
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.TeamName != null)
                    hash = hash * 59 + this.TeamName.GetHashCode();
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
