using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// FieldPermissiond
/// </summary>
[DataContract]
public partial class FieldPermissiond
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
	/// DepartmentMemberEdit
	/// </summary>
	[DataMember(Name = "departmentMemberEdit", EmitDefaultValue = false)]
	public bool? DepartmentMemberEdit { get; set; }

	/// <summary>
	/// DepartmentMemberView
	/// </summary>
	[DataMember(Name = "departmentMemberView", EmitDefaultValue = false)]
	public bool? DepartmentMemberView { get; set; }

	/// <summary>
	/// Edit
	/// </summary>
	[DataMember(Name = "edit", EmitDefaultValue = false)]
	public bool? Edit { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// FieldName
	/// </summary>
	[DataMember(Name = "fieldName", EmitDefaultValue = false)]
	public string FieldName { get; set; }

	/// <summary>
	/// ManagerOfOwnerEdit
	/// </summary>
	[DataMember(Name = "managerOfOwnerEdit", EmitDefaultValue = false)]
	public bool? ManagerOfOwnerEdit { get; set; }

	/// <summary>
	/// ManagerOfOwnerView
	/// </summary>
	[DataMember(Name = "managerOfOwnerView", EmitDefaultValue = false)]
	public bool? ManagerOfOwnerView { get; set; }

	/// <summary>
	/// OwnerEdit
	/// </summary>
	[DataMember(Name = "ownerEdit", EmitDefaultValue = false)]
	public bool? OwnerEdit { get; set; }

	/// <summary>
	/// OwnerView
	/// </summary>
	[DataMember(Name = "ownerView", EmitDefaultValue = false)]
	public bool? OwnerView { get; set; }

	/// <summary>
	/// TeamEdit
	/// </summary>
	[DataMember(Name = "teamEdit", EmitDefaultValue = false)]
	public bool? TeamEdit { get; set; }

	/// <summary>
	/// TeamManagerOfOwnerEdit
	/// </summary>
	[DataMember(Name = "teamManagerOfOwnerEdit", EmitDefaultValue = false)]
	public bool? TeamManagerOfOwnerEdit { get; set; }

	/// <summary>
	/// TeamManagerOfOwnerView
	/// </summary>
	[DataMember(Name = "teamManagerOfOwnerView", EmitDefaultValue = false)]
	public bool? TeamManagerOfOwnerView { get; set; }

	/// <summary>
	/// TeamView
	/// </summary>
	[DataMember(Name = "teamView", EmitDefaultValue = false)]
	public bool? TeamView { get; set; }

	/// <summary>
	/// View
	/// </summary>
	[DataMember(Name = "view", EmitDefaultValue = false)]
	public bool? View { get; set; }


















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







		}
	}

	
}
