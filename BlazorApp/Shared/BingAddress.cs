using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{

	public class Address
	{
		public string countryRegion { get; set; }
		public string locality { get; set; }
		public string adminDistrict { get; set; }
		public string adminDistrict2 { get; set; }
		public string countryRegionIso2 { get; set; }
		public string formattedAddress { get; set; }
		public string postalCode { get; set; }
		public string addressLine { get; set; }
	}

	public class Resource
	{
		public string __type { get; set; }
		public List<Value> value { get; set; }
	}

	public class ResourceSet
	{
		public int estimatedTotal { get; set; }
		public List<Resource> resources { get; set; }
	}

	public class BingLocationsResult
	{
		public string authenticationResultCode { get; set; }
		public string brandLogoUri { get; set; }
		public string copyright { get; set; }
		public List<ResourceSet> resourceSets { get; set; }
		public int statusCode { get; set; }
		public string statusDescription { get; set; }
		public string traceId { get; set; }
	}

	public class Value
	{
		public string __type { get; set; }
		public Address address { get; set; }
		public string name { get; set; }
	}







	//[Serializable]
	//public class ResourceSets
	//{
	//	public ResourceSets()
	//	{

	//	}
	//	[JsonProperty("estimatedTotal")]
	//	public int EstimatedTotal { get; set; }
	//	//[JsonProperty("resources")]
	//	//public Resources[] Resources { get; set; }
	//}
	//[Serializable]
	//public class Resources
	//{
	//	[JsonProperty("value")]
	//	public Place[] Value { get; set; }
	//}
	//   [Serializable]
	//public class Place
	//{
	//	public Place()
	//	{

	//	}
	//	[JsonProperty("countryRegion")]
	//	public string CountryRegion { get; set; }
	//	[JsonProperty("locality")]
	//	public string Locality { get; set; }
	//	[JsonProperty("adminDistrict")]
	//	public string AdminDistrict { get; set; }
	//	[JsonProperty("adminDistrict2")]
	//	public string AdminDistrict2 { get; set; }
	//	[JsonProperty("countryRegionIso2")]
	//	public string CountryRegionIso2 { get; set; }
	//	[JsonProperty("formattedAddress")]
	//	public string FormattedAddress { get; set; }
	//   }
}
