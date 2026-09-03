using Cherwell.Api.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Cherwell.Api.Test;

public abstract class TestBase : IAsyncLifetime
{
	private CherwellClient? _cherwellClient;

	protected CherwellClient Client => _cherwellClient
		?? throw new InvalidOperationException("CherwellClient not initialized. Ensure InitializeAsync has been called.");

	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	public ValueTask InitializeAsync()
	{
		var config = new ConfigurationBuilder()
			.AddJsonFile("../../../appsettings.json", true)
			.AddJsonFile("../../../appsettings.jsonc", true)
			.AddEnvironmentVariables()
			.AddUserSecrets<TestBase>()
			.Build();

		var optionsSection = config.GetSection("CherwellClientOptions");
		var options = new CherwellClientOptions
		{
			BaseAddress = optionsSection["BaseAddress"] ?? throw new FormatException("BaseAddress is required"),
			ClientId = optionsSection["ClientId"] ?? throw new FormatException("ClientId is required"),
			UserName = optionsSection["UserName"] ?? throw new FormatException("UserName is required"),
			Password = optionsSection["Password"] ?? throw new FormatException("Password is required"),
		};
		options.Validate();

		using var loggerFactory = LoggerFactory.Create(builder =>
		{
			builder
				.AddDebug()
				.AddFilter(level => level >= LogLevel.Debug);
		});

		_cherwellClient = new CherwellClient(options, loggerFactory.CreateLogger<CherwellClient>());

		return ValueTask.CompletedTask;
	}

	/// <summary>
	/// Asserts that <paramref name="action"/> fails with a <see cref="CherwellApiException"/> carrying the
	/// expected message, error code and (optionally) HTTP status code.
	/// </summary>
	/// <remarks>
	/// Every "not authorised" test in this suite makes the same four-part assertion, so it lives here rather
	/// than being copied into each one.
	/// </remarks>
	protected static async Task AssertThrowsCherwellAsync(
		Func<Task> action,
		string expectedMessage,
		string expectedErrorCode,
		EnumHttpStatusCode? expectedStatusCode = null)
	{
		var assertion = await action
			.Should()
			.ThrowAsync<CherwellApiException>()
			.WithMessage(expectedMessage);

		assertion.Which.Response.Should().NotBeNull();
		assertion.Which.Response!.ErrorCode.Should().Be(expectedErrorCode);
		assertion.Which.Response.HasError.Should().BeTrue();
		if (expectedStatusCode is not null)
		{
			assertion.Which.Response.HttpStatusCode.Should().Be(expectedStatusCode);
		}
	}

	/// <summary>
	/// Asserts that <paramref name="action"/> is rejected as forbidden.
	/// </summary>
	protected static Task AssertForbiddenAsync(Func<Task> action) => AssertThrowsCherwellAsync(
		action,
		Message.Forbidden,
		ErrorCode.Forbidden,
		EnumHttpStatusCode.Forbidden);

	public ValueTask DisposeAsync()
	{
		_cherwellClient?.Dispose();
		GC.SuppressFinalize(this);
		return ValueTask.CompletedTask;
	}
}
