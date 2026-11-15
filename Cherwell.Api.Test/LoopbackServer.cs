using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Cherwell.Api.Test;

internal sealed class LoopbackServer : IDisposable
{
	private readonly HttpListener _listener = new();
	private readonly Func<HttpListenerRequest, (int Status, string Body)> _respond;
	private readonly List<string> _requests = [];
	private readonly Task _loop;

	public LoopbackServer(Func<HttpListenerRequest, (int Status, string Body)> respond)
	{
		_respond = respond;
		var probe = new TcpListener(IPAddress.Loopback, 0);
		probe.Start();
		var port = ((IPEndPoint)probe.LocalEndpoint).Port;
		probe.Stop();
		BaseAddress = $"http://127.0.0.1:{port}";
		_listener.Prefixes.Add(BaseAddress + "/");
		_listener.Start();
		_loop = Task.Run(RunAsync);
	}

	public string BaseAddress { get; }

	public IReadOnlyList<string> Requests
	{
		get
		{
			lock (_requests)
			{
				return [.. _requests];
			}
		}
	}

	private async Task RunAsync()
	{
		while (_listener.IsListening)
		{
			HttpListenerContext context;
			try
			{
				context = await _listener.GetContextAsync();
			}
			catch (Exception ex) when (ex is HttpListenerException or ObjectDisposedException)
			{
				return;
			}

			lock (_requests)
			{
				_requests.Add($"{context.Request.HttpMethod} {context.Request.Url!.PathAndQuery}");
			}

			var (status, body) = _respond(context.Request);
			var bytes = Encoding.UTF8.GetBytes(body);
			context.Response.StatusCode = status;
			context.Response.ContentType = "application/json";
			await context.Response.OutputStream.WriteAsync(bytes);
			context.Response.Close();
		}
	}

	public void Dispose()
	{
		_listener.Close();
		_loop.Wait(TimeSpan.FromSeconds(5));
	}
}
