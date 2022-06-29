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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesRelatedBusinessObjectResponse {\n");
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  Links: ").Append(Links).Append('\n');
		sb.Append("  PageNumber: ").Append(PageNumber).Append('\n');
		sb.Append("  PageSize: ").Append(PageSize).Append('\n');
		sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append('\n');
		sb.Append("  ParentBusObPublicId: ").Append(ParentBusObPublicId).Append('\n');
		sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append('\n');
		sb.Append("  RelatedBusinessObjects: ").Append(RelatedBusinessObjects).Append('\n');
		sb.Append("  RelationshipId: ").Append(RelationshipId).Append('\n');
		sb.Append("  TotalRecords: ").Append(TotalRecords).Append('\n');
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
			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (Links != null)
			{
				hash = hash * 59 + Links.GetHashCode();
			}

			if (PageNumber != null)
			{
				hash = hash * 59 + PageNumber.GetHashCode();
			}

			if (PageSize != null)
			{
				hash = hash * 59 + PageSize.GetHashCode();
			}

			if (ParentBusObId != null)
			{
				hash = hash * 59 + ParentBusObId.GetHashCode();
			}

			if (ParentBusObPublicId != null)
			{
				hash = hash * 59 + ParentBusObPublicId.GetHashCode();
			}

			if (ParentBusObRecId != null)
			{
				hash = hash * 59 + ParentBusObRecId.GetHashCode();
			}

			if (RelatedBusinessObjects != null)
			{
				hash = hash * 59 + RelatedBusinessObjects.GetHashCode();
			}

			if (RelationshipId != null)
			{
				hash = hash * 59 + RelationshipId.GetHashCode();
			}

			if (TotalRecords != null)
			{
				hash = hash * 59 + TotalRecords.GetHashCode();
			}

			return hash;
		}
	}

	
}
