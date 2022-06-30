using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectTemplateRequest
/// </summary>
[DataContract]
public partial class TemplateRequest
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// FieldNames
	/// </summary>
	[DataMember(Name = "fieldNames", EmitDefaultValue = false)]
	public List<string?> FieldNames { get; set; }

	/// <summary>
	/// FieldIds
	/// </summary>
	[DataMember(Name = "fieldIds", EmitDefaultValue = false)]
	public List<string?> FieldIds { get; set; }

	/// <summary>
	/// IncludeAll
	/// </summary>
	[DataMember(Name = "includeAll", EmitDefaultValue = false)]
	public bool? IncludeAll { get; set; }

	/// <summary>
	/// IncludeRequired
	/// </summary>
	[DataMember(Name = "includeRequired", EmitDefaultValue = false)]
	public bool? IncludeRequired { get; set; }
}