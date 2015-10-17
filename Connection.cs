using System;

namespace sparkiy.Connectors.IoT.Windows
{
	/// <summary>
	/// Connection data for <see cref="DeviceApi"/> client.
	/// </summary>
	public class Connection
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Connection"/> class.
		/// </summary>
		public Connection()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Connection"/> class.
		/// </summary>
		/// <param name="machineName">Name of the machine.</param>
		/// <param name="port">The port.</param>
		/// <exception cref="System.ArgumentNullException">
		/// machineName
		/// or
		/// port
		/// </exception>
		public Connection(string machineName, string port)
		{
			if (string.IsNullOrWhiteSpace(machineName)) throw new ArgumentNullException(nameof(machineName));
			if (string.IsNullOrWhiteSpace(port)) throw new ArgumentNullException(nameof(port));

			this.MachineName = machineName;
			this.RestApiPort = port;
		}


		/// <summary>
		/// Gets or sets the name of the machine.
		/// </summary>
		/// <value>
		/// The name of the machine.
		/// </value>
		/// <remarks>
		/// Default value is <c>minwinpc</c>.
		/// </remarks>
		public string MachineName { get; set; } = "minwinpc";

		/// <summary>
		/// Gets or sets the REST API port.
		/// </summary>
		/// <value>
		/// The REST API port.
		/// </value>
		/// <remarks>
		/// Default value is <c>8080</c>
		/// </remarks>
		public string RestApiPort { get; set; } = "8080";
	}
}