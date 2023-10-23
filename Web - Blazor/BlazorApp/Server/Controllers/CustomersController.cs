using BlazorApp.Server.Cache;
using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {

        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public CustomerResponseDto Get(int pageSize , int skip)
        {

			var result =  new CustomerResponseDto { Payload = CustomersCache.Customers.Skip((1 - skip) * pageSize).Take(pageSize).ToList(), TotalCount = CustomersCache.Customers.Count};
            return result;

		}
        [HttpGet]
		[Route("GetById")]
		public Customer GetById(string id)
        {
			var result = CustomersCache.Customers?.Where(c => c.Id.ToString() == id).FirstOrDefault();
			return result;

		}
		[HttpPost]
		[Route("Add")]
		public async Task Add(Customer customer)
		{

				CustomersCache.Customers.Add(customer);

		}
		[HttpPost]
		[Route("Update")]
		public void Update(Customer customer)
		{
            var oldCust = CustomersCache.Customers.Where(c => c.Id.Equals(customer.Id)).FirstOrDefault();
            CustomersCache.Customers.Remove(oldCust);
			CustomersCache.Customers.Add(customer);
		}
		[HttpPost]
		[Route("Delete")]
		public void Delete([FromBody] string indx)
		{
            var oldCust = CustomersCache.Customers.Find(c => c.Id.ToString() == indx);
            CustomersCache.Customers.Remove(oldCust);
		}
	}
}