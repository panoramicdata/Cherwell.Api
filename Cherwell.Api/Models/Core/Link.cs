using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLink
/// </summary>
[DataContract]
public partial class Link : IEquatable<Link>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Link" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="Url">Url.</param>
	public Link(string Name, string Url)
	{
		this.Name = Name;
		this.Url = Url;
	}

	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }
	/// <summary>
	/// Gets or Sets Url
	/// </summary>
	[DataMember(Name = "url", EmitDefaultValue = false)]
	public string Url { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CoreLink {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Url: ").Append(Url).Append('\n');
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
		return this.Equals(obj as Link);
	}

	/// <summary>
	/// Returns true if CoreLink instances are equal
	/// </summary>
	/// <param name="other">Instance of CoreLink to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(Link? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					this.Name == other.Name ||
					this.Name != null &&
					this.Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					this.Url == other.Url ||
					this.Url != null &&
					this.Url.Equals(other.Url, StringComparison.Ordinal)
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
			if (this.Name != null)
			{
				hash = hash * 59 + this.Name.GetHashCode();
			}

			if (this.Url != null)
			{
				hash = hash * 59 + this.Url.GetHashCode();
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
