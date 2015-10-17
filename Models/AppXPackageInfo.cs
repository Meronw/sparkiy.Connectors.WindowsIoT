using System.Diagnostics;

namespace sparkiy.Connectors.IoT.Windows.Models
{
	/// <summary>
	/// AppX package information.
	/// </summary>
	[DebuggerDisplay("AppXPackageInfo: {Name}")]
	public class AppXPackageInfo
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the name of the package family.
		/// </summary>
		/// <value>
		/// The name of the package family.
		/// </value>
		public string PackageFamilyName { get; set; }

		/// <summary>
		/// Gets or sets the full name of the package.
		/// </summary>
		/// <value>
		/// The full name of the package.
		/// </value>
		public string PackageFullName { get; set; }

		/// <summary>
		/// Gets or sets the package relative identifier.
		/// </summary>
		/// <value>
		/// The package relative identifier.
		/// </value>
		public string PackageRelativeId { get; set; }
	}
}