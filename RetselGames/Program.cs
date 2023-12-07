using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RetselGames.Data.Context;
using RetselGames.Data.Extensions;
using RetselGames.Entity.Entities;
using RetselGames.Service.Extensions;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();


builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// Add services to the container.
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
	opt.Password.RequireNonAlphanumeric = false;
	opt.Password.RequireLowercase = false;
	opt.Password.RequireUppercase = false;																																							
}
)
	//rol tabanlý yetkilendirme için kullandýðýmýz kod.
	.AddRoleManager<RoleManager<AppRole>>()
	.AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
	config.LoginPath = new PathString("/Admin/Auth/Login");
	config.LogoutPath = new PathString("/Admin/Auth/Logout");
	config.Cookie = new CookieBuilder
	{
		Name = "RetselGames",
		HttpOnly = true,
		SameSite = SameSiteMode.Strict,
		SecurePolicy = CookieSecurePolicy.SameAsRequest //Site yayýnlanýrsa SameAsRequest yerine Always kullanýlýr.
	};
	config.SlidingExpiration = true;
	config.ExpireTimeSpan = TimeSpan.FromDays(7);
	config.AccessDeniedPath = new PathString("/Admin/Auth/AccesDenied");

});



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

app.UseSession();
app.UseRouting();


app.UseAuthentication();


//Authorize'ýn altta kalmasý gerekiyor.
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
