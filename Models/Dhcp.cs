using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// DHCP.
	/// </summary>
	[DebuggerDisplay("DHCP: {Address}")]
	public class Dhcp
	{
		/// <summary>
		/// Gets or sets the lease expires.
		/// </summary>
		/// <value>
		/// The lease expires.
		/// </value>
		public int LeaseExpires { get; set; }

		/// <summary>
		/// Gets or sets the lease obtained.
		/// </summary>
		/// <value>
		/// The lease obtained.
		/// </value>
		public int LeaseObtained { get; set; }

		/// <summary>
		/// Gets or sets the address.
		/// </summary>
		/// <value>
		/// The address.
		/// </value>
		public Address Address { get; set; }
	}
}