using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesStoredSearchResults
/// </summary>
[DataContract]
public partial class StoredSearchResults : IEquatable<StoredSearchResults>, IValidatableObject
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
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as StoredSearchResults);
	}

	/// <summary>
	/// Returns true if SearchesStoredSearchResults instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesStoredSearchResults to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(StoredSearchResults? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Columns == other.Columns ||
					Columns != null &&
					Columns.SequenceEqual(other.Columns)
				) &&
				(
					Rows == other.Rows ||
					Rows != null &&
					Rows.SequenceEqual(other.Rows)
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
