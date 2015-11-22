using System.Threading.Tasks;

namespace sparkiy.Connectors.IoT.Windows
{
	/// <summary>
	/// REST API client.
	/// </summary>
	public interface IRestClient
	{
		/// <summary>
		/// Gets the data from REST API using GET method.
		/// </summary>
		/// <param name="path">The path (excluding base address which is set in <see cref="Connection"/>).</param>
		/// <returns>Returns string data that is returned from REST API.</returns>
		Task<string> GetAsync(string path);

		/// <summary>
		/// Sends the data to REST API using POST method.
		/// </summary>
		/// <param name="path">The path (excluding base address which is set in <see cref="Connection"/>).</param>
		/// <param name="data">The data to send as content.</param>
		Task PostAsync(string path, string data);
	}
}