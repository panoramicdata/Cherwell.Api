using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldValuesLookupRequest
/// </summary>
[DataContract]
public partial class FieldValuesLookupRequest
{
	/// <summary>
	/// BusbPublicId
	/// </summary>
	[DataMember(Name = "busbPublicId", EmitDefaultValue = false)]
	public string? BusbPublicId { get; set; }

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string? BusObRecId { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string? FieldId { get; set; }

	/// <summary>
	/// FieldName
	/// </summary>
	[DataMember(Name = "fieldName", EmitDefaultValue = false)]
	public string? FieldName { get; set; }

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem>? Fields { get; set; }
}