using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace sparkiy.Connectors.IoT.Windows
{
	/// <summary>
	/// REST API client.
	/// </summary>
	public class RestClient : IRestClient
	{
		private readonly Connection clientConnection;
		private readonly Credentials clientCredentials;


		/// <summary>
		/// Initializes a new instance of the <see cref="RestClient"/> class.
		/// </summary>
		/// <param name="connection">The connection.</param>
		/// <param name="credentials">The credentials.</param>
		/// <exception cref="System.ArgumentNullException">
		/// connection
		/// or
		/// credentials
		/// </exception>
		public RestClient(Connection connection, Credentials credentials)
		{
			if (connection == null) throw new ArgumentNullException(nameof(connection));
			if (credentials == null) throw new ArgumentNullException(nameof(credentials));

			this.clientConnection = connection;
			this.clientCredentials = credentials;
		}


		/// <summary>
		/// Gets the data from REST API using GET method.
		/// </summary>
		/// <param name="path">The path (excluding base address which is set in <see cref="Connection"/>).</param>
		/// <returns>Returns string data that is returned from REST API.</returns>
		public async Task<string> GetAsync(string path)
		{
			using (var client = this.GetClientHttp())
			{
				try
				{
					var result = await client.GetAsync(path);
					var content = await result.Content.ReadAsStringAsync();
					return content;
				}
				catch (Exception)
				{
					// TODO Log the error
					return null;
				}
			}
		}
		
		/// <summary>
		/// Sends the data to REST API using POST method.
		/// </summary>
		/// <param name="path">The path (excluding base address which is set in <see cref="Connection" />).</param>
		/// <param name="data">The data to send as content.</param>
		public async Task PostAsync(string path, string data)
		{
			using (var client = this.GetClientHttp())
			{
				try
				{
					var content = new StringContent(data ?? string.Empty, Encoding.ASCII, "application/json");
					var result = await client.PostAsync(path, content);
					
					// Read content
					var responseContent = await result.Content.ReadAsStringAsync();

					// Check result
					if (!result.IsSuccessStatusCode)
						throw new InvalidOperationException(string.Format("Failed to retrieve data from device. {0}", responseContent));
				}
				catch (Exception)
				{
					// TODO Log the error
				}
			}
		}

		/// <summary>
		/// Gets the new instance of <see cref="HttpClient"/> configured with client connection information and credentials.
		/// </summary>
		/// <returns>Returns new instance of <see cref="HttpClient"/> that is configured with client connection information and credentials.</returns>
		protected HttpClient GetClientHttp()
		{
			if (this.clientCredentials == null) throw new NullReferenceException(nameof(this.clientCredentials));
			if (this.clientConnection == null) throw new NullReferenceException(nameof(this.clientConnection));

			// Obtain client credentials 
			var handler = new HttpClientHandler {Credentials = new NetworkCredential(this.clientCredentials.UserName, this.clientCredentials.Password)};

			// Instantiate new instance of http client and assign credentials and base address to it
			return new HttpClient(handler)
			{
				BaseAddress = new Uri($"http://{this.clientConnection.MachineName}:{this.clientConnection.RestApiPort}", UriKind.Absolute)
			};
		}
	}
}