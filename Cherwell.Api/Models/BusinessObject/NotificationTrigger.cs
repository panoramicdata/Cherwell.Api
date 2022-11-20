using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// NotificationTrigger
/// </summary>
[DataContract]
public class NotificationTrigger
{
	/// <summary>
	/// SourceType
	/// </summary>
	[DataMember(Name = "sourceType", EmitDefaultValue = false)]
	public string SourceType { get; set; } = null!;

	/// <summary>
	/// SourceId
	/// </summary>
	[DataMember(Name = "sourceId", EmitDefaultValue = false)]
	public string SourceId { get; set; } = null!;

	/// <summary>
	/// SourceChange
	/// </summary>
	[DataMember(Name = "sourceChange", EmitDefaultValue = false)]
	public string SourceChange { get; set; } = null!;

	/// <summary>
	/// Key
	/// </summary>
	[DataMember(Name = "key", EmitDefaultValue = false)]
	public string Key { get; set; } = null!;
}