using Cherwell.Api.Test.Config;
using Divergic.Logging.Xunit;
using Newtonsoft.Json;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class CherwellClientTest
{
   protected DateTimeOffset UtcNow { get; } = DateTimeOffset.UtcNow;

   protected DateTimeOffset Utc10DaysAgo => UtcNow - TimeSpan.FromDays(10);

   private CherwellClient? _cherwellClient;

   private Configuration? _configuration;

   protected ICacheLogger Logger { get; }

   public CherwellClientTest(ITestOutputHelper iTestOutputHelper)
   {
	  Logger = iTestOutputHelper.BuildLogger();
   }

   internal Configuration Configuration
   {
	  get
	  {
		 // Have we already created this?
		 if (_configuration != null)
		 {
			// Yes - return that one
			return _configuration;
		 }
		 // No - we need to create one

		 // Load config from file
		 var fileInfo = new FileInfo("../../../appsettings.jsonc");

		 // Does the config file exist?
		 if (!fileInfo.Exists)
		 {
			// No - hint to the user what to do
			throw new ConfigurationException("Missing appsettings.jsonc.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
		 }
		 // Yes

		 // Load in the config
		 _configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName));
		 if (_configuration is null)
		 {
			throw new ConfigurationException("Configuration did not deserialize");
		 }

		 _configuration.Validate();
		 return _configuration;
	  }
   }

   protected CherwellClient TestCherwellClient
   {
	  get
	  {
		 if (_cherwellClient != null)
		 {
			return _cherwellClient;
		 }

		 // Unit tests should always error if members are missing to aid picking up issues with models early
		 Configuration.CherwellClientOptions!.JsonMissingMemberHandling = JsonMissingMemberHandling.ThrowOnError;
		 // Log the response JSON so we can see what's going on
		 Configuration.CherwellClientOptions.JsonMissingMemberResponseLogLevel = Microsoft.Extensions.Logging.LogLevel.Critical;

		 return _cherwellClient = new CherwellClient(Configuration.CherwellClientOptions, Logger);
	  }
   }
}
