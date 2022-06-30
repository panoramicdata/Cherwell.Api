using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesStoredSearchRequest
/// </summary>
[DataContract]
public partial class StoredSearchRequest
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
	public StoredSearchRequest(string AssociationId, string AssociationName, string GridId, bool IncludeSchema, string Scope, string ScopeOwnerId, string SearchId, string SearchName)
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
	/// AssociationId
	/// </summary>
	[DataMember(Name = "associationId", EmitDefaultValue = false)]
	public string AssociationId { get; set; } = null!;

	/// <summary>
	/// AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string AssociationName { get; set; } = null!;

	/// <summary>
	/// GridId
	/// </summary>
	[DataMember(Name = "gridId", EmitDefaultValue = false)]
	public string GridId { get; set; } = null!;

	/// <summary>
	/// IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool IncludeSchema { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; } = null!;

	/// <summary>
	/// ScopeOwnerId
	/// </summary>
	[DataMember(Name = "scopeOwnerId", EmitDefaultValue = false)]
	public string ScopeOwnerId { get; set; } = null!;

	/// <summary>
	/// SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string SearchId { get; set; } = null!;

	/// <summary>
	/// SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string SearchName { get; set; } = null!;
}
