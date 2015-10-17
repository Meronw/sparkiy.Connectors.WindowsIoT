using System.Collections.Generic;
using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// IP configuration.
	/// </summary>
	[DebuggerDisplay("IP adapters available: {Adapters.Count}")]
	public class IpConfig
	{
		/// <summary>
		/// Gets or sets the adapters.
		/// </summary>
		/// <value>
		/// The adapters.
		/// </value>
		public List<Adapter> Adapters { get; set; }
	}
}