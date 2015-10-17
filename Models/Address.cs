using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// IP address.
	/// </summary>
	[DebuggerDisplay("IP address: {IpAddress}")]
	public class Address
	{
		/// <summary>
		/// Gets or sets the IP address.
		/// </summary>
		/// <value>
		/// The IP address.
		/// </value>
		public string IpAddress { get; set; }

		/// <summary>
		/// Gets or sets the mask.
		/// </summary>
		/// <value>
		/// The mask.
		/// </value>
		public string Mask { get; set; }
	}
}