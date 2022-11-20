using System.Runtime.Serialization;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// FieldValuesLookupRequest
/// </summary>
[DataContract]
public class FieldValuesLookupRequest
{
	/// <summary>
	/// BusbPublicId
	/// </summary>
	[DataMember(Name = "busbPublicId", EmitDefaultValue = false)]
	public string BusbPublicId { get; set; } = null!;

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; } = null!;

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;

	/// <summary>
	/// FieldName
	/// </summary>
	[DataMember(Name = "fieldName", EmitDefaultValue = false)]
	public string FieldName { get; set; } = null!;

	/// <summary>
	/// Fields
	/// </summary>
	[DataMember(Name = "fields", EmitDefaultValue = false)]
	public List<FieldTemplateItem> Fields { get; set; } = null!;
}