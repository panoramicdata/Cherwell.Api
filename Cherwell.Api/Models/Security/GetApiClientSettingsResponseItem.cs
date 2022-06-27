using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetApiClientSettingsResponseItem
/// </summary>
[DataContract]
public partial class GetApiClientSettingsResponseItem : IEquatable<GetApiClientSettingsResponseItem>, IValidatableObject
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityGetApiClientSettingsResponseItem {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
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
		return Equals(obj as GetApiClientSettingsResponseItem);
	}

	/// <summary>
	/// Returns true if GetApiClientSettingsResponseItem instances are equal
	/// </summary>
	/// <param name="other">Instance of GetApiClientSettingsResponseItem to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetApiClientSettingsResponseItem? other)
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
					StandInKey == other.StandInKey ||
					StandInKey != null &&
					StandInKey.Equals(other.StandInKey, StringComparison.Ordinal)
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

			if (StandInKey != null)
			{
				hash = hash * 59 + StandInKey.GetHashCode();
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
