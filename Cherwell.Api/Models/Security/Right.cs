using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// Right
/// </summary>
[DataContract]
public partial class Right
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
	public Right(bool? Add, bool? Allow, string CategoryDescription, string CategoryId, string CategoryName, bool? Delete, bool? Edit, bool? IsYesNoRight, bool? NonScopeOwnerAdd, bool? NonScopeOwnerDelete, bool? NonScopeOwnerEdit, bool? NonScopeOwnerView, string RightId, string RightName, string StandardRightName, bool? ViewRunOpen)
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
	public string CategoryDescription { get; set; }

	/// <summary>
	/// CategoryId
	/// </summary>
	[DataMember(Name = "categoryId", EmitDefaultValue = false)]
	public string CategoryId { get; set; }

	/// <summary>
	/// CategoryName
	/// </summary>
	[DataMember(Name = "categoryName", EmitDefaultValue = false)]
	public string CategoryName { get; set; }

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
	public string RightId { get; set; }

	/// <summary>
	/// RightName
	/// </summary>
	[DataMember(Name = "rightName", EmitDefaultValue = false)]
	public string RightName { get; set; }

	/// <summary>
	/// StandardRightName
	/// </summary>
	[DataMember(Name = "standardRightName", EmitDefaultValue = false)]
	public string StandardRightName { get; set; }

	/// <summary>
	/// ViewRunOpen
	/// </summary>
	[DataMember(Name = "viewRunOpen", EmitDefaultValue = false)]
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
			if (Add != null)
			{
				hash = hash * 59 + Add.GetHashCode();
			}

			if (Allow != null)
			{
				hash = hash * 59 + Allow.GetHashCode();
			}

			if (CategoryDescription != null)
			{
				hash = hash * 59 + CategoryDescription.GetHashCode();
			}

			if (CategoryId != null)
			{
				hash = hash * 59 + CategoryId.GetHashCode();
			}

			if (CategoryName != null)
			{
				hash = hash * 59 + CategoryName.GetHashCode();
			}

			if (Delete != null)
			{
				hash = hash * 59 + Delete.GetHashCode();
			}

			if (Edit != null)
			{
				hash = hash * 59 + Edit.GetHashCode();
			}

			if (IsYesNoRight != null)
			{
				hash = hash * 59 + IsYesNoRight.GetHashCode();
			}

			if (NonScopeOwnerAdd != null)
			{
				hash = hash * 59 + NonScopeOwnerAdd.GetHashCode();
			}

			if (NonScopeOwnerDelete != null)
			{
				hash = hash * 59 + NonScopeOwnerDelete.GetHashCode();
			}

			if (NonScopeOwnerEdit != null)
			{
				hash = hash * 59 + NonScopeOwnerEdit.GetHashCode();
			}

			if (NonScopeOwnerView != null)
			{
				hash = hash * 59 + NonScopeOwnerView.GetHashCode();
			}

			if (RightId != null)
			{
				hash = hash * 59 + RightId.GetHashCode();
			}

			if (RightName != null)
			{
				hash = hash * 59 + RightName.GetHashCode();
			}

			if (StandardRightName != null)
			{
				hash = hash * 59 + StandardRightName.GetHashCode();
			}

			if (ViewRunOpen != null)
			{
				hash = hash * 59 + ViewRunOpen.GetHashCode();
			}

			return hash;
		}
	}

	
}

