using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// ApiClientSettingResponse
/// </summary>
[DataContract]
public partial class ApiClientSettingResponse : IEquatable<ApiClientSettingResponse>, IValidatableObject
{
	/// <summary>
	/// Gets or Sets HttpStatusCode
	/// </summary>
	[DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
	public EnumHttpStatusCode? HttpStatusCode { get; set; }

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
		bool? hasError,
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
	/// Gets or Sets Name
	/// </summary>
	[DataMember(Name = "name", EmitDefaultValue = false)]
	public string Name { get; set; }

	/// <summary>
	/// Gets or Sets Description
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = false)]
	public string Description { get; set; }

	/// <summary>
	/// Gets or Sets Culture
	/// </summary>
	[DataMember(Name = "culture", EmitDefaultValue = false)]
	public string Culture { get; set; }

	/// <summary>
	/// Gets or Sets ClientKey
	/// </summary>
	[DataMember(Name = "clientKey", EmitDefaultValue = false)]
	public string ClientKey { get; set; }

	/// <summary>
	/// Gets or Sets TokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
	public int? TokenLifespanMinutes { get; set; }

	/// <summary>
	/// Gets or Sets RefreshTokenLifespanMinutes
	/// </summary>
	[DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
	public int? RefreshTokenLifespanMinutes { get; set; }

	/// <summary>
	/// Gets or Sets ApiAccessIsEnabled
	/// </summary>
	[DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
	public bool? ApiAccessIsEnabled { get; set; }

	/// <summary>
	/// Gets or Sets AllowAnonymousAccess
	/// </summary>
	[DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
	public bool? AllowAnonymousAccess { get; set; }

	/// <summary>
	/// Gets or Sets StandInKey
	/// </summary>
	[DataMember(Name = "standInKey", EmitDefaultValue = false)]
	public string StandInKey { get; set; }

	/// <summary>
	/// Gets or Sets ErrorCode
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false)]
	public string ErrorCode { get; set; }

	/// <summary>
	/// Gets or Sets ErrorMessage
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false)]
	public string ErrorMessage { get; set; }

	/// <summary>
	/// Gets or Sets HasError
	/// </summary>
	[DataMember(Name = "hasError", EmitDefaultValue = false)]
	public bool? HasError { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityApiClientSettingResponse {\n");
		sb.Append("  Name: ").Append(Name).Append('\n');
		sb.Append("  Description: ").Append(Description).Append('\n');
		sb.Append("  Culture: ").Append(Culture).Append('\n');
		sb.Append("  ClientKey: ").Append(ClientKey).Append('\n');
		sb.Append("  TokenLifespanMinutes: ").Append(TokenLifespanMinutes).Append('\n');
		sb.Append("  RefreshTokenLifespanMinutes: ").Append(RefreshTokenLifespanMinutes).Append('\n');
		sb.Append("  ApiAccessIsEnabled: ").Append(ApiAccessIsEnabled).Append('\n');
		sb.Append("  AllowAnonymousAccess: ").Append(AllowAnonymousAccess).Append('\n');
		sb.Append("  StandInKey: ").Append(StandInKey).Append('\n');
		sb.Append("  ErrorCode: ").Append(ErrorCode).Append('\n');
		sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append('\n');
		sb.Append("  HasError: ").Append(HasError).Append('\n');
		sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append('\n');
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
		return Equals(obj as ApiClientSettingResponse);
	}

	/// <summary>
	/// Returns true if ApiClientSettingResponse instances are equal
	/// </summary>
	/// <param name="other">Instance of ApiClientSettingResponse to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ApiClientSettingResponse? other)
	{
		// credit: http://stackoverflow.com/a/10454552/677735
		if (other == null)
		{
			return false;
		}

		return
				(
					Name == other.Name ||
					Name != null &&
					Name.Equals(other.Name, StringComparison.Ordinal)
				) &&
				(
					Description == other.Description ||
					Description != null &&
					Description.Equals(other.Description, StringComparison.Ordinal)
				) &&
				(
					Culture == other.Culture ||
					Culture != null &&
					Culture.Equals(other.Culture, StringComparison.Ordinal)
				) &&
				(
					ClientKey == other.ClientKey ||
					ClientKey != null &&
					ClientKey.Equals(other.ClientKey, StringComparison.Ordinal)
				) &&
				(
					TokenLifespanMinutes == other.TokenLifespanMinutes ||
					TokenLifespanMinutes != null &&
					TokenLifespanMinutes.Equals(other.TokenLifespanMinutes)
				) &&
				(
					RefreshTokenLifespanMinutes == other.RefreshTokenLifespanMinutes ||
					RefreshTokenLifespanMinutes != null &&
					RefreshTokenLifespanMinutes.Equals(other.RefreshTokenLifespanMinutes)
				) &&
				(
					ApiAccessIsEnabled == other.ApiAccessIsEnabled ||
					ApiAccessIsEnabled != null &&
					ApiAccessIsEnabled.Equals(other.ApiAccessIsEnabled)
				) &&
				(
					AllowAnonymousAccess == other.AllowAnonymousAccess ||
					AllowAnonymousAccess != null &&
					AllowAnonymousAccess.Equals(other.AllowAnonymousAccess)
				) &&
				(
					StandInKey == other.StandInKey ||
					StandInKey != null &&
					StandInKey.Equals(other.StandInKey, StringComparison.Ordinal)
				) &&
				(
					ErrorCode == other.ErrorCode ||
					ErrorCode != null &&
					ErrorCode.Equals(other.ErrorCode, StringComparison.Ordinal)
				) &&
				(
					ErrorMessage == other.ErrorMessage ||
					ErrorMessage != null &&
					ErrorMessage.Equals(other.ErrorMessage, StringComparison.Ordinal)
				) &&
				(
					HasError == other.HasError ||
					HasError != null &&
					HasError.Equals(other.HasError)
				) &&
				(
					HttpStatusCode == other.HttpStatusCode ||
					HttpStatusCode != null &&
					HttpStatusCode.Equals(other.HttpStatusCode)
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
			if (Name != null)
			{
				hash = hash * 59 + Name.GetHashCode();
			}

			if (Description != null)
			{
				hash = hash * 59 + Description.GetHashCode();
			}

			if (Culture != null)
			{
				hash = hash * 59 + Culture.GetHashCode();
			}

			if (ClientKey != null)
			{
				hash = hash * 59 + ClientKey.GetHashCode();
			}

			if (TokenLifespanMinutes != null)
			{
				hash = hash * 59 + TokenLifespanMinutes.GetHashCode();
			}

			if (RefreshTokenLifespanMinutes != null)
			{
				hash = hash * 59 + RefreshTokenLifespanMinutes.GetHashCode();
			}

			if (ApiAccessIsEnabled != null)
			{
				hash = hash * 59 + ApiAccessIsEnabled.GetHashCode();
			}

			if (AllowAnonymousAccess != null)
			{
				hash = hash * 59 + AllowAnonymousAccess.GetHashCode();
			}

			if (StandInKey != null)
			{
				hash = hash * 59 + StandInKey.GetHashCode();
			}

			if (ErrorCode != null)
			{
				hash = hash * 59 + ErrorCode.GetHashCode();
			}

			if (ErrorMessage != null)
			{
				hash = hash * 59 + ErrorMessage.GetHashCode();
			}

			if (HasError != null)
			{
				hash = hash * 59 + HasError.GetHashCode();
			}

			if (HttpStatusCode != null)
			{
				hash = hash * 59 + HttpStatusCode.GetHashCode();
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
