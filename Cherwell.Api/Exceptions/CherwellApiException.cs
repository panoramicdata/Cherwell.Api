using System.Runtime.Serialization;

namespace Cherwell.Api.Exceptions;

[Serializable]
public class CherwellApiException : Exception
{
	public CherwellApiException()
	{
	}

	public CherwellApiException(Response response) : base(response.ErrorMessage)
	{
		Response = response;
	}

	public CherwellApiException(string? message) : base(message)
	{
	}

	public CherwellApiException(string? message, Exception? innerException) : base(message, innerException)
	{
	}

	protected CherwellApiException(SerializationInfo info, StreamingContext context) : base(info, context)
	{
	}

	public Response? Response { get; }
}