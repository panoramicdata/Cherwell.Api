using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectGridDefinition
/// </summary>
[DataContract]
public partial class GridDefinition
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GridDefinition" /> class.
	/// </summary>
	/// <param name="GridId">GridId.</param>
	/// <param name="Name">Name.</param>
	/// <param name="DisplayName">DisplayName.</param>
	public GridDefinition(string GridId, string Name, string DisplayName)
	{
		this.GridId = GridId;
		this.Name = Name;
		this.DisplayName = DisplayName;
	}

	/// <summary>
	/// GridId
	/// </summary>
	[DataMember(Name = "gridId", EmitDefaultValue = false)]
	public string GridId { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectGridDefinition {\n");
		sb.Append("  GridId: ").Append(GridId).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
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
			if (GridId != null)
			{
				hash = hash * 59 + GridId.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			return hash;
		}
	}

	
}