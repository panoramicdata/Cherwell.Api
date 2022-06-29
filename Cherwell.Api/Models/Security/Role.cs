using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// Role
/// </summary>
[DataContract]
public partial class Role
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Role" /> class.
	/// </summary>
	/// <param name="BrowserClientCustomViewId">BrowserClientCustomViewId.</param>
	/// <param name="BusinessObjectExcludeList">BusinessObjectExcludeList.</param>
	/// <param name="Culture">Culture.</param>
	/// <param name="Description">Description.</param>
	/// <param name="MobileClientCustomViewId">MobileClientCustomViewId.</param>
	/// <param name="PrimaryBusObId">PrimaryBusObId.</param>
	/// <param name="RoleId">RoleId.</param>
	/// <param name="RoleName">RoleName.</param>
	/// <param name="SmartClientCustomViewId">SmartClientCustomViewId.</param>
	public Role(string BrowserClientCustomViewId, List<string> BusinessObjectExcludeList, string Culture, string Description, string MobileClientCustomViewId, string PrimaryBusObId, string RoleId, string RoleName, string SmartClientCustomViewId)
	{
		this.BrowserClientCustomViewId = BrowserClientCustomViewId;
		this.BusinessObjectExcludeList = BusinessObjectExcludeList;
		this.Culture = Culture;
		this.Description = Description;
		this.MobileClientCustomViewId = MobileClientCustomViewId;
		this.PrimaryBusObId = PrimaryBusObId;
		this.RoleId = RoleId;
		this.RoleName = RoleName;
		this.SmartClientCustomViewId = SmartClientCustomViewId;
	}

	/// <summary>
	/// BrowserClientCustomViewId
	/// </summary>
	[DataMember(Name = "browserClientCustomViewId", EmitDefaultValue = false)]
	public string BrowserClientCustomViewId { get; set; }

	/// <summary>
	/// BusinessObjectExcludeList
	/// </summary>
	[DataMember(Name = "businessObjectExcludeList", EmitDefaultValue = false)]
	public List<string> BusinessObjectExcludeList { get; set; }

	/// <summary>
	/// Culture
	/// </summary>
	[DataMember(Name = "culture", EmitDefaultValue = false)]
	public string Culture { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// MobileClientCustomViewId
	/// </summary>
	[DataMember(Name = "mobileClientCustomViewId", EmitDefaultValue = false)]
	public string MobileClientCustomViewId { get; set; }

	/// <summary>
	/// PrimaryBusObId
	/// </summary>
	[DataMember(Name = "primaryBusObId", EmitDefaultValue = false)]
	public string PrimaryBusObId { get; set; }

	/// <summary>
	/// RoleId
	/// </summary>
	[DataMember(Name = "roleId", EmitDefaultValue = false)]
	public string RoleId { get; set; }

	/// <summary>
	/// RoleName
	/// </summary>
	[DataMember(Name = "roleName", EmitDefaultValue = false)]
	public string RoleName { get; set; }

	/// <summary>
	/// SmartClientCustomViewId
	/// </summary>
	[DataMember(Name = "smartClientCustomViewId", EmitDefaultValue = false)]
	public string SmartClientCustomViewId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityRole {\n");
		sb.Append("  BrowserClientCustomViewId: ").Append(BrowserClientCustomViewId).Append('\n');
		sb.Append("  BusinessObjectExcludeList: ").Append(BusinessObjectExcludeList).Append('\n');
		sb.Append("  Culture: ").Append(Culture).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  MobileClientCustomViewId: ").Append(MobileClientCustomViewId).Append('\n');
		sb.Append("  PrimaryBusObId: ").Append(PrimaryBusObId).Append('\n');
		sb.Append("  RoleId: ").Append(RoleId).Append('\n');
		sb.Append("  RoleName: ").Append(RoleName).Append('\n');
		sb.Append("  SmartClientCustomViewId: ").Append(SmartClientCustomViewId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
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
			if (BrowserClientCustomViewId != null)
			{
				hash = hash * 59 + BrowserClientCustomViewId.GetHashCode();
			}

			if (BusinessObjectExcludeList != null)
			{
				hash = hash * 59 + BusinessObjectExcludeList.GetHashCode();
			}

			if (Culture != null)
			{
				hash = hash * 59 + Culture.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (MobileClientCustomViewId != null)
			{
				hash = hash * 59 + MobileClientCustomViewId.GetHashCode();
			}

			if (PrimaryBusObId != null)
			{
				hash = hash * 59 + PrimaryBusObId.GetHashCode();
			}

			if (RoleId != null)
			{
				hash = hash * 59 + RoleId.GetHashCode();
			}

			if (RoleName != null)
			{
				hash = hash * 59 + RoleName.GetHashCode();
			}

			if (SmartClientCustomViewId != null)
			{
				hash = hash * 59 + SmartClientCustomViewId.GetHashCode();
			}

			return hash;
		}
	}

	
}

