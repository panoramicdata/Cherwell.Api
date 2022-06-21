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
    /// TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest :  IEquatable<TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest" /> class.
        /// </summary>
        /// <param name="AttachBusObId">AttachBusObId.</param>
        /// <param name="AttachBusObName">AttachBusObName.</param>
        /// <param name="AttachBusObPublicId">AttachBusObPublicId.</param>
        /// <param name="AttachBusObRecId">AttachBusObRecId.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObName">BusObName.</param>
        /// <param name="BusObPublicId">BusObPublicId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Comment">Comment.</param>
        /// <param name="IncludeLinks">IncludeLinks.</param>
        public TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest(string AttachBusObId = default(string), string AttachBusObName = default(string), string AttachBusObPublicId = default(string), string AttachBusObRecId = default(string), string BusObId = default(string), string BusObName = default(string), string BusObPublicId = default(string), string BusObRecId = default(string), string Comment = default(string), bool? IncludeLinks = default(bool?))
        {
            this.AttachBusObId = AttachBusObId;
            this.AttachBusObName = AttachBusObName;
            this.AttachBusObPublicId = AttachBusObPublicId;
            this.AttachBusObRecId = AttachBusObRecId;
            this.BusObId = BusObId;
            this.BusObName = BusObName;
            this.BusObPublicId = BusObPublicId;
            this.BusObRecId = BusObRecId;
            this.Comment = Comment;
            this.IncludeLinks = IncludeLinks;
        }
        
        /// <summary>
        /// Gets or Sets AttachBusObId
        /// </summary>
        [DataMember(Name="attachBusObId", EmitDefaultValue=false)]
        public string AttachBusObId { get; set; }
        /// <summary>
        /// Gets or Sets AttachBusObName
        /// </summary>
        [DataMember(Name="attachBusObName", EmitDefaultValue=false)]
        public string AttachBusObName { get; set; }
        /// <summary>
        /// Gets or Sets AttachBusObPublicId
        /// </summary>
        [DataMember(Name="attachBusObPublicId", EmitDefaultValue=false)]
        public string AttachBusObPublicId { get; set; }
        /// <summary>
        /// Gets or Sets AttachBusObRecId
        /// </summary>
        [DataMember(Name="attachBusObRecId", EmitDefaultValue=false)]
        public string AttachBusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObName
        /// </summary>
        [DataMember(Name="busObName", EmitDefaultValue=false)]
        public string BusObName { get; set; }
        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets IncludeLinks
        /// </summary>
        [DataMember(Name="includeLinks", EmitDefaultValue=false)]
        public bool? IncludeLinks { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest {\n");
            sb.Append("  AttachBusObId: ").Append(AttachBusObId).Append("\n");
            sb.Append("  AttachBusObName: ").Append(AttachBusObName).Append("\n");
            sb.Append("  AttachBusObPublicId: ").Append(AttachBusObPublicId).Append("\n");
            sb.Append("  AttachBusObRecId: ").Append(AttachBusObRecId).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObName: ").Append(BusObName).Append("\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  IncludeLinks: ").Append(IncludeLinks).Append("\n");
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
            return this.Equals(obj as TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsBusinessObjectSaveBusObAttachmentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AttachBusObId == other.AttachBusObId ||
                    this.AttachBusObId != null &&
                    this.AttachBusObId.Equals(other.AttachBusObId)
                ) && 
                (
                    this.AttachBusObName == other.AttachBusObName ||
                    this.AttachBusObName != null &&
                    this.AttachBusObName.Equals(other.AttachBusObName)
                ) && 
                (
                    this.AttachBusObPublicId == other.AttachBusObPublicId ||
                    this.AttachBusObPublicId != null &&
                    this.AttachBusObPublicId.Equals(other.AttachBusObPublicId)
                ) && 
                (
                    this.AttachBusObRecId == other.AttachBusObRecId ||
                    this.AttachBusObRecId != null &&
                    this.AttachBusObRecId.Equals(other.AttachBusObRecId)
                ) && 
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId)
                ) && 
                (
                    this.BusObName == other.BusObName ||
                    this.BusObName != null &&
                    this.BusObName.Equals(other.BusObName)
                ) && 
                (
                    this.BusObPublicId == other.BusObPublicId ||
                    this.BusObPublicId != null &&
                    this.BusObPublicId.Equals(other.BusObPublicId)
                ) && 
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.IncludeLinks == other.IncludeLinks ||
                    this.IncludeLinks != null &&
                    this.IncludeLinks.Equals(other.IncludeLinks)
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
                if (this.AttachBusObId != null)
                    hash = hash * 59 + this.AttachBusObId.GetHashCode();
                if (this.AttachBusObName != null)
                    hash = hash * 59 + this.AttachBusObName.GetHashCode();
                if (this.AttachBusObPublicId != null)
                    hash = hash * 59 + this.AttachBusObPublicId.GetHashCode();
                if (this.AttachBusObRecId != null)
                    hash = hash * 59 + this.AttachBusObRecId.GetHashCode();
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.BusObName != null)
                    hash = hash * 59 + this.BusObName.GetHashCode();
                if (this.BusObPublicId != null)
                    hash = hash * 59 + this.BusObPublicId.GetHashCode();
                if (this.BusObRecId != null)
                    hash = hash * 59 + this.BusObRecId.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.IncludeLinks != null)
                    hash = hash * 59 + this.IncludeLinks.GetHashCode();
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
