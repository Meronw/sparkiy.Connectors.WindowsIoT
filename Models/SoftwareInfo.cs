using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// Software information.
	/// </summary>
	[DebuggerDisplay("Software OS: {OsVersion}")]
	public class SoftwareInfo : MachineName
	{
		/// <summary>
		/// Gets or sets the language.
		/// </summary>
		/// <value>
		/// The language.
		/// </value>
		public string Language { get; set; }

		/// <summary>
		/// Gets or sets the MAC address.
		/// </summary>
		/// <value>
		/// The MAC address.
		/// </value>
		public string MacAddress { get; set; }

		/// <summary>
		/// Gets or sets the OS edition.
		/// </summary>
		/// <value>
		/// The OS edition.
		/// </value>
		public string OsEdition { get; set; }

		/// <summary>
		/// Gets or sets the OS version.
		/// </summary>
		/// <value>
		/// The OS version.
		/// </value>
		public string OsVersion { get; set; }

		/// <summary>
		/// Gets or sets the platform.
		/// </summary>
		/// <value>
		/// The platform.
		/// </value>
		public string Platform { get; set; }

		/// <summary>
		/// Gets or sets the SQM machine identifier.
		/// </summary>
		/// <value>
		/// The SQM machine identifier.
		/// </value>
		public string SqmMachineId { get; set; }
	}
}