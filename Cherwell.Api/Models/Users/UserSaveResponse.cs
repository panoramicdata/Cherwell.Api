using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Users;

/// <summary>
/// UserSaveResponse
/// </summary>
[DataContract]
public partial class UserSaveResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="UserSaveResponse" /> class.
	/// </summary>
	/// <param name="BusObPublicId">BusObPublicId.</param>
	/// <param name="BusObRecId">BusObRecId.</param>
	/// <param name="Error">Error.</param>
	/// <param name="ErrorCode">ErrorCode.</param>
	/// <param name="HasError">HasError.</param>
	public UserSaveResponse(string BusObPublicId, string BusObRecId, string error, string errorCode, bool? hasError)
	{
		this.BusObPublicId = BusObPublicId;
		this.BusObRecId = BusObRecId;
		this.Error = error;
		this.ErrorCode = errorCode;
		this.HasError = hasError;
	}

	/// <summary>
	/// BusObPublicId
	/// </summary>
	[DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
	public string BusObPublicId { get; set; }

	/// <summary>
	/// BusObRecId
	/// </summary>
	[DataMember(Name = "busObRecId", EmitDefaultValue = false)]
	public string BusObRecId { get; set; }

	/// <summary>
	/// Error
	/// </summary>
	[DataMember(Name = "error", EmitDefaultValue = false)]
	public string Error { get; set; }
}