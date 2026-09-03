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
	/// expected message and error code.
	/// </summary>
	/// <remarks>
	/// Every "not authorised" test in this suite makes the same assertion, so it lives here rather than
	/// being copied into each one.
	/// </remarks>
	/// <param name="action">The call expected to fail.</param>
	/// <param name="expectedMessage">The exception message expected.</param>
	/// <param name="expectedErrorCode">The Cherwell error code expected on the response.</param>
	protected static async Task AssertThrowsCherwellAsync(
		Func<Task> action,
		string expectedMessage,
		string expectedErrorCode)
	{
		var response = await AssertThrowsCherwellResponseAsync(action, expectedMessage);
		response.ErrorCode.Should().Be(expectedErrorCode);
	}

	/// <summary>
	/// Asserts that <paramref name="action"/> fails with a <see cref="CherwellApiException"/> carrying the
	/// expected message, error code and HTTP status code.
	/// </summary>
	/// <param name="action">The call expected to fail.</param>
	/// <param name="expectedMessage">The exception message expected.</param>
	/// <param name="expectedErrorCode">The Cherwell error code expected on the response.</param>
	/// <param name="expectedStatusCode">The HTTP status code expected on the response.</param>
	protected static async Task AssertThrowsCherwellAsync(
		Func<Task> action,
		string expectedMessage,
		string expectedErrorCode,
		EnumHttpStatusCode expectedStatusCode)
	{
		var response = await AssertThrowsCherwellResponseAsync(action, expectedMessage);
		response.ErrorCode.Should().Be(expectedErrorCode);
		response.HttpStatusCode.Should().Be(expectedStatusCode);
	}

	/// <summary>
	/// Asserts that <paramref name="action"/> is rejected as forbidden.
	/// </summary>
	/// <param name="action">The call expected to be rejected.</param>
	protected static Task AssertForbiddenAsync(Func<Task> action) => AssertThrowsCherwellAsync(
		action,
		Message.Forbidden,
		ErrorCode.Forbidden,
		EnumHttpStatusCode.Forbidden);

	/// <summary>
	/// Asserts that <paramref name="action"/> is rejected because the record does not exist.
	/// </summary>
	/// <param name="action">The call expected to be rejected.</param>
	protected static Task AssertRecordNotFoundAsync(Func<Task> action) => AssertThrowsCherwellAsync(
		action,
		Message.RecordNotFound,
		ErrorCode.RecordNotFound);

	/// <summary>
	/// Asserts that <paramref name="action"/> succeeds and returns a response.
	/// </summary>
	/// <remarks>
	/// Many endpoints can only be smoke-tested against the live instance, because the test account has no
	/// fixture data to assert against. For those, that the call succeeds and returns something is the
	/// assertion.
	/// </remarks>
	/// <typeparam name="TResponse">The response type of the call.</typeparam>
	/// <param name="action">The call expected to succeed.</param>
	protected static async Task AssertSucceedsAsync<TResponse>(Func<Task<TResponse>> action)
	{
		var response = await action();
		response.Should().NotBeNull();
	}

	/// <summary>
	/// Asserts that <paramref name="action"/> throws a <see cref="CherwellApiException"/> whose message
	/// matches and which carries an error-bearing response, and returns that response for further checks.
	/// </summary>
	private static async Task<Response> AssertThrowsCherwellResponseAsync(
		Func<Task> action,
		string expectedMessage)
	{
		var assertion = await action
			.Should()
			.ThrowAsync<CherwellApiException>()
			.WithMessage(expectedMessage);

		assertion.Which.Response.Should().NotBeNull();
		assertion.Which.Response!.HasError.Should().BeTrue();
		return assertion.Which.Response;
	}

	public ValueTask DisposeAsync()
	{
		_cherwellClient?.Dispose();
		GC.SuppressFinalize(this);
		return ValueTask.CompletedTask;
	}
}
