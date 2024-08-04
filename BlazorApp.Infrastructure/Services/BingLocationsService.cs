using BlazorApp.Infrastructure.Configuration;
using BlazorApp.Infrastructure.Interfaces;
using BlazorApp.Shared;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp.Infrastructure.Services
{
	public sealed class BingLocationsService : IBingLocationsService , IDisposable
	{
		private readonly HttpClient _httpClient = null!;
		private readonly ILogger<BingLocationsService> _logger = null!;
        BingoMapSettings _bingoMapSettings = null;

        public BingLocationsService(HttpClient httpClient, ILogger<BingLocationsService> logger, IOptionsSnapshot<ApplicationConfiguration> applicationConfiguration)
        {
            _httpClient = httpClient;
            _logger = logger;
            _bingoMapSettings = applicationConfiguration.Value.BingoMapSettings;
        }

        public async Task<BingLocationsResult> GetLocationsAsync(string query)
		{
			try
			{
				var apiEndpoint = string.Format(_bingoMapSettings.BingoLocationsApiCallTemplate, query, _bingoMapSettings.BingoMapLat, _bingoMapSettings.BingoMapLng, _bingoMapSettings.BingoLocationsApiKey);

				BingLocationsResult? locations = await _httpClient.GetFromJsonAsync<BingLocationsResult>(
                    apiEndpoint,
					new JsonSerializerOptions(JsonSerializerDefaults.Web));

				return locations ?? null;
			}
			catch (Exception ex)
			{
				_logger.LogError("Error getting locations: {Error}", ex.Message);
			}

			return null;
		}

		public void Dispose() => _httpClient?.Dispose();
	}
}
