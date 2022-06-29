using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// ApiClientSettingResponse
/// </summary>
[DataContract]
public partial class ApiClientSettingResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ApiClientSettingResponse" /> class.
	/// </summary>
	/// <param name="name">Name.</param>
	/// <param name="description">Description.</param>
	/// <param name="culture">Culture.</param>
	/// <param name="clientKey">ClientKey.</param>
	/// <param name="tokenLifespanMinutes">TokenLifespanMinutes.</param>
	/// <param name="refreshTokenLifespanMinutes">RefreshTokenLifespanMinutes.</param>
	/// <param name="apiAccessIsEnabled">ApiAccessIsEnabled.</param>
	/// <param name="allowAnonymousAccess">AllowAnonymousAccess.</param>
	/// <param name="standInKey">StandInKey.</param>
	/// <param name="errorCode">ErrorCode.</param>
	/// <param name="errorMessage">ErrorMessage.</param>
	/// <param name="hasError">HasError.</param>
	/// <param name="httpStatusCode">HttpStatusCode.</param>
	public ApiClientSettingResponse(
		string name,
		string description,
		string culture,
		string clientKey,
		int? tokenLifespanMinutes,
		int? refreshTokenLifespanMinutes,
		bool? apiAccessIsEnabled,
		bool? allowAnonymousAccess,
		string standInKey,
		string errorCode,
		string errorMessage,
		bool hasError,
		EnumHttpStatusCode? httpStatusCode)
	{
		Name = name;
		Description = description;
		Culture = culture;
		ClientKey = clientKey;
		TokenLifespanMinutes = tokenLifespanMinutes;
		RefreshTokenLifespanMinutes = refreshTokenLifespanMinutes;
		ApiAccessIsEnabled = apiAccessIsEnabled;
		AllowAnonymousAccess = allowAnonymousAccess;
		StandInKey = standInKey;
		ErrorCode = errorCode;
		ErrorMessage = errorMessage;
		HasError = hasError;
		HttpStatusCode = httpStatusCode;
	}

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Culture
	/// </summary>
	[DataMember(Name = "culture", EmitDefaultValue = false)]
	public string Culture { get; set; }

	/// <summary>
	/// ClientKey
	/// </summary>
	[DataMember(Name = "clientKey", EmitDefaultValue = false)]
	public string ClientKey { get; set; }

	/// <summary>
	/// TokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
	public int? TokenLifespanMinutes { get; set; }

	/// <summary>
	/// RefreshTokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
	public int? RefreshTokenLifespanMinutes { get; set; }

	/// <summary>
	/// ApiAccessIsEnabled
	/// </summary>
	[DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
	public bool? ApiAccessIsEnabled { get; set; }

	/// <summary>
	/// AllowAnonymousAccess
	/// </summary>
	[DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
	public bool? AllowAnonymousAccess { get; set; }

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }
}
