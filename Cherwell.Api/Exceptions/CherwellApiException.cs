namespace Cherwell.Api.Exceptions;

[Serializable]
public class CherwellApiException : Exception
{
	public CherwellApiException()
	{
	}

	public CherwellApiException(Response response, string message) : base(message)
	{
		Response = response;
	}

	public CherwellApiException(string? message) : base(message)
	{
	}

	public CherwellApiException(string? message, Exception? innerException) : base(message, innerException)
	{
	}

	public Response? Response { get; }
}