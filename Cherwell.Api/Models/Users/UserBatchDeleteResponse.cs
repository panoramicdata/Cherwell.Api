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







	
}

