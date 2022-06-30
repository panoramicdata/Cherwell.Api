using System.Runtime.Serialization;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesRelatedBusinessObjectResponse
/// </summary>
[DataContract]
public partial class RelatedBusinessObjectResponse : Response
{
	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link>? Links { get; set; }

	/// <summary>
	/// PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int? PageNumber { get; set; }

	/// <summary>
	/// PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int? PageSize { get; set; }

	/// <summary>
	/// ParentBusObId
	/// </summary>
	[DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
	public string? ParentBusObId { get; set; }

	/// <summary>
	/// ParentBusObPublicId
	/// </summary>
	[DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
	public string? ParentBusObPublicId { get; set; }

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string? ParentBusObRecId { get; set; }

	/// <summary>
	/// RelatedBusinessObjects
	/// </summary>
	[DataMember(Name = "relatedBusinessObjects", EmitDefaultValue = false)]
	public List<ReadResponse>? RelatedBusinessObjects { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string? RelationshipId { get; set; }

	/// <summary>
	/// TotalRecords
	/// </summary>
	[DataMember(Name = "totalRecords", EmitDefaultValue = false)]
	public int? TotalRecords { get; set; }
}
