using BlazorApp.Infrastructure.Context;
using BlazorApp.Infrastructure.Interfaces;
using BlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SQLitePCL;
using static System.Net.WebRequestMethods;

namespace BlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {

        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository, ILogger<CustomersController> logger)
        {
            _logger = logger;
			_repository = repository;
        }

        [HttpGet]
        public async Task<CustomerResponseDto> Get(int pageSize , int skip)
        {
			var customers = await _repository.GetCustomersRange(pageSize, skip);

			var result =  new CustomerResponseDto { Payload = customers, TotalCount = customers.Count()};
            return result;
		}
        [HttpGet]
		[Route("GetById")]
		public async Task<Customer> GetById(string id)
        {
			return await _repository.GetCustomer(id);
		}
		[HttpPost]
		[Route("Add")]
		public async Task Add(Customer customer)
		{
			await _repository.AddCustomer(customer);
		}
		[HttpPost]
		[Route("Update")]
		public async Task Update(Customer customer)
		{
			await _repository.UpdateCustomer(customer);
		}
		[HttpPost]
		[Route("Delete")]
		public async Task Delete([FromBody] string indx)
		{
			await _repository.DeleteCustomer(indx);
		}
	}
}