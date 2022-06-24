using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesColumnSchema
/// </summary>
[DataContract]
public partial class ColumnSchema : IEquatable<ColumnSchema>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnumType
	{

		/// <summary>
		/// Enum Text for "Text"
		/// </summary>
		[EnumMember(Value = "Text")]
		Text,

		/// <summary>
		/// Enum Number for "Number"
		/// </summary>
		[EnumMember(Value = "Number")]
		Number,

		/// <summary>
		/// Enum Currency for "Currency"
		/// </summary>
		[EnumMember(Value = "Currency")]
		Currency,

		/// <summary>
		/// Enum Integer for "Integer"
		/// </summary>
		[EnumMember(Value = "Integer")]
		EnumInteger,

		/// <summary>
		/// Enum Datetime for "Datetime"
		/// </summary>
		[EnumMember(Value = "Datetime")]
		Datetime,

		/// <summary>
		/// Enum Date for "Date"
		/// </summary>
		[EnumMember(Value = "Date")]
		Date,

		/// <summary>
		/// Enum Time for "Time"
		/// </summary>
		[EnumMember(Value = "Time")]
		Time,

		/// <summary>
		/// Enum Logical for "Logical"
		/// </summary>
		[EnumMember(Value = "Logical")]
		Logical
	}

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public EnumType? Type { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="ColumnSchema" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="Type">Type.</param>
	public ColumnSchema(string Name, string FieldId, EnumType? Type)
	{
		this.Name = Name;
		this.FieldId = FieldId;
		this.Type = Type;
	}

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Gets or Sets FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SearchesColumnSchema {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  Type: ").Append(Type).Append('\n');
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
		return Equals(obj as ColumnSchema);
	}

	/// <summary>
	/// Returns true if SearchesColumnSchema instances are equal
	/// </summary>
	/// <param name="other">Instance of SearchesColumnSchema to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ColumnSchema? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					Type == other.Type ||
					Type != null &&
					Type.Equals(other.Type)
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
			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (Type != null)
			{
				hash = hash * 59 + Type.GetHashCode();
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
