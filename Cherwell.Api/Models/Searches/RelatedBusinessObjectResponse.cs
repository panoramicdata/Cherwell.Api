using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesRelatedBusinessObjectResponse
/// </summary>
[DataContract]
public partial class RelatedBusinessObjectResponse : IEquatable<RelatedBusinessObjectResponse>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RelatedBusinessObjectResponse" /> class.
	/// </summary>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="ErrorMessage">ErrorMessage.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="Links">Links.</param>
	/// <param name="PageNumber">PageNumber.</param>
	/// <param name="PageSize">PageSize.</param>
	/// <param name="ParentBusObId">ParentBusObId.</param>
	/// <param name="ParentBusObPublicId">ParentBusObPublicId.</param>
	/// <param name="ParentBusObRecId">ParentBusObRecId.</param>
	/// <param name="RelatedBusinessObjects">RelatedBusinessObjects.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="TotalRecords">TotalRecords.</param>
	public RelatedBusinessObjectResponse(string ErrorCode,
		string ErrorMessage,
		bool? HasError,
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
		this.ErrorCode = ErrorCode;
		this.ErrorMessage = ErrorMessage;
		this.HasError = HasError;
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
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }
	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }
	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }
	/// <summary>
	/// Gets or Sets Links
	/// </summary>
	[DataMember(Name = "links", EmitDefaultValue = false)]
	public List<Link> Links { get; set; }
	/// <summary>
	/// Gets or Sets PageNumber
	/// </summary>
	[DataMember(Name = "pageNumber", EmitDefaultValue = false)]
	public int? PageNumber { get; set; }
	/// <summary>
	/// Gets or Sets PageSize
	/// </summary>
	[DataMember(Name = "pageSize", EmitDefaultValue = false)]
	public int? PageSize { get; set; }
	/// <summary>
	/// Gets or Sets ParentBusObId
	/// </summary>
	[DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
	public string ParentBusObId { get; set; }
	/// <summary>
	/// Gets or Sets ParentBusObPublicId
	/// </summary>
	[DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
	public string ParentBusObPublicId { get; set; }
	/// <summary>
	/// Gets or Sets ParentBusObRecId
	/// </summary>
	[DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
	public string ParentBusObRecId { get; set; }
	/// <summary>
	/// Gets or Sets RelatedBusinessObjects
	/// </summary>
	[DataMember(Name = "relatedBusinessObjects", EmitDefaultValue = false)]
	public List<ReadResponse> RelatedBusinessObjects { get; set; }
	/// <summary>
	/// Gets or Sets RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; }
	/// <summary>
	/// Gets or Sets TotalRecords
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
		return Equals(obj as RelatedBusinessObjectResponse);
	}

	/// <summary>
	/// Returns true if SearchesRelatedBusinessObjectResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesRelatedBusinessObjectResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(RelatedBusinessObjectResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					Links == other.Links ||
					Links != null &&
					Links.SequenceEqual(other.Links)
				) &&
				(
					PageNumber == other.PageNumber ||
					PageNumber != null &&
					PageNumber.Equals(other.PageNumber)
				) &&
				(
					PageSize == other.PageSize ||
					PageSize != null &&
					PageSize.Equals(other.PageSize)
				) &&
				(
					ParentBusObId == other.ParentBusObId ||
					ParentBusObId != null &&
					ParentBusObId.Equals(other.ParentBusObId, StringComparison.Ordinal)
				) &&
				(
					ParentBusObPublicId == other.ParentBusObPublicId ||
					ParentBusObPublicId != null &&
					ParentBusObPublicId.Equals(other.ParentBusObPublicId, StringComparison.Ordinal)
				) &&
				(
					ParentBusObRecId == other.ParentBusObRecId ||
					ParentBusObRecId != null &&
					ParentBusObRecId.Equals(other.ParentBusObRecId, StringComparison.Ordinal)
				) &&
				(
					RelatedBusinessObjects == other.RelatedBusinessObjects ||
					RelatedBusinessObjects != null &&
					RelatedBusinessObjects.SequenceEqual(other.RelatedBusinessObjects)
				) &&
				(
					RelationshipId == other.RelationshipId ||
					RelationshipId != null &&
					RelationshipId.Equals(other.RelationshipId, StringComparison.Ordinal)
				) &&
				(
					TotalRecords == other.TotalRecords ||
					TotalRecords != null &&
					TotalRecords.Equals(other.TotalRecords)
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
