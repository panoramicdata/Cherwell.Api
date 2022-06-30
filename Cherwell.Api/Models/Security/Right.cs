using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// Right
/// </summary>
[DataContract]
public partial class Right
{
	/// <summary>
	/// Add
	/// </summary>
	[DataMember(Name = "add", EmitDefaultValue = false)]
	public bool? Add { get; set; }

	/// <summary>
	/// Allow
	/// </summary>
	[DataMember(Name = "allow", EmitDefaultValue = false)]
	public bool? Allow { get; set; }

	/// <summary>
	/// CategoryDescription
	/// </summary>
	[DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
	public string? CategoryDescription { get; set; }

	/// <summary>
	/// CategoryId
	/// </summary>
	[DataMember(Name = "categoryId", EmitDefaultValue = false)]
	public string? CategoryId { get; set; }

	/// <summary>
	/// CategoryName
	/// </summary>
	[DataMember(Name = "categoryName", EmitDefaultValue = false)]
	public string? CategoryName { get; set; }

	/// <summary>
	/// Delete
	/// </summary>
	[DataMember(Name = "delete", EmitDefaultValue = false)]
	public bool? Delete { get; set; }

	/// <summary>
	/// Edit
	/// </summary>
	[DataMember(Name = "edit", EmitDefaultValue = false)]
	public bool? Edit { get; set; }

	/// <summary>
	/// IsYesNoRight
	/// </summary>
	[DataMember(Name = "isYesNoRight", EmitDefaultValue = false)]
	public bool? IsYesNoRight { get; set; }

	/// <summary>
	/// NonScopeOwnerAdd
	/// </summary>
	[DataMember(Name = "nonScopeOwnerAdd", EmitDefaultValue = false)]
	public bool? NonScopeOwnerAdd { get; set; }

	/// <summary>
	/// NonScopeOwnerDelete
	/// </summary>
	[DataMember(Name = "nonScopeOwnerDelete", EmitDefaultValue = false)]
	public bool? NonScopeOwnerDelete { get; set; }

	/// <summary>
	/// NonScopeOwnerEdit
	/// </summary>
	[DataMember(Name = "nonScopeOwnerEdit", EmitDefaultValue = false)]
	public bool? NonScopeOwnerEdit { get; set; }

	/// <summary>
	/// NonScopeOwnerView
	/// </summary>
	[DataMember(Name = "nonScopeOwnerView", EmitDefaultValue = false)]
	public bool? NonScopeOwnerView { get; set; }

	/// <summary>
	/// RightId
	/// </summary>
	[DataMember(Name = "rightId", EmitDefaultValue = false)]
	public string? RightId { get; set; }

	/// <summary>
	/// RightName
	/// </summary>
	[DataMember(Name = "rightName", EmitDefaultValue = false)]
	public string? RightName { get; set; }

	/// <summary>
	/// StandardRightName
	/// </summary>
	[DataMember(Name = "standardRightName", EmitDefaultValue = false)]
	public string? StandardRightName { get; set; }

	/// <summary>
	/// ViewRunOpen
	/// </summary>
	[DataMember(Name = "viewRunOpen", EmitDefaultValue = false)]
	public bool? ViewRunOpen { get; set; }
}

