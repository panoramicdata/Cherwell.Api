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
	/// RelationshipId
	/// </summary>
	[DataMember(Name = "relationshipId", EmitDefaultValue = false)]
	public string? RelationshipId { get; set; }

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string? BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string? BusObRecId { get; set; }

	/// <summary>
	/// CacheKey
	/// </summary>
	[DataMember(Name = "cacheKey", EmitDefaultValue = false)]
	public string? CacheKey { get; set; }

	/// <summary>
	/// FieldValidationErrors
	/// </summary>
	[DataMember(Name = "fieldValidationErrors", EmitDefaultValue = false)]
	public List<FieldValidationError>? FieldValidationErrors { get; set; }

	/// <summary>
	/// NotificationTriggers
	/// </summary>
	[DataMember(Name = "notificationTriggers", EmitDefaultValue = false)]
	public List<NotificationTrigger>? NotificationTriggers { get; set; }
}