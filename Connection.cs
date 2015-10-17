namespace sparkiy.Connectors.IoT.Windows
{
	/// <summary>
	/// Connection data for <see cref="DeviceApi"/> client.
	/// </summary>
	public class Connection
	{
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