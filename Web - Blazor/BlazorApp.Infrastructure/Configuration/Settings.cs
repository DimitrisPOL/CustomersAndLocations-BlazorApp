namespace BlazorApp.Infrastructure.Configuration
{
	public class ApplicationConfiguration
	{
		public Settings Settings { get; set; }
		public ApplicationConfiguration()
		{
			Settings = new Settings();
		}
	}

	public class Settings
	{
		public string DB_ConnectionString { get; set; }

		public Settings()
		{
		}
	}
}