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

namespace Cherwell.Api.Model.Lifecycle
{
    /// <summary>
    /// LifecycleGetTransitionOptionsResponseTransition
    /// </summary>
    [DataContract]
    public partial class LifecycleGetTransitionOptionsResponseTransition : IEquatable<LifecycleGetTransitionOptionsResponseTransition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LifecycleGetTransitionOptionsResponseTransition" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Id">Id.</param>
        /// <param name="IsAvailable">IsAvailable.</param>
        /// <param name="Criteria">Criteria.</param>
        public LifecycleGetTransitionOptionsResponseTransition(string Name = default(string), string Id = default(string), bool? IsAvailable = default(bool?), List<string> Criteria = default(List<string>))
        {
            this.Name = Name;
            this.Id = Id;
            this.IsAvailable = IsAvailable;
            this.Criteria = Criteria;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets IsAvailable
        /// </summary>
        [DataMember(Name = "isAvailable", EmitDefaultValue = false)]
        public bool? IsAvailable { get; set; }
        /// <summary>
        /// Gets or Sets Criteria
        /// </summary>
        [DataMember(Name = "criteria", EmitDefaultValue = false)]
        public List<string> Criteria { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LifecycleGetTransitionOptionsResponseTransition {\n");
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  IsAvailable: ").Append(IsAvailable).Append('\n');
            sb.Append("  Criteria: ").Append(Criteria).Append('\n');
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
            return this.Equals(obj as LifecycleGetTransitionOptionsResponseTransition);
        }

        /// <summary>
        /// Returns true if LifecycleGetTransitionOptionsResponseTransition instances are equal
        /// </summary>
        /// <param name="other">Instance of LifecycleGetTransitionOptionsResponseTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LifecycleGetTransitionOptionsResponseTransition other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.IsAvailable == other.IsAvailable ||
                    this.IsAvailable != null &&
                    this.IsAvailable.Equals(other.IsAvailable)
                ) &&
                (
                    this.Criteria == other.Criteria ||
                    this.Criteria != null &&
                    this.Criteria.SequenceEqual(other.Criteria)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsAvailable != null)
                    hash = hash * 59 + this.IsAvailable.GetHashCode();
                if (this.Criteria != null)
                    hash = hash * 59 + this.Criteria.GetHashCode();
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
