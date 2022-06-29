using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserDeleteResponse
/// </summary>
[DataContract]
public partial class UserDeleteResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserDeleteResponse" /> class.
	/// </summary>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="HasError">HasError.</param>
	/// <param name="Users">Users.</param>
	public UserDeleteResponse(string error, string errorCode, bool? hasError, List<User> Users)
	{
		this.Error = error;
		this.ErrorCode = errorCode;
		this.HasError = hasError;
		this.Users = Users;
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
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserDeleteResponse {\n");
		sb.Append("  Error: ").Append(Error).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  Users: ").Append(Users).Append('\n');
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
			if (Error != null)
			{
				hash = hash * 59 + Error.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (Users != null)
			{
				hash = hash * 59 + Users.GetHashCode();
			}

			return hash;
		}
	}

	
}

