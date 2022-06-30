using Refit;

namespace Cherwell.Api.Interfaces;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IService
{
	/// <summary>
	/// Get information about the REST Api and CSM
	/// </summary>
	/// <remarks>
	/// Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
	/// </remarks>
	/// <exception cref="Client.ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of CoreServiceInfoResponse</returns>
	[Get("/api/V1/serviceinfo")]
	Task<ServiceInfoResponse> GetServiceInfoAsync(
		CancellationToken cancellationToken);
}