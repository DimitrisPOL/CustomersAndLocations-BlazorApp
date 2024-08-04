using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
	public class NamePrinter
	{
		public NamePrinter(IPerson person)
		{
			this.person = person;
		}

		public IPerson person { get; set; }

		public string PrintName()
		{
			return person.Name;
		}

	}

	public interface IPerson
	{
		public string Name { get; set; }
	}

	public class Employee : IPerson
	{
		public string Name { get; set; }
	}

	public class Manager : IPerson
	{
		public string Name { get; set; }
	}

}
