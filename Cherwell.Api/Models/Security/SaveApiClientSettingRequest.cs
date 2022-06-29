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

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecuritySaveApiClientSettingRequest {\n");
		sb.Append("  AllowAnonymousAccess: ").Append(AllowAnonymousAccess).Append('\n');
		sb.Append("  ApiAccessIsEnabled: ").Append(ApiAccessIsEnabled).Append('\n');
		sb.Append("  CreateNewClientKey: ").Append(CreateNewClientKey).Append('\n');
		sb.Append("  Culture: ").Append(Culture).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  RefreshTokenLifespanMinutes: ").Append(RefreshTokenLifespanMinutes).Append('\n');
		sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
		sb.Append("  TokenLifespanMinutes: ").Append(TokenLifespanMinutes).Append('\n');
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
			if (AllowAnonymousAccess != null)
			{
				hash = hash * 59 + AllowAnonymousAccess.GetHashCode();
			}

			if (ApiAccessIsEnabled != null)
			{
				hash = hash * 59 + ApiAccessIsEnabled.GetHashCode();
			}

			if (CreateNewClientKey != null)
			{
				hash = hash * 59 + CreateNewClientKey.GetHashCode();
			}

			if (Culture != null)
			{
				hash = hash * 59 + Culture.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (RefreshTokenLifespanMinutes != null)
			{
				hash = hash * 59 + RefreshTokenLifespanMinutes.GetHashCode();
			}

			if (StandInKey != null)
			{
				hash = hash * 59 + StandInKey.GetHashCode();
			}

			if (TokenLifespanMinutes != null)
			{
				hash = hash * 59 + TokenLifespanMinutes.GetHashCode();
			}

			return hash;
		}
	}

	
}

