using BlazorApp.Infrastructure.Interfaces;
using BlazorApp.Shared;
using Microsoft.Extensions.Logging;
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

		public BingLocationsService(HttpClient httpClient, ILogger<BingLocationsService> logger) =>	 (_httpClient, _logger) = (httpClient, logger);

		public async Task<BingLocationsResult> GetLocationsAsync(string query)
		{
			try
			{
				BingLocationsResult? locations = await _httpClient.GetFromJsonAsync<BingLocationsResult>(
					$"REST/v1/Autosuggest?query={query}&userLocation=48.604311,-122.981998,5000&key=AowS92VceTemKIGzaCv8a00NIAGphFEJTmrMtywkJB1NWeWQ8nRCxeeUa_PgTxKp",
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
