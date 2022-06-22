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

namespace Cherwell.Api.Model.BusinessObject
{
    /// <summary>
    /// BusinessObjectViewSummary
    /// </summary>
    [DataContract]
    public partial class BusinessObjectViewSummary : IEquatable<BusinessObjectViewSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectViewSummary" /> class.
        /// </summary>
        /// <param name="GroupSummaries">GroupSummaries.</param>
        /// <param name="Image">Image.</param>
        /// <param name="IsPartOfView">IsPartOfView.</param>
        /// <param name="BusObId">BusObId.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Lookup">Lookup.</param>
        /// <param name="Major">Major.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Supporting">Supporting.</param>
        public BusinessObjectViewSummary(List<BusinessObjectViewSummary> GroupSummaries = default(List<BusinessObjectViewSummary>), string Image = default, bool? IsPartOfView = default(bool?), string BusObId = default, string DisplayName = default, bool? Group = default(bool?), bool? Lookup = default(bool?), bool? Major = default(bool?), string Name = default, bool? Supporting = default(bool?))
        {
            this.GroupSummaries = GroupSummaries;
            this.Image = Image;
            this.IsPartOfView = IsPartOfView;
            this.BusObId = BusObId;
            this.DisplayName = DisplayName;
            this.Group = Group;
            this.Lookup = Lookup;
            this.Major = Major;
            this.Name = Name;
            this.Supporting = Supporting;
        }

        /// <summary>
        /// Gets or Sets GroupSummaries
        /// </summary>
        [DataMember(Name = "groupSummaries", EmitDefaultValue = false)]
        public List<BusinessObjectViewSummary> GroupSummaries { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }
        /// <summary>
        /// Gets or Sets IsPartOfView
        /// </summary>
        [DataMember(Name = "isPartOfView", EmitDefaultValue = false)]
        public bool? IsPartOfView { get; set; }
        /// <summary>
        /// Gets or Sets BusObId
        /// </summary>
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public bool? Group { get; set; }
        /// <summary>
        /// Gets or Sets Lookup
        /// </summary>
        [DataMember(Name = "lookup", EmitDefaultValue = false)]
        public bool? Lookup { get; set; }
        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name = "major", EmitDefaultValue = false)]
        public bool? Major { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Supporting
        /// </summary>
        [DataMember(Name = "supporting", EmitDefaultValue = false)]
        public bool? Supporting { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessObjectViewSummary {\n");
            sb.Append("  GroupSummaries: ").Append(GroupSummaries).Append('\n');
            sb.Append("  Image: ").Append(Image).Append('\n');
            sb.Append("  IsPartOfView: ").Append(IsPartOfView).Append('\n');
            sb.Append("  BusObId: ").Append(BusObId).Append('\n');
            sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
            sb.Append("  Group: ").Append(Group).Append('\n');
            sb.Append("  Lookup: ").Append(Lookup).Append('\n');
            sb.Append("  Major: ").Append(Major).Append('\n');
            sb.Append("  Name: ").Append(Name).Append('\n');
            sb.Append("  Supporting: ").Append(Supporting).Append('\n');
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
            return this.Equals(obj as BusinessObjectViewSummary);
        }

        /// <summary>
        /// Returns true if BusinessObjectViewSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessObjectViewSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessObjectViewSummary? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.GroupSummaries == other.GroupSummaries ||
                    this.GroupSummaries != null &&
                    this.GroupSummaries.SequenceEqual(other.GroupSummaries)
                ) &&
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image, StringComparison.Ordinal)
                ) &&
                (
                    this.IsPartOfView == other.IsPartOfView ||
                    this.IsPartOfView != null &&
                    this.IsPartOfView.Equals(other.IsPartOfView)
                ) &&
                (
                    this.BusObId == other.BusObId ||
                    this.BusObId != null &&
                    this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
                ) &&
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) &&
                (
                    this.Lookup == other.Lookup ||
                    this.Lookup != null &&
                    this.Lookup.Equals(other.Lookup)
                ) &&
                (
                    this.Major == other.Major ||
                    this.Major != null &&
                    this.Major.Equals(other.Major)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name, StringComparison.Ordinal)
                ) &&
                (
                    this.Supporting == other.Supporting ||
                    this.Supporting != null &&
                    this.Supporting.Equals(other.Supporting)
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
                if (this.GroupSummaries != null)
                    hash = hash * 59 + this.GroupSummaries.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.IsPartOfView != null)
                    hash = hash * 59 + this.IsPartOfView.GetHashCode();
                if (this.BusObId != null)
                    hash = hash * 59 + this.BusObId.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Lookup != null)
                    hash = hash * 59 + this.Lookup.GetHashCode();
                if (this.Major != null)
                    hash = hash * 59 + this.Major.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Supporting != null)
                    hash = hash * 59 + this.Supporting.GetHashCode();
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