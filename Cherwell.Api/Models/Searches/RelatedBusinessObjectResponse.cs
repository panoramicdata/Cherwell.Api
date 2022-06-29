using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesRelatedBusinessObjectResponse
/// </summary>
[DataContract]
public partial class RelatedBusinessObjectResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RelatedBusinessObjectResponse" /> class.
	/// </summary>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="Links">Links.</param>
	/// <param name="PageNumber">PageNumber.</param>
	/// <param name="PageSize">PageSize.</param>
	/// <param name="ParentBusObId">ParentBusObId.</param>
	/// <param name="ParentBusObPublicId">ParentBusObPublicId.</param>
	/// <param name="ParentBusObRecId">ParentBusObRecId.</param>
	/// <param name="RelatedBusinessObjects">RelatedBusinessObjects.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="TotalRecords">TotalRecords.</param>
	public RelatedBusinessObjectResponse(string errorCode,
		string errorMessage,
		bool? hasError,
		List<Link> Links,
		int? PageNumber,
		int? PageSize,
		string ParentBusObId,
		string ParentBusObPublicId,
		string ParentBusObRecId,
		List<ReadResponse> RelatedBusinessObjects,
		string RelationshipId,
		int? TotalRecords)
	{
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.Links = Links;
		this.PageNumber = PageNumber;
		this.PageSize = PageSize;
		this.ParentBusObId = ParentBusObId;
		this.ParentBusObPublicId = ParentBusObPublicId;
		this.ParentBusObRecId = ParentBusObRecId;
		this.RelatedBusinessObjects = RelatedBusinessObjects;
		this.RelationshipId = RelationshipId;
		this.TotalRecords = TotalRecords;
	}

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }

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
	public string ParentBusObId { get; set; }

	/// <summary>
	/// ParentBusObPublicId
	/// </summary>
	[DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
	public string ParentBusObPublicId { get; set; }

	/// <summary>
	/// ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string ParentBusObRecId { get; set; }

	/// <summary>
	/// RelatedBusinessObjects
	/// </summary>
	[DataMember(Name = "relatedBusinessObjects", EmitDefaultValue = false)]
	public List<ReadResponse> RelatedBusinessObjects { get; set; }

	/// <summary>
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; }

	/// <summary>
	/// TotalRecords
	/// </summary>
	[DataMember(Name = "totalRecords", EmitDefaultValue = false)]
	public int? TotalRecords { get; set; }
















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
