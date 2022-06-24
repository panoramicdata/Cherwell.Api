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
	/// <param name="busObId">BusObId.</param>
	/// <param name="busObName">BusObName.</param>
	/// <param name="departmentMemberEdit">DepartmentMemberEdit.</param>
	/// <param name="departmentMemberView">DepartmentMemberView.</param>
	/// <param name="edit">Edit.</param>
	/// <param name="fieldPermissions">FieldPermissions.</param>
	/// <param name="managerOfOwnerEdit">ManagerOfOwnerEdit.</param>
	/// <param name="managerOfOwnerView">ManagerOfOwnerView.</param>
	/// <param name="ownerEdit">OwnerEdit.</param>
	/// <param name="ownerView">OwnerView.</param>
	/// <param name="teamEdit">TeamEdit.</param>
	/// <param name="teamManagerOfOwnerEdit">TeamManagerOfOwnerEdit.</param>
	/// <param name="teamManagerOfOwnerView">TeamManagerOfOwnerView.</param>
	/// <param name="teamView">TeamView.</param>
	/// <param name="view">View.</param>
	public BusinessObjectPermission(
		string busObId,
		string busObName,
		bool? departmentMemberEdit,
		bool? departmentMemberView,
		bool? edit,
		List<FieldPermissiond> fieldPermissions,
		bool? managerOfOwnerEdit,
		bool? managerOfOwnerView,
		bool? ownerEdit,
		bool? ownerView,
		bool? teamEdit,
		bool? teamManagerOfOwnerEdit,
		bool? teamManagerOfOwnerView,
		bool? teamView,
		bool? view)
	{
		BusObId = busObId;
		BusObName = busObName;
		DepartmentMemberEdit = departmentMemberEdit;
		DepartmentMemberView = departmentMemberView;
		Edit = edit;
		FieldPermissions = fieldPermissions;
		ManagerOfOwnerEdit = managerOfOwnerEdit;
		ManagerOfOwnerView = managerOfOwnerView;
		OwnerEdit = ownerEdit;
		OwnerView = ownerView;
		TeamEdit = teamEdit;
		TeamManagerOfOwnerEdit = teamManagerOfOwnerEdit;
		TeamManagerOfOwnerView = teamManagerOfOwnerView;
		TeamView = teamView;
		View = view;
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
		return Equals(obj as BusinessObjectPermission);
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
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					BusObName == other.BusObName ||
					BusObName != null &&
					BusObName.Equals(other.BusObName, StringComparison.Ordinal)
				) &&
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
					FieldPermissions == other.FieldPermissions ||
					FieldPermissions != null &&
					FieldPermissions.SequenceEqual(other.FieldPermissions)
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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (BusObName != null)
			{
				hash = hash * 59 + BusObName.GetHashCode();
			}

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

			if (FieldPermissions != null)
			{
				hash = hash * 59 + FieldPermissions.GetHashCode();
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
