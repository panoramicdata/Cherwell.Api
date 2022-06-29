using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserReadRequest
/// </summary>
[DataContract]
public partial class UserReadRequest
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
	/// LoginId
	/// </summary>
	[DataMember(Name = "loginId", EmitDefaultValue = false)]
	public string LoginId { get; set; }

	/// <summary>
	/// PublicId
	/// </summary>
	[DataMember(Name = "publicId", EmitDefaultValue = false)]
	public string PublicId { get; set; }






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

