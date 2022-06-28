using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreLink
/// </summary>
[DataContract]
public partial class Link
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
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Url
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
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					Url == other.Url ||
					Url != null &&
					Url.Equals(other.Url, StringComparison.Ordinal)
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

			if (Url != null)
			{
				hash = hash * 59 + Url.GetHashCode();
			}

			return hash;
		}
	}

	
}
