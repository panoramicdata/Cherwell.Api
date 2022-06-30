using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// Role
/// </summary>
[DataContract]
public partial class Role
{
	/// <summary>
	/// BrowserClientCustomViewId
	/// </summary>
	[DataMember(Name = "browserClientCustomViewId", EmitDefaultValue = false)]
	public string? BrowserClientCustomViewId { get; set; }

	/// <summary>
	/// BusinessObjectExcludeList
	/// </summary>
	[DataMember(Name = "businessObjectExcludeList", EmitDefaultValue = false)]
	public List<string>? BusinessObjectExcludeList { get; set; }

	/// <summary>
	/// Culture
	/// </summary>
	[DataMember(Name = "culture", EmitDefaultValue = false)]
	public string? Culture { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string? Description { get; set; }

	/// <summary>
	/// MobileClientCustomViewId
	/// </summary>
	[DataMember(Name = "mobileClientCustomViewId", EmitDefaultValue = false)]
	public string? MobileClientCustomViewId { get; set; }

	/// <summary>
	/// PrimaryBusObId
	/// </summary>
	[DataMember(Name = "primaryBusObId", EmitDefaultValue = false)]
	public string? PrimaryBusObId { get; set; }

	/// <summary>
	/// RoleId
	/// </summary>
	[DataMember(Name = "roleId", EmitDefaultValue = false)]
	public string? RoleId { get; set; }

	/// <summary>
	/// RoleName
	/// </summary>
	[DataMember(Name = "roleName", EmitDefaultValue = false)]
	public string? RoleName { get; set; }

	/// <summary>
	/// SmartClientCustomViewId
	/// </summary>
	[DataMember(Name = "smartClientCustomViewId", EmitDefaultValue = false)]
	public string? SmartClientCustomViewId { get; set; }
}

