using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CorePromptValue
/// </summary>
[DataContract]
public partial class PromptValue
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string? BusObId { get; set; }

	/// <summary>
	/// CollectionStoreEntireRow
	/// </summary>
	[DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
	public string? CollectionStoreEntireRow { get; set; }

	/// <summary>
	/// CollectionValueField
	/// </summary>
	[DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
	public string? CollectionValueField { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string? FieldId { get; set; }

	/// <summary>
	/// ListReturnFieldId
	/// </summary>
	[DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
	public string? ListReturnFieldId { get; set; }

	/// <summary>
	/// PromptId
	/// </summary>
	[DataMember(Name = "promptId", EmitDefaultValue = false)]
	public string? PromptId { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public Object? Value { get; set; }

	/// <summary>
	/// ValueIsRecId
	/// </summary>
	[DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
	public bool? ValueIsRecId { get; set; }
}
