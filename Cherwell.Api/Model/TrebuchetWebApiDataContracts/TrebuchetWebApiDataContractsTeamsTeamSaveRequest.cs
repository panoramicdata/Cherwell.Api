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
    /// TrebuchetWebApiDataContractsTeamsTeamSaveRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsTeamsTeamSaveRequest :  IEquatable<TrebuchetWebApiDataContractsTeamsTeamSaveRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TeamType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TeamTypeEnum
        {
            
            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,
            
            /// <summary>
            /// Enum CustomerWorkgroup for "CustomerWorkgroup"
            /// </summary>
            [EnumMember(Value = "CustomerWorkgroup")]
            CustomerWorkgroup
        }

        /// <summary>
        /// Gets or Sets TeamType
        /// </summary>
        [DataMember(Name="teamType", EmitDefaultValue=false)]
        public TeamTypeEnum? TeamType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsTeamsTeamSaveRequest" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="EmailAlias">EmailAlias.</param>
        /// <param name="Image">Image.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="TeamName">TeamName.</param>
        /// <param name="TeamType">TeamType.</param>
        public TrebuchetWebApiDataContractsTeamsTeamSaveRequest(string Description = default(string), string EmailAlias = default(string), string Image = default(string), string TeamId = default(string), string TeamName = default(string), TeamTypeEnum? TeamType = default(TeamTypeEnum?))
        {
            this.Description = Description;
            this.EmailAlias = EmailAlias;
            this.Image = Image;
            this.TeamId = TeamId;
            this.TeamName = TeamName;
            this.TeamType = TeamType;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets EmailAlias
        /// </summary>
        [DataMember(Name="emailAlias", EmitDefaultValue=false)]
        public string EmailAlias { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
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
            sb.Append("class TrebuchetWebApiDataContractsTeamsTeamSaveRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmailAlias: ").Append(EmailAlias).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TeamName: ").Append(TeamName).Append("\n");
            sb.Append("  TeamType: ").Append(TeamType).Append("\n");
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
            return this.Equals(obj as TrebuchetWebApiDataContractsTeamsTeamSaveRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsTeamsTeamSaveRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsTeamsTeamSaveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsTeamsTeamSaveRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.EmailAlias == other.EmailAlias ||
                    this.EmailAlias != null &&
                    this.EmailAlias.Equals(other.EmailAlias)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.TeamName == other.TeamName ||
                    this.TeamName != null &&
                    this.TeamName.Equals(other.TeamName)
                ) && 
                (
                    this.TeamType == other.TeamType ||
                    this.TeamType != null &&
                    this.TeamType.Equals(other.TeamType)
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
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.EmailAlias != null)
                    hash = hash * 59 + this.EmailAlias.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.TeamName != null)
                    hash = hash * 59 + this.TeamName.GetHashCode();
                if (this.TeamType != null)
                    hash = hash * 59 + this.TeamType.GetHashCode();
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
