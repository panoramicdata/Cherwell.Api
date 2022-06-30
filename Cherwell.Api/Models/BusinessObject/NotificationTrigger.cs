using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectNotificationTrigger
/// </summary>
[DataContract]
public partial class NotificationTrigger
{
	/// <summary>
	/// SourceType
	/// </summary>
	[DataMember(Name = "sourceType", EmitDefaultValue = false)]
	public string? SourceType { get; set; }

	/// <summary>
	/// SourceId
	/// </summary>
	[DataMember(Name = "sourceId", EmitDefaultValue = false)]
	public string? SourceId { get; set; }

	/// <summary>
	/// SourceChange
	/// </summary>
	[DataMember(Name = "sourceChange", EmitDefaultValue = false)]
	public string? SourceChange { get; set; }

	/// <summary>
	/// Key
	/// </summary>
	[DataMember(Name = "key", EmitDefaultValue = false)]
	public string? Key { get; set; }
}