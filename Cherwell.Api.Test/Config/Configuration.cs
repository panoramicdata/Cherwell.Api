using Cherwell.Api.Exceptions;

namespace Cherwell.Api.Test.Config;

internal class Configuration
{
	public CherwellClientOptions? CherwellClientOptions { get; set; }

	internal void Validate()
	{
		if (CherwellClientOptions is null)
		{
			throw new ConfigurationException($"Missing {nameof(CherwellClientOptions)} in config.");
		}
	}
}
