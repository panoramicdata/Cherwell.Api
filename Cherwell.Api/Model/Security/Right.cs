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
    /// Right
    /// </summary>
    [DataContract]
    public partial class Right :  IEquatable<Right>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Right" /> class.
        /// </summary>
        /// <param name="Add">Add.</param>
        /// <param name="Allow">Allow.</param>
        /// <param name="CategoryDescription">CategoryDescription.</param>
        /// <param name="CategoryId">CategoryId.</param>
        /// <param name="CategoryName">CategoryName.</param>
        /// <param name="Delete">Delete.</param>
        /// <param name="Edit">Edit.</param>
        /// <param name="IsYesNoRight">IsYesNoRight.</param>
        /// <param name="NonScopeOwnerAdd">NonScopeOwnerAdd.</param>
        /// <param name="NonScopeOwnerDelete">NonScopeOwnerDelete.</param>
        /// <param name="NonScopeOwnerEdit">NonScopeOwnerEdit.</param>
        /// <param name="NonScopeOwnerView">NonScopeOwnerView.</param>
        /// <param name="RightId">RightId.</param>
        /// <param name="RightName">RightName.</param>
        /// <param name="StandardRightName">StandardRightName.</param>
        /// <param name="ViewRunOpen">ViewRunOpen.</param>
        public Right(bool? Add = default(bool?), bool? Allow = default(bool?), string CategoryDescription = default, string CategoryId = default, string CategoryName = default, bool? Delete = default(bool?), bool? Edit = default(bool?), bool? IsYesNoRight = default(bool?), bool? NonScopeOwnerAdd = default(bool?), bool? NonScopeOwnerDelete = default(bool?), bool? NonScopeOwnerEdit = default(bool?), bool? NonScopeOwnerView = default(bool?), string RightId = default, string RightName = default, string StandardRightName = default, bool? ViewRunOpen = default(bool?))
        {
            this.Add = Add;
            this.Allow = Allow;
            this.CategoryDescription = CategoryDescription;
            this.CategoryId = CategoryId;
            this.CategoryName = CategoryName;
            this.Delete = Delete;
            this.Edit = Edit;
            this.IsYesNoRight = IsYesNoRight;
            this.NonScopeOwnerAdd = NonScopeOwnerAdd;
            this.NonScopeOwnerDelete = NonScopeOwnerDelete;
            this.NonScopeOwnerEdit = NonScopeOwnerEdit;
            this.NonScopeOwnerView = NonScopeOwnerView;
            this.RightId = RightId;
            this.RightName = RightName;
            this.StandardRightName = StandardRightName;
            this.ViewRunOpen = ViewRunOpen;
        }
        
        /// <summary>
        /// Gets or Sets Add
        /// </summary>
        [DataMember(Name="add", EmitDefaultValue=false)]
        public bool? Add { get; set; }
        /// <summary>
        /// Gets or Sets Allow
        /// </summary>
        [DataMember(Name="allow", EmitDefaultValue=false)]
        public bool? Allow { get; set; }
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
        /// Gets or Sets Delete
        /// </summary>
        [DataMember(Name="delete", EmitDefaultValue=false)]
        public bool? Delete { get; set; }
        /// <summary>
        /// Gets or Sets Edit
        /// </summary>
        [DataMember(Name="edit", EmitDefaultValue=false)]
        public bool? Edit { get; set; }
        /// <summary>
        /// Gets or Sets IsYesNoRight
        /// </summary>
        [DataMember(Name="isYesNoRight", EmitDefaultValue=false)]
        public bool? IsYesNoRight { get; set; }
        /// <summary>
        /// Gets or Sets NonScopeOwnerAdd
        /// </summary>
        [DataMember(Name="nonScopeOwnerAdd", EmitDefaultValue=false)]
        public bool? NonScopeOwnerAdd { get; set; }
        /// <summary>
        /// Gets or Sets NonScopeOwnerDelete
        /// </summary>
        [DataMember(Name="nonScopeOwnerDelete", EmitDefaultValue=false)]
        public bool? NonScopeOwnerDelete { get; set; }
        /// <summary>
        /// Gets or Sets NonScopeOwnerEdit
        /// </summary>
        [DataMember(Name="nonScopeOwnerEdit", EmitDefaultValue=false)]
        public bool? NonScopeOwnerEdit { get; set; }
        /// <summary>
        /// Gets or Sets NonScopeOwnerView
        /// </summary>
        [DataMember(Name="nonScopeOwnerView", EmitDefaultValue=false)]
        public bool? NonScopeOwnerView { get; set; }
        /// <summary>
        /// Gets or Sets RightId
        /// </summary>
        [DataMember(Name="rightId", EmitDefaultValue=false)]
        public string RightId { get; set; }
        /// <summary>
        /// Gets or Sets RightName
        /// </summary>
        [DataMember(Name="rightName", EmitDefaultValue=false)]
        public string RightName { get; set; }
        /// <summary>
        /// Gets or Sets StandardRightName
        /// </summary>
        [DataMember(Name="standardRightName", EmitDefaultValue=false)]
        public string StandardRightName { get; set; }
        /// <summary>
        /// Gets or Sets ViewRunOpen
        /// </summary>
        [DataMember(Name="viewRunOpen", EmitDefaultValue=false)]
        public bool? ViewRunOpen { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityRight {\n");
            sb.Append("  Add: ").Append(Add).Append('\n');
            sb.Append("  Allow: ").Append(Allow).Append('\n');
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append('\n');
            sb.Append("  CategoryId: ").Append(CategoryId).Append('\n');
            sb.Append("  CategoryName: ").Append(CategoryName).Append('\n');
            sb.Append("  Delete: ").Append(Delete).Append('\n');
            sb.Append("  Edit: ").Append(Edit).Append('\n');
            sb.Append("  IsYesNoRight: ").Append(IsYesNoRight).Append('\n');
            sb.Append("  NonScopeOwnerAdd: ").Append(NonScopeOwnerAdd).Append('\n');
            sb.Append("  NonScopeOwnerDelete: ").Append(NonScopeOwnerDelete).Append('\n');
            sb.Append("  NonScopeOwnerEdit: ").Append(NonScopeOwnerEdit).Append('\n');
            sb.Append("  NonScopeOwnerView: ").Append(NonScopeOwnerView).Append('\n');
            sb.Append("  RightId: ").Append(RightId).Append('\n');
            sb.Append("  RightName: ").Append(RightName).Append('\n');
            sb.Append("  StandardRightName: ").Append(StandardRightName).Append('\n');
            sb.Append("  ViewRunOpen: ").Append(ViewRunOpen).Append('\n');
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
            return this.Equals(obj as Right);
        }

        /// <summary>
        /// Returns true if Right instances are equal
        /// </summary>
        /// <param name="other">Instance of Right to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Right? other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Add == other.Add ||
                    this.Add != null &&
                    this.Add.Equals(other.Add)
                ) && 
                (
                    this.Allow == other.Allow ||
                    this.Allow != null &&
                    this.Allow.Equals(other.Allow)
                ) && 
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
                ) && 
                (
                    this.Delete == other.Delete ||
                    this.Delete != null &&
                    this.Delete.Equals(other.Delete)
                ) && 
                (
                    this.Edit == other.Edit ||
                    this.Edit != null &&
                    this.Edit.Equals(other.Edit)
                ) && 
                (
                    this.IsYesNoRight == other.IsYesNoRight ||
                    this.IsYesNoRight != null &&
                    this.IsYesNoRight.Equals(other.IsYesNoRight)
                ) && 
                (
                    this.NonScopeOwnerAdd == other.NonScopeOwnerAdd ||
                    this.NonScopeOwnerAdd != null &&
                    this.NonScopeOwnerAdd.Equals(other.NonScopeOwnerAdd)
                ) && 
                (
                    this.NonScopeOwnerDelete == other.NonScopeOwnerDelete ||
                    this.NonScopeOwnerDelete != null &&
                    this.NonScopeOwnerDelete.Equals(other.NonScopeOwnerDelete)
                ) && 
                (
                    this.NonScopeOwnerEdit == other.NonScopeOwnerEdit ||
                    this.NonScopeOwnerEdit != null &&
                    this.NonScopeOwnerEdit.Equals(other.NonScopeOwnerEdit)
                ) && 
                (
                    this.NonScopeOwnerView == other.NonScopeOwnerView ||
                    this.NonScopeOwnerView != null &&
                    this.NonScopeOwnerView.Equals(other.NonScopeOwnerView)
                ) && 
                (
                    this.RightId == other.RightId ||
                    this.RightId != null &&
                    this.RightId.Equals(other.RightId, StringComparison.Ordinal)
                ) && 
                (
                    this.RightName == other.RightName ||
                    this.RightName != null &&
                    this.RightName.Equals(other.RightName, StringComparison.Ordinal)
                ) && 
                (
                    this.StandardRightName == other.StandardRightName ||
                    this.StandardRightName != null &&
                    this.StandardRightName.Equals(other.StandardRightName, StringComparison.Ordinal)
                ) && 
                (
                    this.ViewRunOpen == other.ViewRunOpen ||
                    this.ViewRunOpen != null &&
                    this.ViewRunOpen.Equals(other.ViewRunOpen)
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
                if (this.Add != null)
                    hash = hash * 59 + this.Add.GetHashCode();
                if (this.Allow != null)
                    hash = hash * 59 + this.Allow.GetHashCode();
                if (this.CategoryDescription != null)
                    hash = hash * 59 + this.CategoryDescription.GetHashCode();
                if (this.CategoryId != null)
                    hash = hash * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hash = hash * 59 + this.CategoryName.GetHashCode();
                if (this.Delete != null)
                    hash = hash * 59 + this.Delete.GetHashCode();
                if (this.Edit != null)
                    hash = hash * 59 + this.Edit.GetHashCode();
                if (this.IsYesNoRight != null)
                    hash = hash * 59 + this.IsYesNoRight.GetHashCode();
                if (this.NonScopeOwnerAdd != null)
                    hash = hash * 59 + this.NonScopeOwnerAdd.GetHashCode();
                if (this.NonScopeOwnerDelete != null)
                    hash = hash * 59 + this.NonScopeOwnerDelete.GetHashCode();
                if (this.NonScopeOwnerEdit != null)
                    hash = hash * 59 + this.NonScopeOwnerEdit.GetHashCode();
                if (this.NonScopeOwnerView != null)
                    hash = hash * 59 + this.NonScopeOwnerView.GetHashCode();
                if (this.RightId != null)
                    hash = hash * 59 + this.RightId.GetHashCode();
                if (this.RightName != null)
                    hash = hash * 59 + this.RightName.GetHashCode();
                if (this.StandardRightName != null)
                    hash = hash * 59 + this.StandardRightName.GetHashCode();
                if (this.ViewRunOpen != null)
                    hash = hash * 59 + this.ViewRunOpen.GetHashCode();
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
