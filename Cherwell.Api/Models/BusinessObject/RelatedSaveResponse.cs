using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectRelatedSaveResponse
/// </summary>
[DataContract]
public partial class RelatedSaveResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="RelatedSaveResponse" /> class.
	/// </summary>
	/// <param name="ParentBusObId">ParentBusObId.</param>
	/// <param name="ParentBusObPublicId">ParentBusObPublicId.</param>
	/// <param name="ParentBusObRecId">ParentBusObRecId.</param>
	/// <param name="RelationshipId">RelationshipId.</param>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="CacheKey">CacheKey.</param>
	/// <param name="FieldValidationErrors">FieldValidationErrors.</param>
	/// <param name="NotificationTriggers">NotificationTriggers.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public RelatedSaveResponse(string ParentBusObId, string ParentBusObPublicId, string ParentBusObRecId, string RelationshipId, string BusObPublicId, string BusObRecId, string CacheKey, List<FieldValidationError> FieldValidationErrors, List<NotificationTrigger> NotificationTriggers, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.ParentBusObId = ParentBusObId;
		this.ParentBusObPublicId = ParentBusObPublicId;
		this.ParentBusObRecId = ParentBusObRecId;
		this.RelationshipId = RelationshipId;
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.CacheKey = CacheKey;
		this.FieldValidationErrors = FieldValidationErrors;
		this.NotificationTriggers = NotificationTriggers;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

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
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string RelationshipId { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// CacheKey
	/// </summary>
	[DataMember(Name = "cacheKey", EmitDefaultValue = false)]
	public string CacheKey { get; set; }

	/// <summary>
	/// FieldValidationErrors
	/// </summary>
	[DataMember(Name = "fieldValidationErrors", EmitDefaultValue = false)]
	public List<FieldValidationError> FieldValidationErrors { get; set; }

	/// <summary>
	/// NotificationTriggers
	/// </summary>
	[DataMember(Name = "notificationTriggers", EmitDefaultValue = false)]
	public List<NotificationTrigger> NotificationTriggers { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectRelatedSaveResponse {\n");
		sb.Append("  ParentBusObId: ").Append(ParentBusObId).Append('\n');
		sb.Append("  ParentBusObPublicId: ").Append(ParentBusObPublicId).Append('\n');
		sb.Append("  ParentBusObRecId: ").Append(ParentBusObRecId).Append('\n');
		sb.Append("  RelationshipId: ").Append(RelationshipId).Append('\n');
		sb.Append("  BusObPublicId: ").Append(BusObPublicId).Append('\n');
		sb.Append("  BusObRecId: ").Append(BusObRecId).Append('\n');
		sb.Append("  CacheKey: ").Append(CacheKey).Append('\n');
		sb.Append("  FieldValidationErrors: ").Append(FieldValidationErrors).Append('\n');
		sb.Append("  NotificationTriggers: ").Append(NotificationTriggers).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
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

			if (RelationshipId != null)
			{
				hash = hash * 59 + RelationshipId.GetHashCode();
			}

			if (BusObPublicId != null)
			{
				hash = hash * 59 + BusObPublicId.GetHashCode();
			}

			if (BusObRecId != null)
			{
				hash = hash * 59 + BusObRecId.GetHashCode();
			}

			if (CacheKey != null)
			{
				hash = hash * 59 + CacheKey.GetHashCode();
			}

			if (FieldValidationErrors != null)
			{
				hash = hash * 59 + FieldValidationErrors.GetHashCode();
			}

			if (NotificationTriggers != null)
			{
				hash = hash * 59 + NotificationTriggers.GetHashCode();
			}

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

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
			}

			return hash;
		}
	}

	
}