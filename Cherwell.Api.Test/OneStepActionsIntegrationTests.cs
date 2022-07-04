using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class OneStepActionsIntegrationTests : CherwellClientTest
{
	public OneStepActionsIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void GetOneStepActions_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await TestCherwellClient
			.OneStepActions
			.GetOneStepActionsAsync(null, cancellationToken)
			.ConfigureAwait(false);

		response
			.Should()
			.NotBeNull();
	}
}