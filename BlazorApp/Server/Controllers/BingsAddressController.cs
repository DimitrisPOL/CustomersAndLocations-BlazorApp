using BlazorApp.Infrastructure.Context;
using BlazorApp.Infrastructure.Interfaces;
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
		private readonly ILogger<BingsAddressController> _logger;
		private readonly IBingLocationsService _bingLocationsService;

		public BingsAddressController(ILogger<BingsAddressController> logger, IBingLocationsService bingLocationsService)
		{
			_logger = logger;
			_bingLocationsService = bingLocationsService;
		}

		[HttpGet]
		public async Task<BingLocationsResult> Get(string query)
		{
			return await _bingLocationsService.GetLocationsAsync(query);
		}
	}
}
