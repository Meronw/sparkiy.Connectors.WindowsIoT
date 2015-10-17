using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// Machine name.
	/// </summary>
	[DebuggerDisplay("ComputerName: {ComputerName}")]
	public class MachineName
	{
		/// <summary>
		/// Gets or sets the name of the computer.
		/// </summary>
		/// <value>
		/// The name of the computer.
		/// </value>
		public string ComputerName { get; set; }
	}
}