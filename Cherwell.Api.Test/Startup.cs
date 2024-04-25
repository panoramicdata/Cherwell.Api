using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xunit.DependencyInjection.Logging;

namespace Cherwell.Api.Test;

public class Startup
{
	public static void ConfigureServices(IServiceCollection services)
	{
		var config = new ConfigurationBuilder()
			.AddJsonFile("../../../appsettings.json", true)
			.AddJsonFile("../../../appsettings.jsonc", true)
			.AddEnvironmentVariables()
			.AddUserSecrets<Startup>()
			.Build();

		services
			.AddLogging(lb => lb
				.AddDebug()
				.AddFilter(level => level >= LogLevel.Debug)
				.AddXunitOutput()
			)
			.AddTransient(s =>
			{
				var options = config.GetSection("CherwellClientOptions").Get<CherwellClientOptions>()
					?? throw new FormatException("Configuration is missing a valid CherwellClientOptions section");
				options.Validate();
				return new CherwellClient(options, s.GetRequiredService<ILogger<CherwellClient>>());
			})
			;
	}
}