using System.Runtime.Serialization;
using System.Text.Json;
using Cherwell.Api.Models;

namespace Cherwell.Api.Test;

/// <summary>
/// <see cref="CherwellJson"/> is internal; the tests use it via the public serializer surface,
/// <see cref="CherwellClient"/>, which constructs a <see cref="System.Text.Json.JsonSerializerOptions"/>
/// from it. The round-trip tests here pin down the contract that those options implement.
/// </summary>
public class CherwellJsonTests
{
	[Fact]
	public void Serialisation_DataMemberNames_AreHonoured()
	{
		var json = JsonSerializer.Serialize(new Response
		{
			ErrorCode = "ERR",
			ErrorMessage = "msg"
		}, CreateOptions());

		json.Should().Contain("\"errorCode\":\"ERR\"");
		json.Should().Contain("\"errorMessage\":\"msg\"");
		json.Should().NotContain("\"ErrorCode\"");
	}

	[Fact]
	public void Serialisation_DefaultValues_AreOmitted()
	{
		var json = JsonSerializer.Serialize(new Response { ErrorCode = "ERR" }, CreateOptions());

		json.Should().NotContain("\"hasError\"");
		json.Should().NotContain("\"httpStatusCode\"");
	}

	[Fact]
	public void Deserialisation_DataMemberNames_AreHonoured()
	{
		var response = JsonSerializer.Deserialize<Response>(
			"{\"errorCode\":\"ERR\",\"errorMessage\":\"msg\"}", CreateOptions());

		response!.ErrorCode.Should().Be("ERR");
		response.ErrorMessage.Should().Be("msg");
	}

	[Fact]
	public void Deserialisation_UnknownMembers_AreIgnored()
	{
		var response = JsonSerializer.Deserialize<Response>(
			"{\"errorCode\":\"ERR\",\"someUnknown\":\"x\"}", CreateOptions());

		response!.ErrorCode.Should().Be("ERR");
	}

	[Fact]
	public void WriteIndented_CreatesIndentation()
	{
		var options = CreateOptions();
		options.WriteIndented = true;

		var json = JsonSerializer.Serialize(new Response { ErrorCode = "ERR" }, options);
		json.Should().Contain("\n");
	}

	[Fact]
	public void CreateSerializerOptions_Default_UsesWebDefaults()
	{
		var options = CreateOptions();

		options.PropertyNamingPolicy.Should().Be(JsonNamingPolicy.CamelCase);
		options.WriteIndented.Should().BeFalse();
	}

	private static JsonSerializerOptions CreateOptions() =>
		CherwellJson.CreateSerializerOptions();
}
