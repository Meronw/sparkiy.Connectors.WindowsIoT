using System.Collections.Generic;
using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// Adapter.
	/// </summary>
	[DebuggerDisplay("Adapter: {Name}")]
	public class Adapter
	{
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the hardware address.
		/// </summary>
		/// <value>
		/// The hardware address.
		/// </value>
		public string HardwareAddress { get; set; }

		/// <summary>
		/// Gets or sets the index.
		/// </summary>
		/// <value>
		/// The index.
		/// </value>
		public int Index { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>
		/// The type.
		/// </value>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the DHCP.
		/// </summary>
		/// <value>
		/// The DHCP.
		/// </value>
		public Dhcp Dhcp { get; set; }

		/// <summary>
		/// Gets or sets the gateways.
		/// </summary>
		/// <value>
		/// The gateways.
		/// </value>
		public List<Address> Gateways { get; set; }

		/// <summary>
		/// Gets or sets the ip addresses.
		/// </summary>
		/// <value>
		/// The ip addresses.
		/// </value>
		public List<Address> IpAddresses { get; set; }
	}
}