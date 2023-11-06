using BlazorApp.Infrastructure.Configuration;
using BlazorApp.Infrastructure.Context;
using BlazorApp.Infrastructure.Interfaces;
using BlazorApp.Infrastructure.Policies;
using BlazorApp.Infrastructure.Repositories;
using BlazorApp.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Polly.Extensions.Http;
using Polly;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.Configure<ApplicationConfiguration>(builder.Configuration);

builder.Services.AddDbContext<CustomerContext>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddHttpClient<IBingLocationsService, BingLocationsService>(
	client =>
	{
		client.BaseAddress = new Uri("http://dev.virtualearth.net/");
	}).AddPolicyHandler(PolicyHandler.GetRetryPolicy());

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
