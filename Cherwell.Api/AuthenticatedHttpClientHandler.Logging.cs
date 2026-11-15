using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Security.Authentication;
using System.Text.Json;

namespace Cherwell.Api;

public partial class AuthenticatedHttpClientHandler
{
	private static readonly JsonSerializerOptions IndentedJsonOptions = CherwellJson.CreateSerializerOptions(true);

	private async Task LogRequestAsync(Guid requestId, HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		var body = await ReadBodyAsync(request.Content, cancellationToken).ConfigureAwait(false);
		_logger.LogDebug(
			"{RequestId}: REQUEST: Url:{Url}\nHeaders:{Headers}\nBody: {Body}",
			requestId,
			request.RequestUri,
			request.Headers.ToDebugString(),
			FormatJson(body));
	}

	private async Task LogResponseAsync(Guid requestId, HttpResponseMessage response, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		var body = await ReadBodyAsync(response.Content, cancellationToken).ConfigureAwait(false);
		_logger.LogDebug(
			"{RequestId}: RESPONSE: {StatusCode}\nHeaders:{Headers}\nBody: {Body}",
			requestId,
			response.StatusCode,
			response.Headers.ToDebugString(),
			FormatJson(body));
	}

	private static async Task<string> ReadBodyAsync(HttpContent? content, CancellationToken cancellationToken)
	{
		if (content is null)
		{
			return string.Empty;
		}

		return await content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
	}

	private static string FormatJson(string body)
	{
		try
		{
			using var document = JsonDocument.Parse(body);
			return JsonSerializer.Serialize(document.RootElement, IndentedJsonOptions);
		}
		catch (JsonException)
		{
			return body;
		}
	}

	private static async Task ThrowIfUnsuccessfulAsync(HttpResponseMessage httpResponse, CancellationToken cancellationToken)
	{
		if (httpResponse.IsSuccessStatusCode)
		{
			return;
		}

		var body = await ReadBodyAsync(httpResponse.Content, cancellationToken).ConfigureAwait(false);

		Response? response;
		try
		{
			response = DeserializeResponse(body);
		}
		catch (JsonException)
		{
			throw CreateUnstructuredResponseException(httpResponse, body);
		}

		if (response is null)
		{
			throw CreateUnstructuredResponseException(httpResponse, body);
		}

		ThrowForStructuredResponse(response, httpResponse);
	}

	private static Response? DeserializeResponse(string body)
	{
		return JsonSerializer.Deserialize<Response>(body, JsonOptions);
	}

	private static void ThrowForStructuredResponse(Response response, HttpResponseMessage httpResponse)
	{
		if (response.HttpStatusCode is null or EnumHttpStatusCode.None)
		{
			response.HttpStatusCode = (EnumHttpStatusCode)httpResponse.StatusCode;
		}

		var reason = $"Cherwell responded with {response.ErrorCode} ({response.HttpStatusCode})";
		if (!string.IsNullOrWhiteSpace(response.ErrorMessage))
		{
			reason += $", with message: {response.ErrorMessage}";
		}

		throw new CherwellApiException(response, reason);
	}

	private static CherwellApiException CreateUnstructuredResponseException(HttpResponseMessage response, string body)
	{
		var reason = $"Cherwell responded with {response.StatusCode} ({response.ReasonPhrase})";
		if (!string.IsNullOrWhiteSpace(body))
		{
			reason += $" - {body}";
		}

		return new CherwellApiException(reason);
	}
}
