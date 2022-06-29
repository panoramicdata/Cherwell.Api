using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// TokenResponse
/// </summary>
[DataContract]
public partial class TokenResponse : Response
{
	/// <summary>
	/// Initializes a new instance of the <see cref="TokenResponse" /> class.
	/// </summary>
	/// <param name="accessToken">AccessToken.</param>
	/// <param name="asclientId">AsclientId.</param>
	/// <param name="expires">Expires.</param>
	/// <param name="expiresIn">ExpiresIn.</param>
	/// <param name="issued">Issued.</param>
	/// <param name="refreshToken">RefreshToken.</param>
	/// <param name="tokenType">TokenType.</param>
	/// <param name="username">Username.</param>
	public TokenResponse(
		string accessToken,
		string asclientId,
		string expires,
		int? expiresIn,
		string issued,
		string refreshToken,
		string tokenType,
		string username)
	{
		AccessToken = accessToken;
		AsclientId = asclientId;
		Expires = expires;
		ExpiresIn = expiresIn;
		Issued = issued;
		RefreshToken = refreshToken;
		TokenType = tokenType;
		Username = username;
	}

	/// <summary>
	/// AccessToken
	/// </summary>
	[DataMember(Name = "access_token", EmitDefaultValue = false)]
	public string AccessToken { get; set; }

	/// <summary>
	/// AsclientId
	/// </summary>
	[DataMember(Name = "as:client_id", EmitDefaultValue = false)]
	public string AsclientId { get; set; }

	/// <summary>
	/// Expires
	/// </summary>
	[DataMember(Name = ".expires", EmitDefaultValue = false)]
	public string Expires { get; set; }

	/// <summary>
	/// ExpiresIn
	/// </summary>
	[DataMember(Name = "expires_in", EmitDefaultValue = false)]
	public int? ExpiresIn { get; set; }

	/// <summary>
	/// Issued
	/// </summary>
	[DataMember(Name = ".issued", EmitDefaultValue = false)]
	public string Issued { get; set; }

	/// <summary>
	/// RefreshToken
	/// </summary>
	[DataMember(Name = "refresh_token", EmitDefaultValue = false)]
	public string RefreshToken { get; set; }

	/// <summary>
	/// TokenType
	/// </summary>
	[DataMember(Name = "token_type", EmitDefaultValue = false)]
	public string TokenType { get; set; }

	/// <summary>
	/// Username
	/// </summary>
	[DataMember(Name = "username", EmitDefaultValue = false)]
	public string Username { get; set; }

	/// <summary>
	/// Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class SecurityTokenResponse {\n");
		sb.Append("  AccessToken: ").Append(AccessToken).Append('\n');
		sb.Append("  AsclientId: ").Append(AsclientId).Append('\n');
		sb.Append("  Expires: ").Append(Expires).Append('\n');
		sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append('\n');
		sb.Append("  Issued: ").Append(Issued).Append('\n');
		sb.Append("  RefreshToken: ").Append(RefreshToken).Append('\n');
		sb.Append("  TokenType: ").Append(TokenType).Append('\n');
		sb.Append("  Username: ").Append(Username).Append('\n');
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
			if (AccessToken != null)
			{
				hash = hash * 59 + AccessToken.GetHashCode();
			}

			if (AsclientId != null)
			{
				hash = hash * 59 + AsclientId.GetHashCode();
			}

			if (Expires != null)
			{
				hash = hash * 59 + Expires.GetHashCode();
			}

			if (ExpiresIn != null)
			{
				hash = hash * 59 + ExpiresIn.GetHashCode();
			}

			if (Issued != null)
			{
				hash = hash * 59 + Issued.GetHashCode();
			}

			if (RefreshToken != null)
			{
				hash = hash * 59 + RefreshToken.GetHashCode();
			}

			if (TokenType != null)
			{
				hash = hash * 59 + TokenType.GetHashCode();
			}

			if (Username != null)
			{
				hash = hash * 59 + Username.GetHashCode();
			}

			return hash;
		}
	}

	
}