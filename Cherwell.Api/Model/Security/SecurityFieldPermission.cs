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

namespace Cherwell.Api.Model.Security
{
    /// <summary>
    /// SecurityFieldPermission
    /// </summary>
    [DataContract]
    public partial class SecurityFieldPermission : IEquatable<SecurityFieldPermission>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityFieldPermission" /> class.
        /// </summary>
        /// <param name="DepartmentMemberEdit">DepartmentMemberEdit.</param>
        /// <param name="DepartmentMemberView">DepartmentMemberView.</param>
        /// <param name="Edit">Edit.</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="ManagerOfOwnerEdit">ManagerOfOwnerEdit.</param>
        /// <param name="ManagerOfOwnerView">ManagerOfOwnerView.</param>
        /// <param name="OwnerEdit">OwnerEdit.</param>
        /// <param name="OwnerView">OwnerView.</param>
        /// <param name="TeamEdit">TeamEdit.</param>
        /// <param name="TeamManagerOfOwnerEdit">TeamManagerOfOwnerEdit.</param>
        /// <param name="TeamManagerOfOwnerView">TeamManagerOfOwnerView.</param>
        /// <param name="TeamView">TeamView.</param>
        /// <param name="View">View.</param>
        public SecurityFieldPermission(bool? DepartmentMemberEdit = default(bool?), bool? DepartmentMemberView = default(bool?), bool? Edit = default(bool?), string FieldId = default(string), string FieldName = default(string), bool? ManagerOfOwnerEdit = default(bool?), bool? ManagerOfOwnerView = default(bool?), bool? OwnerEdit = default(bool?), bool? OwnerView = default(bool?), bool? TeamEdit = default(bool?), bool? TeamManagerOfOwnerEdit = default(bool?), bool? TeamManagerOfOwnerView = default(bool?), bool? TeamView = default(bool?), bool? View = default(bool?))
        {
            this.DepartmentMemberEdit = DepartmentMemberEdit;
            this.DepartmentMemberView = DepartmentMemberView;
            this.Edit = Edit;
            this.FieldId = FieldId;
            this.FieldName = FieldName;
            this.ManagerOfOwnerEdit = ManagerOfOwnerEdit;
            this.ManagerOfOwnerView = ManagerOfOwnerView;
            this.OwnerEdit = OwnerEdit;
            this.OwnerView = OwnerView;
            this.TeamEdit = TeamEdit;
            this.TeamManagerOfOwnerEdit = TeamManagerOfOwnerEdit;
            this.TeamManagerOfOwnerView = TeamManagerOfOwnerView;
            this.TeamView = TeamView;
            this.View = View;
        }

