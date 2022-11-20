using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// TemplateRequest
/// </summary>
[DataContract]
public class TemplateRequest
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// FieldNames
	/// </summary>
	[DataMember(Name = "fieldNames", EmitDefaultValue = false)]
	public List<string> FieldNames { get; set; } = null!;

	/// <summary>
	/// FieldIds
	/// </summary>
	[DataMember(Name = "fieldIds", EmitDefaultValue = false)]
	public List<string> FieldIds { get; set; } = null!;

	/// <summary>
	/// IncludeAll
	/// </summary>
	[DataMember(Name = "includeAll", EmitDefaultValue = false)]
	public bool IncludeAll { get; set; }

	/// <summary>
	/// IncludeRequired
	/// </summary>
	[DataMember(Name = "includeRequired", EmitDefaultValue = false)]
	public bool IncludeRequired { get; set; }
}