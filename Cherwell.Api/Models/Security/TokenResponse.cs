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




		}
	}

	
}