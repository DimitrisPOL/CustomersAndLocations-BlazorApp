using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Infrastructure.Interfaces
{
	public interface ICustomerRepository
	{
		public Task<List<Customer>> GetCustomersRange(int pageSize, int skip);
		public Task<Customer> GetCustomer(string id);
		public Task AddCustomer(Customer customer);
		public Task UpdateCustomer(Customer customer);
		public Task DeleteCustomer(string id);

	}
}
