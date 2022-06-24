using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CorePromptValue
/// </summary>
[DataContract]
public partial class PromptValue : IEquatable<PromptValue>, IValidatableObject
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
	/// Gets or Sets BusObId
	/// </summary>
	[DataMember(Name = "busObId", EmitDefaultValue = false)]
	public string BusObId { get; set; }
	/// <summary>
	/// Gets or Sets CollectionStoreEntireRow
	/// </summary>
	[DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
	public string CollectionStoreEntireRow { get; set; }
	/// <summary>
	/// Gets or Sets CollectionValueField
	/// </summary>
	[DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
	public string CollectionValueField { get; set; }
	/// <summary>
	/// Gets or Sets FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }
	/// <summary>
	/// Gets or Sets ListReturnFieldId
	/// </summary>
	[DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
	public string ListReturnFieldId { get; set; }
	/// <summary>
	/// Gets or Sets PromptId
	/// </summary>
	[DataMember(Name = "promptId", EmitDefaultValue = false)]
	public string PromptId { get; set; }
	/// <summary>
	/// Gets or Sets Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public Object Value { get; set; }
	/// <summary>
	/// Gets or Sets ValueIsRecId
	/// </summary>
	[DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
	public bool? ValueIsRecId { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CorePromptValue {\n");
		sb.Append("  BusObId: ").Append(BusObId).Append('\n');
		sb.Append("  CollectionStoreEntireRow: ").Append(CollectionStoreEntireRow).Append('\n');
		sb.Append("  CollectionValueField: ").Append(CollectionValueField).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  ListReturnFieldId: ").Append(ListReturnFieldId).Append('\n');
		sb.Append("  PromptId: ").Append(PromptId).Append('\n');
		sb.Append("  Value: ").Append(Value).Append('\n');
		sb.Append("  ValueIsRecId: ").Append(ValueIsRecId).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as PromptValue);
	}

	/// <summary>
	/// Returns true if CorePromptValue instances are equal
	/// </summary>
	/// <param name="other">Instance of CorePromptValue to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(PromptValue? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					BusObId == other.BusObId ||
					BusObId != null &&
					BusObId.Equals(other.BusObId, StringComparison.Ordinal)
				) &&
				(
					CollectionStoreEntireRow == other.CollectionStoreEntireRow ||
					CollectionStoreEntireRow != null &&
					CollectionStoreEntireRow.Equals(other.CollectionStoreEntireRow, StringComparison.Ordinal)
				) &&
				(
					CollectionValueField == other.CollectionValueField ||
					CollectionValueField != null &&
					CollectionValueField.Equals(other.CollectionValueField, StringComparison.Ordinal)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					ListReturnFieldId == other.ListReturnFieldId ||
					ListReturnFieldId != null &&
					ListReturnFieldId.Equals(other.ListReturnFieldId, StringComparison.Ordinal)
				) &&
				(
					PromptId == other.PromptId ||
					PromptId != null &&
					PromptId.Equals(other.PromptId, StringComparison.Ordinal)
				) &&
				(
					Value == other.Value ||
					Value != null &&
					Value.Equals(other.Value)
				) &&
				(
					ValueIsRecId == other.ValueIsRecId ||
					ValueIsRecId != null &&
					ValueIsRecId.Equals(other.ValueIsRecId)
				);
	}

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
			if (BusObId != null)
			{
				hash = hash * 59 + BusObId.GetHashCode();
			}

			if (CollectionStoreEntireRow != null)
			{
				hash = hash * 59 + CollectionStoreEntireRow.GetHashCode();
			}

			if (CollectionValueField != null)
			{
				hash = hash * 59 + CollectionValueField.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (ListReturnFieldId != null)
			{
				hash = hash * 59 + ListReturnFieldId.GetHashCode();
			}

			if (PromptId != null)
			{
				hash = hash * 59 + PromptId.GetHashCode();
			}

			if (Value != null)
			{
				hash = hash * 59 + Value.GetHashCode();
			}

			if (ValueIsRecId != null)
			{
				hash = hash * 59 + ValueIsRecId.GetHashCode();
			}

			return hash;
		}
	}

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}
