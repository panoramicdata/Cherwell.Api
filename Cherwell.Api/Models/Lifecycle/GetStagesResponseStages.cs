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

namespace Cherwell.Api.Models.Lifecycle;

    /// <summary>
    /// LifecycleGetStagesResponseStages
    /// </summary>
    [DataContract]
    public partial class GetStagesResponseStages : IEquatable<GetStagesResponseStages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStagesResponseStages" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="IsFinal">IsFinal.</param>
        /// <param name="Name">Name.</param>
        public GetStagesResponseStages(string Id, bool? IsFinal, string Name)
        {
            this.Id = Id;
            this.IsFinal = IsFinal;
            this.Name = Name;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets IsFinal
        /// </summary>
        [DataMember(Name = "isFinal", EmitDefaultValue = false)]
        public bool? IsFinal { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LifecycleGetStagesResponseStages {\n");
            sb.Append("  Id: ").Append(Id).Append('\n');
            sb.Append("  IsFinal: ").Append(IsFinal).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
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
            return this.Equals(obj as GetStagesResponseStages);
        }

        /// <summary>
        /// Returns true if LifecycleGetStagesResponseStages instances are equal
        /// </summary>
        /// <param name="other">Instance of LifecycleGetStagesResponseStages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStagesResponseStages? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id, StringComparison.Ordinal)
                ) &&
                (
                    this.IsFinal == other.IsFinal ||
                    this.IsFinal != null &&
                    this.IsFinal.Equals(other.IsFinal)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name, StringComparison.Ordinal)
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
                if (this.Id != null)
			{
				hash = hash * 59 + this.Id.GetHashCode();
			}

			if (this.IsFinal != null)
			{
				hash = hash * 59 + this.IsFinal.GetHashCode();
			}

			if (this.Name != null)
			{
				hash = hash * 59 + this.Name.GetHashCode();
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