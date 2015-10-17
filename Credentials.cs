using System;

namespace sparkiy.Connectors.IoT.Windows
{
	/// <summary>
	/// <see cref="DeviceApi"/> credentials.
	/// </summary>
	public class Credentials
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Credentials"/> class.
		/// </summary>
		public Credentials()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Credentials"/> class.
		/// </summary>
		/// <param name="userName">Name of the user.</param>
		/// <param name="password">The password.</param>
		/// <exception cref="System.ArgumentNullException">
		/// userName
		/// or
		/// password
		/// </exception>
		public Credentials(string userName, string password)
		{
			if (string.IsNullOrWhiteSpace(userName)) throw new ArgumentNullException(nameof(userName));
			if (string.IsNullOrWhiteSpace(password)) throw new ArgumentNullException(nameof(password));

			this.UserName = userName;
			this.Password = password;
		}


		/// <summary>
		/// Gets or sets the user name of the user.
		/// </summary>
		/// <value>
		/// The user name of the user.
		/// </value>
		public string UserName { get; set; }

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		/// <value>
		/// The password.
		/// </value>
		public string Password { get; set; }
	}
}