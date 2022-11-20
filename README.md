# Cherwell.Api

[![Nuget](https://img.shields.io/nuget/v/Cherwell.Api)](https://www.nuget.org/packages/Cherwell.Api/)

This project implements access to the v1 Cherwell API

See the [contribution guide](CONTRIBUTING.md) for more information regarding contributing to this project

To use the Cherwell API nuget package:

## Visual Studio

 1. Open your project in Visual Studio
 2. Right-click on the project and click "Manage Nuget packages"
 3. Find the package "Cherwell.Api" - install the latest version

## Example code (C# 10.0):

``` C#
using Cherwell.Api;
using System;
using System.Threading.Tasks;

namespace My.Project
{
	public static class Program
	{
		public static async Task Main()
		{
			using var cherwellClient = new CherwellClient(new CherwellClientOptions
			{
				BaseAddress = "xxxxxxx",
				Username = "0123456789abcdef0123456789abcdef01234567",
				Password = "0123456789abcdef0123456789abcdef01234567",
				ClientId = "0123456789abcdef0123456789abcdef01234567"
			});

			var views = await cherwellClient
				.Core
				.GetViewsAsync()
				.ConfigureAwait(false);
		}
	}
}
````

## API Documentation

The Cherwell API documentation can be found here:

  - [Cherwell API Documentation v1](https://help.cherwell.com/bundle/cherwell_rest_api_10_1_help_only/page/content/system_administration/rest_api)
