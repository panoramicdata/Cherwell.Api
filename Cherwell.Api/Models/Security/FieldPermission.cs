using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// FieldPermissiond
/// </summary>
[DataContract]
public partial class FieldPermissiond : IEquatable<FieldPermissiond>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldPermissiond" /> class.
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
	public FieldPermissiond(bool? DepartmentMemberEdit, bool? DepartmentMemberView, bool? Edit, string FieldId, string FieldName, bool? ManagerOfOwnerEdit, bool? ManagerOfOwnerView, bool? OwnerEdit, bool? OwnerView, bool? TeamEdit, bool? TeamManagerOfOwnerEdit, bool? TeamManagerOfOwnerView, bool? TeamView, bool? View)
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
		sb.Append("class PermissionSecurityField {\n");
		sb.Append("  DepartmentMemberEdit: ").Append(DepartmentMemberEdit).Append('\n');
		sb.Append("  DepartmentMemberView: ").Append(DepartmentMemberView).Append('\n');
		sb.Append("  Edit: ").Append(Edit).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  FieldName: ").Append(FieldName).Append('\n');
		sb.Append("  ManagerOfOwnerEdit: ").Append(ManagerOfOwnerEdit).Append('\n');
		sb.Append("  ManagerOfOwnerView: ").Append(ManagerOfOwnerView).Append('\n');
		sb.Append("  OwnerEdit: ").Append(OwnerEdit).Append('\n');
		sb.Append("  OwnerView: ").Append(OwnerView).Append('\n');
		sb.Append("  TeamEdit: ").Append(TeamEdit).Append('\n');
		sb.Append("  TeamManagerOfOwnerEdit: ").Append(TeamManagerOfOwnerEdit).Append('\n');
		sb.Append("  TeamManagerOfOwnerView: ").Append(TeamManagerOfOwnerView).Append('\n');
		sb.Append("  TeamView: ").Append(TeamView).Append('\n');
		sb.Append("  View: ").Append(View).Append('\n');
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
		return Equals(obj as FieldPermissiond);
	}

	/// <summary>
	/// Returns true if FieldPermissiond instances are equal
	/// </summary>
	/// <param name="other">Instance of FieldPermissiond to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(FieldPermissiond? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					DepartmentMemberEdit == other.DepartmentMemberEdit ||
					DepartmentMemberEdit != null &&
					DepartmentMemberEdit.Equals(other.DepartmentMemberEdit)
				) &&
				(
					DepartmentMemberView == other.DepartmentMemberView ||
					DepartmentMemberView != null &&
					DepartmentMemberView.Equals(other.DepartmentMemberView)
				) &&
				(
					Edit == other.Edit ||
					Edit != null &&
					Edit.Equals(other.Edit)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					FieldName == other.FieldName ||
					FieldName != null &&
					FieldName.Equals(other.FieldName, StringComparison.Ordinal)
				) &&
				(
					ManagerOfOwnerEdit == other.ManagerOfOwnerEdit ||
					ManagerOfOwnerEdit != null &&
					ManagerOfOwnerEdit.Equals(other.ManagerOfOwnerEdit)
				) &&
				(
					ManagerOfOwnerView == other.ManagerOfOwnerView ||
					ManagerOfOwnerView != null &&
					ManagerOfOwnerView.Equals(other.ManagerOfOwnerView)
				) &&
				(
					OwnerEdit == other.OwnerEdit ||
					OwnerEdit != null &&
					OwnerEdit.Equals(other.OwnerEdit)
				) &&
				(
					OwnerView == other.OwnerView ||
					OwnerView != null &&
					OwnerView.Equals(other.OwnerView)
				) &&
				(
					TeamEdit == other.TeamEdit ||
					TeamEdit != null &&
					TeamEdit.Equals(other.TeamEdit)
				) &&
				(
					TeamManagerOfOwnerEdit == other.TeamManagerOfOwnerEdit ||
					TeamManagerOfOwnerEdit != null &&
					TeamManagerOfOwnerEdit.Equals(other.TeamManagerOfOwnerEdit)
				) &&
				(
					TeamManagerOfOwnerView == other.TeamManagerOfOwnerView ||
					TeamManagerOfOwnerView != null &&
					TeamManagerOfOwnerView.Equals(other.TeamManagerOfOwnerView)
				) &&
				(
					TeamView == other.TeamView ||
					TeamView != null &&
					TeamView.Equals(other.TeamView)
				) &&
				(
					View == other.View ||
					View != null &&
					View.Equals(other.View)
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
			if (DepartmentMemberEdit != null)
			{
				hash = hash * 59 + DepartmentMemberEdit.GetHashCode();
			}

			if (DepartmentMemberView != null)
			{
				hash = hash * 59 + DepartmentMemberView.GetHashCode();
			}

			if (Edit != null)
			{
				hash = hash * 59 + Edit.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (FieldName != null)
			{
				hash = hash * 59 + FieldName.GetHashCode();
			}

			if (ManagerOfOwnerEdit != null)
			{
				hash = hash * 59 + ManagerOfOwnerEdit.GetHashCode();
			}

			if (ManagerOfOwnerView != null)
			{
				hash = hash * 59 + ManagerOfOwnerView.GetHashCode();
			}

			if (OwnerEdit != null)
			{
				hash = hash * 59 + OwnerEdit.GetHashCode();
			}

			if (OwnerView != null)
			{
				hash = hash * 59 + OwnerView.GetHashCode();
			}

			if (TeamEdit != null)
			{
				hash = hash * 59 + TeamEdit.GetHashCode();
			}

			if (TeamManagerOfOwnerEdit != null)
			{
				hash = hash * 59 + TeamManagerOfOwnerEdit.GetHashCode();
			}

			if (TeamManagerOfOwnerView != null)
			{
				hash = hash * 59 + TeamManagerOfOwnerView.GetHashCode();
			}

			if (TeamView != null)
			{
				hash = hash * 59 + TeamView.GetHashCode();
			}

			if (View != null)
			{
				hash = hash * 59 + View.GetHashCode();
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
