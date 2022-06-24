using FluentAssertions;
using Refit;
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
		await ((Func<Task>)(async () =>
		{
			var views = await TestCherwellClient
			.Core
			.GetViewsAsync(default)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<ApiException>()
		.WithMessage("Response status code does not indicate success: 403 (Forbidden).");
	}
}
