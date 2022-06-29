using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesSortInfo
/// </summary>
[DataContract]
public partial class SortInfo
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SortInfo" /> class.
	/// </summary>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="SortDirection">SortDirection.</param>
	public SortInfo(string FieldId, int? SortDirection)
	{
		this.FieldId = FieldId;
		this.SortDirection = SortDirection;
	}

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// SortDirection
	/// </summary>
	[DataMember(Name = "sortDirection", EmitDefaultValue = false)]
	public int? SortDirection { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesSortInfo {\n");
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  SortDirection: ").Append(SortDirection).Append('\n');
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
			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (SortDirection != null)
			{
				hash = hash * 59 + SortDirection.GetHashCode();
			}

			return hash;
		}
	}

	
}
