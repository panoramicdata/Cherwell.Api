using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesStoredSearchRequest
/// </summary>
[DataContract]
public partial class StoredSearchRequest : IEquatable<StoredSearchRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="StoredSearchRequest" /> class.
	/// </summary>
	/// <param name="AssociationId">AssociationId.</param>
	/// <param name="AssociationName">AssociationName.</param>
	/// <param name="GridId">GridId.</param>
	/// <param name="IncludeSchema">IncludeSchema.</param>
	/// <param name="Scope">Scope.</param>
	/// <param name="ScopeOwnerId">ScopeOwnerId.</param>
	/// <param name="SearchId">SearchId.</param>
	/// <param name="SearchName">SearchName.</param>
	public StoredSearchRequest(string AssociationId, string AssociationName, string GridId, bool? IncludeSchema, string Scope, string ScopeOwnerId, string SearchId, string SearchName)
	{
		this.AssociationId = AssociationId;
		this.AssociationName = AssociationName;
		this.GridId = GridId;
		this.IncludeSchema = IncludeSchema;
		this.Scope = Scope;
		this.ScopeOwnerId = ScopeOwnerId;
		this.SearchId = SearchId;
		this.SearchName = SearchName;
	}

	/// <summary>
	/// Gets or Sets AssociationId
	/// </summary>
	[DataMember(Name = "associationId", EmitDefaultValue = false)]
	public string AssociationId { get; set; }
	/// <summary>
	/// Gets or Sets AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string AssociationName { get; set; }
	/// <summary>
	/// Gets or Sets GridId
	/// </summary>
	[DataMember(Name = "gridId", EmitDefaultValue = false)]
	public string GridId { get; set; }
	/// <summary>
	/// Gets or Sets IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool? IncludeSchema { get; set; }
	/// <summary>
	/// Gets or Sets Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; }
	/// <summary>
	/// Gets or Sets ScopeOwnerId
	/// </summary>
	[DataMember(Name = "scopeOwnerId", EmitDefaultValue = false)]
	public string ScopeOwnerId { get; set; }
	/// <summary>
	/// Gets or Sets SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string SearchId { get; set; }
	/// <summary>
	/// Gets or Sets SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string SearchName { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesStoredSearchRequest {\n");
		sb.Append("  AssociationId: ").Append(AssociationId).Append('\n');
		sb.Append("  AssociationName: ").Append(AssociationName).Append('\n');
		sb.Append("  GridId: ").Append(GridId).Append('\n');
		sb.Append("  IncludeSchema: ").Append(IncludeSchema).Append('\n');
		sb.Append("  Scope: ").Append(Scope).Append('\n');
		sb.Append("  ScopeOwnerId: ").Append(ScopeOwnerId).Append('\n');
		sb.Append("  SearchId: ").Append(SearchId).Append('\n');
		sb.Append("  SearchName: ").Append(SearchName).Append('\n');
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
		return Equals(obj as StoredSearchRequest);
	}

	/// <summary>
	/// Returns true if SearchesStoredSearchRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesStoredSearchRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(StoredSearchRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AssociationId == other.AssociationId ||
					AssociationId != null &&
					AssociationId.Equals(other.AssociationId, StringComparison.Ordinal)
				) &&
				(
					AssociationName == other.AssociationName ||
					AssociationName != null &&
					AssociationName.Equals(other.AssociationName, StringComparison.Ordinal)
				) &&
				(
					GridId == other.GridId ||
					GridId != null &&
					GridId.Equals(other.GridId, StringComparison.Ordinal)
				) &&
				(
					IncludeSchema == other.IncludeSchema ||
					IncludeSchema != null &&
					IncludeSchema.Equals(other.IncludeSchema)
				) &&
				(
					Scope == other.Scope ||
					Scope != null &&
					Scope.Equals(other.Scope, StringComparison.Ordinal)
				) &&
				(
					ScopeOwnerId == other.ScopeOwnerId ||
					ScopeOwnerId != null &&
					ScopeOwnerId.Equals(other.ScopeOwnerId, StringComparison.Ordinal)
				) &&
				(
					SearchId == other.SearchId ||
					SearchId != null &&
					SearchId.Equals(other.SearchId, StringComparison.Ordinal)
				) &&
				(
					SearchName == other.SearchName ||
					SearchName != null &&
					SearchName.Equals(other.SearchName, StringComparison.Ordinal)
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
			if (AssociationId != null)
			{
				hash = hash * 59 + AssociationId.GetHashCode();
			}

			if (AssociationName != null)
			{
				hash = hash * 59 + AssociationName.GetHashCode();
			}

			if (GridId != null)
			{
				hash = hash * 59 + GridId.GetHashCode();
			}

			if (IncludeSchema != null)
			{
				hash = hash * 59 + IncludeSchema.GetHashCode();
			}

			if (Scope != null)
			{
				hash = hash * 59 + Scope.GetHashCode();
			}

			if (ScopeOwnerId != null)
			{
				hash = hash * 59 + ScopeOwnerId.GetHashCode();
			}

			if (SearchId != null)
			{
				hash = hash * 59 + SearchId.GetHashCode();
			}

			if (SearchName != null)
			{
				hash = hash * 59 + SearchName.GetHashCode();
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
