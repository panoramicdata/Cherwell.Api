using Xunit.Abstractions;

namespace Cherwell.Api.Test;

public class LifecycleIntegrationTests(ITestOutputHelper iTestOutputHelper) : CherwellClientTest(iTestOutputHelper)
{

	// GetStagesAsync - unable to test, no businessObjectDefinitionId to test with
	// GetStatusesAsync - unable to test, no businessObjectDefinitionId to test with
	// GetTransitionsAsync - unable to test, no businessObjectDefinitionId to test with
	// GetRecordStatusAsync - unable to test, no businessObjectDefinitionId to test with
	// GetRecordStageAsync - unable to test, no businessObjectDefinitionId to test with
	// GetTransitionOptionsAsync - unable to test, no businessObjectDefinitionId to test with
	// TransitionRecordAsync - unable to test, no businessObjectDefinitionId to test with
}