using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserBatchSaveResponse
/// </summary>
[DataContract]
public partial class UserBatchSaveResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserBatchSaveResponse" /> class.
	/// </summary>
	/// <param name="Responses">Responses.</param>
	public UserBatchSaveResponse(List<UserSaveResponse> Responses)
	{
		this.Responses = Responses;
	}

	/// <summary>
	/// Responses
	/// </summary>
	[DataMember(Name = "responses", EmitDefaultValue = false)]
	public List<UserSaveResponse> Responses { get; set; }







	
}

