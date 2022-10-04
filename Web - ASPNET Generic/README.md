# Description

You are given the following model named “Customer” 

```
public class Customer
{
	public Guid Id { get; set; }
	public string CompanyName { get; set; }
	public string ContactName { get; set; }
	public string Address { get; set; }
	public string City { get; set; }
	public string Region { get; set; }
	public string PostalCode { get; set; }
	public string Country { get; set; }
	public string Phone { get; set; }
}
```

You have to create an ASP.NET Core project and develop the following

Required: 
- A grid with all customers with server side paging
- CRUD Operations on "Customer" model with new, edit and delete functionalities
- Expose all CRUD Operations of the "Customer" model as an API 
- Create a component that takes text as input and displays the results of Bing Autosuggest Map API(free version) https://learn.microsoft.com/en-us/bingmaps/rest-services/autosuggest

Extra (nice to have)
- Add authentication for the UI with the provided demo Identity Server 4 https://demo.identityserver.io/
- Protect your API with authentication with the provided demo Identity Server above
- Unit & Integration Tests

## Technical Requirements 

- C#
- .Net 6
- Blazor Wasm

## Optional
- Sql Server (e.g. with Entity Framework Core/Dapper/etc)
- Bootstrap
- Typescript
- Kendo UI (with mvvm)
