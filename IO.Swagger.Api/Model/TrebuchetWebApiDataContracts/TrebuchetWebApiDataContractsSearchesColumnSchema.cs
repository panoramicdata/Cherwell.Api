/* 
 * Cherwell Rest API
 *
 * <a href=\"https://xantes.sharepoint.com/sites/supporthelp\">Cherwell Rest API Documentation</a><br>Select version options from the header drop-down list (to the left of the Client Key box). Then, click Explore to view different versions of operations.
 *
 * OpenAPI spec version: 10.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

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
    /// TrebuchetWebApiDataContractsSearchesColumnSchema
    /// </summary>
    [DataContract]
    public partial class TrebuchetWebApiDataContractsSearchesColumnSchema :  IEquatable<TrebuchetWebApiDataContractsSearchesColumnSchema>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
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
            /// Enum Currency for "Currency"
            /// </summary>
            [EnumMember(Value = "Currency")]
            Currency,
            
            /// <summary>
            /// Enum Integer for "Integer"
            /// </summary>
            [EnumMember(Value = "Integer")]
            Integer,
            
            /// <summary>
            /// Enum Datetime for "Datetime"
            /// </summary>
            [EnumMember(Value = "Datetime")]
            Datetime,
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>
            [EnumMember(Value = "Date")]
            Date,
            
            /// <summary>
            /// Enum Time for "Time"
            /// </summary>
            [EnumMember(Value = "Time")]
            Time,
            
            /// <summary>
            /// Enum Logical for "Logical"
            /// </summary>
            [EnumMember(Value = "Logical")]
            Logical
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrebuchetWebApiDataContractsSearchesColumnSchema" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="Type">Type.</param>
        public TrebuchetWebApiDataContractsSearchesColumnSchema(string Name = default(string), string FieldId = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            this.Name = Name;
            this.FieldId = FieldId;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrebuchetWebApiDataContractsSearchesColumnSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
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
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TrebuchetWebApiDataContractsSearchesColumnSchema);
        }

        /// <summary>
        /// Returns true if TrebuchetWebApiDataContractsSearchesColumnSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of TrebuchetWebApiDataContractsSearchesColumnSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrebuchetWebApiDataContractsSearchesColumnSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
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
