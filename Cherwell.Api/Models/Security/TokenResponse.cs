using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Cherwell.Api.Models.Security;

/// <summary>
/// TokenResponse
/// </summary>
[DataContract]
public class TokenResponse : Response
{
	/// <summary>
	/// AccessToken
	/// </summary>
	[DataMember(Name = "access_token", EmitDefaultValue = false)]
	[JsonPropertyName("access_token")]
	public string AccessToken { get; set; } = null!;

	/// <summary>
	/// AsclientId
	/// </summary>
	[DataMember(Name = "as:client_id", EmitDefaultValue = false)]
	[JsonPropertyName("as:client_id")]
	public string AsClientId { get; set; } = null!;

	/// <summary>
	/// Expires
	/// </summary>
	[DataMember(Name = ".expires", EmitDefaultValue = false)]
	[JsonPropertyName(".expires")]
	public string Expires { get; set; } = null!;

	/// <summary>
	/// ExpiresIn
	/// </summary>
	[DataMember(Name = "expires_in", EmitDefaultValue = false)]
	[JsonPropertyName("expires_in")]
	public int ExpiresIn { get; set; }

	/// <summary>
	/// Issued
	/// </summary>
	[DataMember(Name = ".issued", EmitDefaultValue = false)]
	[JsonPropertyName(".issued")]
	public string Issued { get; set; } = null!;

	/// <summary>
	/// RefreshToken
	/// </summary>
	[DataMember(Name = "refresh_token", EmitDefaultValue = false)]
	[JsonPropertyName("refresh_token")]
	public string RefreshToken { get; set; } = null!;

	/// <summary>
	/// TokenType
	/// </summary>
	[DataMember(Name = "token_type", EmitDefaultValue = false)]
	[JsonPropertyName("token_type")]
	public string TokenType { get; set; } = null!;

	/// <summary>
	/// Username
	/// </summary>
	[DataMember(Name = "username", EmitDefaultValue = false)]
	public string Username { get; set; } = null!;
}