        /// <summary>
        /// Gets or Sets DepartmentMemberEdit
        /// </summary>
        [DataMember(Name = "departmentMemberEdit", EmitDefaultValue = false)]
        public bool? DepartmentMemberEdit { get; set; }
        /// <summary>
        /// Gets or Sets DepartmentMemberView
        /// </summary>
        [DataMember(Name = "departmentMemberView", EmitDefaultValue = false)]
        public bool? DepartmentMemberView { get; set; }
        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name = "edit", EmitDefaultValue = false)]
        public bool? Edit { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }
        /// <summary>
        /// Gets or Sets ManagerOfOwnerEdit
        /// </summary>
        [DataMember(Name = "managerOfOwnerEdit", EmitDefaultValue = false)]
        public bool? ManagerOfOwnerEdit { get; set; }
        /// <summary>
        /// Gets or Sets ManagerOfOwnerView
        /// </summary>
        [DataMember(Name = "managerOfOwnerView", EmitDefaultValue = false)]
        public bool? ManagerOfOwnerView { get; set; }
        /// <summary>
        /// Gets or Sets OwnerEdit
        /// </summary>
        [DataMember(Name = "ownerEdit", EmitDefaultValue = false)]
        public bool? OwnerEdit { get; set; }
        /// <summary>
        /// Gets or Sets OwnerView
        /// </summary>
        [DataMember(Name = "ownerView", EmitDefaultValue = false)]
        public bool? OwnerView { get; set; }
        /// <summary>
        /// Gets or Sets TeamEdit
        /// </summary>
        [DataMember(Name = "teamEdit", EmitDefaultValue = false)]
        public bool? TeamEdit { get; set; }
        /// <summary>
        /// Gets or Sets TeamManagerOfOwnerEdit
        /// </summary>
        [DataMember(Name = "teamManagerOfOwnerEdit", EmitDefaultValue = false)]
        public bool? TeamManagerOfOwnerEdit { get; set; }
        /// <summary>
        /// Gets or Sets TeamManagerOfOwnerView
        /// </summary>
        [DataMember(Name = "teamManagerOfOwnerView", EmitDefaultValue = false)]
        public bool? TeamManagerOfOwnerView { get; set; }
        /// <summary>
        /// Gets or Sets TeamView
        /// </summary>
        [DataMember(Name = "teamView", EmitDefaultValue = false)]
        public bool? TeamView { get; set; }
        /// <summary>
        /// Gets or Sets View
        /// </summary>
        [DataMember(Name = "view", EmitDefaultValue = false)]
        public bool? View { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityFieldPermission {\n");
            sb.Append("  DepartmentMemberEdit: ").Append(DepartmentMemberEdit).Append("\n");
            sb.Append("  DepartmentMemberView: ").Append(DepartmentMemberView).Append("\n");
            sb.Append("  Edit: ").Append(Edit).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  ManagerOfOwnerEdit: ").Append(ManagerOfOwnerEdit).Append("\n");
            sb.Append("  ManagerOfOwnerView: ").Append(ManagerOfOwnerView).Append("\n");
            sb.Append("  OwnerEdit: ").Append(OwnerEdit).Append("\n");
            sb.Append("  OwnerView: ").Append(OwnerView).Append("\n");
            sb.Append("  TeamEdit: ").Append(TeamEdit).Append("\n");
            sb.Append("  TeamManagerOfOwnerEdit: ").Append(TeamManagerOfOwnerEdit).Append("\n");
            sb.Append("  TeamManagerOfOwnerView: ").Append(TeamManagerOfOwnerView).Append("\n");
            sb.Append("  TeamView: ").Append(TeamView).Append("\n");
            sb.Append("  View: ").Append(View).Append("\n");
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
            return this.Equals(obj as SecurityFieldPermission);
        }

        /// <summary>
        /// Returns true if SecurityFieldPermission instances are equal
        /// </summary>
        /// <param name="other">Instance of SecurityFieldPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityFieldPermission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.DepartmentMemberEdit == other.DepartmentMemberEdit ||
                    this.DepartmentMemberEdit != null &&
                    this.DepartmentMemberEdit.Equals(other.DepartmentMemberEdit)
                ) &&
                (
                    this.DepartmentMemberView == other.DepartmentMemberView ||
                    this.DepartmentMemberView != null &&
                    this.DepartmentMemberView.Equals(other.DepartmentMemberView)
                ) &&
                (
                    this.Edit == other.Edit ||
                    this.Edit != null &&
                    this.Edit.Equals(other.Edit)
                ) &&
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) &&
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) &&
                (
                    this.ManagerOfOwnerEdit == other.ManagerOfOwnerEdit ||
                    this.ManagerOfOwnerEdit != null &&
                    this.ManagerOfOwnerEdit.Equals(other.ManagerOfOwnerEdit)
                ) &&
                (
                    this.ManagerOfOwnerView == other.ManagerOfOwnerView ||
                    this.ManagerOfOwnerView != null &&
                    this.ManagerOfOwnerView.Equals(other.ManagerOfOwnerView)
                ) &&
                (
                    this.OwnerEdit == other.OwnerEdit ||
                    this.OwnerEdit != null &&
                    this.OwnerEdit.Equals(other.OwnerEdit)
                ) &&
                (
                    this.OwnerView == other.OwnerView ||
                    this.OwnerView != null &&
                    this.OwnerView.Equals(other.OwnerView)
                ) &&
                (
                    this.TeamEdit == other.TeamEdit ||
                    this.TeamEdit != null &&
                    this.TeamEdit.Equals(other.TeamEdit)
                ) &&
                (
                    this.TeamManagerOfOwnerEdit == other.TeamManagerOfOwnerEdit ||
                    this.TeamManagerOfOwnerEdit != null &&
                    this.TeamManagerOfOwnerEdit.Equals(other.TeamManagerOfOwnerEdit)
                ) &&
                (
                    this.TeamManagerOfOwnerView == other.TeamManagerOfOwnerView ||
                    this.TeamManagerOfOwnerView != null &&
                    this.TeamManagerOfOwnerView.Equals(other.TeamManagerOfOwnerView)
                ) &&
                (
                    this.TeamView == other.TeamView ||
                    this.TeamView != null &&
                    this.TeamView.Equals(other.TeamView)
                ) &&
                (
                    this.View == other.View ||
                    this.View != null &&
                    this.View.Equals(other.View)
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
                if (this.DepartmentMemberEdit != null)
                    hash = hash * 59 + this.DepartmentMemberEdit.GetHashCode();
                if (this.DepartmentMemberView != null)
                    hash = hash * 59 + this.DepartmentMemberView.GetHashCode();
                if (this.Edit != null)
                    hash = hash * 59 + this.Edit.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.ManagerOfOwnerEdit != null)
                    hash = hash * 59 + this.ManagerOfOwnerEdit.GetHashCode();
                if (this.ManagerOfOwnerView != null)
                    hash = hash * 59 + this.ManagerOfOwnerView.GetHashCode();
                if (this.OwnerEdit != null)
                    hash = hash * 59 + this.OwnerEdit.GetHashCode();
                if (this.OwnerView != null)
                    hash = hash * 59 + this.OwnerView.GetHashCode();
                if (this.TeamEdit != null)
                    hash = hash * 59 + this.TeamEdit.GetHashCode();
                if (this.TeamManagerOfOwnerEdit != null)
                    hash = hash * 59 + this.TeamManagerOfOwnerEdit.GetHashCode();
                if (this.TeamManagerOfOwnerView != null)
                    hash = hash * 59 + this.TeamManagerOfOwnerView.GetHashCode();
                if (this.TeamView != null)
                    hash = hash * 59 + this.TeamView.GetHashCode();
                if (this.View != null)
                    hash = hash * 59 + this.View.GetHashCode();
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
