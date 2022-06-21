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

namespace Cherwell.Model.Core;

/// <summary>
/// CoreLogBatchRequest
/// </summary>
[DataContract]
public partial class CoreLogBatchRequest :  IEquatable<CoreLogBatchRequest>, IValidatableObject
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CoreLogBatchRequest" /> class.
    /// </summary>
    /// <param name="LogRequests">LogRequests.</param>
    public CoreLogBatchRequest(List<CoreLogRequest> LogRequests = default(List<CoreLogRequest>))
    {
        this.LogRequests = LogRequests;
    }
    
    /// <summary>
    /// Gets or Sets LogRequests
    /// </summary>
    [DataMember(Name="logRequests", EmitDefaultValue=false)]
    public List<CoreLogRequest> LogRequests { get; set; }
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoreLogBatchRequest {\n");
        sb.Append("  LogRequests: ").Append(LogRequests).Append("\n");
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
        return this.Equals(obj as CoreLogBatchRequest);
    }

    /// <summary>
    /// Returns true if CoreLogBatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CoreLogBatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoreLogBatchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
            return false;

        return 
            (
                this.LogRequests == other.LogRequests ||
                this.LogRequests != null &&
                this.LogRequests.SequenceEqual(other.LogRequests)
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
            if (this.LogRequests != null)
                hash = hash * 59 + this.LogRequests.GetHashCode();
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

