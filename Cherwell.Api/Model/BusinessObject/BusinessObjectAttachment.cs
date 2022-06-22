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

namespace Cherwell.Api.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectAttachment
    /// </summary>
    [DataContract]
    public partial class BusinessObjectAttachment : IEquatable<BusinessObjectAttachment>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AttachmentType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AttachmentTypeEnum
        {

            /// <summary>
            /// Enum Imported for "Imported"
            /// </summary>
            [EnumMember(Value = "Imported")]
            Imported,

            /// <summary>
            /// Enum Linked for "Linked"
            /// </summary>
            [EnumMember(Value = "Linked")]
            Linked,

            /// <summary>
            /// Enum URL for "URL"
            /// </summary>
            [EnumMember(Value = "URL")]
            URL
        }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum Global for "Global"
            /// </summary>
            [EnumMember(Value = "Global")]
            Global,

            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,

            /// <summary>
            /// Enum Persona for "Persona"
            /// </summary>
            [EnumMember(Value = "Persona")]
            Persona,

            /// <summary>
            /// Enum SecurityGroup for "SecurityGroup"
            /// </summary>
            [EnumMember(Value = "SecurityGroup")]
            SecurityGroup,

            /// <summary>
            /// Enum User for "User"
            /// </summary>
            [EnumMember(Value = "User")]
            User,

            /// <summary>
            /// Enum UserInPersona for "UserInPersona"
            /// </summary>
            [EnumMember(Value = "UserInPersona")]
            UserInPersona,

            /// <summary>
            /// Enum OtherUsers for "OtherUsers"
            /// </summary>
            [EnumMember(Value = "OtherUsers")]
            OtherUsers,

            /// <summary>
            /// Enum Core for "Core"
            /// </summary>
            [EnumMember(Value = "Core")]
            Core,

            /// <summary>
            /// Enum BusIntel for "BusIntel"
            /// </summary>
            [EnumMember(Value = "BusIntel")]
            BusIntel,

            /// <summary>
            /// Enum FromResource for "FromResource"
            /// </summary>
            [EnumMember(Value = "FromResource")]
            FromResource,

            /// <summary>
            /// Enum Site for "Site"
            /// </summary>
            [EnumMember(Value = "Site")]
            Site,

            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom,

            /// <summary>
            /// Enum BusObRecord for "BusObRecord"
            /// </summary>
            [EnumMember(Value = "BusObRecord")]
            BusObRecord
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,

            /// <summary>
            /// Enum File for "File"
            /// </summary>
            [EnumMember(Value = "File")]
            File,

            /// <summary>
            /// Enum FileManagerFile for "FileManagerFile"
            /// </summary>
            [EnumMember(Value = "FileManagerFile")]
            FileManagerFile,

            /// <summary>
            /// Enum BusOb for "BusOb"
            /// </summary>
            [EnumMember(Value = "BusOb")]
            BusOb,

            /// <summary>
            /// Enum History for "History"
            /// </summary>
            [EnumMember(Value = "History")]
            History,

            /// <summary>
            /// Enum Other for "Other"
            /// </summary>
            [EnumMember(Value = "Other")]
            Other,

            /// <summary>
            /// Enum Solution for "Solution"
            /// </summary>
            [EnumMember(Value = "Solution")]
            Solution,

            /// <summary>
            /// Enum UsedAsSolution for "UsedAsSolution"
            /// </summary>
            [EnumMember(Value = "UsedAsSolution")]
            UsedAsSolution,

            /// <summary>
            /// Enum ExternalSolution for "ExternalSolution"
            /// </summary>
            [EnumMember(Value = "ExternalSolution")]
            ExternalSolution
        }

        /// <summary>
        /// Gets or Sets AttachmentType
        /// </summary>
        [DataMember(Name = "attachmentType", EmitDefaultValue = false)]
        public AttachmentTypeEnum? AttachmentType { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public ScopeEnum? Scope { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectAttachment" /> class.
        /// </summary>
        /// <param name="AttachedBusObId">AttachedBusObId.</param>
        /// <param name="AttachedBusObRecId">AttachedBusObRecId.</param>
        /// <param name="AttachmentFileId">AttachmentFileId.</param>
        /// <param name="AttachmentFileName">AttachmentFileName.</param>
        /// <param name="AttachmentFileType">AttachmentFileType.</param>
        /// <param name="AttachmentId">AttachmentId.</param>
        /// <param name="AttachmentType">AttachmentType.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Comment">Comment.</param>
        /// <param name="Created">Created.</param>
        /// <param name="DisplayText">DisplayText.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="Type">Type.</param>
        public BusinessObjectAttachment(string AttachedBusObId = default(string), string AttachedBusObRecId = default(string), string AttachmentFileId = default(string), string AttachmentFileName = default(string), string AttachmentFileType = default(string), string AttachmentId = default(string), AttachmentTypeEnum? AttachmentType = default(AttachmentTypeEnum?), string BusObId = default(string), string BusObRecId = default(string), string Comment = default(string), DateTime? Created = default(DateTime?), string DisplayText = default(string), List<CoreLink> Links = default(List<CoreLink>), string Owner = default(string), ScopeEnum? Scope = default(ScopeEnum?), string ScopeOwner = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            this.AttachedBusObId = AttachedBusObId;
            this.AttachedBusObRecId = AttachedBusObRecId;
            this.AttachmentFileId = AttachmentFileId;
            this.AttachmentFileName = AttachmentFileName;
            this.AttachmentFileType = AttachmentFileType;
            this.AttachmentId = AttachmentId;
            this.AttachmentType = AttachmentType;
            this.BusObId = BusObId;
            this.BusObRecId = BusObRecId;
            this.Comment = Comment;
            this.Created = Created;
            this.DisplayText = DisplayText;
            this.Links = Links;
            this.Owner = Owner;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.Type = Type;
        }

        /// <summary>
        /// Gets or Sets AttachedBusObId
        /// </summary>
        [DataMember(Name = "attachedBusObId", EmitDefaultValue = false)]
        public string AttachedBusObId { get; set; }
        /// <summary>
        /// Gets or Sets AttachedBusObRecId
        /// </summary>
        [DataMember(Name = "attachedBusObRecId", EmitDefaultValue = false)]
        public string AttachedBusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentFileId
        /// </summary>
        [DataMember(Name = "attachmentFileId", EmitDefaultValue = false)]
        public string AttachmentFileId { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentFileName
        /// </summary>
        [DataMember(Name = "attachmentFileName", EmitDefaultValue = false)]
        public string AttachmentFileName { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentFileType
        /// </summary>
        [DataMember(Name = "attachmentFileType", EmitDefaultValue = false)]
        public string AttachmentFileType { get; set; }
        /// <summary>
        /// Gets or Sets AttachmentId
        /// </summary>
        [DataMember(Name = "attachmentId", EmitDefaultValue = false)]
        public string AttachmentId { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name = "displayText", EmitDefaultValue = false)]
        public string DisplayText { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<CoreLink> Links { get; set; }
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }
        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
        public string ScopeOwner { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectAttachment {\n");
            sb.Append("  AttachedBusObId: ").Append(AttachedBusObId).Append("\n");
            sb.Append("  AttachedBusObRecId: ").Append(AttachedBusObRecId).Append("\n");
            sb.Append("  AttachmentFileId: ").Append(AttachmentFileId).Append("\n");
            sb.Append("  AttachmentFileName: ").Append(AttachmentFileName).Append("\n");
            sb.Append("  AttachmentFileType: ").Append(AttachmentFileType).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  AttachmentType: ").Append(AttachmentType).Append("\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as BusinessObjectAttachment);
        }

        /// <summary>
        /// Returns true if BusinessObjectAttachment instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectAttachment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectAttachment? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.AttachedBusObId == other.AttachedBusObId ||
                    this.AttachedBusObId != null &&
                    this.AttachedBusObId.Equals(other.AttachedBusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.AttachedBusObRecId == other.AttachedBusObRecId ||
                    this.AttachedBusObRecId != null &&
                    this.AttachedBusObRecId.Equals(other.AttachedBusObRecId, StringComparison.Ordinal)
                ) &&
                (
                    this.AttachmentFileId == other.AttachmentFileId ||
                    this.AttachmentFileId != null &&
                    this.AttachmentFileId.Equals(other.AttachmentFileId, StringComparison.Ordinal)
                ) &&
                (
                    this.AttachmentFileName == other.AttachmentFileName ||
                    this.AttachmentFileName != null &&
                    this.AttachmentFileName.Equals(other.AttachmentFileName, StringComparison.Ordinal)
                ) &&
                (
                    this.AttachmentFileType == other.AttachmentFileType ||
                    this.AttachmentFileType != null &&
                    this.AttachmentFileType.Equals(other.AttachmentFileType, StringComparison.Ordinal)
                ) &&
                (
                    this.AttachmentId == other.AttachmentId ||
                    this.AttachmentId != null &&
                    this.AttachmentId.Equals(other.AttachmentId, StringComparison.Ordinal)
                ) &&
                (
                    this.AttachmentType == other.AttachmentType ||
                    this.AttachmentType != null &&
                    this.AttachmentType.Equals(other.AttachmentType)
                ) &&
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
                ) &&
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment, StringComparison.Ordinal)
                ) &&
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) &&
                (
                    this.DisplayText == other.DisplayText ||
                    this.DisplayText != null &&
                    this.DisplayText.Equals(other.DisplayText, StringComparison.Ordinal)
                ) &&
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(other.Links)
                ) &&
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner, StringComparison.Ordinal)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.ScopeOwner == other.ScopeOwner ||
                    this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(other.ScopeOwner, StringComparison.Ordinal)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AttachedBusObId != null)
                    hash = hash * 59 + this.AttachedBusObId.GetHashCode();
                if (this.AttachedBusObRecId != null)
                    hash = hash * 59 + this.AttachedBusObRecId.GetHashCode();
                if (this.AttachmentFileId != null)
                    hash = hash * 59 + this.AttachmentFileId.GetHashCode();
                if (this.AttachmentFileName != null)
                    hash = hash * 59 + this.AttachmentFileName.GetHashCode();
                if (this.AttachmentFileType != null)
                    hash = hash * 59 + this.AttachmentFileType.GetHashCode();
                if (this.AttachmentId != null)
                    hash = hash * 59 + this.AttachmentId.GetHashCode();
                if (this.AttachmentType != null)
                    hash = hash * 59 + this.AttachmentType.GetHashCode();
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.BusObRecId != null)
                    hash = hash * 59 + this.BusObRecId.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.DisplayText != null)
                    hash = hash * 59 + this.DisplayText.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hash = hash * 59 + this.ScopeOwner.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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