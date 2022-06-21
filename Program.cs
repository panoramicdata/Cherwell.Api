using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO.Swagger.Api;
using IO.Swagger.Client;

namespace Cherwell.Api
{
	public class Program
	{
		static async void Main(string[] args)
		{
			HttpClient _client = new HttpClient();
			var apiClient = new ApiClient(_client);

			//var response = await apiClient.SendAsync
		}
	}
}