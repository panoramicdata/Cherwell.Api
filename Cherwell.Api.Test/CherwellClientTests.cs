using System.Net.Http;
using System.Reflection;
using Cherwell.Api.Exceptions;

namespace Cherwell.Api.Test;

public class CherwellClientTests
{
	/// <summary>
	/// A fresh client exposes a non-null proxy for every service area.
	/// </summary>
	[Fact]
	public void Constructor_AllServiceAreas_ArePopulated()
	{
		using var client = CreateClient();

		client.Approval.Should().NotBeNull();
		client.BusinessObject.Should().NotBeNull();
		client.Core.Should().NotBeNull();
		client.Forms.Should().NotBeNull();
		client.Lifecycle.Should().NotBeNull();
		client.OneStepActions.Should().NotBeNull();
		client.Queues.Should().NotBeNull();
		client.Searches.Should().NotBeNull();
		client.Security.Should().NotBeNull();
		client.Service.Should().NotBeNull();
		client.Teams.Should().NotBeNull();
		client.Users.Should().NotBeNull();
	}

	/// <summary>
	/// A null options argument is rejected before anything is constructed.
	/// </summary>
	[Fact]
	public void Constructor_NullOptions_ThrowsArgumentNull()
	{
		CherwellClientOptions? options = null;
		ArgumentNullException? argument = null;
		try
		{
			_ = new CherwellClient(options!);
		}
		catch (ArgumentNullException ex)
		{
			argument = ex;
		}

		argument!.Should().NotBeNull();
		argument.ParamName.Should().Be("options");
	}

	/// <summary>
	/// A client created from an explicit logger also exposes its service areas.
	/// </summary>
	[Fact]
	public void Constructor_ExplicitLogger_Succeeds()
	{
		var logger = new Microsoft.Extensions.Logging.Abstractions.NullLogger<CherwellClient>();
		using var client = new CherwellClient(ValidOptions(), logger);

		client.Core.Should().NotBeNull();
	}

	/// <summary>
	/// The options' BaseAddress and TimeoutSeconds are wired through to the underlying client.
	/// </summary>
	[Fact]
	public void Constructor_BaseAddressAndTimeout_AreWired()
	{
		var options = ValidOptions();
		options.TimeoutSeconds = 12;
		using var client = new CherwellClient(options);

		var field = typeof(CherwellClient).GetField(
			"_httpClient",
			BindingFlags.Instance | BindingFlags.NonPublic);
		var httpClient = (HttpClient)field!.GetValue(client)!;
		httpClient.BaseAddress!.ToString().Should().StartWith("https://cherwell.example.com");
		httpClient.Timeout.Should().Be(TimeSpan.FromSeconds(12));
	}

	private static CherwellClient CreateClient() => new(ValidOptions());

	private static CherwellClientOptions ValidOptions() => new()
	{
		UserName = "alice",
		Password = "secret",
		ClientId = "client-1",
		BaseAddress = "https://cherwell.example.com",
		AuthenticationMode = "Internal"
	};
}
