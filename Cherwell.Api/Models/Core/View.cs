using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreView
/// </summary>
[DataContract]
public partial class View : IEquatable<View>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="View" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="ViewId">ViewId.</param>
	/// <param name="Image">Image.</param>
	public View(string Name, string ViewId, string Image)
	{
		this.Name = Name;
		this.ViewId = ViewId;
		this.Image = Image;
	}

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// ViewId
	/// </summary>
	[DataMember(Name = "viewId", EmitDefaultValue = false)]
	public string ViewId { get; set; }

	/// <summary>
	/// Image
	/// </summary>
	[DataMember(Name = "image", EmitDefaultValue = false)]
	public string Image { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreView {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  ViewId: ").Append(ViewId).Append('\n');
		sb.Append("  Image: ").Append(Image).Append('\n');
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
		return Equals(obj as View);
	}

	/// <summary>
	/// Returns true if CoreView instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreView to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(View? other)
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
					ViewId == other.ViewId ||
					ViewId != null &&
					ViewId.Equals(other.ViewId, StringComparison.Ordinal)
				) &&
				(
					Image == other.Image ||
					Image != null &&
					Image.Equals(other.Image, StringComparison.Ordinal)
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

			if (ViewId != null)
			{
				hash = hash * 59 + ViewId.GetHashCode();
			}

			if (Image != null)
			{
				hash = hash * 59 + Image.GetHashCode();
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
