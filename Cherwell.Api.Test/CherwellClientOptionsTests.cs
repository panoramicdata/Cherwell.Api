using System.Globalization;
using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;

namespace Cherwell.Api.Test;

public class CherwellClientOptionsTests
{
	/// <summary>
	/// A fully populated options instance round-trips its settings.
	/// </summary>
	[Fact]
	public void Properties_SettingValues_ReadBack()
	{
		var culture = new CultureInfo("fr-FR");
		var options = new CherwellClientOptions
		{
			UserName = "alice",
			Password = "secret",
			ClientId = "client-1",
			BaseAddress = "https://cherwell.example.com",
			AuthenticationMode = "LDAP",
			UserAgent = "SystemName/2.5",
			JsonMissingMemberHandling = JsonMissingMemberHandling.ThrowOnError,
			JsonMissingMemberResponseLogLevel = LogLevel.Warning,
			Culture = culture,
			TimeoutSeconds = 42,
			MaxAttempts = 9
		};

		options.UserName.Should().Be("alice");
		options.Password.Should().Be("secret");
		options.ClientId.Should().Be("client-1");
		options.BaseAddress.Should().Be("https://cherwell.example.com");
		options.AuthenticationMode.Should().Be("LDAP");
		options.UserAgent.Should().Be("SystemName/2.5");
		options.JsonMissingMemberHandling.Should().Be(JsonMissingMemberHandling.ThrowOnError);
		options.JsonMissingMemberResponseLogLevel.Should().Be(LogLevel.Warning);
		options.Culture.Should().Be(culture);
		options.TimeoutSeconds.Should().Be(42);
		options.MaxAttempts.Should().Be(9);
	}

	/// <summary>
	/// A fresh instance ships with the documented defaults.
	/// </summary>
	[Fact]
	public void Defaults_AreSensible()
	{
		var options = new CherwellClientOptions();

		options.BaseAddress.Should().BeEmpty();
		options.AuthenticationMode.Should().Be("Internal");
		options.TimeoutSeconds.Should().Be(100);
		options.MaxAttempts.Should().Be(5);
	}

	/// <summary>
	/// Each required setting is demanded by validation when it is missing.
	/// </summary>
	/// <param name="setting">Which required setting the instance should lack.</param>
	/// <param name="which">The setting being tested (encoded so the theory can run it).</param>
	[Theory]
	[InlineData(nameof(CherwellClientOptions.UserName), (int)RequiredSetting.UserName)]
	[InlineData(nameof(CherwellClientOptions.Password), (int)RequiredSetting.Password)]
	[InlineData(nameof(CherwellClientOptions.ClientId), (int)RequiredSetting.ClientId)]
	[InlineData(nameof(CherwellClientOptions.BaseAddress), (int)RequiredSetting.BaseAddress)]
	[InlineData(nameof(CherwellClientOptions.AuthenticationMode), (int)RequiredSetting.AuthenticationMode)]
	public void Validate_MissingRequiredSetting_ThrowsConfigurationError(string setting, int which)
	{
		var options = ValidOptions();
		switch ((RequiredSetting)which)
		{
			case RequiredSetting.UserName: options.UserName = "  "; break;
			case RequiredSetting.Password: options.Password = null; break;
			case RequiredSetting.ClientId: options.ClientId = ""; break;
			case RequiredSetting.BaseAddress: options.BaseAddress = string.Empty; break;
			case RequiredSetting.AuthenticationMode: options.AuthenticationMode = " "; break;
		}

		ConfigurationException? exception = null;
		try
		{
			options.Validate();
		}
		catch (ConfigurationException ex)
		{
			exception = ex;
		}

		exception.Should().NotBeNull();
		exception!.Message.Should().Contain(setting);
	}

	/// <summary>
	/// All required settings present, so validation passes.
	/// </summary>
	[Fact]
	public void Validate_AllRequiredSettingsPresent_Succeeds()
	{
		ValidOptions().Validate();
	}

	private enum RequiredSetting { UserName, Password, ClientId, BaseAddress, AuthenticationMode }

	private static CherwellClientOptions ValidOptions() => new()
	{
		UserName = "alice",
		Password = "secret",
		ClientId = "client-1",
		BaseAddress = "https://cherwell.example.com",
		AuthenticationMode = "Internal"
	};
}
