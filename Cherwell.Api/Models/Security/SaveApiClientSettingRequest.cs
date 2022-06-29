using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SaveApiClientSettingRequest
/// </summary>
[DataContract]
public partial class SaveApiClientSettingRequest
{
	/// <summary>
	/// Initializes a new instance of the <see cref="SaveApiClientSettingRequest" /> class.
	/// </summary>
	/// <param name="AllowAnonymousAccess">AllowAnonymousAccess.</param>
	/// <param name="ApiAccessIsEnabled">ApiAccessIsEnabled.</param>
	/// <param name="CreateNewClientKey">CreateNewClientKey.</param>
	/// <param name="Culture">Culture.</param>
	/// <param name="Description">Description.</param>
	/// <param name="Name">Name.</param>
	/// <param name="RefreshTokenLifespanMinutes">RefreshTokenLifespanMinutes.</param>
	/// <param name="StandInKey">StandInKey.</param>
	/// <param name="TokenLifespanMinutes">TokenLifespanMinutes.</param>
	public SaveApiClientSettingRequest(bool? AllowAnonymousAccess, bool? ApiAccessIsEnabled, bool? CreateNewClientKey, string Culture, string Description, string Name, int? RefreshTokenLifespanMinutes, string StandInKey, int? TokenLifespanMinutes)
	{
		this.AllowAnonymousAccess = AllowAnonymousAccess;
		this.ApiAccessIsEnabled = ApiAccessIsEnabled;
		this.CreateNewClientKey = CreateNewClientKey;
		this.Culture = Culture;
		this.Description = Description;
		this.Name = Name;
		this.RefreshTokenLifespanMinutes = RefreshTokenLifespanMinutes;
		this.StandInKey = StandInKey;
		this.TokenLifespanMinutes = TokenLifespanMinutes;
	}

	/// <summary>
	/// AllowAnonymousAccess
	/// </summary>
	[DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
	public bool? AllowAnonymousAccess { get; set; }

	/// <summary>
	/// ApiAccessIsEnabled
	/// </summary>
	[DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
	public bool? ApiAccessIsEnabled { get; set; }

	/// <summary>
	/// CreateNewClientKey
	/// </summary>
	[DataMember(Name = "createNewClientKey", EmitDefaultValue = false)]
	public bool? CreateNewClientKey { get; set; }

	/// <summary>
	/// Culture
	/// </summary>
	[DataMember(Name = "culture", EmitDefaultValue = false)]
	public string Culture { get; set; }

	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// RefreshTokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
	public int? RefreshTokenLifespanMinutes { get; set; }

	/// <summary>
	/// StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }

	/// <summary>
	/// TokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
	public int? TokenLifespanMinutes { get; set; }
}

