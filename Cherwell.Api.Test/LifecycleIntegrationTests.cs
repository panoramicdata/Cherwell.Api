using Cherwell.Api.Exceptions;
using Cherwell.Api.Models.Searches;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class LifecycleIntegrationTests : CherwellClientTest
{
	public LifecycleIntegrationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	// GetStagesAsync - unable to test, no businessObjectDefinitionId to test with
	// GetStatusesAsync - unable to test, no businessObjectDefinitionId to test with
	// GetTransitionsAsync - unable to test, no businessObjectDefinitionId to test with
	// GetRecordStatusAsync - unable to test, no businessObjectDefinitionId to test with
	// GetRecordStageAsync - unable to test, no businessObjectDefinitionId to test with
	// GetTransitionOptionsAsync - unable to test, no businessObjectDefinitionId to test with
	// TransitionRecordAsync - unable to test, no businessObjectDefinitionId to test with
}