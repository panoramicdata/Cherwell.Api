using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// BusinessObjectPermission
/// </summary>
[DataContract]
public class BusinessObjectPermission
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObName
	/// </summary>
	[DataMember(Name = "busObName", EmitDefaultValue = false)]
	public string BusObName { get; set; } = null!;

	/// <summary>
	/// DepartmentMemberEdit
	/// </summary>
	[DataMember(Name = "departmentMemberEdit", EmitDefaultValue = false)]
	public bool DepartmentMemberEdit { get; set; }

	/// <summary>
	/// DepartmentMemberView
	/// </summary>

	[DataMember(Name = "departmentMemberView", EmitDefaultValue = false)]
	public bool DepartmentMemberView { get; set; }

	/// <summary>
	/// Edit
	/// </summary>
	[DataMember(Name = "edit", EmitDefaultValue = false)]
	public bool Edit { get; set; }

	/// <summary>
	/// FieldPermissions
	/// </summary>
	[DataMember(Name = "fieldPermissions", EmitDefaultValue = false)]
	public List<FieldPermissiond> FieldPermissions { get; set; } = null!;

	/// <summary>
	/// ManagerOfOwnerEdit
	/// </summary>
	[DataMember(Name = "managerOfOwnerEdit", EmitDefaultValue = false)]
	public bool ManagerOfOwnerEdit { get; set; }

	/// <summary>
	/// ManagerOfOwnerView
	/// </summary>
	[DataMember(Name = "managerOfOwnerView", EmitDefaultValue = false)]
	public bool ManagerOfOwnerView { get; set; }

	/// <summary>
	/// OwnerEdit
	/// </summary>
	[DataMember(Name = "ownerEdit", EmitDefaultValue = false)]
	public bool OwnerEdit { get; set; }

	/// <summary>
	/// OwnerView
	/// </summary>
	[DataMember(Name = "ownerView", EmitDefaultValue = false)]
	public bool OwnerView { get; set; }

	/// <summary>
	/// TeamEdit
	/// </summary>
	[DataMember(Name = "teamEdit", EmitDefaultValue = false)]
	public bool TeamEdit { get; set; }

	/// <summary>
	/// TeamManagerOfOwnerEdit
	/// </summary>
	[DataMember(Name = "teamManagerOfOwnerEdit", EmitDefaultValue = false)]
	public bool TeamManagerOfOwnerEdit { get; set; }

	/// <summary>
	/// TeamManagerOfOwnerView
	/// </summary>
	[DataMember(Name = "teamManagerOfOwnerView", EmitDefaultValue = false)]
	public bool TeamManagerOfOwnerView { get; set; }

	/// <summary>
	/// TeamView
	/// </summary>
	[DataMember(Name = "teamView", EmitDefaultValue = false)]
	public bool TeamView { get; set; }

	/// <summary>
	/// View
	/// </summary>
	[DataMember(Name = "view", EmitDefaultValue = false)]
	public bool View { get; set; }
}
