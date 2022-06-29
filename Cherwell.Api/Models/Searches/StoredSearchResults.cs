using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesStoredSearchResults
/// </summary>
[DataContract]
public partial class StoredSearchResults
{
	/// <summary>
	/// Initializes a new instance of the <see cref="StoredSearchResults" /> class.
	/// </summary>
	/// <param name="Columns">Columns.</param>
	/// <param name="Rows">Rows.</param>
	public StoredSearchResults(List<ColumnSchema> Columns, List<List<object>> Rows)
	{
		this.Columns = Columns;
		this.Rows = Rows;
	}

	/// <summary>
	/// Columns
	/// </summary>
	[DataMember(Name = "columns", EmitDefaultValue = false)]
	public List<ColumnSchema> Columns { get; set; }

	/// <summary>
	/// Rows
	/// </summary>
	[DataMember(Name = "rows", EmitDefaultValue = false)]
	public List<List<object>> Rows { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesStoredSearchResults {\n");
		sb.Append("  Columns: ").Append(Columns).Append('\n');
		sb.Append("  Rows: ").Append(Rows).Append('\n');
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
			if (Columns != null)
			{
				hash = hash * 59 + Columns.GetHashCode();
			}

			if (Rows != null)
			{
				hash = hash * 59 + Rows.GetHashCode();
			}

			return hash;
		}
	}

	
}
