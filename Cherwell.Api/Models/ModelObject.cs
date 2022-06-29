using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models;

/// <summary>
/// ModelObject
/// </summary>
[DataContract]
public partial class ModelObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ModelObject" /> class.
	/// </summary>
	[JsonConstructor]
	public ModelObject()
	{
	}

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ModelObject {\n");
		sb.Append("}\n");
		return sb.ToString();
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
			return hash;
		}
	}

	
}