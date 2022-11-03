using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Cherwell.Api;

/// <summary>
/// Options used to control the behaviour of the Cherwell client
/// </summary>
public class CherwellClientOptions
{

	/// <summary>
	/// The Username of the user as whom we are to authenticate
	/// </summary>
	public string? UserName { get; set; }

	/// <summary>
	/// The Password of the user as whom we are to authenticate
	/// </summary>
	public string? Password { get; set; }

	/// <summary>
	/// The API ClientId that has been created to allow access to the API
	/// </summary>
	public string? ClientId { get; set; }

	/// <summary>
	/// The base address of the API instance to which we are to connect
	/// </summary>
	public string BaseAddress { get; set; } = null!;

	/// <summary>
	/// The authentication mode in use for connection attempts
	/// </summary>
	public string AuthenticationMode { get; set; } = "Internal";

	/// <summary>
	/// The user agent to be included in requests to the API
	/// </summary>
	public string? UserAgent { get; set; } = "CherwellApiNuget/" + ThisAssembly.AssemblyFileVersion;

	/// <summary>
	/// How to handle missing members
	/// </summary>
	public JsonMissingMemberHandling JsonMissingMemberHandling { get; set; }

	/// <summary>
	/// The logging level to use when members are found to be missing
	/// </summary>
	public LogLevel JsonMissingMemberResponseLogLevel { get; set; }

	/// <summary>
	/// An optional culture to use when parsing dates
	/// </summary>
	public CultureInfo? Culture { get; set; }

	/// <summary>
	/// Validate that all of the necessary options have been specified
	/// </summary>
	/// <exception cref="ConfigurationException">A problem has been identified with the options provided</exception>
	public void Validate()
	{
		if (string.IsNullOrWhiteSpace(UserName))
		{
			throw new ConfigurationException($"Missing {nameof(UserName)}.");
		}

		if (string.IsNullOrWhiteSpace(Password))
		{
			throw new ConfigurationException($"Missing {nameof(Password)}.");
		}

		if (string.IsNullOrWhiteSpace(ClientId))
		{
			throw new ConfigurationException($"Missing {nameof(ClientId)}.");
		}

		if (string.IsNullOrWhiteSpace(BaseAddress))
		{
			throw new ConfigurationException($"Missing {nameof(BaseAddress)}.");
		}

		if (string.IsNullOrWhiteSpace(AuthenticationMode))
		{
			throw new ConfigurationException($"Missing {nameof(AuthenticationMode)}.");
		}
	}
}
