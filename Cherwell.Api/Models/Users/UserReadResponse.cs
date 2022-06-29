using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserReadResponse
/// </summary>
[DataContract]
public partial class UserReadResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserReadResponse" /> class.
	/// </summary>
	/// <param name="error">Error.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="users">Users.</param>
	public UserReadResponse(
		string error,
		string errorCode,
		bool hasError,
		List<User> users)
	{
		Error = error;
		ErrorCode = errorCode;
		HasError = hasError;
		Users = users;
	}

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }

	/// <summary>
	/// Users
	/// </summary>
	[DataMember(Name = "users", EmitDefaultValue = false)]
	public List<User> Users { get; set; }








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

