using Cherwell.Api.Exceptions;
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
		await ((Func<Task>)(async () =>
		{
			var views = await TestCherwellClient
			.Core
			.GetViewsAsync(default)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.Forbidden)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.Forbidden
			&& e.Response.HttpStatusCode == Models.EnumHttpStatusCode.Forbidden
			&& e.Response.HasError == true
		);
	}
}
