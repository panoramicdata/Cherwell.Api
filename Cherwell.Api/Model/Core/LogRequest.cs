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
    /// CoreLogRequest
    /// </summary>
    [DataContract]
    public partial class LogRequest : IEquatable<LogRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnumLevel
        {

            /// <summary>
            /// Enum Fatal for "Fatal"
            /// </summary>
            [EnumMember(Value = "Fatal")]
            Fatal,

            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error,

            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning,

            /// <summary>
            /// Enum Info for "Info"
            /// </summary>
            [EnumMember(Value = "Info")]
            Info,

            /// <summary>
            /// Enum Stats for "Stats"
            /// </summary>
            [EnumMember(Value = "Stats")]
            Stats,

            /// <summary>
            /// Enum Debug for "Debug"
            /// </summary>
            [EnumMember(Value = "Debug")]
            Debug
        }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public EnumLevel? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        /// <param name="KeyValueProperties">KeyValueProperties.</param>
        /// <param name="Level">Level.</param>
        /// <param name="Message">Message.</param>
        public LogRequest(List<Object> KeyValueProperties = default(List<Object>), EnumLevel? Level = default(EnumLevel?), string Message = default)
        {
            this.KeyValueProperties = KeyValueProperties;
            this.Level = Level;
            this.Message = Message;
        }

        /// <summary>
        /// Gets or Sets KeyValueProperties
        /// </summary>
        [DataMember(Name = "keyValueProperties", EmitDefaultValue = false)]
        public List<Object> KeyValueProperties { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CoreLogRequest {\n");
            sb.Append("  KeyValueProperties: ").Append(KeyValueProperties).Append('\n');
            sb.Append("  Level: ").Append(Level).Append('\n');
            sb.Append("  Message: ").Append(Message).Append('\n');
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
            return this.Equals(obj as LogRequest);
        }

        /// <summary>
        /// Returns true if CoreLogRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CoreLogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRequest? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.KeyValueProperties == other.KeyValueProperties ||
                    this.KeyValueProperties != null &&
                    this.KeyValueProperties.SequenceEqual(other.KeyValueProperties)
                ) &&
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message, StringComparison.Ordinal)
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
                if (this.KeyValueProperties != null)
                    hash = hash * 59 + this.KeyValueProperties.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
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
