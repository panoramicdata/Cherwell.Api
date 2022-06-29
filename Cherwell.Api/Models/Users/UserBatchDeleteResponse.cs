using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchDeleteResponse
/// </summary>
[DataContract]
public partial class UserBatchDeleteResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchDeleteResponse" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	public UserBatchDeleteResponse(List<UserDeleteResponse> Responses)
	{
		this.Responses = Responses;
	}

	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserDeleteResponse> Responses { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class UserBatchDeleteResponse {\n");
		sb.Append("  Responses: ").Append(Responses).Append('\n');
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
			if (Responses != null)
			{
				hash = hash * 59 + Responses.GetHashCode();
			}

			return hash;
		}
	}

	
}

