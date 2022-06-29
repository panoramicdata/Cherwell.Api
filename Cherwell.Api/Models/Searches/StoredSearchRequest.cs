using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

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
	/// AssociationId
	/// </summary>
	[DataMember(Name = "associationId", EmitDefaultValue = false)]
	public string AssociationId { get; set; }

	/// <summary>
	/// AssociationName
	/// </summary>
	[DataMember(Name = "associationName", EmitDefaultValue = false)]
	public string AssociationName { get; set; }

	/// <summary>
	/// GridId
	/// </summary>
	[DataMember(Name = "gridId", EmitDefaultValue = false)]
	public string GridId { get; set; }

	/// <summary>
	/// IncludeSchema
	/// </summary>
	[DataMember(Name = "includeSchema", EmitDefaultValue = false)]
	public bool? IncludeSchema { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[DataMember(Name = "scope", EmitDefaultValue = false)]
	public string Scope { get; set; }

	/// <summary>
	/// ScopeOwnerId
	/// </summary>
	[DataMember(Name = "scopeOwnerId", EmitDefaultValue = false)]
	public string ScopeOwnerId { get; set; }

	/// <summary>
	/// SearchId
	/// </summary>
	[DataMember(Name = "searchId", EmitDefaultValue = false)]
	public string SearchId { get; set; }

	/// <summary>
	/// SearchName
	/// </summary>
	[DataMember(Name = "searchName", EmitDefaultValue = false)]
	public string SearchName { get; set; }












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




		}
	}

	
}
