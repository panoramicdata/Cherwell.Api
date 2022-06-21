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
    /// QueuesCheckInQueueItemRequest
    /// </summary>
    [DataContract]
    public partial class QueuesCheckInQueueItemRequest :  IEquatable<QueuesCheckInQueueItemRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuesCheckInQueueItemRequest" /> class.
        /// </summary>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="BusObRecId">BusObRecId.</param>
        /// <param name="HistoryNotes">HistoryNotes.</param>
        /// <param name="QueueStandInKey">QueueStandInKey.</param>
        public QueuesCheckInQueueItemRequest(string BusObId = default(string), string BusObRecId = default(string), string HistoryNotes = default(string), string QueueStandInKey = default(string))
        {
            this.BusObId = BusObId;
            this.BusObRecId = BusObRecId;
            this.HistoryNotes = HistoryNotes;
            this.QueueStandInKey = QueueStandInKey;
        }
        
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets BusObRecId
        /// </summary>
        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }
        /// <summary>
        /// Gets or Sets HistoryNotes
        /// </summary>
        [DataMember(Name="historyNotes", EmitDefaultValue=false)]
        public string HistoryNotes { get; set; }
        /// <summary>
        /// Gets or Sets QueueStandInKey
        /// </summary>
        [DataMember(Name="queueStandInKey", EmitDefaultValue=false)]
        public string QueueStandInKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueuesCheckInQueueItemRequest {\n");
            sb.Append("  BusObId: ").Append(BusObId).Append("\n");
            sb.Append("  BusObRecId: ").Append(BusObRecId).Append("\n");
            sb.Append("  HistoryNotes: ").Append(HistoryNotes).Append("\n");
            sb.Append("  QueueStandInKey: ").Append(QueueStandInKey).Append("\n");
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
            return this.Equals(obj as QueuesCheckInQueueItemRequest);
        }

        /// <summary>
        /// Returns true if QueuesCheckInQueueItemRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of QueuesCheckInQueueItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueuesCheckInQueueItemRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId)
                ) && 
                (
                    this.BusObRecId == other.BusObRecId ||
                    this.BusObRecId != null &&
                    this.BusObRecId.Equals(other.BusObRecId)
                ) && 
                (
                    this.HistoryNotes == other.HistoryNotes ||
                    this.HistoryNotes != null &&
                    this.HistoryNotes.Equals(other.HistoryNotes)
                ) && 
                (
                    this.QueueStandInKey == other.QueueStandInKey ||
                    this.QueueStandInKey != null &&
                    this.QueueStandInKey.Equals(other.QueueStandInKey)
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
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.BusObRecId != null)
                    hash = hash * 59 + this.BusObRecId.GetHashCode();
                if (this.HistoryNotes != null)
                    hash = hash * 59 + this.HistoryNotes.GetHashCode();
                if (this.QueueStandInKey != null)
                    hash = hash * 59 + this.QueueStandInKey.GetHashCode();
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