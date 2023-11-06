using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BlazorApp.Infrastructure.Context
{
	public class CustomerContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }

		public static string DbPath;
		static CustomerContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath =  String.Concat("Data Source=" , Path.Join(path, "customer.db"));
		}
		public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
		{
			
		}
		public CustomerContext()
		{
			//var folder = Environment.SpecialFolder.LocalApplicationData;
			//var path = Environment.GetFolderPath(folder);
			//DbPath = System.IO.Path.Join(path, "customer.db");
		}

		// The following configures EF to create a Sqlite database file in the
		// special "local" folder for your platform.
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			var test = DbPath;
			bool test1 = DbPath == $"Data Source=C:\\Users\\dimip\\AppData\\Local\\customer.db";

			 options.UseSqlite(DbPath);
		}
	}

}
