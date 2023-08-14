namespace Cherwell.Api.Exceptions;
public static class Message
{
	public static readonly string Forbidden = "You are not authorized to view this object";

	public static readonly string NotFound = "The requested search was not found : ";

	public static readonly string RecordNotFound = "Record not found";

	public static readonly string RecordNotFoundMessage = "RECORDNOTFOUND : Record not found";

	public static readonly string UnknownException = "Exception of type 'Cherwell.Api.Exceptions.CherwellApiException' was thrown.";

	public static readonly string InsufficientRights = "Insufficient rights to view personas";
}
