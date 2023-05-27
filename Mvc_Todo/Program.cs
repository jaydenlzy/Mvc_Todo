using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mvc_Todo.Areas.Identity.Data;
using Mvc_Todo.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Mvc_TodoContextConnection") ?? throw new InvalidOperationException("Connection string 'Mvc_TodoContextConnection' not found.");

builder.Services.AddDbContext<Mvc_TodoContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Mvc_TodoUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Mvc_TodoContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
