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

namespace Cherwell.Api.Models.Users;

    /// <summary>
    /// UserSaveResponse
    /// </summary>
    [DataContract]
    public partial class UserSaveResponse : IEquatable<UserSaveResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSaveResponse" /> class.
        /// </summary>
        /// <param name="BusObPublicId">BusObPublicId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="Error">Error.</param>
        /// <param name="ErrorCode">ErrorCode.</param>
        /// <param name="HasError">HasError.</param>
        public UserSaveResponse(string BusObPublicId, string BusObRecId, string Error, string ErrorCode, bool? HasError)
        {
            this.BusObPublicId = BusObPublicId;
            this.BusObRecId = BusObRecId;
            this.Error = Error;
            this.ErrorCode = ErrorCode;
            this.HasError = HasError;
        }

        /// <summary>
        /// Gets or Sets BusObPublicId
        /// </summary>
        [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
        public string BusObPublicId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }
        /// <summary>
        /// Gets or Sets ErrorCode
        /// </summary>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }
        /// <summary>
        /// Gets or Sets HasError
        /// </summary>
        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSaveResponse {\n");
            sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
            sb.Append("  Error: ").Append(Error).Append('\n');
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
            sb.Append("  HasError: ").Append(HasError).Append('\n');
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
            return Equals(obj as UserSaveResponse);
        }

        /// <summary>
        /// Returns true if UserSaveResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSaveResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSaveResponse? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
		{
			return false;
		}

		return
                (
                    BusObPublicId == other.BusObPublicId ||
                    BusObPublicId != null &&
                    BusObPublicId.Equals(other.BusObPublicId, StringComparison.Ordinal)
                ) &&
                (
                    BusObRecId == other.BusObRecId ||
                    BusObRecId != null &&
                    BusObRecId.Equals(other.BusObRecId, StringComparison.Ordinal)
                ) &&
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error, StringComparison.Ordinal)
                ) &&
                (
                    ErrorCode == other.ErrorCode ||
                    ErrorCode != null &&
                    ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
                ) &&
                (
                    HasError == other.HasError ||
                    HasError != null &&
                    HasError.Equals(other.HasError)
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
                if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (Error != null)
			{
				hash = hash * 59 + Error.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
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

