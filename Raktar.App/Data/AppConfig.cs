namespace Raktar.App.Data
{
	class AppConfig
	{
		public const string FileName = "application.config";

		public static AppConfig Default = new AppConfig()
		{
			DatabaseServer = "localhost",
			DatabaseName = "raktar",
			DatabaseUser = "root",
			DatabasePassword = "",
			ODBCDriver = "MySQL ODBC 5.3 ANSI Driver"
		};

		public string DatabaseServer;
		public string DatabaseName;
		public string DatabaseUser;
		public string DatabasePassword;
		public string ODBCDriver;
	}
}
