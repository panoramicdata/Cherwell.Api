namespace Cherwell.Api.Test;

public class LifecycleIntegrationTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _testCherwellClient = cherwellClient;

	// GetStagesAsync - unable to test, no businessObjectDefinitionId to test with
	// GetStatusesAsync - unable to test, no businessObjectDefinitionId to test with
	// GetTransitionsAsync - unable to test, no businessObjectDefinitionId to test with
	// GetRecordStatusAsync - unable to test, no businessObjectDefinitionId to test with
	// GetRecordStageAsync - unable to test, no businessObjectDefinitionId to test with
	// GetTransitionOptionsAsync - unable to test, no businessObjectDefinitionId to test with
	// TransitionRecordAsync - unable to test, no businessObjectDefinitionId to test with
}