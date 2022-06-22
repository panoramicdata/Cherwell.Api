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

namespace Cherwell.Api.Model.Core
{
    /// <summary>
    /// CoreSaveStoredValueRequest
    /// </summary>
    [DataContract]
    public partial class CoreSaveStoredValueRequest : IEquatable<CoreSaveStoredValueRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets StoredValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StoredValueTypeEnum
        {

            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,

            /// <summary>
            /// Enum Number for "Number"
            /// </summary>
            [EnumMember(Value = "Number")]
            Number,

            /// <summary>
            /// Enum DateTime for "DateTime"
            /// </summary>
            [EnumMember(Value = "DateTime")]
            DateTime,

            /// <summary>
            /// Enum Logical for "Logical"
            /// </summary>
            [EnumMember(Value = "Logical")]
            Logical,

            /// <summary>
            /// Enum Color for "Color"
            /// </summary>
            [EnumMember(Value = "Color")]
            Color,

            /// <summary>
            /// Enum Json for "Json"
            /// </summary>
            [EnumMember(Value = "Json")]
            Json,

            /// <summary>
            /// Enum JsonArray for "JsonArray"
            /// </summary>
            [EnumMember(Value = "JsonArray")]
            JsonArray,

            /// <summary>
            /// Enum Xml for "Xml"
            /// </summary>
            [EnumMember(Value = "Xml")]
            Xml,

            /// <summary>
            /// Enum XmlCollection for "XmlCollection"
            /// </summary>
            [EnumMember(Value = "XmlCollection")]
            XmlCollection
        }

        /// <summary>
        /// Gets or Sets StoredValueType
        /// </summary>
        [DataMember(Name = "storedValueType", EmitDefaultValue = false)]
        public StoredValueTypeEnum? StoredValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreSaveStoredValueRequest" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Folder">Folder.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Scope">Scope.</param>
        /// <param name="ScopeOwner">ScopeOwner.</param>
        /// <param name="StandInKey">StandInKey.</param>
        /// <param name="StoredValueType">StoredValueType.</param>
        /// <param name="Value">Value.</param>
        public CoreSaveStoredValueRequest(string Description = default(string), string Folder = default(string), string Name = default(string), string Scope = default(string), string ScopeOwner = default(string), string StandInKey = default(string), StoredValueTypeEnum? StoredValueType = default(StoredValueTypeEnum?), string Value = default(string))
        {
            this.Description = Description;
            this.Folder = Folder;
            this.Name = Name;
            this.Scope = Scope;
            this.ScopeOwner = ScopeOwner;
            this.StandInKey = StandInKey;
            this.StoredValueType = StoredValueType;
            this.Value = Value;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name = "folder", EmitDefaultValue = false)]
        public string Folder { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }
        /// <summary>
        /// Gets or Sets ScopeOwner
        /// </summary>
        [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
        public string ScopeOwner { get; set; }
        /// <summary>
        /// Gets or Sets StandInKey
        /// </summary>
        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreSaveStoredValueRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  ScopeOwner: ").Append(ScopeOwner).Append("\n");
            sb.Append("  StandInKey: ").Append(StandInKey).Append("\n");
            sb.Append("  StoredValueType: ").Append(StoredValueType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as CoreSaveStoredValueRequest);
        }

        /// <summary>
        /// Returns true if CoreSaveStoredValueRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreSaveStoredValueRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CoreSaveStoredValueRequest other)
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
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
                ) &&
                (
                    this.ScopeOwner == other.ScopeOwner ||
                    this.ScopeOwner != null &&
                    this.ScopeOwner.Equals(other.ScopeOwner)
                ) &&
                (
                    this.StandInKey == other.StandInKey ||
                    this.StandInKey != null &&
                    this.StandInKey.Equals(other.StandInKey)
                ) &&
                (
                    this.StoredValueType == other.StoredValueType ||
                    this.StoredValueType != null &&
                    this.StoredValueType.Equals(other.StoredValueType)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                if (this.ScopeOwner != null)
                    hash = hash * 59 + this.ScopeOwner.GetHashCode();
                if (this.StandInKey != null)
                    hash = hash * 59 + this.StandInKey.GetHashCode();
                if (this.StoredValueType != null)
                    hash = hash * 59 + this.StoredValueType.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
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
