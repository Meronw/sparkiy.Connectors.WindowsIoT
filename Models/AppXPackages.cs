using System.Collections.Generic;
using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// AppX packages.
	/// </summary>
	[DebuggerDisplay("AppX packages installed: {InstalledPackages.Count}")]
	public class AppXPackages 
	{
		/// <summary>
		/// Gets or sets the installed packages.
		/// </summary>
		/// <value>
		/// The installed packages.
		/// </value>
		public List<AppXPackageInfo> InstalledPackages { get; set; }
	}
}