using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Infrastructure.Interfaces
{
	public interface IBingLocationsService
	{
		public Task<BingLocationsResult> GetLocationsAsync(string query);
	}
}
