using BlazorApp.Server.Cache;
using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BlazorApp.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BingsAddressController : Controller
    {


		[HttpGet]
		public async Task<BingLocationsResult> Get(string query)
		{

			using (HttpClient _httpClient = new HttpClient())
			{

				var bingRsults = await _httpClient.GetAsync($"http://dev.virtualearth.net/REST/v1/Autosuggest?query={query}&userLocation=48.604311,-122.981998,5000&key=AowS92VceTemKIGzaCv8a00NIAGphFEJTmrMtywkJB1NWeWQ8nRCxeeUa_PgTxKp");
				var text = await bingRsults.Content.ReadAsStringAsync();
				BingLocationsResult result =  JsonConvert.DeserializeObject<BingLocationsResult>(text);

				return result;
			}

		}
	}
}
