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

namespace Cherwell.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectRelationship
    /// </summary>
    [DataContract]
    public partial class BusinessObjectRelationship : IEquatable<BusinessObjectRelationship>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectRelationship" /> class.
        /// </summary>
        /// <param name="Cardinality">Cardinality.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="FieldDefinitions">FieldDefinitions.</param>
        /// <param name="RelationshipId">RelationshipId.</param>
        /// <param name="Target">Target.</param>
        public BusinessObjectRelationship(string Cardinality = default(string), string Description = default(string), string DisplayName = default(string), List<BusinessObjectFieldDefinition> FieldDefinitions = default(List<BusinessObjectFieldDefinition>), string RelationshipId = default(string), string Target = default(string))
        {
            this.Cardinality = Cardinality;
            this.Description = Description;
            this.DisplayName = DisplayName;
            this.FieldDefinitions = FieldDefinitions;
            this.RelationshipId = RelationshipId;
            this.Target = Target;
        }

        /// <summary>
        /// Gets or Sets Cardinality
        /// </summary>
        [DataMember(Name = "cardinality", EmitDefaultValue = false)]
        public string Cardinality { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets FieldDefinitions
        /// </summary>
        [DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
        public List<BusinessObjectFieldDefinition> FieldDefinitions { get; set; }
        /// <summary>
        /// Gets or Sets RelationshipId
        /// </summary>
        [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
        public string RelationshipId { get; set; }
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public string Target { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectRelationship {\n");
            sb.Append("  Cardinality: ").Append(Cardinality).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FieldDefinitions: ").Append(FieldDefinitions).Append("\n");
            sb.Append("  RelationshipId: ").Append(RelationshipId).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as BusinessObjectRelationship);
        }

        /// <summary>
        /// Returns true if BusinessObjectRelationship instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectRelationship to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectRelationship other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Cardinality == other.Cardinality ||
                    this.Cardinality != null &&
                    this.Cardinality.Equals(other.Cardinality)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) &&
                (
                    this.FieldDefinitions == other.FieldDefinitions ||
                    this.FieldDefinitions != null &&
                    this.FieldDefinitions.SequenceEqual(other.FieldDefinitions)
                ) &&
                (
                    this.RelationshipId == other.RelationshipId ||
                    this.RelationshipId != null &&
                    this.RelationshipId.Equals(other.RelationshipId)
                ) &&
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
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
                if (this.Cardinality != null)
                    hash = hash * 59 + this.Cardinality.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.FieldDefinitions != null)
                    hash = hash * 59 + this.FieldDefinitions.GetHashCode();
                if (this.RelationshipId != null)
                    hash = hash * 59 + this.RelationshipId.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
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