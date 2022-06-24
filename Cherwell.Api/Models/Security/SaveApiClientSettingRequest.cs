using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// SaveApiClientSettingRequest
/// </summary>
[DataContract]
public partial class SaveApiClientSettingRequest : IEquatable<SaveApiClientSettingRequest>, IValidatableObject
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
	/// Gets or Sets AllowAnonymousAccess
	/// </summary>
	[DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
	public bool? AllowAnonymousAccess { get; set; }
	/// <summary>
	/// Gets or Sets ApiAccessIsEnabled
	/// </summary>
	[DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
	public bool? ApiAccessIsEnabled { get; set; }
	/// <summary>
	/// Gets or Sets CreateNewClientKey
	/// </summary>
	[DataMember(Name = "createNewClientKey", EmitDefaultValue = false)]
	public bool? CreateNewClientKey { get; set; }
	/// <summary>
	/// Gets or Sets Culture
	/// </summary>
	[DataMember(Name = "culture", EmitDefaultValue = false)]
	public string Culture { get; set; }
	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }
	/// <summary>
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }
	/// <summary>
	/// Gets or Sets RefreshTokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
	public int? RefreshTokenLifespanMinutes { get; set; }
	/// <summary>
	/// Gets or Sets StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }
	/// <summary>
	/// Gets or Sets TokenLifespanMinutes
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
	/// Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	/// Returns true if objects are equal
	/// </summary>
	/// <param name="obj">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object? obj)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		return Equals(obj as SaveApiClientSettingRequest);
	}

	/// <summary>
	/// Returns true if SaveApiClientSettingRequest instances are equal
	/// </summary>
	/// <param name="other">Instance of SaveApiClientSettingRequest to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(SaveApiClientSettingRequest? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					AllowAnonymousAccess == other.AllowAnonymousAccess ||
					AllowAnonymousAccess != null &&
					AllowAnonymousAccess.Equals(other.AllowAnonymousAccess)
				) &&
				(
					ApiAccessIsEnabled == other.ApiAccessIsEnabled ||
					ApiAccessIsEnabled != null &&
					ApiAccessIsEnabled.Equals(other.ApiAccessIsEnabled)
				) &&
				(
					CreateNewClientKey == other.CreateNewClientKey ||
					CreateNewClientKey != null &&
					CreateNewClientKey.Equals(other.CreateNewClientKey)
				) &&
				(
					Culture == other.Culture ||
					Culture != null &&
					Culture.Equals(other.Culture, StringComparison.Ordinal)
				) &&
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					RefreshTokenLifespanMinutes == other.RefreshTokenLifespanMinutes ||
					RefreshTokenLifespanMinutes != null &&
					RefreshTokenLifespanMinutes.Equals(other.RefreshTokenLifespanMinutes)
				) &&
				(
					StandInKey == other.StandInKey ||
					StandInKey != null &&
					StandInKey.Equals(other.StandInKey, StringComparison.Ordinal)
				) &&
				(
					TokenLifespanMinutes == other.TokenLifespanMinutes ||
					TokenLifespanMinutes != null &&
					TokenLifespanMinutes.Equals(other.TokenLifespanMinutes)
				);
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

	/// <summary>
	/// To validate all properties of the instance
	/// </summary>
	/// <param name="validationContext">Validation context</param>
	/// <returns>Validation Result</returns>
	IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
	{
		yield break;
	}
}

