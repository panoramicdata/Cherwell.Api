namespace Cherwell.Api.Exceptions;

public class Message
{
	public static readonly string Forbidden = "Cherwell responded with INSUFFICIENTRIGHTS (Forbidden), with message: You are not authorized to view this object";
	public static readonly string NotFound = "Cherwell responded with SEARCHNOTFOUND (InternalServerError), with message: The requested search was not found : ";
	public static readonly string RecordNotFound = "Cherwell responded with RECORDNOTFOUND (InternalServerError), with message: Record not found";
	public static readonly string RecordNotFoundMessage = "RECORDNOTFOUND : Record not found";
	public static readonly string UnknownException = "Cherwell responded with INSUFFICIENTRIGHTS (InternalServerError)";
	public static readonly string InsufficientRights = "Cherwell responded with INSUFFICIENTRIGHTS (InternalServerError), with message: Insufficient rights to view personas";
}
