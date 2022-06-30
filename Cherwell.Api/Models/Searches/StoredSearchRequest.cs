using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesStoredSearchRequest
/// </summary>
[DataContract]
public partial class StoredSearchRequest
{
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
