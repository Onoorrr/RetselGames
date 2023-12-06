using Microsoft.EntityFrameworkCore;
using RetselGames.Data.Context;
using RetselGames.Data.Extensions;
using RetselGames.Service.Extensions;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtension();

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
	endpoints.MapAreaControllerRoute(name: "Admin", areaName: "Admin", pattern: "Admin/{controller=Home}/{action=Index}/{id?}");
	endpoints.MapDefaultControllerRoute();
}
);

app.Run();
