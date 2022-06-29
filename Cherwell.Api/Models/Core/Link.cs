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
