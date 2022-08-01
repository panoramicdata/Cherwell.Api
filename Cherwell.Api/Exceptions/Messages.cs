namespace Cherwell.Api.Exceptions;
public class Message
{
	public const string Forbidden = "You are not authorized to view this object";

	public const string NotFound = "The requested search was not found : ";
	
	public const string RecordNotFound = "Record not found";

	public const string RecordNotFoundMessage = "RECORDNOTFOUND : Record not found";

	public const string UnknownException = "Exception of type 'Cherwell.Api.Exceptions.CherwellApiException' was thrown.";

	public const string InsufficientRights = "Insufficient rights to view personas";
}
