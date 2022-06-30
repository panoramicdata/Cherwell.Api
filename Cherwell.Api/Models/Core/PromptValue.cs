using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// PromptValue
/// </summary>
[DataContract]
public partial class PromptValue
{
	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; } = null!;
	/// <summary>
	/// CollectionStoreEntireRow
	/// </summary>
	[DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
	public string CollectionStoreEntireRow { get; set; } = null!;
	/// <summary>
	/// CollectionValueField
	/// </summary>
	[DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
	public string CollectionValueField { get; set; } = null!;
	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; } = null!;
	/// <summary>
	/// ListReturnFieldId
	/// </summary>
	[DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
	public string ListReturnFieldId { get; set; } = null!;
	/// <summary>
	/// PromptId
	/// </summary>
	[DataMember(Name = "promptId", EmitDefaultValue = false)]
	public string PromptId { get; set; } = null!;
	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public Object Value { get; set; } = null!;
	/// <summary>
	/// ValueIsRecId
	/// </summary>
	[DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
	public bool ValueIsRecId { get; set; }
}
