using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserReadRequest
/// </summary>
[DataContract]
public partial class UserReadRequest : IEquatable<UserReadRequest>, IValidatableObject
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserReadRequest" /> class.
	/// </summary>
	/// <param name="LoginId">LoginId.</param>
	/// <param name="PublicId">PublicId.</param>
	public UserReadRequest(string LoginId, string PublicId)
	{
		this.LoginId = LoginId;
		this.PublicId = PublicId;
	}

	/// <summary>
	/// Gets or Sets LoginId
	/// </summary>
	[DataMember(Name = "loginId", EmitDefaultValue = false)]
	public string LoginId { get; set; }

	/// <summary>
	/// Gets or Sets PublicId
	/// </summary>
	[DataMember(Name = "publicId", EmitDefaultValue = false)]
	public string PublicId { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserReadRequest {\n");
		sb.Append("  LoginId: ").Append(LoginId).Append('\n');
		sb.Append("  PublicId: ").Append(PublicId).Append('\n');
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
		return Equals(obj as UserReadRequest);
	}

	/// <summary>
	/// Returns true if UserReadRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of UserReadRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(UserReadRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					LoginId == other.LoginId ||
					LoginId != null &&
					LoginId.Equals(other.LoginId, StringComparison.Ordinal)
				) &&
				(
					PublicId == other.PublicId ||
					PublicId != null &&
					PublicId.Equals(other.PublicId, StringComparison.Ordinal)
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
			if (LoginId != null)
			{
				hash = hash * 59 + LoginId.GetHashCode();
			}

			if (PublicId != null)
			{
				hash = hash * 59 + PublicId.GetHashCode();
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

