using BlazorApp.Infrastructure.Configuration;
using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Options;
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
		}
		public CustomerContext(DbContextOptions<CustomerContext> options, IOptionsSnapshot<ApplicationConfiguration> applicationConfiguration) : base(options)
		{

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
			var db = applicationConfiguration.Value.ConnectionStrings.SQLiteDefaultConnection;
            DbPath = String.Concat("Data Source=", Path.Join(path, db));
        }

		// The following configures EF to create a Sqlite database file in the
		// special "local" folder for your platform.
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			 options.UseSqlite(DbPath);
		}
	}

}
