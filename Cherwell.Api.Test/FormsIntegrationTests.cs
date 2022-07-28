using Cherwell.Api.Exceptions;
using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class FormsIntegrationTests : CherwellClientTest
{
	public FormsIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	// GetMobileFormForBusObByIdAndPublicIdAsync - unable to test, we don't have a public id to test with

	[Fact]
	public async void Form_GetMobileFormByRecId()
	{
		var cancellationToken = CancellationToken.None;
		
		await ((Func<Task>)(async () =>
		{
			var response = await TestCherwellClient
			.Forms
			.GetMobileFormForBusObByIdAndRecIdAsync("944e0f0f214f53100758de4c81b78466866323bccf", "944e0f1424e236ce71b3c6484d875764a57ce45e51", null, null, cancellationToken)
			.ConfigureAwait(false);
		}))
		.Should()
		.ThrowAsync<CherwellApiException>()
		.WithMessage(Message.RecordNotFound)
		.Where(e =>
			e.Response != null && e.Response.ErrorCode == ErrorCode.RecordNotFound
			&& e.Response.HasError == true
		);
	}
}