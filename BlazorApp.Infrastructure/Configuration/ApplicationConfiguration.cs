namespace BlazorApp.Infrastructure.Configuration
{
	public class ApplicationConfiguration
	{
		public BingoMapSettings BingoMapSettings { get; set; }
		public ConnectionStrings ConnectionStrings { get; set; }
		public ApplicationConfiguration()
		{
            BingoMapSettings = new BingoMapSettings();
			ConnectionStrings = new ConnectionStrings();
		}
	}

	public class BingoMapSettings
    {
		public BingoMapSettings()
		{

		}
		public string BingoLocationsApiUrl { get; set; }
		public string BingoLocationsApiCallTemplate { get; set; }
		public string BingoLocationsApiKey { get; set; }
		public string BingoMapLat { get; set; }
		public string BingoMapLng { get; set; }

	}

	public class ConnectionStrings
	{
		public ConnectionStrings()
		{

		}
		public string SQLiteDefaultConnection { get; set; }
	}
}