using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// BusinessObjectPermission
/// </summary>
[DataContract]
public partial class BusinessObjectPermission : IEquatable<BusinessObjectPermission>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="BusinessObjectPermission" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="BusObName">BusObName.</param>
	/// <param name="DepartmentMemberEdit">DepartmentMemberEdit.</param>
	/// <param name="DepartmentMemberView">DepartmentMemberView.</param>
	/// <param name="Edit">Edit.</param>
	/// <param name="FieldPermissions">FieldPermissions.</param>
	/// <param name="ManagerOfOwnerEdit">ManagerOfOwnerEdit.</param>
	/// <param name="ManagerOfOwnerView">ManagerOfOwnerView.</param>
	/// <param name="OwnerEdit">OwnerEdit.</param>
	/// <param name="OwnerView">OwnerView.</param>
	/// <param name="TeamEdit">TeamEdit.</param>
	/// <param name="TeamManagerOfOwnerEdit">TeamManagerOfOwnerEdit.</param>
	/// <param name="TeamManagerOfOwnerView">TeamManagerOfOwnerView.</param>
	/// <param name="TeamView">TeamView.</param>
	/// <param name="View">View.</param>
	public BusinessObjectPermission(string BusObId, string BusObName, bool? DepartmentMemberEdit, bool? DepartmentMemberView, bool? Edit, List<FieldPermissiond> FieldPermissions, bool? ManagerOfOwnerEdit, bool? ManagerOfOwnerView, bool? OwnerEdit, bool? OwnerView, bool? TeamEdit, bool? TeamManagerOfOwnerEdit, bool? TeamManagerOfOwnerView, bool? TeamView, bool? View)
	{
		this.BusObId = BusObId;
		this.BusObName = BusObName;
		this.DepartmentMemberEdit = DepartmentMemberEdit;
		this.DepartmentMemberView = DepartmentMemberView;
		this.Edit = Edit;
		this.FieldPermissions = FieldPermissions;
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
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; }
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
	/// Gets or Sets FieldPermissions
	/// </summary>
	[DataMember(Name = "fieldPermissions", EmitDefaultValue = false)]
	public List<FieldPermissiond> FieldPermissions { get; set; }
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
		sb.Append("class PermissionSecurityBusinessObject {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  BusObName: ").Append(BusObName).Append('\n');
		sb.Append("  DepartmentMemberEdit: ").Append(DepartmentMemberEdit).Append('\n');
		sb.Append("  DepartmentMemberView: ").Append(DepartmentMemberView).Append('\n');
		sb.Append("  Edit: ").Append(Edit).Append('\n');
		sb.Append("  FieldPermissions: ").Append(FieldPermissions).Append('\n');
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
		return this.Equals(obj as BusinessObjectPermission);
	}

	/// <summary>
	/// Returns true if BusinessObjectPermission instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectPermission to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(BusinessObjectPermission? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					this.BusObId == other.BusObId ||
					this.BusObId != null &&
					this.BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					this.BusObName == other.BusObName ||
					this.BusObName != null &&
					this.BusObName.Equals(other.BusObName, StringComparison.Ordinal)
				) &&
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
					this.FieldPermissions == other.FieldPermissions ||
					this.FieldPermissions != null &&
					this.FieldPermissions.SequenceEqual(other.FieldPermissions)
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
			if (this.BusObId != null)
			{
				hash = hash * 59 + this.BusObId.GetHashCode();
			}

			if (this.BusObName != null)
			{
				hash = hash * 59 + this.BusObName.GetHashCode();
			}

			if (this.DepartmentMemberEdit != null)
			{
				hash = hash * 59 + this.DepartmentMemberEdit.GetHashCode();
			}

			if (this.DepartmentMemberView != null)
			{
				hash = hash * 59 + this.DepartmentMemberView.GetHashCode();
			}

			if (this.Edit != null)
			{
				hash = hash * 59 + this.Edit.GetHashCode();
			}

			if (this.FieldPermissions != null)
			{
				hash = hash * 59 + this.FieldPermissions.GetHashCode();
			}

			if (this.ManagerOfOwnerEdit != null)
			{
				hash = hash * 59 + this.ManagerOfOwnerEdit.GetHashCode();
			}

			if (this.ManagerOfOwnerView != null)
			{
				hash = hash * 59 + this.ManagerOfOwnerView.GetHashCode();
			}

			if (this.OwnerEdit != null)
			{
				hash = hash * 59 + this.OwnerEdit.GetHashCode();
			}

			if (this.OwnerView != null)
			{
				hash = hash * 59 + this.OwnerView.GetHashCode();
			}

			if (this.TeamEdit != null)
			{
				hash = hash * 59 + this.TeamEdit.GetHashCode();
			}

			if (this.TeamManagerOfOwnerEdit != null)
			{
				hash = hash * 59 + this.TeamManagerOfOwnerEdit.GetHashCode();
			}

			if (this.TeamManagerOfOwnerView != null)
			{
				hash = hash * 59 + this.TeamManagerOfOwnerView.GetHashCode();
			}

			if (this.TeamView != null)
			{
				hash = hash * 59 + this.TeamView.GetHashCode();
			}

			if (this.View != null)
			{
				hash = hash * 59 + this.View.GetHashCode();
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
