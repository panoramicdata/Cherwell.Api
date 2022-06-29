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
	/// Initializes a new instance of the <see cref="TemplateRequest" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="FieldNames">FieldNames.</param>
	/// <param name="FieldIds">FieldIds.</param>
	/// <param name="IncludeAll">IncludeAll.</param>
	/// <param name="IncludeRequired">IncludeRequired.</param>
	public TemplateRequest(string BusObId, List<string> FieldNames, List<string> FieldIds, bool? IncludeAll, bool? IncludeRequired)
	{
		this.BusObId = BusObId;
		this.FieldNames = FieldNames;
		this.FieldIds = FieldIds;
		this.IncludeAll = IncludeAll;
		this.IncludeRequired = IncludeRequired;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// FieldNames
	/// </summary>
	[DataMember(Name = "fieldNames", EmitDefaultValue = false)]
	public List<string> FieldNames { get; set; }

	/// <summary>
	/// FieldIds
	/// </summary>
	[DataMember(Name = "fieldIds", EmitDefaultValue = false)]
	public List<string> FieldIds { get; set; }

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