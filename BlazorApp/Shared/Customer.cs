﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    [Serializable]
    public class Customer
    {
        public Customer()
        {

		}
		public Guid Id { get; set; }
		public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public void Update(Customer updated)
        {
            this.CompanyName = updated.CompanyName;
            this.ContactName = updated.ContactName;
            this.Address = updated.Address;
            this.City = updated.City;
            this.Region = updated.Region;
            this.PostalCode = updated.PostalCode;
            this.Country = updated.Country;
            this.Phone = updated.Phone;
        }
    }
}
