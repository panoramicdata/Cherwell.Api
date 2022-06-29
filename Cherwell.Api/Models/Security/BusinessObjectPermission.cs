using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// BusinessObjectPermission
/// </summary>
[DataContract]
public partial class BusinessObjectPermission
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
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; }

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
	/// FieldPermissions
	/// </summary>
	[DataMember(Name = "fieldPermissions", EmitDefaultValue = false)]
	public List<FieldPermissiond> FieldPermissions { get; set; }

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
}
