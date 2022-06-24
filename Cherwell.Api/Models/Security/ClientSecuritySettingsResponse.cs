using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// ClientSecuritySettingsResponse
/// </summary>
[DataContract]
public partial class ClientSecuritySettingsResponse : IEquatable<ClientSecuritySettingsResponse>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ClientSecuritySettingsResponse" /> class.
	/// </summary>
	/// <param name="InternalLoginAllowed">InternalLoginAllowed.</param>
	/// <param name="LdapLoginAllowed">LdapLoginAllowed.</param>
	/// <param name="SamlLoginAllowed">SamlLoginAllowed.</param>
	/// <param name="WindowsLoginAllowed">WindowsLoginAllowed.</param>
	public ClientSecuritySettingsResponse(
		bool? InternalLoginAllowed = default,
		bool? LdapLoginAllowed = default,
		bool? SamlLoginAllowed = default,
		bool? WindowsLoginAllowed = default)
	{
		this.InternalLoginAllowed = InternalLoginAllowed;
		this.LdapLoginAllowed = LdapLoginAllowed;
		this.SamlLoginAllowed = SamlLoginAllowed;
		this.WindowsLoginAllowed = WindowsLoginAllowed;
	}

	/// <summary>
	/// Gets or Sets InternalLoginAllowed
	/// </summary>
	[DataMember(Name = "internalLoginAllowed", EmitDefaultValue = false)]
	public bool? InternalLoginAllowed { get; set; }
	/// <summary>
	/// Gets or Sets LdapLoginAllowed
	/// </summary>
	[DataMember(Name = "ldapLoginAllowed", EmitDefaultValue = false)]
	public bool? LdapLoginAllowed { get; set; }
	/// <summary>
	/// Gets or Sets SamlLoginAllowed
	/// </summary>
	[DataMember(Name = "samlLoginAllowed", EmitDefaultValue = false)]
	public bool? SamlLoginAllowed { get; set; }
	/// <summary>
	/// Gets or Sets WindowsLoginAllowed
	/// </summary>
	[DataMember(Name = "windowsLoginAllowed", EmitDefaultValue = false)]
	public bool? WindowsLoginAllowed { get; set; }
	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityClientSecuritySettingsResponse {\n");
		sb.Append("  InternalLoginAllowed: ").Append(InternalLoginAllowed).Append('\n');
		sb.Append("  LdapLoginAllowed: ").Append(LdapLoginAllowed).Append('\n');
		sb.Append("  SamlLoginAllowed: ").Append(SamlLoginAllowed).Append('\n');
		sb.Append("  WindowsLoginAllowed: ").Append(WindowsLoginAllowed).Append('\n');
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
		return Equals(obj as ClientSecuritySettingsResponse);
	}

	/// <summary>
	/// Returns true if ClientSecuritySettingsResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of ClientSecuritySettingsResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ClientSecuritySettingsResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					InternalLoginAllowed == other.InternalLoginAllowed ||
					InternalLoginAllowed != null &&
					InternalLoginAllowed.Equals(other.InternalLoginAllowed)
				) &&
				(
					LdapLoginAllowed == other.LdapLoginAllowed ||
					LdapLoginAllowed != null &&
					LdapLoginAllowed.Equals(other.LdapLoginAllowed)
				) &&
				(
					SamlLoginAllowed == other.SamlLoginAllowed ||
					SamlLoginAllowed != null &&
					SamlLoginAllowed.Equals(other.SamlLoginAllowed)
				) &&
				(
					WindowsLoginAllowed == other.WindowsLoginAllowed ||
					WindowsLoginAllowed != null &&
					WindowsLoginAllowed.Equals(other.WindowsLoginAllowed)
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
			if (InternalLoginAllowed != null)
			{
				hash = hash * 59 + InternalLoginAllowed.GetHashCode();
			}

			if (LdapLoginAllowed != null)
			{
				hash = hash * 59 + LdapLoginAllowed.GetHashCode();
			}

			if (SamlLoginAllowed != null)
			{
				hash = hash * 59 + SamlLoginAllowed.GetHashCode();
			}

			if (WindowsLoginAllowed != null)
			{
				hash = hash * 59 + WindowsLoginAllowed.GetHashCode();
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