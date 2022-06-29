using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// RightCategory
/// </summary>
[DataContract]
public partial class RightCategory
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RightCategory" /> class.
	/// </summary>
	/// <param name="CategoryDescription">CategoryDescription.</param>
	/// <param name="CategoryId">CategoryId.</param>
	/// <param name="CategoryName">CategoryName.</param>
	public RightCategory(string CategoryDescription, string CategoryId, string CategoryName)
	{
		this.CategoryDescription = CategoryDescription;
		this.CategoryId = CategoryId;
		this.CategoryName = CategoryName;
	}

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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityRightCategory {\n");
		sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append('\n');
		sb.Append("  CategoryId: ").Append(CategoryId).Append('\n');
		sb.Append("  CategoryName: ").Append(CategoryName).Append('\n');
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

			return hash;
		}
	}

	
}

