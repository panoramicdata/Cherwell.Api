using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Searches;

/// <summary>
/// SearchesChangedLimit
/// </summary>
[DataContract]
public partial class ChangedLimit
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ChangedLimit" /> class.
	/// </summary>
	/// <param name="DisplayName">DisplayName.</param>
	/// <param name="Units">Units.</param>
	/// <param name="Value">Value.</param>
	public ChangedLimit(string DisplayName, string Units, int? Value)
	{
		this.DisplayName = DisplayName;
		this.Units = Units;
		this.Value = Value;
	}

	/// <summary>
	/// DisplayName
	/// </summary>
	[DataMember(Name = "displayName", EmitDefaultValue = false)]
	public string DisplayName { get; set; }

	/// <summary>
	/// Units
	/// </summary>
	[DataMember(Name = "units", EmitDefaultValue = false)]
	public string Units { get; set; }

	/// <summary>
	/// Value
	/// </summary>
	[DataMember(Name = "value", EmitDefaultValue = false)]
	public int? Value { get; set; }







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
