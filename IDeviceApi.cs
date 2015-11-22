using System.Threading.Tasks;
using sparkiy.Connectors.IoT.Windows.Models;


namespace sparkiy.Connectors.IoT.Windows
{
	/// <summary>
	/// Windows IoT device API client.
	/// </summary>
	public interface IDeviceApi
	{
		/// <summary>
		/// Gets the machine name.
		/// </summary>
		/// <returns>Returns <see cref="MachineName"/> that is populated with data from device.</returns>
		Task<MachineName> GetMachineNameAsync();

		/// <summary>
		/// Sets the machine name.
		/// </summary>
		/// <param name="machineName">New name of the machine.</param>
		Task SetMachineNameAsync(string machineName);

		/// <summary>
		/// Gets the software information.
		/// </summary>
		/// <returns>Returns <see cref="SoftwareInfo"/> that is populated with data from device.</returns>
		Task<SoftwareInfo> GetSoftwareInfo();

		/// <summary>
		/// Gets the ip configuration.
		/// </summary>
		/// <returns>Returns <see cref="IpConfig"/> that is populated with data from device.</returns>
		Task<IpConfig> GetIpConfig();

		/// <summary>
		/// Gets the installed AppX packages.
		/// </summary>
		/// <returns>Returns <see cref="AppXPackages"/> that is populated with data from device.</returns>
		Task<AppXPackages> GetInstalledAppXPackages();
	}
}
