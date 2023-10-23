using BlazorApp.Shared;

namespace BlazorApp.Server.Cache
{
	public static class CustomersCache
	{
		public static List<Customer> Customers = new List<Customer> {
			new Customer { Id = Guid.NewGuid(), ContactName = "dimitris", CompanyName = "Epsilon" , Address = "Estoros 2", City ="Athens", Country = "Greece", Phone = "697777777", Region = "Attika", PostalCode = "44444"},
			new Customer { Id = Guid.NewGuid(), ContactName = "Vasilis", CompanyName = "Epsilon" , Address = "Solonos 54", City ="Athens", Country = "Greece", Phone = "697888888", Region = "Attika", PostalCode = "55555"}

		};
	}
}
