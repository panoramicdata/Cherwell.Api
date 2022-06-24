using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.BusinessObject;

/// <summary>
/// BusinessObjectFieldDefinition
/// </summary>
[DataContract]
public partial class FieldDefinition : IEquatable<FieldDefinition>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FieldDefinition" /> class.
	/// </summary>
	/// <param name="AutoFill">AutoFill.</param>
	/// <param name="Calculated">Calculated.</param>
	/// <param name="Category">Category.</param>
	/// <param name="DecimalDigits">DecimalDigits.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Details">Details.</param>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="Enabled">Enabled.</param>
	/// <param name="FieldId">FieldId.</param>
	/// <param name="HasDate">HasDate.</param>
	/// <param name="HasTime">HasTime.</param>
	/// <param name="IsFullTextSearchable">IsFullTextSearchable.</param>
	/// <param name="MaximumSize">MaximumSize.</param>
	/// <param name="Name">Name.</param>
	/// <param name="ReadOnly">_ReadOnly.</param>
	/// <param name="Required">Required.</param>
	/// <param name="Type">Type.</param>
	/// <param name="TypeLocalized">TypeLocalized.</param>
	/// <param name="Validated">Validated.</param>
	/// <param name="WholeDigits">WholeDigits.</param>
	public FieldDefinition(bool? AutoFill, bool? Calculated, string Category, int? DecimalDigits, string Description, string Details, string DisplayName, bool? Enabled, string FieldId, bool? HasDate, bool? HasTime, bool? IsFullTextSearchable, string MaximumSize, string Name, bool? ReadOnly, bool? Required, string Type, string TypeLocalized, bool? Validated, int? WholeDigits)
	{
		this.AutoFill = AutoFill;
		this.Calculated = Calculated;
		this.Category = Category;
		this.DecimalDigits = DecimalDigits;
		this.Description = Description;
		this.Details = Details;
		this.DisplayName = DisplayName;
		this.Enabled = Enabled;
		this.FieldId = FieldId;
		this.HasDate = HasDate;
		this.HasTime = HasTime;
		this.IsFullTextSearchable = IsFullTextSearchable;
		this.MaximumSize = MaximumSize;
		this.Name = Name;
		this.ReadOnly = ReadOnly;
		this.Required = Required;
		this.Type = Type;
		this.TypeLocalized = TypeLocalized;
		this.Validated = Validated;
		this.WholeDigits = WholeDigits;
	}

	/// <summary>
	/// Gets or Sets AutoFill
	/// </summary>
	[DataMember(Name = "autoFill", EmitDefaultValue = false)]
	public bool? AutoFill { get; set; }

	/// <summary>
	/// Gets or Sets Calculated
	/// </summary>
	[DataMember(Name = "calculated", EmitDefaultValue = false)]
	public bool? Calculated { get; set; }

	/// <summary>
	/// Gets or Sets Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string Category { get; set; }

	/// <summary>
	/// Gets or Sets DecimalDigits
	/// </summary>
	[DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
	public int? DecimalDigits { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Gets or Sets Details
	/// </summary>
	[DataMember(Name = "details", EmitDefaultValue = false)]
	public string Details { get; set; }

	/// <summary>
	/// Gets or Sets DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Gets or Sets Enabled
	/// </summary>
	[DataMember(Name = "enabled", EmitDefaultValue = false)]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Gets or Sets FieldId
	/// </summary>
	[DataMember(Name = "fieldId", EmitDefaultValue = false)]
	public string FieldId { get; set; }

	/// <summary>
	/// Gets or Sets HasDate
	/// </summary>
	[DataMember(Name = "hasDate", EmitDefaultValue = false)]
	public bool? HasDate { get; set; }

	/// <summary>
	/// Gets or Sets HasTime
	/// </summary>
	[DataMember(Name = "hasTime", EmitDefaultValue = false)]
	public bool? HasTime { get; set; }

	/// <summary>
	/// Gets or Sets IsFullTextSearchable
	/// </summary>
	[DataMember(Name = "isFullTextSearchable", EmitDefaultValue = false)]
	public bool? IsFullTextSearchable { get; set; }

	/// <summary>
	/// Gets or Sets MaximumSize
	/// </summary>
	[DataMember(Name = "maximumSize", EmitDefaultValue = false)]
	public string MaximumSize { get; set; }

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Gets or Sets _ReadOnly
	/// </summary>
	[DataMember(Name = "readOnly", EmitDefaultValue = false)]
	public bool? ReadOnly { get; set; }

	/// <summary>
	/// Gets or Sets Required
	/// </summary>
	[DataMember(Name = "required", EmitDefaultValue = false)]
	public bool? Required { get; set; }

	/// <summary>
	/// Gets or Sets Type
	/// </summary>
	[DataMember(Name = "type", EmitDefaultValue = false)]
	public string Type { get; set; }

	/// <summary>
	/// Gets or Sets TypeLocalized
	/// </summary>
	[DataMember(Name = "typeLocalized", EmitDefaultValue = false)]
	public string TypeLocalized { get; set; }

	/// <summary>
	/// Gets or Sets Validated
	/// </summary>
	[DataMember(Name = "validated", EmitDefaultValue = false)]
	public bool? Validated { get; set; }

	/// <summary>
	/// Gets or Sets WholeDigits
	/// </summary>
	[DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
	public int? WholeDigits { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class BusinessObjectFieldDefinition {\n");
		sb.Append("  AutoFill: ").Append(AutoFill).Append('\n');
		sb.Append("  Calculated: ").Append(Calculated).Append('\n');
		sb.Append("  Category: ").Append(Category).Append('\n');
		sb.Append("  DecimalDigits: ").Append(DecimalDigits).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  Details: ").Append(Details).Append('\n');
		sb.Append("  DisplayName: ").Append(DisplayName).Append('\n');
		sb.Append("  Enabled: ").Append(Enabled).Append('\n');
		sb.Append("  FieldId: ").Append(FieldId).Append('\n');
		sb.Append("  HasDate: ").Append(HasDate).Append('\n');
		sb.Append("  HasTime: ").Append(HasTime).Append('\n');
		sb.Append("  IsFullTextSearchable: ").Append(IsFullTextSearchable).Append('\n');
		sb.Append("  MaximumSize: ").Append(MaximumSize).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  _ReadOnly: ").Append(ReadOnly).Append('\n');
		sb.Append("  Required: ").Append(Required).Append('\n');
		sb.Append("  Type: ").Append(Type).Append('\n');
		sb.Append("  TypeLocalized: ").Append(TypeLocalized).Append('\n');
		sb.Append("  Validated: ").Append(Validated).Append('\n');
		sb.Append("  WholeDigits: ").Append(WholeDigits).Append('\n');
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
		return Equals(obj as FieldDefinition);
	}

	/// <summary>
	/// Returns true if BusinessObjectFieldDefinition instances are equal
	/// </summary>
	/// <param name="other">Instance of BusinessObjectFieldDefinition to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(FieldDefinition? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AutoFill == other.AutoFill ||
					AutoFill != null &&
					AutoFill.Equals(other.AutoFill)
				) &&
				(
					Calculated == other.Calculated ||
					Calculated != null &&
					Calculated.Equals(other.Calculated)
				) &&
				(
					Category == other.Category ||
					Category != null &&
					Category.Equals(other.Category, StringComparison.Ordinal)
				) &&
				(
					DecimalDigits == other.DecimalDigits ||
					DecimalDigits != null &&
					DecimalDigits.Equals(other.DecimalDigits)
				) &&
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					Details == other.Details ||
					Details != null &&
					Details.Equals(other.Details, StringComparison.Ordinal)
				) &&
				(
					DisplayName == other.DisplayName ||
					DisplayName != null &&
					DisplayName.Equals(other.DisplayName, StringComparison.Ordinal)
				) &&
				(
					Enabled == other.Enabled ||
					Enabled != null &&
					Enabled.Equals(other.Enabled)
				) &&
				(
					FieldId == other.FieldId ||
					FieldId != null &&
					FieldId.Equals(other.FieldId, StringComparison.Ordinal)
				) &&
				(
					HasDate == other.HasDate ||
					HasDate != null &&
					HasDate.Equals(other.HasDate)
				) &&
				(
					HasTime == other.HasTime ||
					HasTime != null &&
					HasTime.Equals(other.HasTime)
				) &&
				(
					IsFullTextSearchable == other.IsFullTextSearchable ||
					IsFullTextSearchable != null &&
					IsFullTextSearchable.Equals(other.IsFullTextSearchable)
				) &&
				(
					MaximumSize == other.MaximumSize ||
					MaximumSize != null &&
					MaximumSize.Equals(other.MaximumSize, StringComparison.Ordinal)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					ReadOnly == other.ReadOnly ||
					ReadOnly != null &&
					ReadOnly.Equals(other.ReadOnly)
				) &&
				(
					Required == other.Required ||
					Required != null &&
					Required.Equals(other.Required)
				) &&
				(
					Type == other.Type ||
					Type != null &&
					Type.Equals(other.Type, StringComparison.Ordinal)
				) &&
				(
					TypeLocalized == other.TypeLocalized ||
					TypeLocalized != null &&
					TypeLocalized.Equals(other.TypeLocalized, StringComparison.Ordinal)
				) &&
				(
					Validated == other.Validated ||
					Validated != null &&
					Validated.Equals(other.Validated)
				) &&
				(
					WholeDigits == other.WholeDigits ||
					WholeDigits != null &&
					WholeDigits.Equals(other.WholeDigits)
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
			if (AutoFill != null)
			{
				hash = hash * 59 + AutoFill.GetHashCode();
			}

			if (Calculated != null)
			{
				hash = hash * 59 + Calculated.GetHashCode();
			}

			if (Category != null)
			{
				hash = hash * 59 + Category.GetHashCode();
			}

			if (DecimalDigits != null)
			{
				hash = hash * 59 + DecimalDigits.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (Details != null)
			{
				hash = hash * 59 + Details.GetHashCode();
			}

			if (DisplayName != null)
			{
				hash = hash * 59 + DisplayName.GetHashCode();
			}

			if (Enabled != null)
			{
				hash = hash * 59 + Enabled.GetHashCode();
			}

			if (FieldId != null)
			{
				hash = hash * 59 + FieldId.GetHashCode();
			}

			if (HasDate != null)
			{
				hash = hash * 59 + HasDate.GetHashCode();
			}

			if (HasTime != null)
			{
				hash = hash * 59 + HasTime.GetHashCode();
			}

			if (IsFullTextSearchable != null)
			{
				hash = hash * 59 + IsFullTextSearchable.GetHashCode();
			}

			if (MaximumSize != null)
			{
				hash = hash * 59 + MaximumSize.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (ReadOnly != null)
			{
				hash = hash * 59 + ReadOnly.GetHashCode();
			}

			if (Required != null)
			{
				hash = hash * 59 + Required.GetHashCode();
			}

			if (Type != null)
			{
				hash = hash * 59 + Type.GetHashCode();
			}

			if (TypeLocalized != null)
			{
				hash = hash * 59 + TypeLocalized.GetHashCode();
			}

			if (Validated != null)
			{
				hash = hash * 59 + Validated.GetHashCode();
			}

			if (WholeDigits != null)
			{
				hash = hash * 59 + WholeDigits.GetHashCode();
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