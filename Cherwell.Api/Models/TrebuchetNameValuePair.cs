using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models;

/// <summary>
/// TrebuchetNameValuePair
/// </summary>
[DataContract]
public partial class TrebuchetNameValuePair : IEquatable<TrebuchetNameValuePair>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TrebuchetNameValuePair" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="ValueObject">ValueObject.</param>
	/// <param name="ValueString">ValueString.</param>
	/// <param name="Category">Category.</param>
	/// <param name="Description">Description.</param>
	/// <param name="DisplayShowsValue">DisplayShowsValue.</param>
	/// <param name="SpecialUseFlag">SpecialUseFlag.</param>
	/// <param name="DisplayString">DisplayString.</param>
	public TrebuchetNameValuePair(string Name, Object ValueObject, string ValueString, string Category, string Description, bool? DisplayShowsValue, bool? SpecialUseFlag, string DisplayString)
	{
		this.Name = Name;
		this.ValueObject = ValueObject;
		this.ValueString = ValueString;
		this.Category = Category;
		this.Description = Description;
		this.DisplayShowsValue = DisplayShowsValue;
		this.SpecialUseFlag = SpecialUseFlag;
		this.DisplayString = DisplayString;
	}

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// ValueObject
	/// </summary>
	[DataMember(Name = "valueObject", EmitDefaultValue = false)]
	public Object ValueObject { get; set; }

	/// <summary>
	/// ValueString
	/// </summary>
	[DataMember(Name = "valueString", EmitDefaultValue = false)]
	public string ValueString { get; set; }

	/// <summary>
	/// Category
	/// </summary>
	[DataMember(Name = "category", EmitDefaultValue = false)]
	public string Category { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// DisplayShowsValue
	/// </summary>
	[DataMember(Name = "displayShowsValue", EmitDefaultValue = false)]
	public bool? DisplayShowsValue { get; set; }

	/// <summary>
	/// SpecialUseFlag
	/// </summary>
	[DataMember(Name = "specialUseFlag", EmitDefaultValue = false)]
	public bool? SpecialUseFlag { get; set; }

	/// <summary>
	/// DisplayString
	/// </summary>
	[DataMember(Name = "displayString", EmitDefaultValue = false)]
	public string DisplayString { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TrebuchetNameValuePair {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  ValueObject: ").Append(ValueObject).Append('\n');
		sb.Append("  ValueString: ").Append(ValueString).Append('\n');
		sb.Append("  Category: ").Append(Category).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  DisplayShowsValue: ").Append(DisplayShowsValue).Append('\n');
		sb.Append("  SpecialUseFlag: ").Append(SpecialUseFlag).Append('\n');
		sb.Append("  DisplayString: ").Append(DisplayString).Append('\n');
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as TrebuchetNameValuePair);
	}

	/// <summary>
	/// Returns true if TrebuchetNameValuePair instances are equal
	/// </summary>
	/// <param name="other">Instance of TrebuchetNameValuePair to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TrebuchetNameValuePair? other)
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
					ValueObject == other.ValueObject ||
					ValueObject != null &&
					ValueObject.Equals(other.ValueObject)
				) &&
				(
					ValueString == other.ValueString ||
					ValueString != null &&
					ValueString.Equals(other.ValueString, StringComparison.Ordinal)
				) &&
				(
					Category == other.Category ||
					Category != null &&
					Category.Equals(other.Category, StringComparison.Ordinal)
				) &&
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					DisplayShowsValue == other.DisplayShowsValue ||
					DisplayShowsValue != null &&
					DisplayShowsValue.Equals(other.DisplayShowsValue)
				) &&
				(
					SpecialUseFlag == other.SpecialUseFlag ||
					SpecialUseFlag != null &&
					SpecialUseFlag.Equals(other.SpecialUseFlag)
				) &&
				(
					DisplayString == other.DisplayString ||
					DisplayString != null &&
					DisplayString.Equals(other.DisplayString, StringComparison.Ordinal)
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

			if (ValueObject != null)
			{
				hash = hash * 59 + ValueObject.GetHashCode();
			}

			if (ValueString != null)
			{
				hash = hash * 59 + ValueString.GetHashCode();
			}

			if (Category != null)
			{
				hash = hash * 59 + Category.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (DisplayShowsValue != null)
			{
				hash = hash * 59 + DisplayShowsValue.GetHashCode();
			}

			if (SpecialUseFlag != null)
			{
				hash = hash * 59 + SpecialUseFlag.GetHashCode();
			}

			if (DisplayString != null)
			{
				hash = hash * 59 + DisplayString.GetHashCode();
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