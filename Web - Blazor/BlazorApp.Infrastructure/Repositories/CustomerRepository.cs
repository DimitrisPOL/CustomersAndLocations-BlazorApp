using BlazorApp.Infrastructure.Context;
using BlazorApp.Infrastructure.Interfaces;
using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Infrastructure.Repositories
{
	public class CustomerRepository : ICustomerRepository
	{
		private readonly ILogger<CustomerRepository> _logger;
		private readonly CustomerContext _context;

		public CustomerRepository(ILogger<CustomerRepository> logger, CustomerContext context)
		{
			_logger = logger;
			_context = context;
		}

		public async Task AddCustomer(Customer customer)
		{
			try
			{
				await _context.AddAsync(customer);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
			}
		}

		public async Task DeleteCustomer(string id)
		{
			try
			{
				var cust = new Customer { Id = new Guid(id) };
				_context.Entry(cust).State = EntityState.Deleted;
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
			}
		}

		public async Task<Customer> GetCustomer(string id)
		{
			try
			{
				return await _context.Customers.Where(c => c.Id == new Guid(id)).FirstOrDefaultAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				return null;
			}
		}

		public async Task<List<Customer>> GetCustomersRange(int pageSize, int skip)
		{
			try
			{
				return await _context.Customers.Skip((1 - skip) * pageSize).Take(pageSize).ToListAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
				return null;
			}
		}

		public async Task UpdateCustomer(Customer customer)
		{
			try
			{
				var oldCust = await _context.Customers.FindAsync(customer.Id);
				if (oldCust != null)
				{
					oldCust.Update(customer);
					await _context.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, ex.Message);
			}
		}
	}
}
