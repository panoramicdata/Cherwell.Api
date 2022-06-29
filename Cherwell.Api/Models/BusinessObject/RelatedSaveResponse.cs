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
}