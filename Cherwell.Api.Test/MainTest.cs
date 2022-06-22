using Xunit;

namespace Cherwell.Api.Test
{
	public class MainTest
	{
		[Fact]
		public void ApiShouldReturnSomething()
		{
			var options = new CherwellClientOptions();
			var client = new CherwellClient(options);
			var response = client.Core.CoreGetViews("Tests");

		}
	}
}