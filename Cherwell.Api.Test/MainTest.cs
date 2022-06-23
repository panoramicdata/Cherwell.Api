using Xunit;

namespace Cherwell.Api.Test;

public class MainTest
{
	[Fact]
	public void ApiShouldReturnSomething()
	{
		CherwellClientOptions options = new CherwellClientOptions();
		options.BaseAddress = "https://selfserviceacceptatie.avitgroup.com";

		CherwellClient client = new CherwellClient(options);
		var response = client.Approval.GetMyApprovalsAsync(options.UserAgent, null, null);

		Assert.NotNull(response);
	}
}