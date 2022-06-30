using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesRelatedBusinessObjectRequest
/// </summary>
[DataContract]
public partial class RelatedBusinessObjectRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RelatedBusinessObjectRequest" /> class.
	/// </summary>
	/// <param name="AllFields">AllFields.</param>
	/// <param name="CustomGridId">CustomGridId.</param>
	/// <param name="FieldsList">FieldsList.</param>
	/// <param name="Filters">Filters.</param>
	/// <param name="PageNumber">PageNumber.</param>
	/// <param name="PageSize">PageSize.</param>
	/// <param name="ParentBusObId">ParentBusObId.</param>
	/// <param name="ParentBusObRecId">ParentBusObRecId.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="Sorting">Sorting.</param>
	/// <param name="UseDefaultGrid">UseDefaultGrid.</param>
	public RelatedBusinessObjectRequest(bool AllFields, string CustomGridId, List<string> FieldsList, List<FilterInfo> Filters, int PageNumber, int PageSize, string ParentBusObId, string ParentBusObRecId, string RelationshipId, List<SortInfo> Sorting, bool UseDefaultGrid)
	{
		this.AllFields = AllFields;
		this.CustomGridId = CustomGridId;
		this.FieldsList = FieldsList;
		this.Filters = Filters;
		this.PageNumber = PageNumber;
		this.PageSize = PageSize;
		this.ParentBusObId = ParentBusObId;
		this.ParentBusObRecId = ParentBusObRecId;
		this.RelationshipId = RelationshipId;
		this.Sorting = Sorting;
		this.UseDefaultGrid = UseDefaultGrid;
	}

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
