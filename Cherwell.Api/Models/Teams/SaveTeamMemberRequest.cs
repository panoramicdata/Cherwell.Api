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

namespace Cherwell.Api.Models.Teams;

    /// <summary>
    /// SaveTeamMemberRequest
    /// </summary>
    [DataContract]
    public partial class SaveTeamMemberRequest :  IEquatable<SaveTeamMemberRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTeamMemberRequest" /> class.
        /// </summary>
        /// <param name="IsTeamManager">IsTeamManager.</param>
        /// <param name="SetAsDefaultTeam">SetAsDefaultTeam.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="UserRecId">UserRecId.</param>
        public SaveTeamMemberRequest(bool? IsTeamManager, bool? SetAsDefaultTeam, string TeamId, string UserRecId)
        {
            this.IsTeamManager = IsTeamManager;
            this.SetAsDefaultTeam = SetAsDefaultTeam;
            this.TeamId = TeamId;
            this.UserRecId = UserRecId;
        }
        
        /// <summary>
        /// Gets or Sets IsTeamManager
        /// </summary>
        [DataMember(Name="isTeamManager", EmitDefaultValue=false)]
        public bool? IsTeamManager { get; set; }
        /// <summary>
        /// Gets or Sets SetAsDefaultTeam
        /// </summary>
        [DataMember(Name="setAsDefaultTeam", EmitDefaultValue=false)]
        public bool? SetAsDefaultTeam { get; set; }
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets UserRecId
        /// </summary>
        [DataMember(Name="userRecId", EmitDefaultValue=false)]
        public string UserRecId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamsSaveTeamMemberRequest {\n");
            sb.Append("  IsTeamManager: ").Append(IsTeamManager).Append('\n');
            sb.Append("  SetAsDefaultTeam: ").Append(SetAsDefaultTeam).Append('\n');
            sb.Append("  TeamId: ").Append(TeamId).Append('\n');
            sb.Append("  UserRecId: ").Append(UserRecId).Append('\n');
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
            return this.Equals(obj as SaveTeamMemberRequest);
        }

        /// <summary>
        /// Returns true if SaveTeamMemberRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SaveTeamMemberRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveTeamMemberRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return 
                (
                    this.IsTeamManager == other.IsTeamManager ||
                    this.IsTeamManager != null &&
                    this.IsTeamManager.Equals(other.IsTeamManager)
                ) && 
                (
                    this.SetAsDefaultTeam == other.SetAsDefaultTeam ||
                    this.SetAsDefaultTeam != null &&
                    this.SetAsDefaultTeam.Equals(other.SetAsDefaultTeam)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId, StringComparison.Ordinal)
                ) && 
                (
                    this.UserRecId == other.UserRecId ||
                    this.UserRecId != null &&
                    this.UserRecId.Equals(other.UserRecId, StringComparison.Ordinal)
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
                if (this.IsTeamManager != null)
			{
				hash = hash * 59 + this.IsTeamManager.GetHashCode();
			}

			if (this.SetAsDefaultTeam != null)
			{
				hash = hash * 59 + this.SetAsDefaultTeam.GetHashCode();
			}

			if (this.TeamId != null)
			{
				hash = hash * 59 + this.TeamId.GetHashCode();
			}

			if (this.UserRecId != null)
			{
				hash = hash * 59 + this.UserRecId.GetHashCode();
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

