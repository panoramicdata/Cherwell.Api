using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// GetApiClientSettingsResponse
/// </summary>
[DataContract]
public partial class GetApiClientSettingsResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="GetApiClientSettingsResponse" /> class.
	/// </summary>
	/// <param name="Settings">Settings.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="HttpStatusCode">HttpStatusCode.</param>
	public GetApiClientSettingsResponse(List<GetApiClientSettingsResponseItem> Settings, string errorCode, string errorMessage, bool? hasError, EnumHttpStatusCode HttpStatusCode)
	{
		this.Settings = Settings;
		this.ErrorCode = errorCode;
		this.ErrorMessage = errorMessage;
		this.HasError = hasError;
		this.HttpStatusCode = HttpStatusCode;
	}

	/// <summary>
	/// Settings
	/// </summary>
	[DataMember(Name = "settings", EmitDefaultValue = false)]
	public List<GetApiClientSettingsResponseItem> Settings { get; set; }











	
}
