using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class ViewsTests : CherwellClientTest
{
	public ViewsTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async void Core_GetViews()
	{
		// Get a list of views from Cherwell
		var views = await TestCherwellClient
			.Core
			.GetViewsAsync(default)
			.ConfigureAwait(false);

		views.Should().NotBeNull();
	}
}