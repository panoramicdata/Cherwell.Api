using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetApiClientSettingsResponseItem
/// </summary>
[DataContract]
public partial class GetApiClientSettingsResponseItem
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetApiClientSettingsResponseItem" /> class.
	/// </summary>
	/// <param name="Name">Name.</param>
	/// <param name="StandInKey">StandInKey.</param>
	public GetApiClientSettingsResponseItem(string Name, string StandInKey)
	{
		this.Name = Name;
		this.StandInKey = StandInKey;
	}

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }






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
