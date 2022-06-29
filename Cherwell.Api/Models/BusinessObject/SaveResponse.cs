using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectSaveResponse
/// </summary>
[DataContract]
public partial class SaveResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveResponse" /> class.
	/// </summary>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="CacheKey">CacheKey.</param>
	/// <param name="FieldValidationErrors">FieldValidationErrors.</param>
	/// <param name="NotificationTriggers">NotificationTriggers.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public SaveResponse(string BusObPublicId, string BusObRecId, string CacheKey, List<FieldValidationError> FieldValidationErrors, List<NotificationTrigger> NotificationTriggers, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
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
