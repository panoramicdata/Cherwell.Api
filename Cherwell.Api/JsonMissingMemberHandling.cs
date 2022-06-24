﻿namespace Cherwell.Api;
public enum JsonMissingMemberHandling
{
	/// <summary>
	/// Use the default Ignore missing members behaviour
	/// </summary>
	Ignore = 1,

	/// <summary>
	/// Use the default Error on missing members behaviour
	/// </summary>
	ThrowOnError = 2,

	/// <summary>
	/// Log the issue when a missing member error occurs and then reattempt using the Ignore behaviour
	/// </summary>
	LogWarningOnErrorAndContinue = 3
}
