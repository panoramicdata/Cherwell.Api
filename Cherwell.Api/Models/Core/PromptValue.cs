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
	/// Initializes a new instance of the <see cref="PromptValue" /> class.
	/// </summary>
	/// <param name="BusObId">BusObId.</param>
	/// <param name="CollectionStoreEntireRow">CollectionStoreEntireRow.</param>
	/// <param name="CollectionValueField">CollectionValueField.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="ListReturnFieldId">ListReturnFieldId.</param>
	/// <param name="PromptId">PromptId.</param>
	/// <param name="Value">Value.</param>
	/// <param name="ValueIsRecId">ValueIsRecId.</param>
	public PromptValue(string BusObId, string CollectionStoreEntireRow, string CollectionValueField, string FieldId, string ListReturnFieldId, string PromptId, Object Value, bool? ValueIsRecId)
	{
		this.BusObId = BusObId;
		this.CollectionStoreEntireRow = CollectionStoreEntireRow;
		this.CollectionValueField = CollectionValueField;
		this.FieldId = FieldId;
		this.ListReturnFieldId = ListReturnFieldId;
		this.PromptId = PromptId;
		this.Value = Value;
		this.ValueIsRecId = ValueIsRecId;
	}

	/// <summary>
	/// BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }

	/// <summary>
	/// CollectionStoreEntireRow
	/// </summary>
	[DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
	public string CollectionStoreEntireRow { get; set; }

	/// <summary>
	/// CollectionValueField
	/// </summary>
	[DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
	public string CollectionValueField { get; set; }

	/// <summary>
	/// FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// ListReturnFieldId
	/// </summary>
	[DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
	public string ListReturnFieldId { get; set; }

	/// <summary>
	/// PromptId
	/// </summary>
	[DataMember(Name = "promptId", EmitDefaultValue = false)]
	public string PromptId { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public Object Value { get; set; }

	/// <summary>
	/// ValueIsRecId
	/// </summary>
	[DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
	public bool? ValueIsRecId { get; set; }












	/// <summary>
	/// Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		// credit: http://stackoverflow.com/a/263416/677735
		unchecked // Overflow is fine, just wrap
		{
			int hash = 41;
			// Suitable nullity checks etc, of course :)




		}
	}

	
}
