﻿using FluentAssertions;
using Xunit;

namespace Cherwell.Api.Test;

public class OneStepActionsIntegrationTests(CherwellClient cherwellClient)
{
	private readonly CherwellClient _testCherwellClient = cherwellClient;

	// GetOneStepActionsByAssociationScopeScopeOwnerFolderAsync - unable to test, no association to test with
	// GetOneStepActionsByAssociationScopeScopeOwnerAsync - unable to test, no association to test with
	// GetOneStepActionsByAssociationScopeAsync - unable to test, no association to test with
	// GetOneStepActionsByAssociationAsync - unable to test, no association to test with

	[Fact]
	public async Task GetOneStepActions_Succeeds()
	{
		var cancellationToken = CancellationToken.None;

		var response = await _testCherwellClient
			.OneStepActions
			.GetOneStepActionsAsync(null, cancellationToken)
			;

		response
			.Should()
			.NotBeNull();
	}

	// RunOneStepActionByKeyForRecordByRecIdAsync - unable to test, no standinkey to test with
	// RunOneStepActionByStandInKeyAsync - unable to test, no standinkey to test with
	// RunOneStepActionAsync - unable to test, no OneStepAction object to test with

}