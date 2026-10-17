using Cherwell.Api.Exceptions;
using Cherwell.Api.Models;

namespace Cherwell.Api.Test;

public class CherwellApiExceptionTests
{
	/// <summary>
	/// A parameterless instance has no structured response.
	/// </summary>
	[Fact]
	public void Ctor_Parameterless_CarriesNoMessage()
	{
		var exception = new CherwellApiException();

		exception.Message.Should().Be(
			"Exception of type 'Cherwell.Api.Exceptions.CherwellApiException' was thrown.");
		exception.Response.Should().BeNull();
		exception.InnerException.Should().BeNull();
	}

	/// <summary>
	/// The message-only constructor records the message.
	/// </summary>
	[Fact]
	public void Ctor_Message_RecordsMessage()
	{
		var exception = new CherwellApiException("something went wrong");

		exception.Message.Should().Be("something went wrong");
		exception.Response.Should().BeNull();
	}

	/// <summary>
	/// The message-plus-exception constructor records both.
	/// </summary>
	[Fact]
	public void Ctor_MessageAndInner_RecordsBoth()
	{
		var inner = new InvalidOperationException("root cause");
		var exception = new CherwellApiException("wrapper", inner);

		exception.Message.Should().Be("wrapper");
		exception.InnerException.Should().BeSameAs(inner);
		exception.Response.Should().BeNull();
	}

	/// <summary>
	/// The response-plus-message constructor keeps the response accessible.
	/// </summary>
	[Fact]
	public void Ctor_ResponseAndMessage_KeepsResponse()
	{
		var response = new Response { ErrorCode = "ERR-123", ErrorMessage = "nope" };
		var exception = new CherwellApiException(response, "Cherwell failed");

		exception.Message.Should().Be("Cherwell failed");
		exception.Response.Should().BeSameAs(response);
		exception.Response!.ErrorCode.Should().Be("ERR-123");
	}
}
