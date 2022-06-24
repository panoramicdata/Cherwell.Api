using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// Right
/// </summary>
[DataContract]
public partial class Right : IEquatable<Right>, IValidatableObject
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
	/// Gets or Sets Add
	/// </summary>
	[DataMember(Name = "add", EmitDefaultValue = false)]
	public bool? Add { get; set; }
	/// <summary>
	/// Gets or Sets Allow
	/// </summary>
	[DataMember(Name = "allow", EmitDefaultValue = false)]
	public bool? Allow { get; set; }
	/// <summary>
	/// Gets or Sets CategoryDescription
	/// </summary>
	[DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
	public string CategoryDescription { get; set; }
	/// <summary>
	/// Gets or Sets CategoryId
	/// </summary>
	[DataMember(Name = "categoryId", EmitDefaultValue = false)]
	public string CategoryId { get; set; }
	/// <summary>
	/// Gets or Sets CategoryName
	/// </summary>
	[DataMember(Name = "categoryName", EmitDefaultValue = false)]
	public string CategoryName { get; set; }
	/// <summary>
	/// Gets or Sets Delete
	/// </summary>
	[DataMember(Name = "delete", EmitDefaultValue = false)]
	public bool? Delete { get; set; }
	/// <summary>
	/// Gets or Sets Edit
	/// </summary>
	[DataMember(Name = "edit", EmitDefaultValue = false)]
	public bool? Edit { get; set; }
	/// <summary>
	/// Gets or Sets IsYesNoRight
	/// </summary>
	[DataMember(Name = "isYesNoRight", EmitDefaultValue = false)]
	public bool? IsYesNoRight { get; set; }
	/// <summary>
	/// Gets or Sets NonScopeOwnerAdd
	/// </summary>
	[DataMember(Name = "nonScopeOwnerAdd", EmitDefaultValue = false)]
	public bool? NonScopeOwnerAdd { get; set; }
	/// <summary>
	/// Gets or Sets NonScopeOwnerDelete
	/// </summary>
	[DataMember(Name = "nonScopeOwnerDelete", EmitDefaultValue = false)]
	public bool? NonScopeOwnerDelete { get; set; }
	/// <summary>
	/// Gets or Sets NonScopeOwnerEdit
	/// </summary>
	[DataMember(Name = "nonScopeOwnerEdit", EmitDefaultValue = false)]
	public bool? NonScopeOwnerEdit { get; set; }
	/// <summary>
	/// Gets or Sets NonScopeOwnerView
	/// </summary>
	[DataMember(Name = "nonScopeOwnerView", EmitDefaultValue = false)]
	public bool? NonScopeOwnerView { get; set; }
	/// <summary>
	/// Gets or Sets RightId
	/// </summary>
	[DataMember(Name = "rightId", EmitDefaultValue = false)]
	public string RightId { get; set; }
	/// <summary>
	/// Gets or Sets RightName
	/// </summary>
	[DataMember(Name = "rightName", EmitDefaultValue = false)]
	public string RightName { get; set; }
	/// <summary>
	/// Gets or Sets StandardRightName
	/// </summary>
	[DataMember(Name = "standardRightName", EmitDefaultValue = false)]
	public string StandardRightName { get; set; }
	/// <summary>
	/// Gets or Sets ViewRunOpen
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
		return Equals(obj as Right);
	}

	/// <summary>
	/// Returns true if Right instances are equal
	/// </summary>
	/// <param name="other">Instance of Right to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Right? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Add == other.Add ||
					Add != null &&
					Add.Equals(other.Add)
				) &&
				(
					Allow == other.Allow ||
					Allow != null &&
					Allow.Equals(other.Allow)
				) &&
				(
					CategoryDescription == other.CategoryDescription ||
					CategoryDescription != null &&
					CategoryDescription.Equals(other.CategoryDescription, StringComparison.Ordinal)
				) &&
				(
					CategoryId == other.CategoryId ||
					CategoryId != null &&
					CategoryId.Equals(other.CategoryId, StringComparison.Ordinal)
				) &&
				(
					CategoryName == other.CategoryName ||
					CategoryName != null &&
					CategoryName.Equals(other.CategoryName, StringComparison.Ordinal)
				) &&
				(
					Delete == other.Delete ||
					Delete != null &&
					Delete.Equals(other.Delete)
				) &&
				(
					Edit == other.Edit ||
					Edit != null &&
					Edit.Equals(other.Edit)
				) &&
				(
					IsYesNoRight == other.IsYesNoRight ||
					IsYesNoRight != null &&
					IsYesNoRight.Equals(other.IsYesNoRight)
				) &&
				(
					NonScopeOwnerAdd == other.NonScopeOwnerAdd ||
					NonScopeOwnerAdd != null &&
					NonScopeOwnerAdd.Equals(other.NonScopeOwnerAdd)
				) &&
				(
					NonScopeOwnerDelete == other.NonScopeOwnerDelete ||
					NonScopeOwnerDelete != null &&
					NonScopeOwnerDelete.Equals(other.NonScopeOwnerDelete)
				) &&
				(
					NonScopeOwnerEdit == other.NonScopeOwnerEdit ||
					NonScopeOwnerEdit != null &&
					NonScopeOwnerEdit.Equals(other.NonScopeOwnerEdit)
				) &&
				(
					NonScopeOwnerView == other.NonScopeOwnerView ||
					NonScopeOwnerView != null &&
					NonScopeOwnerView.Equals(other.NonScopeOwnerView)
				) &&
				(
					RightId == other.RightId ||
					RightId != null &&
					RightId.Equals(other.RightId, StringComparison.Ordinal)
				) &&
				(
					RightName == other.RightName ||
					RightName != null &&
					RightName.Equals(other.RightName, StringComparison.Ordinal)
				) &&
				(
					StandardRightName == other.StandardRightName ||
					StandardRightName != null &&
					StandardRightName.Equals(other.StandardRightName, StringComparison.Ordinal)
				) &&
				(
					ViewRunOpen == other.ViewRunOpen ||
					ViewRunOpen != null &&
					ViewRunOpen.Equals(other.ViewRunOpen)
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

