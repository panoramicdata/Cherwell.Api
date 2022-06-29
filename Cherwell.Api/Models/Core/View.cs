using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Core;

/// <summary>
/// CoreView
/// </summary>
[DataContract]
public partial class View
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
			return hash;
		}
	}

	
}
