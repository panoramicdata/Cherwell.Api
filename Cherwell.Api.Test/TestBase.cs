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

	public ValueTask DisposeAsync()
	{
		_cherwellClient?.Dispose();
		GC.SuppressFinalize(this);
		return ValueTask.CompletedTask;
	}
}
