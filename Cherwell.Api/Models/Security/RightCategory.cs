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

namespace Cherwell.Api.Models.Security;

    /// <summary>
    /// RightCategory
    /// </summary>
    [DataContract]
    public partial class RightCategory :  IEquatable<RightCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RightCategory" /> class.
        /// </summary>
        /// <param name="CategoryDescription">CategoryDescription.</param>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="CategoryName">CategoryName.</param>
        public RightCategory(string CategoryDescription, string CategoryId, string CategoryName)
        {
            this.CategoryDescription = CategoryDescription;
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
        }
        
        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name="categoryDescription", EmitDefaultValue=false)]
        public string CategoryDescription { get; set; }
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="categoryId", EmitDefaultValue=false)]
        public string CategoryId { get; set; }
        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="categoryName", EmitDefaultValue=false)]
        public string CategoryName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityRightCategory {\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append('\n');
            sb.Append("  CategoryId: ").Append(CategoryId).Append('\n');
            sb.Append("  CategoryName: ").Append(CategoryName).Append('\n');
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
            return this.Equals(obj as RightCategory);
        }

        /// <summary>
        /// Returns true if RightCategory instances are equal
        /// </summary>
        /// <param name="other">Instance of RightCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RightCategory? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return 
                (
                    this.CategoryDescription == other.CategoryDescription ||
                    this.CategoryDescription != null &&
                    this.CategoryDescription.Equals(other.CategoryDescription, StringComparison.Ordinal)
                ) && 
                (
                    this.CategoryId == other.CategoryId ||
                    this.CategoryId != null &&
                    this.CategoryId.Equals(other.CategoryId, StringComparison.Ordinal)
                ) && 
                (
                    this.CategoryName == other.CategoryName ||
                    this.CategoryName != null &&
                    this.CategoryName.Equals(other.CategoryName, StringComparison.Ordinal)
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
                if (this.CategoryDescription != null)
			{
				hash = hash * 59 + this.CategoryDescription.GetHashCode();
			}

			if (this.CategoryId != null)
			{
				hash = hash * 59 + this.CategoryId.GetHashCode();
			}

			if (this.CategoryName != null)
			{
				hash = hash * 59 + this.CategoryName.GetHashCode();
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

