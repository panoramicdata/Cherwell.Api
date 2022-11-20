using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesRelatedBusinessObjectRequest
/// </summary>
[DataContract]
public class RelatedBusinessObjectRequest
{
	/// <summary>
	/// AllFields
	/// </summary>
	[DataMember(Name = "allFields", EmitDefaultValue = false)]
	public bool AllFields { get; set; }

	/// <summary>
	/// CustomGridId
	/// </summary>
	[DataMember(Name = "customGridId", EmitDefaultValue = false)]
	public string CustomGridId { get; set; } = null!;

	/// <summary>
	/// FieldsList
	/// </summary>
	[DataMember(Name = "fieldsList", EmitDefaultValue = false)]
	public List<string> FieldsList { get; set; } = null!;

	/// <summary>
	/// Filters
	/// </summary>
	[DataMember(Name = "filters", EmitDefaultValue = false)]
	public List<FilterInfo> Filters { get; set; } = null!;

	/// <summary>
	/// PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int PageNumber { get; set; }

	/// <summary>
	/// PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int PageSize { get; set; }

	/// <summary>
	/// ParentBusObId
	/// </summary>
	[DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
	public string ParentBusObId { get; set; } = null!;

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string ParentBusObRecId { get; set; } = null!;

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; } = null!;

	/// <summary>
	/// Sorting
	/// </summary>
	[DataMember(Name = "sorting", EmitDefaultValue = false)]
	public List<SortInfo> Sorting { get; set; } = null!;

	/// <summary>
	/// UseDefaultGrid
	/// </summary>
	[DataMember(Name = "useDefaultGrid", EmitDefaultValue = false)]
	public bool UseDefaultGrid { get; set; }
}
